using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoInTime.Classes
{
    public class ListClass
    {
        private static List<Tasks> taskListIn;

        public static List<Tasks> TaskListIn { get => taskListIn; set => taskListIn = value; }


        public static List<Tasks> GetTasks()
        {
            return TaskListIn;
        }
    }
}



