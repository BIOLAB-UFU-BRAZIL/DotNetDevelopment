/* File: XMLHandler.cs                   
 * Author: Daniel T. G. Mariano          
 * Email: dtgmariano@gmail.com           
 * Date: 17/09/2015                     
 * Update: 17/09/2015
 * Version: 1.0
 */
namespace CSharpXMLSerialization
{
    using System;
    using System.Xml.Serialization;
    using System.IO;

    class XMLHandler
    {

        #region Create .XML File
        /// <summary>
        /// 
        /// </summary>
        /// <param name="trialdata"></param>
        public static void SaveXMLFile(User trialdata)
        {
            try
            {
                if (!Directory.Exists(Settings.Default.folder))
                    Directory.CreateDirectory(Settings.Default.folder);
                
                string output_file = Settings.Default.folder + Settings.Default.filename;
                // Insert code to set properties and fields of the object.
                XmlSerializer mySerializer = new XmlSerializer(typeof(User));

                //XmlSerializer mySerializer = new XmlSerializer(typeof(TrialData));
                // To write to a file, create a StreamWriter object.
                StreamWriter myWriter = new StreamWriter(output_file);

                mySerializer.Serialize(myWriter, trialdata);
                myWriter.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Open .XML File
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public static User OpenXMLFile_TrialData(string filename)
        {
            User td;

            // Construct an instance of the XmlSerializer with the type
            // of object that is being deserialized.
            try
            {
                XmlSerializer mySerializer_A = new XmlSerializer(typeof(User));
                // To read the file, create a FileStream.

                FileStream myFileStream_A = new FileStream((filename), FileMode.Open);
                // Call the Deserialize method and cast to the object type.

                td = (User)mySerializer_A.Deserialize(myFileStream_A);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw ex;
            }
            return td;
        }
        #endregion
    }
}
