using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ToDoInTime.Classes
{
    public class JsonHandler
    {
        public static List<Tasks> getJson(string filePath)
        {

            using (var tw = new StreamWriter(filePath, true))
            {
                if (!File.Exists(filePath))
                {
                    File.Create(filePath);
                    string json = "[]";
                    tw.WriteLine(json);
                    tw.Close();
                }

            }

            // Intake JSON
            string streamresult = null;
            using (var sr = new StreamReader(filePath, true))
            {
                streamresult = sr.ReadToEnd();
                sr.Close();
            }

            //File.WriteAllText(filePath, streamresult, Encoding.UTF8);
            // 
            //  var utf8Reader = new Utf8JsonReader(streamresult);
            List<Tasks> inputData = JsonConvert.DeserializeObject<List<Tasks>>(streamresult);
       
            return inputData;
        }

        public static void saveJson(List<Tasks> listPosts, string filePath)
        {
            string json = JsonConvert.SerializeObject(listPosts, Formatting.Indented);

            //Write(json);
            // ta bort gammal json-fil
            try
            {
                // Check if file exists with its full path    
                if (File.Exists(filePath))
                {
                    // If file found, delete it    
                    File.Delete(filePath);
                }
                else Console.WriteLine("File not found");
            }
            catch (IOException ioExp)
            {
                //Error popup
                MessageBox.Show(ioExp.Message + " något gick fel");
                
            }

            using (var tw = new StreamWriter(filePath, true))
            {
                tw.WriteLine(json.ToString());
                tw.Close();
            }
           // Create.startMethod();
        }
    }
}
