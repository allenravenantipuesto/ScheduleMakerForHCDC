namespace Schedule_Maker
{
    partial class Import_Subject_Offer
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
            this.dgImport = new System.Windows.Forms.DataGridView();
            this.subjectOffer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Until = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leclab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPasteFromExcel = new System.Windows.Forms.Button();
            this.btnImportToDatabase = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dgImport)).BeginInit();
            this.SuspendLayout();
            // 
            // dgImport
            // 
            this.dgImport.AllowUserToAddRows = false;
            this.dgImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgImport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subjectOffer,
            this.subjectCode,
            this.description,
            this.time,
            this.Until,
            this.day,
            this.leclab,
            this.room});
            this.dgImport.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgImport.Location = new System.Drawing.Point(0, 55);
            this.dgImport.Name = "dgImport";
            this.dgImport.Size = new System.Drawing.Size(1216, 488);
            this.dgImport.TabIndex = 1;
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
            this.time.HeaderText = "Time(Start)";
            this.time.Name = "time";
            this.time.Width = 150;
            // 
            // Until
            // 
            this.Until.HeaderText = "Time(Until)";
            this.Until.Name = "Until";
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
            // btnPasteFromExcel
            // 
            this.btnPasteFromExcel.Location = new System.Drawing.Point(12, 13);
            this.btnPasteFromExcel.Name = "btnPasteFromExcel";
            this.btnPasteFromExcel.Size = new System.Drawing.Size(136, 36);
            this.btnPasteFromExcel.TabIndex = 2;
            this.btnPasteFromExcel.Text = "Paste from Excel";
            this.btnPasteFromExcel.UseVisualStyleBackColor = true;
            this.btnPasteFromExcel.Click += new System.EventHandler(this.btnPasteFromExcel_Click);
            // 
            // btnImportToDatabase
            // 
            this.btnImportToDatabase.Location = new System.Drawing.Point(154, 12);
            this.btnImportToDatabase.Name = "btnImportToDatabase";
            this.btnImportToDatabase.Size = new System.Drawing.Size(212, 36);
            this.btnImportToDatabase.TabIndex = 3;
            this.btnImportToDatabase.Text = "Import to Database";
            this.btnImportToDatabase.UseVisualStyleBackColor = true;
            this.btnImportToDatabase.Click += new System.EventHandler(this.btnImportToDatabase_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(373, 12);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(831, 36);
            this.progressBar.TabIndex = 4;
            // 
            // Import_Subject_Offer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1216, 543);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnImportToDatabase);
            this.Controls.Add(this.btnPasteFromExcel);
            this.Controls.Add(this.dgImport);
            this.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Import_Subject_Offer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Import_Subject_Offer";
            this.Load += new System.EventHandler(this.Import_Subject_Offer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgImport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgImport;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectOffer;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Until;
        private System.Windows.Forms.DataGridViewTextBoxColumn day;
        private System.Windows.Forms.DataGridViewTextBoxColumn leclab;
        private System.Windows.Forms.DataGridViewTextBoxColumn room;
        private System.Windows.Forms.Button btnPasteFromExcel;
        private System.Windows.Forms.Button btnImportToDatabase;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}