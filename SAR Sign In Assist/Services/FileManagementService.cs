using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICAClassLibrary.Models;
using ICAClassLibrary.Utilities;
using ICAClassLibrary.Interfaces;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace SAR_Sign_In_Assist.Services
{
    public class FileManagementService : IFileAccessServices
    {
        public bool CreateFolder(string pathToFolder)
        {
            throw new NotImplementedException();
        }

        public bool DeleteFile(string pathOfFileToDelete)
        {
            throw new NotImplementedException();
        }

        public bool SaveFile(string destinationPath, bool overwriteExisting)
        {
            throw new NotImplementedException();
        }
    }


    public static class FileAccessClasses
    {
        private static string getFileFromPath(string path)
        {
            string filename = "";
            if (path.Contains("\\"))
            {
                int index = path.LastIndexOf("\\");
                filename = path.Substring(index + 1);
            }
            else { filename = path; }
            return filename;
        }

        public static string getWritablePath()
        {
            string path = null;




            if (string.IsNullOrEmpty(path))
            {
                path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                path = Path.Combine(path, "SAR ICS Form Helper");
                System.IO.Directory.CreateDirectory(path);
                path = Path.Combine(path, "SAR Sign-In Assist");
                System.IO.Directory.CreateDirectory(path);
                path = System.IO.Path.Combine(path, DateTime.Now.ToString("yyyy-MMM-dd"));
                System.IO.Directory.CreateDirectory(path);



                if (!checkWriteAccess(path, false))
                {
                    path = null;
                }
            }
            return path;
        }

        public static string getUniqueFileName(string baseFileName, string path, string ext = "pdf", bool returnPath = true)
        {
            string filename = baseFileName + "." + ext;
            int x = 1;
            string newpath = Path.Combine(path, filename);
            if (!File.Exists(newpath))
            {
                if (returnPath) { return newpath; }
                else { return filename; }
            }
            else
            {
                while (File.Exists(Path.Combine(path, baseFileName + "(" + x + ")." + ext)))
                {
                    x += 1;
                }
                filename = baseFileName + "(" + x + ")." + ext;
                if (returnPath)
                {
                    return Path.Combine(path, baseFileName + "(" + x + ")." + ext);
                }
                else { return filename; }
            }
        }

        public static byte[] concatAndAddContent(List<byte[]> pdfByteContent)
        {

            using (var ms = new MemoryStream())
            {
                using (var doc = new Document())
                {
                    using (var copy = new PdfSmartCopy(doc, ms))
                    {
                        doc.Open();

                        //Loop through each byte array
                        foreach (var p in pdfByteContent)
                        {
                            try
                            {
                                //Create a PdfReader bound to that byte array
                                using (var reader = new PdfReader(p))
                                {

                                    //Add the entire document instead of page-by-page
                                    copy.AddDocument(reader);
                                }
                            }
                            catch (Exception)
                            {

                            }
                        }

                        doc.Close();
                    }
                }

                //Return just before disposing
                return ms.ToArray();
            }
        }

        public static bool checkWriteAccess(string dirPath, bool throwIfFails = false)
        {
            try
            {
                using (FileStream fs = File.Create(
                    Path.Combine(
                        dirPath,
                        Path.GetRandomFileName()
                    ),
                    1,
                    FileOptions.DeleteOnClose)
                )
                { }
                return true;
            }
            catch
            {
                if (throwIfFails)
                    throw;
                else
                    return false;
            }
        }
    }
}
