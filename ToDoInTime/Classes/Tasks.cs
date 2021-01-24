using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoInTime.Classes
{
    public class Tasks
    {
        // Properties

        public int Id { get; set; }
        // Name of the task and description
        public string Task { get; set; }
        public string Description { get; set; }
        //Hour and minutes tou expekt the task to take
        public int Exp_hour { get; set; }
        public int Exp_min { get; set; }
        // Hour, min and sec from when the task is running
        public int Hour_act { get; set; }
        public int Min_act { get; set; }
        public int Sec_act { get; set; }
        //Bool for when you pause the task
       





        // Constructor of class
        public Tasks(string taskIn, string descIn, int exp_hour, int exp_min, int hour_out, int min_out, int sec_out)
        {
            Task = taskIn;
            Description = descIn;
            Exp_hour = exp_hour;
            Exp_min = exp_min;
            Hour_act = hour_out;
            Min_act = min_out;
            Sec_act = sec_out;

        }



    }

  
}
