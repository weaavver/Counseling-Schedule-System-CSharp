namespace Counseling_Schedule_System.Forms
{
    partial class StudentDashboard
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.richTxtReason = new System.Windows.Forms.RichTextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.TimePicker = new System.Windows.Forms.DateTimePicker();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.PanelScheduleBoard = new System.Windows.Forms.Panel();
            this.txtScheduledTime = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.Label();
            this.txtCounselor = new System.Windows.Forms.Label();
            this.txtDateRequested = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblDateRequested = new System.Windows.Forms.Label();
            this.lblScheduleTime = new System.Windows.Forms.Label();
            this.lblCounselor = new System.Windows.Forms.Label();
            this.lblScheduleBoard = new System.Windows.Forms.Label();
            this.lblGreet = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.PanelScheduleBoard.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(136, 380);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Apply for Counseling";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Reason";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Preferred Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Preferred Time";
            // 
            // richTxtReason
            // 
            this.richTxtReason.Location = new System.Drawing.Point(136, 189);
            this.richTxtReason.Name = "richTxtReason";
            this.richTxtReason.Size = new System.Drawing.Size(294, 125);
            this.richTxtReason.TabIndex = 5;
            this.richTxtReason.Text = "";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(232, 380);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // TimePicker
            // 
            this.TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimePicker.Location = new System.Drawing.Point(136, 346);
            this.TimePicker.Name = "TimePicker";
            this.TimePicker.Size = new System.Drawing.Size(99, 20);
            this.TimePicker.TabIndex = 9;
            // 
            // DatePicker
            // 
            this.DatePicker.Location = new System.Drawing.Point(136, 320);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(200, 20);
            this.DatePicker.TabIndex = 10;
            // 
            // PanelScheduleBoard
            // 
            this.PanelScheduleBoard.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PanelScheduleBoard.Controls.Add(this.txtScheduledTime);
            this.PanelScheduleBoard.Controls.Add(this.txtStatus);
            this.PanelScheduleBoard.Controls.Add(this.txtCounselor);
            this.PanelScheduleBoard.Controls.Add(this.txtDateRequested);
            this.PanelScheduleBoard.Controls.Add(this.lblStatus);
            this.PanelScheduleBoard.Controls.Add(this.lblDateRequested);
            this.PanelScheduleBoard.Controls.Add(this.lblScheduleTime);
            this.PanelScheduleBoard.Controls.Add(this.lblCounselor);
            this.PanelScheduleBoard.Controls.Add(this.lblScheduleBoard);
            this.PanelScheduleBoard.Location = new System.Drawing.Point(480, 147);
            this.PanelScheduleBoard.Name = "PanelScheduleBoard";
            this.PanelScheduleBoard.Size = new System.Drawing.Size(308, 226);
            this.PanelScheduleBoard.TabIndex = 11;
            this.PanelScheduleBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelScheduleBoard_Paint);
            // 
            // txtScheduledTime
            // 
            this.txtScheduledTime.AutoSize = true;
            this.txtScheduledTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScheduledTime.Location = new System.Drawing.Point(117, 91);
            this.txtScheduledTime.Name = "txtScheduledTime";
            this.txtScheduledTime.Size = new System.Drawing.Size(23, 15);
            this.txtScheduledTime.TabIndex = 8;
            this.txtScheduledTime.Text = "----";
            // 
            // txtStatus
            // 
            this.txtStatus.AutoSize = true;
            this.txtStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(117, 144);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(23, 15);
            this.txtStatus.TabIndex = 7;
            this.txtStatus.Text = "----";
            // 
            // txtCounselor
            // 
            this.txtCounselor.AutoSize = true;
            this.txtCounselor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCounselor.Location = new System.Drawing.Point(117, 117);
            this.txtCounselor.Name = "txtCounselor";
            this.txtCounselor.Size = new System.Drawing.Size(23, 15);
            this.txtCounselor.TabIndex = 6;
            this.txtCounselor.Text = "----";
            // 
            // txtDateRequested
            // 
            this.txtDateRequested.AutoSize = true;
            this.txtDateRequested.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateRequested.Location = new System.Drawing.Point(117, 61);
            this.txtDateRequested.Name = "txtDateRequested";
            this.txtDateRequested.Size = new System.Drawing.Size(23, 15);
            this.txtDateRequested.TabIndex = 5;
            this.txtDateRequested.Text = "----";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(14, 144);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(44, 15);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Status:";
            // 
            // lblDateRequested
            // 
            this.lblDateRequested.AutoSize = true;
            this.lblDateRequested.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateRequested.Location = new System.Drawing.Point(14, 61);
            this.lblDateRequested.Name = "lblDateRequested";
            this.lblDateRequested.Size = new System.Drawing.Size(99, 15);
            this.lblDateRequested.TabIndex = 3;
            this.lblDateRequested.Text = "Date Requested:";
            // 
            // lblScheduleTime
            // 
            this.lblScheduleTime.AutoSize = true;
            this.lblScheduleTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScheduleTime.Location = new System.Drawing.Point(14, 90);
            this.lblScheduleTime.Name = "lblScheduleTime";
            this.lblScheduleTime.Size = new System.Drawing.Size(97, 15);
            this.lblScheduleTime.TabIndex = 2;
            this.lblScheduleTime.Text = "Scheduled Time";
            // 
            // lblCounselor
            // 
            this.lblCounselor.AutoSize = true;
            this.lblCounselor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounselor.Location = new System.Drawing.Point(14, 117);
            this.lblCounselor.Name = "lblCounselor";
            this.lblCounselor.Size = new System.Drawing.Size(66, 15);
            this.lblCounselor.TabIndex = 1;
            this.lblCounselor.Text = "Counselor:";
            // 
            // lblScheduleBoard
            // 
            this.lblScheduleBoard.AutoSize = true;
            this.lblScheduleBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScheduleBoard.Location = new System.Drawing.Point(13, 14);
            this.lblScheduleBoard.Name = "lblScheduleBoard";
            this.lblScheduleBoard.Size = new System.Drawing.Size(160, 24);
            this.lblScheduleBoard.TabIndex = 0;
            this.lblScheduleBoard.Text = "Schedule Board";
            // 
            // lblGreet
            // 
            this.lblGreet.AutoSize = true;
            this.lblGreet.BackColor = System.Drawing.Color.Transparent;
            this.lblGreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreet.Location = new System.Drawing.Point(18, 42);
            this.lblGreet.Name = "lblGreet";
            this.lblGreet.Size = new System.Drawing.Size(212, 18);
            this.lblGreet.TabIndex = 12;
            this.lblGreet.Text = "HELLO, [STUDENT NAME]";
            this.lblGreet.Click += new System.EventHandler(this.lblGreet_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.PanelScheduleBoard);
            this.panel1.Controls.Add(this.lblGreet);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.DatePicker);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TimePicker);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.richTxtReason);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 465);
            this.panel1.TabIndex = 13;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(480, 118);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 13;
            this.btnRefresh.Text = "Refesh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // StudentDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 465);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "`";
            this.PanelScheduleBoard.ResumeLayout(false);
            this.PanelScheduleBoard.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTxtReason;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DateTimePicker TimePicker;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.Panel PanelScheduleBoard;
        private System.Windows.Forms.Label lblDateRequested;
        private System.Windows.Forms.Label lblScheduleTime;
        private System.Windows.Forms.Label lblCounselor;
        private System.Windows.Forms.Label lblScheduleBoard;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblGreet;
        private System.Windows.Forms.Label txtScheduledTime;
        private System.Windows.Forms.Label txtStatus;
        private System.Windows.Forms.Label txtCounselor;
        private System.Windows.Forms.Label txtDateRequested;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRefresh;
    }
}