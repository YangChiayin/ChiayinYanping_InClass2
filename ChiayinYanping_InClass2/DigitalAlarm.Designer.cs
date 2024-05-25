namespace ChiayinYanping_InClass2
{
    partial class DigitalAlarm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DigitalAlarm));
            this.lblTime = new System.Windows.Forms.Label();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.lblAmPm = new System.Windows.Forms.Label();
            this.btnAlarmOn = new System.Windows.Forms.Button();
            this.btnAlarmOff = new System.Windows.Forms.Button();
            this.picAlarm = new System.Windows.Forms.PictureBox();
            this.lblAlarmTime = new System.Windows.Forms.Label();
            this.lab1 = new System.Windows.Forms.Label();
            this.lab2 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.timerAlarm = new System.Windows.Forms.Timer(this.components);
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDayOfWeek = new System.Windows.Forms.Label();
            this.lblAlarmStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picAlarm)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(307, 59);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(408, 147);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "label1";
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeconds.Location = new System.Drawing.Point(721, 59);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(171, 61);
            this.lblSeconds.TabIndex = 0;
            this.lblSeconds.Text = "label1";
            // 
            // lblAmPm
            // 
            this.lblAmPm.AutoSize = true;
            this.lblAmPm.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAmPm.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmPm.Location = new System.Drawing.Point(721, 145);
            this.lblAmPm.Name = "lblAmPm";
            this.lblAmPm.Size = new System.Drawing.Size(171, 61);
            this.lblAmPm.TabIndex = 0;
            this.lblAmPm.Text = "label1";
            // 
            // btnAlarmOn
            // 
            this.btnAlarmOn.BackColor = System.Drawing.SystemColors.Info;
            this.btnAlarmOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlarmOn.Location = new System.Drawing.Point(269, 381);
            this.btnAlarmOn.Name = "btnAlarmOn";
            this.btnAlarmOn.Size = new System.Drawing.Size(137, 37);
            this.btnAlarmOn.TabIndex = 1;
            this.btnAlarmOn.Text = "Alarm On";
            this.btnAlarmOn.UseVisualStyleBackColor = false;
            this.btnAlarmOn.Click += new System.EventHandler(this.btnAlarmOn_Click);
            // 
            // btnAlarmOff
            // 
            this.btnAlarmOff.BackColor = System.Drawing.SystemColors.Info;
            this.btnAlarmOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlarmOff.Location = new System.Drawing.Point(427, 381);
            this.btnAlarmOff.Name = "btnAlarmOff";
            this.btnAlarmOff.Size = new System.Drawing.Size(137, 37);
            this.btnAlarmOff.TabIndex = 1;
            this.btnAlarmOff.Text = "Alarm Off";
            this.btnAlarmOff.UseVisualStyleBackColor = false;
            this.btnAlarmOff.Click += new System.EventHandler(this.btnAlarmOff_Click);
            // 
            // picAlarm
            // 
            this.picAlarm.Image = ((System.Drawing.Image)(resources.GetObject("picAlarm.Image")));
            this.picAlarm.Location = new System.Drawing.Point(669, 261);
            this.picAlarm.Name = "picAlarm";
            this.picAlarm.Size = new System.Drawing.Size(377, 271);
            this.picAlarm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAlarm.TabIndex = 2;
            this.picAlarm.TabStop = false;
            this.picAlarm.Visible = false;
            // 
            // lblAlarmTime
            // 
            this.lblAlarmTime.AutoSize = true;
            this.lblAlarmTime.Location = new System.Drawing.Point(269, 261);
            this.lblAlarmTime.Name = "lblAlarmTime";
            this.lblAlarmTime.Size = new System.Drawing.Size(120, 25);
            this.lblAlarmTime.TabIndex = 3;
            this.lblAlarmTime.Text = "Alarm Time";
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lab1.Location = new System.Drawing.Point(269, 564);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(57, 25);
            this.lab1.TabIndex = 3;
            this.lab1.Text = "Date";
            // 
            // lab2
            // 
            this.lab2.AutoSize = true;
            this.lab2.Location = new System.Drawing.Point(664, 564);
            this.lab2.Name = "lab2";
            this.lab2.Size = new System.Drawing.Size(171, 25);
            this.lab2.TabIndex = 3;
            this.lab2.Text = "Day of the Week";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker.Location = new System.Drawing.Point(269, 313);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(295, 38);
            this.dateTimePicker.TabIndex = 4;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(263, 613);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(138, 61);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Date";
            // 
            // lblDayOfWeek
            // 
            this.lblDayOfWeek.AutoSize = true;
            this.lblDayOfWeek.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDayOfWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDayOfWeek.Location = new System.Drawing.Point(658, 613);
            this.lblDayOfWeek.Name = "lblDayOfWeek";
            this.lblDayOfWeek.Size = new System.Drawing.Size(415, 61);
            this.lblDayOfWeek.TabIndex = 3;
            this.lblDayOfWeek.Text = "Day of the Week";
            // 
            // lblAlarmStatus
            // 
            this.lblAlarmStatus.AutoSize = true;
            this.lblAlarmStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlarmStatus.Location = new System.Drawing.Point(264, 472);
            this.lblAlarmStatus.Name = "lblAlarmStatus";
            this.lblAlarmStatus.Size = new System.Drawing.Size(181, 31);
            this.lblAlarmStatus.TabIndex = 3;
            this.lblAlarmStatus.Text = "Alarm Status";
            // 
            // DigitalAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1235, 848);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.lblDayOfWeek);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lab2);
            this.Controls.Add(this.lab1);
            this.Controls.Add(this.lblAlarmStatus);
            this.Controls.Add(this.lblAlarmTime);
            this.Controls.Add(this.picAlarm);
            this.Controls.Add(this.btnAlarmOff);
            this.Controls.Add(this.btnAlarmOn);
            this.Controls.Add(this.lblAmPm);
            this.Controls.Add(this.lblSeconds);
            this.Controls.Add(this.lblTime);
            this.Name = "DigitalAlarm";
            this.Text = "DigitalAlarm";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAlarm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.Label lblAmPm;
        private System.Windows.Forms.Button btnAlarmOn;
        private System.Windows.Forms.Button btnAlarmOff;
        private System.Windows.Forms.PictureBox picAlarm;
        private System.Windows.Forms.Label lblAlarmTime;
        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.Label lab2;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.Timer timerAlarm;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblDayOfWeek;
        private System.Windows.Forms.Label lblAlarmStatus;
    }
}

