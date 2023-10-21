namespace VaccinationManagement
{
    partial class ShowStatus
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
            this.btnEnterID = new System.Windows.Forms.Button();
            this.txtEnterID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvShowStatus = new System.Windows.Forms.DataGridView();
            this.CandidateId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CandidateName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VaccineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnterID
            // 
            this.btnEnterID.Location = new System.Drawing.Point(355, 81);
            this.btnEnterID.Name = "btnEnterID";
            this.btnEnterID.Size = new System.Drawing.Size(75, 23);
            this.btnEnterID.TabIndex = 1;
            this.btnEnterID.Text = "Enter";
            this.btnEnterID.UseVisualStyleBackColor = true;
            this.btnEnterID.Click += new System.EventHandler(this.btnEnterID_Click);
            // 
            // txtEnterID
            // 
            this.txtEnterID.Location = new System.Drawing.Point(153, 81);
            this.txtEnterID.Name = "txtEnterID";
            this.txtEnterID.Size = new System.Drawing.Size(178, 20);
            this.txtEnterID.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(455, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "[Enter ID]";
            // 
            // dgvShowStatus
            // 
            this.dgvShowStatus.AllowUserToAddRows = false;
            this.dgvShowStatus.AllowUserToDeleteRows = false;
            this.dgvShowStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowStatus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CandidateId,
            this.CandidateName,
            this.DOB,
            this.VaccineName});
            this.dgvShowStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvShowStatus.Location = new System.Drawing.Point(0, 199);
            this.dgvShowStatus.Name = "dgvShowStatus";
            this.dgvShowStatus.ReadOnly = true;
            this.dgvShowStatus.Size = new System.Drawing.Size(630, 251);
            this.dgvShowStatus.TabIndex = 4;
            // 
            // CandidateId
            // 
            this.CandidateId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CandidateId.DataPropertyName = "CandidateId";
            this.CandidateId.HeaderText = "Candidate ID";
            this.CandidateId.Name = "CandidateId";
            this.CandidateId.ReadOnly = true;
            // 
            // CandidateName
            // 
            this.CandidateName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CandidateName.DataPropertyName = "CandidateName";
            this.CandidateName.HeaderText = "Name";
            this.CandidateName.Name = "CandidateName";
            this.CandidateName.ReadOnly = true;
            // 
            // DOB
            // 
            this.DOB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DOB.DataPropertyName = "DOB";
            this.DOB.HeaderText = "DOB";
            this.DOB.Name = "DOB";
            this.DOB.ReadOnly = true;
            // 
            // VaccineName
            // 
            this.VaccineName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VaccineName.DataPropertyName = "VaccineName";
            this.VaccineName.HeaderText = "Vaccine Name";
            this.VaccineName.Name = "VaccineName";
            this.VaccineName.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(355, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ShowStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvShowStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEnterID);
            this.Controls.Add(this.btnEnterID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ShowStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowStatus";
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnterID;
        private System.Windows.Forms.TextBox txtEnterID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvShowStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn CandidateId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CandidateName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn VaccineName;
        private System.Windows.Forms.Button button1;
    }
}