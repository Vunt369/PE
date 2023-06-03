namespace PE
{
    partial class UpdateAccount
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
            label2 = new Label();
            txtAccountName = new Label();
            txtBranchName = new Label();
            label5 = new Label();
            btnUpdate = new Button();
            txtReset = new Button();
            cbbTypeId = new ComboBox();
            label1 = new Label();
            cbcName = new ComboBox();
            dtpDate = new DateTimePicker();
            label3 = new Label();
            txtBranch = new TextBox();
            txtAccountId = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 87);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 12;
            label2.Text = "AccountId";
            // 
            // txtAccountName
            // 
            txtAccountName.AutoSize = true;
            txtAccountName.Location = new Point(42, 138);
            txtAccountName.Name = "txtAccountName";
            txtAccountName.Size = new Size(103, 20);
            txtAccountName.TabIndex = 14;
            txtAccountName.Text = "AccountName";
            // 
            // txtBranchName
            // 
            txtBranchName.AutoSize = true;
            txtBranchName.Location = new Point(42, 245);
            txtBranchName.Name = "txtBranchName";
            txtBranchName.Size = new Size(94, 20);
            txtBranchName.TabIndex = 16;
            txtBranchName.Text = "BranchName";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 299);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 17;
            label5.Text = "TypeId";
            // 
            // btnUpdate
            // 
            btnUpdate.Cursor = Cursors.AppStarting;
            btnUpdate.Location = new Point(164, 347);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 18;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtReset
            // 
            txtReset.Location = new Point(320, 347);
            txtReset.Name = "txtReset";
            txtReset.Size = new Size(94, 29);
            txtReset.TabIndex = 19;
            txtReset.Text = "Reset";
            txtReset.UseVisualStyleBackColor = true;
            txtReset.Click += txtReset_Click;
            // 
            // cbbTypeId
            // 
            cbbTypeId.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbTypeId.FormattingEnabled = true;
            cbbTypeId.Items.AddRange(new object[] { "AT0001", "AT0002", "AT0003", "AT0004" });
            cbbTypeId.Location = new Point(164, 291);
            cbbTypeId.Name = "cbbTypeId";
            cbbTypeId.Size = new Size(250, 28);
            cbbTypeId.TabIndex = 20;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.CornflowerBlue;
            label1.Location = new Point(110, 9);
            label1.Name = "label1";
            label1.Size = new Size(289, 55);
            label1.TabIndex = 21;
            label1.Text = "UPDATE ACCOUNT";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbcName
            // 
            cbcName.DropDownStyle = ComboBoxStyle.DropDownList;
            cbcName.FormattingEnabled = true;
            cbcName.Items.AddRange(new object[] { "Saving Account Description", "Checking Account Description", "Trading Account Description", "Money Market Account Description" });
            cbcName.Location = new Point(164, 130);
            cbcName.Name = "cbcName";
            cbcName.Size = new Size(250, 28);
            cbcName.TabIndex = 22;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(164, 184);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(250, 27);
            dtpDate.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 191);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 24;
            label3.Text = "Date";
            // 
            // txtBranch
            // 
            txtBranch.Location = new Point(164, 238);
            txtBranch.Name = "txtBranch";
            txtBranch.Size = new Size(250, 27);
            txtBranch.TabIndex = 25;
            // 
            // txtAccountId
            // 
            txtAccountId.Location = new Point(164, 80);
            txtAccountId.Name = "txtAccountId";
            txtAccountId.Size = new Size(250, 27);
            txtAccountId.TabIndex = 26;
            // 
            // UpdateAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(473, 450);
            Controls.Add(txtAccountId);
            Controls.Add(txtBranch);
            Controls.Add(label3);
            Controls.Add(dtpDate);
            Controls.Add(cbcName);
            Controls.Add(label1);
            Controls.Add(cbbTypeId);
            Controls.Add(txtReset);
            Controls.Add(btnUpdate);
            Controls.Add(label5);
            Controls.Add(txtBranchName);
            Controls.Add(txtAccountName);
            Controls.Add(label2);
            Name = "UpdateAccount";
            Text = "Management";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label txtAccountName;
        private Label txtBranchName;
        private Label label5;
        private Label label1;
        public Button btnUpdate;
        public ComboBox cbbTypeId;
        private Label label3;
        public Button txtReset;
        public ComboBox cbcName;
        public DateTimePicker dtpDate;
        public TextBox txtBranch;
        public TextBox txtAccountId;
    }
}