using ICAClassLibrary.Models;
using ICAClassLibrary.Utilities;
using iTextSharp.text.pdf;
using SAR_Sign_In_Assist.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAR_Sign_In_Assist.Services
{
   public static  class ICS211CheckInListService
    {
        public static SignInPDFResult createSignInPDF(List<GeneralSignInRecord> records, bool automaticallyOpen = true, bool tempFileName = false, bool flattenPDF = false)
        {
            SignInPDFResult result = new SignInPDFResult();

            string path = FileAccessClasses.getWritablePath();

            if (tempFileName || string.IsNullOrEmpty(path))

            {
                path = System.IO.Path.GetTempPath();

            }

            try
            {
                //List<Assignment> OpAssignments = CurrentTask.allAssignments.Where(o => o.OpPeriod == CurrentOpPeriod).OrderBy(o => o.AssignmentNumber).ToList();
                List<byte[]> allPDFs = getSignInSheetPDFs(records, flattenPDF);

                if (allPDFs.Count > 0)
                {
                    string outputFileName = "ICS 211 -  " + records.First().ActivityName + " - Sign In Sheets";
                    //path = System.IO.Path.Combine(path, outputFileName);
                    path = FileAccessClasses.getUniqueFileName(outputFileName, path);

                    /*
                    bool successful = MergePDFs(pdfFileNames, path);
                    */

                    byte[] fullFile = FileAccessClasses.concatAndAddContent(allPDFs);
                    try
                    {
                        File.WriteAllBytes(path, fullFile);
                        if (automaticallyOpen) { System.Diagnostics.Process.Start(path); }

                    }
                    catch (Exception)
                    {
                        result.Errors.Add("There was an error trying to save " + path + " please verify the path is accessible.");
                    }
                }
                else
                {
                    result.Errors.Add("Sorry, you don't appear to have selected any sign in records. Please note that sign in and sign out records are displayed independently on this list, you'll need to grab both when printing from here.");
                }

                //MessageBox.Show("PDF Generated Successfully....!!!");


            }
            catch (IOException ex)
            {
                result.Errors.Add("It appears a previous version of the PDF is still open.  Please close it before trying to generate a new copy.\r\n\r\nDetailed error message:" + ex.ToString());
            }
            catch (System.UnauthorizedAccessException ex)
            {
                result.Errors.Add("A program on your system, typically a virus scanner, is prevening files from being saved to " + path + ". Please select a different folder to save to.");


            }

            result.Path = path;
            return result;
        }
        public static List<byte[]> getSignInSheetPDFs(List<GeneralSignInRecord> records, bool flattenPDF)
        {
            List<byte[]> allPDFs = new List<byte[]>();
            if (records.Any())
            {

                List<MemberStatus> Statuses = Program.signInListService.GetMemberStatus(records);
                List<GroupSignInRecord> groupSignInRecords = new List<GroupSignInRecord>();
                foreach (MemberStatus status in Statuses)
                {
                    if (!groupSignInRecords.Where(o => o.GroupName == status.OrganizationName).Any())
                    {
                        groupSignInRecords.Add(new GroupSignInRecord(status.OrganizationName));
                    }
                    groupSignInRecords.Where(o => o.GroupName == status.OrganizationName).First().MemberStatuses.Add(status);
                }

                /*
                List<string> pdfFileNames = new List<string>();
                for (int gr = 0; gr < groupSignInRecords.Count; gr++)
                {
                    for (int x = 1; x <= groupSignInRecords[gr].totalPages; x++)
                    {
                        List<MemberStatus> nextStatuses = groupSignInRecords[gr].MemberStatuses.Skip(6 * (x - 1)).Take(6).ToList();

                        string filename = createSinglePageSignInSheet(nextStatuses, x, groupSignInRecords[gr].totalPages, OpsPeriod);
                        pdfFileNames.Add(filename);
                    }
                }

                */

                for (int gr = 0; gr < groupSignInRecords.Count; gr++)
                {
                    for (int x = 1; x <= groupSignInRecords[gr].totalPages; x++)
                    {
                        List<MemberStatus> nextStatuses = groupSignInRecords[gr].MemberStatuses.Skip(6 * (x - 1)).Take(6).ToList();

                        allPDFs.AddRange(createSinglePageSignInSheetAsBytes(nextStatuses, records[0].ActivityName, x, groupSignInRecords[gr].totalPages, flattenPDF));
                    }
                }
            }
            return allPDFs;
        }

        private static List<byte[]> createSinglePageSignInSheetAsBytes(List<MemberStatus> statuses, string ActivityName, int pageNumber, int totalPages, bool flattenPDF = false)
        {
            string path = System.IO.Path.GetTempFileName();

            string fileToUse = "ICSForms/ICS 211 - Check In List.pdf";
            //string outputFileName = "ICS 215 - Task #" + CurrentTask.TaskNumber + " - Operations Plan.pdf";
            //path = System.IO.Path.Combine(path, outputFileName);

            using (PdfReader rdr = new PdfReader(fileToUse))
            {
                using (PdfStamper stamper = new PdfStamper(rdr, new System.IO.FileStream(path, System.IO.FileMode.Create)))
                {


                    //Op Plan

                    //Top Section
                    stamper.AcroFields.SetField("TASK", "");
                    stamper.AcroFields.SetField("TASK NAME", ActivityName);

                    stamper.AcroFields.SetField("FOR OP PERIOD", "");
                    if (statuses.Count > 0)
                    {
                        stamper.AcroFields.SetField("PeriodFrom", string.Format("{0:yyyy-MMM-dd HH:mm}", statuses.OrderBy(o => o.SignInTime).First().SignInTime));
                        if (statuses.Any(o => o.SignOutTime < DateTime.MaxValue))
                        {
                            stamper.AcroFields.SetField("PeriodTo", string.Format("{0:yyyy-MMM-dd HH:mm}", statuses.Where(o => o.SignOutTime < DateTime.MaxValue).OrderByDescending(o => o.SignOutTime).First().SignOutTime));
                        }
                        stamper.AcroFields.SetField("GROUP NAME", statuses[0].OrganizationName);
                    }



                    stamper.AcroFields.SetField("PAGE", pageNumber.ToString());

                    double totalHours = 0;
                    decimal totalKMs = 0;

                    for (int x = 0; x < statuses.Count; x++)
                    {
                        MemberStatus status = statuses[x];
                        TeamMember member = new TeamMember();
                        List<TeamMember> members = Program.signInListService.GetAllMembers();
                        if (members.Any(o => o.PersonID == status.MemberID)) { member = members.Where(o => o.PersonID == status.MemberID).First(); }
                        stamper.AcroFields.SetField("Name" + (x + 1).ToString(), status.MemberName);
                        stamper.AcroFields.SetField("Address" + (x + 1).ToString(), member.AddressWithPhone);
                        stamper.AcroFields.SetField("NOK" + (x + 1).ToString(), member.NOKOneLine);

                        if (member.GSTL) { stamper.SetPDFCheckbox("GSTL" + (x + 1).ToString()); }
                        if (member.SARM) { stamper.SetPDFCheckbox("SARM" + (x + 1).ToString()); }
                        if (member.Tracker) { stamper.SetPDFCheckbox("TK" + (x + 1).ToString()); }
                        if (member.RopeRescue) { stamper.SetPDFCheckbox("RRTM" + (x + 1).ToString()); }
                        if (member.MountainRescue) { stamper.SetPDFCheckbox("MR" + (x + 1).ToString()); }

                        string timein = string.Format("{0:HH:mm}", status.SignInTime);
                        stamper.AcroFields.SetField("TimeIn" + (x + 1).ToString(), timein);
                        if (status.TimeOutRequest > DateTime.MinValue)
                        {
                            stamper.AcroFields.SetField("MBO" + (x + 1).ToString(), string.Format("{0:HH:mm}", status.TimeOutRequest));
                        }

                        if (statuses[x].SignOutTime < DateTime.MaxValue)
                        {
                            stamper.AcroFields.SetField("TimeOut" + (x + 1).ToString(), string.Format("{0:HH:mm}", status.SignOutTime));
                        }
                        else
                        {
                            stamper.AcroFields.SetField("TimeOut" + (x + 1).ToString(), "");
                        }
                        if (status.SignInTime > DateTime.MinValue && status.SignOutTime < DateTime.MaxValue)
                        {
                            TimeSpan ts = status.SignOutTime - status.SignInTime;
                            totalHours += ts.TotalHours;
                            stamper.AcroFields.SetField("Hours" + (x + 1).ToString(), string.Format("{0:#,##0.0}", ts.TotalHours));
                        }
                        if (status.KMs > 0)
                        {
                            stamper.AcroFields.SetField("KM" + (x + 1).ToString(), string.Format("{0:#,##0.0}", status.KMs));
                            totalKMs += status.KMs;
                        }

                    }
                    stamper.AcroFields.SetField("OF", totalPages.ToString());
                    stamper.AcroFields.SetField("HoursTotal", string.Format("{0:#,##0.0}", totalHours));
                    stamper.AcroFields.SetField("KMTotal", string.Format("{0:#,##0.0}", totalKMs));
                    Guid page = Guid.NewGuid();


                    /* Rename all the fields in case there is more than 1 page */
                    AcroFields af = stamper.AcroFields;

                    List<string> fieldNames = new List<string>();
                    foreach (var field in af.Fields)
                    {
                        fieldNames.Add(field.Key);
                    }
                    foreach (string s in fieldNames)
                    {
                        stamper.AcroFields.RenameField(s, s + "-" + page.ToString());
                    }
                    if (flattenPDF)
                    {
                        stamper.FormFlattening = true;
                    }
                }
            }

            List<byte[]> allPDFs = new List<byte[]>();


            using (FileStream stream = File.OpenRead(path))
            {
                byte[] fileBytes = new byte[stream.Length];

                stream.Read(fileBytes, 0, fileBytes.Length);
                stream.Close();
                allPDFs.Add(fileBytes);
            }

            return allPDFs;
        }

    }

    public class SignInPDFResult
    {
        public string Path { get; set; }
        public List<string> Errors { get; set; } = new List<string>();
    }
}
