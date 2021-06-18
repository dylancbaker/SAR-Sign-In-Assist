using ICAClassLibrary.Interfaces;
using ICAClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SAR_Sign_In_Assist.Services
{
    public class GeneralOptionsService : IGeneralOptionsService
    {
        private GeneralOptions _options;
        private string _SaveFileName = "mySARAssistOptions.xml";
        private bool _LoadSettingsFromFile;


        public GeneralOptionsService() { }
        public GeneralOptionsService(string fileName)
        {
            _SaveFileName = fileName;
            _LoadSettingsFromFile = true;
            GetGeneralOptions();
        }
        public GeneralOptionsService(bool loadSettingsFromFile)
        {

            _LoadSettingsFromFile = loadSettingsFromFile;
            GetGeneralOptions();
        }

        public bool DeleteGeneralOptions(GeneralOptions options)
        {
            throw new NotImplementedException();
        }

        public GeneralOptions GetGeneralOptions(Guid OrganizationID)
        {
            throw new NotImplementedException();
        }

        public GeneralOptions GetGeneralOptions(string fileName = null)
        {

            if (string.IsNullOrEmpty(fileName)) { fileName = "mySARAssistOptions.xml"; }

            _options = loadGeneralOptionsByFilename(fileName);

            return _options;
        }

        public GeneralOptions GetGeneralOptions()
        {
            if (_LoadSettingsFromFile && !string.IsNullOrEmpty(_SaveFileName))
            {
                _options = loadGeneralOptionsByFilename(_SaveFileName);
            }
            return _options;
        }

        private GeneralOptions loadGeneralOptionsByFilename(string fileName)
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "SAR ICS Form Helper");



            XmlSerializer mySerializer = new XmlSerializer(typeof(GeneralOptions));

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
                        _options = (GeneralOptions)mySerializer.Deserialize(myFileStream);
                        // Assign the property values to this instance of 
                        // the ApplicationSettings class.
                    }
                    if (_options.DefaultPortNumber <= 0) { _options.DefaultPortNumber = 42999; }
                    _options.OptionsLoadedSuccessfully = true;

                }
            }
            catch (Exception)
            {
                //MessageBox.Show(ex.Message);
                throw new Exception();
            }

            return _options;
        }


        public bool SaveGeneralOptions()
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
                    mySerializer = new XmlSerializer(typeof(GeneralOptions));

                    // Serialize this instance of the ApplicationSettings 
                    // class to the config file.
                    mySerializer.Serialize(myWriter, _options);
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


        public bool SaveGeneralOptions(GeneralOptions options, string filename = null)
        {
            if (string.IsNullOrEmpty(filename)) { filename = "mySARAssistOptions.xml"; }

            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "SAR ICS Form Helper");
            Directory.CreateDirectory(path);
            bool saveSuccessful = false;


            using (StreamWriter myWriter = new StreamWriter(Path.Combine(path, filename), false))
            {
                XmlSerializer mySerializer = null;
                try
                {
                    // Create an XmlSerializer for the 
                    // ApplicationSettings type.
                    mySerializer = new XmlSerializer(typeof(GeneralOptions));

                    // Serialize this instance of the ApplicationSettings 
                    // class to the config file.
                    mySerializer.Serialize(myWriter, options);
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

        public object GetOptionsValue(string ValueName)
        {
            switch (ValueName)
            {
                case "CannedCommsItems":
                    return _options.AllCannedCommsLogEntries;
                case "IncludeExecutionIn204Briefings":
                    return _options.IncludeExecutionIn204Briefings;
                default:
                    return null;
            }
        }

        public void UpserOptionValue(object newValue, string property_name = null)
        {
            var type = newValue.GetType();
            if (type == new List<CannedCommsLogEntry>().GetType())
            {
                _options.AllCannedCommsLogEntries = newValue as List<CannedCommsLogEntry>;

            }

            switch (property_name)
            {
                case "TeamMember":
                    TeamMember member = (TeamMember)newValue;
                    _options.AllTeamMembers = _options.AllTeamMembers.Where(o => o.PersonID != member.PersonID).ToList();
                    _options.AllTeamMembers.Add(member);
                    break;
                case "IncludeExecutionIn204Briefings":
                    _options.IncludeExecutionIn204Briefings = (bool)newValue;
                    break;
            }
            SaveGeneralOptions();
        }
    }
}
