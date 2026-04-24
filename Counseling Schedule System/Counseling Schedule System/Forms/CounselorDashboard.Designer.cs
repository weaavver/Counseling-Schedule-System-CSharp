namespace Counseling_Schedule_System.Forms
{
    partial class CounselorDashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CounselorDashboard));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnShowRequests = new System.Windows.Forms.Button();
            this.btnShowSchedule = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblGreet = new System.Windows.Forms.Label();
            this.pnlRequests = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRequestID2 = new System.Windows.Forms.TextBox();
            this.btnScheduleRefresh = new System.Windows.Forms.Button();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnComplete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvSchedules = new System.Windows.Forms.DataGridView();
            this.pnlSchedule = new System.Windows.Forms.Panel();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnRequestRefresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvRequests = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.TimePicker = new System.Windows.Forms.DateTimePicker();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlRequests.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedules)).BeginInit();
            this.pnlSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequests)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.pnlSchedule);
            this.panel2.Controls.Add(this.pnlRequests);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(990, 615);
            this.panel2.TabIndex = 28;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.btnShowRequests);
            this.panel3.Controls.Add(this.btnShowSchedule);
            this.panel3.Controls.Add(this.btnLogout);
            this.panel3.Controls.Add(this.lblGreet);
            this.panel3.Location = new System.Drawing.Point(16, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(960, 48);
            this.panel3.TabIndex = 33;
            // 
            // btnShowRequests
            // 
            this.btnShowRequests.BackColor = System.Drawing.Color.Cyan;
            this.btnShowRequests.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowRequests.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnShowRequests.Location = new System.Drawing.Point(592, 13);
            this.btnShowRequests.Name = "btnShowRequests";
            this.btnShowRequests.Size = new System.Drawing.Size(93, 26);
            this.btnShowRequests.TabIndex = 16;
            this.btnShowRequests.Text = "Schedule";
            this.btnShowRequests.UseVisualStyleBackColor = false;
            this.btnShowRequests.Click += new System.EventHandler(this.btnShowRequests_Click);
            // 
            // btnShowSchedule
            // 
            this.btnShowSchedule.BackColor = System.Drawing.Color.Cyan;
            this.btnShowSchedule.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowSchedule.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnShowSchedule.Location = new System.Drawing.Point(691, 12);
            this.btnShowSchedule.Name = "btnShowSchedule";
            this.btnShowSchedule.Size = new System.Drawing.Size(93, 27);
            this.btnShowSchedule.TabIndex = 15;
            this.btnShowSchedule.Text = "Requests";
            this.btnShowSchedule.UseVisualStyleBackColor = false;
            this.btnShowSchedule.Click += new System.EventHandler(this.btnShowSchedule_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.LightGreen;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(799, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 14;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblGreet
            // 
            this.lblGreet.AutoSize = true;
            this.lblGreet.BackColor = System.Drawing.Color.Transparent;
            this.lblGreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGreet.Location = new System.Drawing.Point(64, 13);
            this.lblGreet.Name = "lblGreet";
            this.lblGreet.Size = new System.Drawing.Size(239, 18);
            this.lblGreet.TabIndex = 13;
            this.lblGreet.Text = "HELLO, [COUNSELOR NAME]";
            this.lblGreet.Click += new System.EventHandler(this.lblGreet_Click);
            // 
            // pnlRequests
            // 
            this.pnlRequests.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pnlRequests.Controls.Add(this.btnCancel);
            this.pnlRequests.Controls.Add(this.label7);
            this.pnlRequests.Controls.Add(this.txtRequestID2);
            this.pnlRequests.Controls.Add(this.btnScheduleRefresh);
            this.pnlRequests.Controls.Add(this.txtNotes);
            this.pnlRequests.Controls.Add(this.label2);
            this.pnlRequests.Controls.Add(this.btnComplete);
            this.pnlRequests.Controls.Add(this.label4);
            this.pnlRequests.Controls.Add(this.dgvSchedules);
            this.pnlRequests.Location = new System.Drawing.Point(16, 66);
            this.pnlRequests.Name = "pnlRequests";
            this.pnlRequests.Size = new System.Drawing.Size(960, 533);
            this.pnlRequests.TabIndex = 37;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancel.Location = new System.Drawing.Point(490, 424);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(132, 39);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 433);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 21);
            this.label7.TabIndex = 35;
            this.label7.Text = "Counseling Notes:";
            // 
            // txtRequestID2
            // 
            this.txtRequestID2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRequestID2.Location = new System.Drawing.Point(177, 474);
            this.txtRequestID2.Name = "txtRequestID2";
            this.txtRequestID2.Size = new System.Drawing.Size(102, 29);
            this.txtRequestID2.TabIndex = 20;
            // 
            // btnScheduleRefresh
            // 
            this.btnScheduleRefresh.BackColor = System.Drawing.Color.Cyan;
            this.btnScheduleRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnScheduleRefresh.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnScheduleRefresh.Location = new System.Drawing.Point(885, 15);
            this.btnScheduleRefresh.Name = "btnScheduleRefresh";
            this.btnScheduleRefresh.Size = new System.Drawing.Size(62, 22);
            this.btnScheduleRefresh.TabIndex = 19;
            this.btnScheduleRefresh.Text = "Refresh";
            this.btnScheduleRefresh.UseVisualStyleBackColor = false;
            this.btnScheduleRefresh.Click += new System.EventHandler(this.btnScheduleRefresh_Click);
            // 
            // txtNotes
            // 
            this.txtNotes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotes.Location = new System.Drawing.Point(177, 429);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(284, 29);
            this.txtNotes.TabIndex = 34;
            this.txtNotes.TextChanged += new System.EventHandler(this.txtNotes_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 30);
            this.label2.TabIndex = 18;
            this.label2.Text = "Scheduled Requests";
            // 
            // btnComplete
            // 
            this.btnComplete.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnComplete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComplete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnComplete.Location = new System.Drawing.Point(490, 471);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(132, 39);
            this.btnComplete.TabIndex = 24;
            this.btnComplete.Text = "Complete";
            this.btnComplete.UseVisualStyleBackColor = false;
            this.btnComplete.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 477);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 21);
            this.label4.TabIndex = 26;
            this.label4.Text = "Input Request ID";
            // 
            // dgvSchedules
            // 
            this.dgvSchedules.BackgroundColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSchedules.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvSchedules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSchedules.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvSchedules.Location = new System.Drawing.Point(15, 43);
            this.dgvSchedules.Name = "dgvSchedules";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSchedules.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvSchedules.Size = new System.Drawing.Size(932, 370);
            this.dgvSchedules.TabIndex = 17;
            this.dgvSchedules.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSchedules_CellClick_1);
            this.dgvSchedules.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSchedules_CellContentClick);
            // 
            // pnlSchedule
            // 
            this.pnlSchedule.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pnlSchedule.Controls.Add(this.btnConfirm);
            this.pnlSchedule.Controls.Add(this.btnRequestRefresh);
            this.pnlSchedule.Controls.Add(this.label1);
            this.pnlSchedule.Controls.Add(this.label6);
            this.pnlSchedule.Controls.Add(this.dgvRequests);
            this.pnlSchedule.Controls.Add(this.label3);
            this.pnlSchedule.Controls.Add(this.TimePicker);
            this.pnlSchedule.Controls.Add(this.DatePicker);
            this.pnlSchedule.Location = new System.Drawing.Point(16, 66);
            this.pnlSchedule.Name = "pnlSchedule";
            this.pnlSchedule.Size = new System.Drawing.Size(960, 533);
            this.pnlSchedule.TabIndex = 36;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.SystemColors.Control;
            this.btnConfirm.Location = new System.Drawing.Point(309, 470);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(85, 31);
            this.btnConfirm.TabIndex = 23;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnRequestRefresh
            // 
            this.btnRequestRefresh.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRequestRefresh.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequestRefresh.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRequestRefresh.Location = new System.Drawing.Point(885, 18);
            this.btnRequestRefresh.Name = "btnRequestRefresh";
            this.btnRequestRefresh.Size = new System.Drawing.Size(62, 22);
            this.btnRequestRefresh.TabIndex = 16;
            this.btnRequestRefresh.Text = "Refresh";
            this.btnRequestRefresh.UseVisualStyleBackColor = false;
            this.btnRequestRefresh.Click += new System.EventHandler(this.btnRequestRefresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 30);
            this.label1.TabIndex = 15;
            this.label1.Text = "Pending Requests";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 474);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 21);
            this.label6.TabIndex = 32;
            this.label6.Text = "Scheduled Time:";
            // 
            // dgvRequests
            // 
            this.dgvRequests.BackgroundColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRequests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRequests.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvRequests.Location = new System.Drawing.Point(15, 42);
            this.dgvRequests.Name = "dgvRequests";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRequests.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvRequests.Size = new System.Drawing.Size(932, 370);
            this.dgvRequests.TabIndex = 14;
            this.dgvRequests.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRequests_CellClick);
            this.dgvRequests.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRequests_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 432);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 21);
            this.label3.TabIndex = 31;
            this.label3.Text = "Scheduled Date:";
            // 
            // TimePicker
            // 
            this.TimePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimePicker.Location = new System.Drawing.Point(178, 471);
            this.TimePicker.Name = "TimePicker";
            this.TimePicker.Size = new System.Drawing.Size(125, 29);
            this.TimePicker.TabIndex = 30;
            // 
            // DatePicker
            // 
            this.DatePicker.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.DatePicker.CalendarTitleBackColor = System.Drawing.Color.LightGreen;
            this.DatePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatePicker.Location = new System.Drawing.Point(178, 429);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(216, 29);
            this.DatePicker.TabIndex = 29;
            this.DatePicker.ValueChanged += new System.EventHandler(this.DatePicker_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(990, 618);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(893, -3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 51);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 36;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // CounselorDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CounselorDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CounselorDashboard";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlRequests.ResumeLayout(false);
            this.pnlRequests.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedules)).EndInit();
            this.pnlSchedule.ResumeLayout(false);
            this.pnlSchedule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequests)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblGreet;
        private System.Windows.Forms.DataGridView dgvSchedules;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnScheduleRefresh;
        private System.Windows.Forms.TextBox txtRequestID2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlRequests;
        private System.Windows.Forms.Button btnShowRequests;
        private System.Windows.Forms.Button btnShowSchedule;
        private System.Windows.Forms.Panel pnlSchedule;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnRequestRefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvRequests;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker TimePicker;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}