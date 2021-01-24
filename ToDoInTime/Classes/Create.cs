using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoInTime.Classes
{
    public  class Create
    {
        public static void startMethod(string taskName, string desc, int expHour, int expMin, int hourOut, int minOut, int secOut, string filePath)
        {
           

            Tasks taskFromForm = new Tasks(taskName, desc, expHour, expMin, hourOut, minOut, secOut);



            // Create new empty listobject
            List<Tasks> listPosts = new List<Tasks>();
            var inList = JsonHandler.getJson(filePath);

            // check if data exist in file, then sets that data på new list (listPosts).
            if(inList != null)
            {

                listPosts = inList;
            }

            // add new task from input fields in the list of objects.
            listPosts.Add(taskFromForm);

            // save the list as json.
            JsonHandler.saveJson(listPosts, filePath);

        }


    }
}
