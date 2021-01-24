using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoInTime.Classes;
using System.IO; // for file
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ToDoInTime
{
    public partial class Form1 : Form
    {
        //BindingSource taskBindingList = new BindingSource();

        // Local props for time
        int timeHour, timeMin, timeSec;
        // Bool to check if timer is on pause
        bool isRunning;
        // Filepath to JSON-file
        string filePath = @"C:\Users\Ny ägare\Documents\Webbprogrammering\cSharp\projekt\app\ToDoInTime\ToDoInTime\Files\book.json";
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            // Load json file and populate list

            upDateList();

        }

        // Writes the list "completed tasks"
        private void upDateList()
        {
            ListClass.TaskListIn = JsonHandler.getJson(filePath);
            // Clear list first
            lst_todo.Items.Clear();
            // loop throe 
            if(ListClass.TaskListIn != null)
            {
                foreach (var item in ListClass.TaskListIn)
                {
                    lst_todo.Items.Add(item.Task);

                }
            }
         

        }


        private void btn_start_Click(object sender, EventArgs e)
        {
            isRunning = true;
   
        }
        private void btn_pause_Click(object sender, EventArgs e)
        {
            isRunning = false;
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
          if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show("Task " + txt_task.Text + " is done, good jobb!", "Message: ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            // Create create = new Create();
            Create.startMethod(txt_task.Text, txt_desc.Text, (int)num_hour.Value, (int)num_min.Value, Int32.Parse(lbl_hour_out.Text),
                Int32.Parse(lbl_min_out.Text), Int32.Parse(lbl_sec_out.Text), filePath);

            // Reset values
            txt_task.Text = null;
            txt_desc.Text = null;
            num_hour.Value = 00;
            num_min.Value = 01;
            timeHour = 00;
            timeMin = 00;
            timeSec = 00;
            upDateList();
        }

        // Validation of task
        private void txt_task_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txt_task.Text))
            {
                e.Cancel = true;
                txt_task.Focus();
                errorProvider.SetError(txt_task, "You must enter a taskname!");
            } else
            {
                e.Cancel = false;
                errorProvider.SetError(txt_task, null);
            }
        }

        // Biuld in timerfunkction
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isRunning)
            {
                timeSec++;
                timeMin = 0;
                if (timeSec >= 60)
                {
                    timeMin++;
                    timeSec = 0;

                    if (timeMin >= 60)
                    {
                        timeHour++;
                        timeMin = 0;
                    }
                }
            }

            PrintTime();
        }

        // Print out the time in the clock
        private void PrintTime()
        {
            lbl_hour_out.Text = String.Format("{0:00}", timeHour);
            lbl_min_out.Text = String.Format("{0:00}", timeMin);
            lbl_sec_out.Text = String.Format("{0:00}", timeSec);
        }
    }
}
