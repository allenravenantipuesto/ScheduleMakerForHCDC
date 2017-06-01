namespace Schedule_Maker
{
    partial class Main
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbSchedules = new System.Windows.Forms.ComboBox();
            this.btnClearScheduleView = new System.Windows.Forms.Button();
            this.btnAddNewSchedule = new System.Windows.Forms.Button();
            this.btnSelectSchedule = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddSubject = new System.Windows.Forms.Button();
            this.txtAddSubject = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgSchedule = new System.Windows.Forms.DataGridView();
            this.subjectOffer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leclab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgSubjectOffered = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subjectOfferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subjectOfferToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.logoutSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSchedule)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSubjectOffered)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1234, 566);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbSchedules);
            this.tabPage1.Controls.Add(this.btnClearScheduleView);
            this.tabPage1.Controls.Add(this.btnAddNewSchedule);
            this.tabPage1.Controls.Add(this.btnSelectSchedule);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btnAddSubject);
            this.tabPage1.Controls.Add(this.txtAddSubject);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dgSchedule);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1226, 532);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Schedule";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbSchedules
            // 
            this.cbSchedules.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSchedules.FormattingEnabled = true;
            this.cbSchedules.Location = new System.Drawing.Point(120, 55);
            this.cbSchedules.Name = "cbSchedules";
            this.cbSchedules.Size = new System.Drawing.Size(253, 29);
            this.cbSchedules.TabIndex = 16;
            // 
            // btnClearScheduleView
            // 
            this.btnClearScheduleView.Location = new System.Drawing.Point(646, 8);
            this.btnClearScheduleView.Name = "btnClearScheduleView";
            this.btnClearScheduleView.Size = new System.Drawing.Size(129, 80);
            this.btnClearScheduleView.TabIndex = 14;
            this.btnClearScheduleView.Text = "Clear";
            this.btnClearScheduleView.UseVisualStyleBackColor = true;
            this.btnClearScheduleView.Click += new System.EventHandler(this.btnClearScheduleView_Click);
            // 
            // btnAddNewSchedule
            // 
            this.btnAddNewSchedule.Location = new System.Drawing.Point(517, 8);
            this.btnAddNewSchedule.Name = "btnAddNewSchedule";
            this.btnAddNewSchedule.Size = new System.Drawing.Size(123, 80);
            this.btnAddNewSchedule.TabIndex = 13;
            this.btnAddNewSchedule.Text = "Add New Schedule";
            this.btnAddNewSchedule.UseVisualStyleBackColor = true;
            this.btnAddNewSchedule.Click += new System.EventHandler(this.btnAddNewSchedule_Click);
            // 
            // btnSelectSchedule
            // 
            this.btnSelectSchedule.Location = new System.Drawing.Point(379, 49);
            this.btnSelectSchedule.Name = "btnSelectSchedule";
            this.btnSelectSchedule.Size = new System.Drawing.Size(132, 39);
            this.btnSelectSchedule.TabIndex = 12;
            this.btnSelectSchedule.Text = "Select Schedule";
            this.btnSelectSchedule.UseVisualStyleBackColor = true;
            this.btnSelectSchedule.Click += new System.EventHandler(this.btnSelectSchedule_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Schedules:";
            // 
            // btnAddSubject
            // 
            this.btnAddSubject.Location = new System.Drawing.Point(379, 8);
            this.btnAddSubject.Name = "btnAddSubject";
            this.btnAddSubject.Size = new System.Drawing.Size(132, 39);
            this.btnAddSubject.TabIndex = 3;
            this.btnAddSubject.Text = "Add Subject";
            this.btnAddSubject.UseVisualStyleBackColor = true;
            this.btnAddSubject.Click += new System.EventHandler(this.btnAddSubject_Click);
            // 
            // txtAddSubject
            // 
            this.txtAddSubject.Location = new System.Drawing.Point(120, 14);
            this.txtAddSubject.Name = "txtAddSubject";
            this.txtAddSubject.Size = new System.Drawing.Size(253, 29);
            this.txtAddSubject.TabIndex = 2;
            this.txtAddSubject.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAddSubject_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Subject Code:";
            // 
            // dgSchedule
            // 
            this.dgSchedule.AllowUserToAddRows = false;
            this.dgSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subjectOffer,
            this.subjectCode,
            this.description,
            this.time,
            this.day,
            this.leclab,
            this.room});
            this.dgSchedule.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgSchedule.Location = new System.Drawing.Point(3, 94);
            this.dgSchedule.Name = "dgSchedule";
            this.dgSchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSchedule.Size = new System.Drawing.Size(1220, 435);
            this.dgSchedule.TabIndex = 0;
            this.dgSchedule.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgSchedule_KeyDown);
            // 
            // subjectOffer
            // 
            this.subjectOffer.HeaderText = "Subject Offer #";
            this.subjectOffer.Name = "subjectOffer";
            this.subjectOffer.Width = 120;
            // 
            // subjectCode
            // 
            this.subjectCode.HeaderText = "Subject Code";
            this.subjectCode.Name = "subjectCode";
            this.subjectCode.Width = 120;
            // 
            // description
            // 
            this.description.HeaderText = "Description";
            this.description.Name = "description";
            this.description.Width = 300;
            // 
            // time
            // 
            this.time.HeaderText = "Time";
            this.time.Name = "time";
            this.time.Width = 150;
            // 
            // day
            // 
            this.day.HeaderText = "Day";
            this.day.Name = "day";
            this.day.Width = 120;
            // 
            // leclab
            // 
            this.leclab.HeaderText = "Lec/Lab";
            this.leclab.Name = "leclab";
            this.leclab.Width = 120;
            // 
            // room
            // 
            this.room.HeaderText = "Room";
            this.room.Name = "room";
            this.room.Width = 120;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnSearch);
            this.tabPage2.Controls.Add(this.txtSearch);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.dgSubjectOffered);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1226, 532);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Offered Subjects";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(332, 8);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(132, 39);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(73, 14);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(253, 29);
            this.txtSearch.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Search:";
            // 
            // dgSubjectOffered
            // 
            this.dgSubjectOffered.AllowUserToAddRows = false;
            this.dgSubjectOffered.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSubjectOffered.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dgSubjectOffered.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgSubjectOffered.Location = new System.Drawing.Point(3, 62);
            this.dgSubjectOffered.Name = "dgSubjectOffered";
            this.dgSubjectOffered.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSubjectOffered.Size = new System.Drawing.Size(1220, 467);
            this.dgSubjectOffered.TabIndex = 4;
            this.dgSubjectOffered.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgSubjectOffered_MouseDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Subject Offer #";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 120;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Subject Code";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 120;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Description";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 300;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Time";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Day";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 120;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Lec/Lab";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 120;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Room";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 120;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.restartAppToolStripMenuItem,
            this.logoutSessionToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subjectOfferToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.settingsToolStripMenuItem.Text = "Import";
            // 
            // subjectOfferToolStripMenuItem
            // 
            this.subjectOfferToolStripMenuItem.Name = "subjectOfferToolStripMenuItem";
            this.subjectOfferToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.subjectOfferToolStripMenuItem.Text = "Subject Offer";
            this.subjectOfferToolStripMenuItem.Click += new System.EventHandler(this.subjectOfferToolStripMenuItem_Click);
            // 
            // restartAppToolStripMenuItem
            // 
            this.restartAppToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subjectOfferToolStripMenuItem1,
            this.scheduleToolStripMenuItem});
            this.restartAppToolStripMenuItem.Name = "restartAppToolStripMenuItem";
            this.restartAppToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.restartAppToolStripMenuItem.Text = "Reload";
            // 
            // subjectOfferToolStripMenuItem1
            // 
            this.subjectOfferToolStripMenuItem1.Name = "subjectOfferToolStripMenuItem1";
            this.subjectOfferToolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
            this.subjectOfferToolStripMenuItem1.Text = "Subject Offer";
            this.subjectOfferToolStripMenuItem1.Click += new System.EventHandler(this.subjectOfferToolStripMenuItem1_Click);
            // 
            // scheduleToolStripMenuItem
            // 
            this.scheduleToolStripMenuItem.Name = "scheduleToolStripMenuItem";
            this.scheduleToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.scheduleToolStripMenuItem.Text = "Schedule";
            this.scheduleToolStripMenuItem.Click += new System.EventHandler(this.scheduleToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1234, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // reloadToolStripMenuItem
            // 
            this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            this.reloadToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.reloadToolStripMenuItem.Text = "Restart";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // logoutSessionToolStripMenuItem
            // 
            this.logoutSessionToolStripMenuItem.Name = "logoutSessionToolStripMenuItem";
            this.logoutSessionToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.logoutSessionToolStripMenuItem.Text = "Logout Session";
            this.logoutSessionToolStripMenuItem.Click += new System.EventHandler(this.logoutSessionToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1234, 590);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schedule Maker v1.0";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.SizeChanged += new System.EventHandler(this.Main_SizeChanged);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSchedule)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSubjectOffered)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgSubjectOffered;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subjectOfferToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartAppToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subjectOfferToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem scheduleToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnClearScheduleView;
        private System.Windows.Forms.Button btnAddNewSchedule;
        private System.Windows.Forms.Button btnSelectSchedule;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddSubject;
        private System.Windows.Forms.TextBox txtAddSubject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgSchedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectOffer;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn day;
        private System.Windows.Forms.DataGridViewTextBoxColumn leclab;
        private System.Windows.Forms.DataGridViewTextBoxColumn room;
        private System.Windows.Forms.ComboBox cbSchedules;
        private System.Windows.Forms.ToolStripMenuItem logoutSessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

