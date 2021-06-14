using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAR_Sign_In_Assist.Models;
using ICAClassLibrary.Models;
using System.IO;
using System.Xml.Serialization;

namespace SAR_Sign_In_Assist.Services
{
    public class SignInListService
    {
        private string _SaveFileName = "SARSignInAssistRecords.xml";
        private List<GeneralSignInRecord> _generalSignInRecords = new List<GeneralSignInRecord>();
        private bool _LoadFromFileSuccessful = false;


        public void UpsertSignInRecord(GeneralSignInRecord record)
        {
            if(_generalSignInRecords.Any(o=> o.SignInRecordID == record.SignInRecordID)) { _generalSignInRecords = _generalSignInRecords.Where(o => o.SignInRecordID != record.SignInRecordID).ToList(); }
            _generalSignInRecords.Add(record);
            _generalSignInRecords = _generalSignInRecords.OrderBy(o => o.StatusChangeTime).ToList();
            SaveSignInRecords();
        }

        public List<GeneralSignInRecord> GetSignInRecords(DateTime startDate, DateTime endDate, bool includeInactive = false, bool sortAscending = true, Guid OrganizationID = new Guid())
        {
            loadSignInRecordsByFilename();
            List<GeneralSignInRecord> records = _generalSignInRecords.Where(o => (o.Active || includeInactive) && o.StatusChangeTime >= startDate && o.StatusChangeTime <= endDate && (OrganizationID == Guid.Empty || o.teamMember.OrganizationID == OrganizationID)).ToList();
            if (sortAscending) { records = records.OrderBy(o => o.StatusChangeTime).ToList();            }
            else { records = records.OrderByDescending(o => o.StatusChangeTime).ToList(); }
            return records;
        }

        private  bool SaveSignInRecords()
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "SAR ICS Form Helper");
            Directory.CreateDirectory(path);
            bool saveSuccessful = false;


            using (StreamWriter myWriter = new StreamWriter(Path.Combine(path, _SaveFileName), false))
            {
                XmlSerializer mySerializer = null;
                try
                {
                    // Create an XmlSerializer for the 
                    // ApplicationSettings type.
                    mySerializer = new XmlSerializer(typeof(List<GeneralSignInRecord>));

                    // Serialize this instance of the ApplicationSettings 
                    // class to the config file.
                    mySerializer.Serialize(myWriter, _generalSignInRecords);
                    saveSuccessful = true;
                }
                catch (Exception)
                {
                    saveSuccessful = false;
                    //MessageBox.Show(ex.Message);
                }
                finally
                {
                    // If the FileStream is open, close it.
                    if (myWriter != null)
                    {
                        myWriter.Close();
                    }
                }
            }
            return saveSuccessful;
        }

        private void loadSignInRecordsByFilename(string fileName = null)
        {
            if (string.IsNullOrEmpty(fileName)) { fileName = _SaveFileName; }

            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "SAR ICS Form Helper");



            XmlSerializer mySerializer = new XmlSerializer(typeof(List<GeneralSignInRecord>));

            try
            {
                System.IO.Directory.CreateDirectory(path);
                // Create an XmlSerializer for the ApplicationSettings type.

                FileInfo fi = new FileInfo(Path.Combine(path, fileName));
                // If the config file exists, open it.
                if (fi.Exists)
                {
                    using (FileStream myFileStream = fi.OpenRead())
                    {
                        // Create a new instance of the ApplicationSettings by
                        // deserializing the config file.
                        _generalSignInRecords = (List<GeneralSignInRecord>)mySerializer.Deserialize(myFileStream);
                        // Assign the property values to this instance of 
                        // the ApplicationSettings class.
                    }
                    _LoadFromFileSuccessful = true;

                }
            }
            catch (Exception)
            {
                //MessageBox.Show(ex.Message);
                _LoadFromFileSuccessful = false;
                throw new Exception();
                
            }
        }
    }
}
