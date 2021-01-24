namespace ToDoInTime
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_pause = new System.Windows.Forms.Button();
            this.btn_create = new System.Windows.Forms.Button();
            this.lbl_hour_out = new System.Windows.Forms.Label();
            this.lbl_min_out = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.num_min = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.num_hour = new System.Windows.Forms.NumericUpDown();
            this.lbl_sec_out = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_desc = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_task = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lst_todo = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_hour)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.groupBox1.Controls.Add(this.btn_pause);
            this.groupBox1.Controls.Add(this.btn_create);
            this.groupBox1.Controls.Add(this.lbl_hour_out);
            this.groupBox1.Controls.Add(this.lbl_min_out);
            this.groupBox1.Controls.Add(this.btn_start);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.num_min);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.num_hour);
            this.groupBox1.Controls.Add(this.lbl_sec_out);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_desc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_task);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(31, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 630);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create a task:";
            // 
            // btn_pause
            // 
            this.btn_pause.BackColor = System.Drawing.Color.Firebrick;
            this.btn_pause.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_pause.Location = new System.Drawing.Point(170, 478);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(98, 32);
            this.btn_pause.TabIndex = 4;
            this.btn_pause.Text = "Pause";
            this.btn_pause.UseVisualStyleBackColor = false;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // btn_create
            // 
            this.btn_create.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_create.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_create.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_create.Location = new System.Drawing.Point(65, 563);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(145, 48);
            this.btn_create.TabIndex = 4;
            this.btn_create.Text = "Task done!";
            this.btn_create.UseVisualStyleBackColor = false;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // lbl_hour_out
            // 
            this.lbl_hour_out.AutoSize = true;
            this.lbl_hour_out.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_hour_out.Location = new System.Drawing.Point(50, 404);
            this.lbl_hour_out.Name = "lbl_hour_out";
            this.lbl_hour_out.Size = new System.Drawing.Size(54, 48);
            this.lbl_hour_out.TabIndex = 0;
            this.lbl_hour_out.Text = "00";
            // 
            // lbl_min_out
            // 
            this.lbl_min_out.AutoSize = true;
            this.lbl_min_out.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_min_out.Location = new System.Drawing.Point(110, 404);
            this.lbl_min_out.Name = "lbl_min_out";
            this.lbl_min_out.Size = new System.Drawing.Size(54, 48);
            this.lbl_min_out.TabIndex = 0;
            this.lbl_min_out.Text = "00";
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_start.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_start.Location = new System.Drawing.Point(20, 478);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(98, 32);
            this.btn_start.TabIndex = 4;
            this.btn_start.Text = "Start Task";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label18.Location = new System.Drawing.Point(92, 404);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(26, 48);
            this.label18.TabIndex = 0;
            this.label18.Text = ":";
            // 
            // num_min
            // 
            this.num_min.Location = new System.Drawing.Point(101, 275);
            this.num_min.Name = "num_min";
            this.num_min.Size = new System.Drawing.Size(51, 27);
            this.num_min.TabIndex = 3;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(151, 404);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(26, 48);
            this.label17.TabIndex = 0;
            this.label17.Text = ":";
            // 
            // num_hour
            // 
            this.num_hour.Location = new System.Drawing.Point(16, 275);
            this.num_hour.Name = "num_hour";
            this.num_hour.Size = new System.Drawing.Size(51, 27);
            this.num_hour.TabIndex = 3;
            // 
            // lbl_sec_out
            // 
            this.lbl_sec_out.AutoSize = true;
            this.lbl_sec_out.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_sec_out.Location = new System.Drawing.Point(170, 404);
            this.lbl_sec_out.Name = "lbl_sec_out";
            this.lbl_sec_out.Size = new System.Drawing.Size(54, 48);
            this.lbl_sec_out.TabIndex = 0;
            this.lbl_sec_out.Text = "00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Minutes:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label15.Location = new System.Drawing.Point(78, 376);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(118, 28);
            this.label15.TabIndex = 0;
            this.label15.Text = "time elapsed:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Hours:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Expected timescale:";
            // 
            // txt_desc
            // 
            this.txt_desc.Location = new System.Drawing.Point(16, 109);
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(275, 72);
            this.txt_desc.TabIndex = 2;
            this.txt_desc.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(16, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Description:";
            // 
            // txt_task
            // 
            this.txt_task.Location = new System.Drawing.Point(16, 56);
            this.txt_task.Name = "txt_task";
            this.txt_task.Size = new System.Drawing.Size(275, 27);
            this.txt_task.TabIndex = 1;
            this.txt_task.Validating += new System.ComponentModel.CancelEventHandler(this.txt_task_Validating);
            this.txt_task.Validated += new System.EventHandler(this.Form1_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(16, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Task:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.InfoText;
            this.groupBox2.Controls.Add(this.lst_todo);
            this.groupBox2.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(365, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 630);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Completed tasks:";
            // 
            // lst_todo
            // 
            this.lst_todo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lst_todo.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point);
            this.lst_todo.FormattingEnabled = true;
            this.lst_todo.ItemHeight = 28;
            this.lst_todo.Location = new System.Drawing.Point(19, 22);
            this.lst_todo.Name = "lst_todo";
            this.lst_todo.Size = new System.Drawing.Size(232, 564);
            this.lst_todo.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(700, 700);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Task to do - in time";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_hour)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txt_desc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_task;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.NumericUpDown num_min;
        private System.Windows.Forms.NumericUpDown num_hour;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lst_todo;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Label lbl_hour_out;
        private System.Windows.Forms.Label lbl_min_out;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lbl_sec_out;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

