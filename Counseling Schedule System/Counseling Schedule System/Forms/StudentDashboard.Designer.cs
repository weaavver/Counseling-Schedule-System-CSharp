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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentDashboard));
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
            this.scheduledDateTime = new System.Windows.Forms.DateTimePicker();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.PanelScheduleBoard.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(253, 377);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(86, 34);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Apply for Counseling";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Issue:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Preferred Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Preferred Time:";
            // 
            // richTxtReason
            // 
            this.richTxtReason.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTxtReason.Location = new System.Drawing.Point(152, 85);
            this.richTxtReason.Name = "richTxtReason";
            this.richTxtReason.Size = new System.Drawing.Size(390, 125);
            this.richTxtReason.TabIndex = 5;
            this.richTxtReason.Text = "";
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(155, 377);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(86, 34);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // TimePicker
            // 
            this.TimePicker.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimePicker.Location = new System.Drawing.Point(152, 303);
            this.TimePicker.Name = "TimePicker";
            this.TimePicker.Size = new System.Drawing.Size(99, 25);
            this.TimePicker.TabIndex = 9;
            // 
            // DatePicker
            // 
            this.DatePicker.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatePicker.Location = new System.Drawing.Point(152, 263);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(187, 25);
            this.DatePicker.TabIndex = 10;
            // 
            // PanelScheduleBoard
            // 
            this.PanelScheduleBoard.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.PanelScheduleBoard.Controls.Add(this.btnRefresh);
            this.PanelScheduleBoard.Controls.Add(this.btnCancel);
            this.PanelScheduleBoard.Controls.Add(this.scheduledDateTime);
            this.PanelScheduleBoard.Controls.Add(this.txtStatus);
            this.PanelScheduleBoard.Controls.Add(this.txtCounselor);
            this.PanelScheduleBoard.Controls.Add(this.txtDateRequested);
            this.PanelScheduleBoard.Controls.Add(this.lblStatus);
            this.PanelScheduleBoard.Controls.Add(this.lblDateRequested);
            this.PanelScheduleBoard.Controls.Add(this.lblScheduleTime);
            this.PanelScheduleBoard.Controls.Add(this.lblCounselor);
            this.PanelScheduleBoard.Controls.Add(this.lblScheduleBoard);
            this.PanelScheduleBoard.Location = new System.Drawing.Point(586, 8);
            this.PanelScheduleBoard.Name = "PanelScheduleBoard";
            this.PanelScheduleBoard.Size = new System.Drawing.Size(386, 543);
            this.PanelScheduleBoard.TabIndex = 11;
            this.PanelScheduleBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelScheduleBoard_Paint);
            // 
            // scheduledDateTime
            // 
            this.scheduledDateTime.Enabled = false;
            this.scheduledDateTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scheduledDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.scheduledDateTime.Location = new System.Drawing.Point(187, 133);
            this.scheduledDateTime.Name = "scheduledDateTime";
            this.scheduledDateTime.Size = new System.Drawing.Size(130, 23);
            this.scheduledDateTime.TabIndex = 15;
            // 
            // txtStatus
            // 
            this.txtStatus.AutoSize = true;
            this.txtStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(183, 221);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(34, 21);
            this.txtStatus.TabIndex = 7;
            this.txtStatus.Text = "----";
            // 
            // txtCounselor
            // 
            this.txtCounselor.AutoSize = true;
            this.txtCounselor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCounselor.Location = new System.Drawing.Point(183, 175);
            this.txtCounselor.Name = "txtCounselor";
            this.txtCounselor.Size = new System.Drawing.Size(34, 21);
            this.txtCounselor.TabIndex = 6;
            this.txtCounselor.Text = "----";
            // 
            // txtDateRequested
            // 
            this.txtDateRequested.AutoSize = true;
            this.txtDateRequested.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateRequested.Location = new System.Drawing.Point(183, 92);
            this.txtDateRequested.Name = "txtDateRequested";
            this.txtDateRequested.Size = new System.Drawing.Size(34, 21);
            this.txtDateRequested.TabIndex = 5;
            this.txtDateRequested.Text = "----";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(99, 221);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(61, 21);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Status:";
            // 
            // lblDateRequested
            // 
            this.lblDateRequested.AutoSize = true;
            this.lblDateRequested.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateRequested.Location = new System.Drawing.Point(28, 92);
            this.lblDateRequested.Name = "lblDateRequested";
            this.lblDateRequested.Size = new System.Drawing.Size(134, 21);
            this.lblDateRequested.TabIndex = 3;
            this.lblDateRequested.Text = "Date Requested:";
            // 
            // lblScheduleTime
            // 
            this.lblScheduleTime.AutoSize = true;
            this.lblScheduleTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScheduleTime.Location = new System.Drawing.Point(26, 133);
            this.lblScheduleTime.Name = "lblScheduleTime";
            this.lblScheduleTime.Size = new System.Drawing.Size(136, 21);
            this.lblScheduleTime.TabIndex = 2;
            this.lblScheduleTime.Text = "Scheduled Time:";
            // 
            // lblCounselor
            // 
            this.lblCounselor.AutoSize = true;
            this.lblCounselor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounselor.Location = new System.Drawing.Point(68, 175);
            this.lblCounselor.Name = "lblCounselor";
            this.lblCounselor.Size = new System.Drawing.Size(92, 21);
            this.lblCounselor.TabIndex = 1;
            this.lblCounselor.Text = "Counselor:";
            // 
            // lblScheduleBoard
            // 
            this.lblScheduleBoard.AutoSize = true;
            this.lblScheduleBoard.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScheduleBoard.Location = new System.Drawing.Point(25, 15);
            this.lblScheduleBoard.Name = "lblScheduleBoard";
            this.lblScheduleBoard.Size = new System.Drawing.Size(166, 30);
            this.lblScheduleBoard.TabIndex = 0;
            this.lblScheduleBoard.Text = "Schedule Board";
            // 
            // lblGreet
            // 
            this.lblGreet.AutoSize = true;
            this.lblGreet.BackColor = System.Drawing.Color.Transparent;
            this.lblGreet.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreet.ForeColor = System.Drawing.SystemColors.Control;
            this.lblGreet.Location = new System.Drawing.Point(10, 9);
            this.lblGreet.Name = "lblGreet";
            this.lblGreet.Size = new System.Drawing.Size(241, 25);
            this.lblGreet.TabIndex = 12;
            this.lblGreet.Text = "HELLO, [STUDENT NAME]";
            this.lblGreet.Click += new System.EventHandler(this.lblGreet_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(988, 617);
            this.panel1.TabIndex = 13;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Controls.Add(this.lblGreet);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(988, 50);
            this.panel2.TabIndex = 14;
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(897, 13);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 29);
            this.btnLogout.TabIndex = 13;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Controls.Add(this.PanelScheduleBoard);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(0, 48);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(985, 566);
            this.panel3.TabIndex = 15;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(187, 303);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(153, 36);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel pending request";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(87, 303);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(73, 36);
            this.btnRefresh.TabIndex = 13;
            this.btnRefresh.Text = "Refesh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.richTxtReason);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.DatePicker);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.TimePicker);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.btnClear);
            this.panel4.Controls.Add(this.btnSubmit);
            this.panel4.Location = new System.Drawing.Point(12, 8);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(568, 543);
            this.panel4.TabIndex = 15;
            // 
            // StudentDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StudentDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "`";
            this.PanelScheduleBoard.ResumeLayout(false);
            this.PanelScheduleBoard.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
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
        private System.Windows.Forms.Label txtStatus;
        private System.Windows.Forms.Label txtCounselor;
        private System.Windows.Forms.Label txtDateRequested;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker scheduledDateTime;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel4;
    }
}