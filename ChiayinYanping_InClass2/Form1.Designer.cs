namespace ChiayinYanping_InClass2
{
    partial class Form1
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
            this.lblTime = new System.Windows.Forms.Label();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.lblAmPm = new System.Windows.Forms.Label();
            this.btnAlarmOn = new System.Windows.Forms.Button();
            this.btnAlarmOff = new System.Windows.Forms.Button();
            this.picAlarm = new System.Windows.Forms.PictureBox();
            this.lblAlarmTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDayOfWeek = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.picAlarm)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(276, 139);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(408, 147);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "label1";
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeconds.Location = new System.Drawing.Point(690, 139);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(171, 61);
            this.lblSeconds.TabIndex = 0;
            this.lblSeconds.Text = "label1";
            // 
            // lblAmPm
            // 
            this.lblAmPm.AutoSize = true;
            this.lblAmPm.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmPm.Location = new System.Drawing.Point(690, 225);
            this.lblAmPm.Name = "lblAmPm";
            this.lblAmPm.Size = new System.Drawing.Size(171, 61);
            this.lblAmPm.TabIndex = 0;
            this.lblAmPm.Text = "label1";
            // 
            // btnAlarmOn
            // 
            this.btnAlarmOn.Location = new System.Drawing.Point(301, 430);
            this.btnAlarmOn.Name = "btnAlarmOn";
            this.btnAlarmOn.Size = new System.Drawing.Size(137, 37);
            this.btnAlarmOn.TabIndex = 1;
            this.btnAlarmOn.Text = "Alarm On";
            this.btnAlarmOn.UseVisualStyleBackColor = true;
            // 
            // btnAlarmOff
            // 
            this.btnAlarmOff.Location = new System.Drawing.Point(459, 430);
            this.btnAlarmOff.Name = "btnAlarmOff";
            this.btnAlarmOff.Size = new System.Drawing.Size(137, 37);
            this.btnAlarmOff.TabIndex = 1;
            this.btnAlarmOff.Text = "Alarm Off";
            this.btnAlarmOff.UseVisualStyleBackColor = true;
            // 
            // picAlarm
            // 
            this.picAlarm.Location = new System.Drawing.Point(701, 310);
            this.picAlarm.Name = "picAlarm";
            this.picAlarm.Size = new System.Drawing.Size(377, 271);
            this.picAlarm.TabIndex = 2;
            this.picAlarm.TabStop = false;
            // 
            // lblAlarmTime
            // 
            this.lblAlarmTime.AutoSize = true;
            this.lblAlarmTime.Location = new System.Drawing.Point(301, 310);
            this.lblAlarmTime.Name = "lblAlarmTime";
            this.lblAlarmTime.Size = new System.Drawing.Size(120, 25);
            this.lblAlarmTime.TabIndex = 3;
            this.lblAlarmTime.Text = "Alarm Time";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(301, 653);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(57, 25);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Date";
            // 
            // lblDayOfWeek
            // 
            this.lblDayOfWeek.AutoSize = true;
            this.lblDayOfWeek.Location = new System.Drawing.Point(696, 653);
            this.lblDayOfWeek.Name = "lblDayOfWeek";
            this.lblDayOfWeek.Size = new System.Drawing.Size(171, 25);
            this.lblDayOfWeek.TabIndex = 3;
            this.lblDayOfWeek.Text = "Day of the Week";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(301, 362);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(295, 31);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 848);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblDayOfWeek);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblAlarmTime);
            this.Controls.Add(this.picAlarm);
            this.Controls.Add(this.btnAlarmOff);
            this.Controls.Add(this.btnAlarmOn);
            this.Controls.Add(this.lblAmPm);
            this.Controls.Add(this.lblSeconds);
            this.Controls.Add(this.lblTime);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblDayOfWeek;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

