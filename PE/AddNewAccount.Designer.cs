namespace PE
{
    partial class AddNewAccount
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
            txtAccountId = new TextBox();
            txtBranch = new TextBox();
            cbbTypeId = new ComboBox();
            btnCreate = new Button();
            txtReset = new Button();
            cbcName = new ComboBox();
            dtpDate = new DateTimePicker();
            label1 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 67);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 6;
            label2.Text = "AccountId";
            // 
            // txtAccountName
            // 
            txtAccountName.AutoSize = true;
            txtAccountName.Location = new Point(70, 115);
            txtAccountName.Name = "txtAccountName";
            txtAccountName.Size = new Size(103, 20);
            txtAccountName.TabIndex = 7;
            txtAccountName.Text = "AccountName";
            // 
            // txtBranchName
            // 
            txtBranchName.AutoSize = true;
            txtBranchName.Location = new Point(70, 201);
            txtBranchName.Name = "txtBranchName";
            txtBranchName.Size = new Size(94, 20);
            txtBranchName.TabIndex = 8;
            txtBranchName.Text = "BranchName";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(70, 252);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 9;
            label5.Text = "TypeId";
            // 
            // txtAccountId
            // 
            txtAccountId.Location = new Point(192, 60);
            txtAccountId.Name = "txtAccountId";
            txtAccountId.Size = new Size(250, 27);
            txtAccountId.TabIndex = 11;
            // 
            // txtBranch
            // 
            txtBranch.Location = new Point(192, 201);
            txtBranch.Name = "txtBranch";
            txtBranch.Size = new Size(250, 27);
            txtBranch.TabIndex = 13;
            // 
            // cbbTypeId
            // 
            cbbTypeId.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbTypeId.FormattingEnabled = true;
            cbbTypeId.Items.AddRange(new object[] { "AT0001", "AT0002", "AT0003", "AT0004" });
            cbbTypeId.Location = new Point(192, 244);
            cbbTypeId.Name = "cbbTypeId";
            cbbTypeId.Size = new Size(250, 28);
            cbbTypeId.TabIndex = 14;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(192, 290);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 15;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // txtReset
            // 
            txtReset.Location = new Point(292, 290);
            txtReset.Name = "txtReset";
            txtReset.Size = new Size(94, 29);
            txtReset.TabIndex = 16;
            txtReset.Text = "Reset";
            txtReset.UseVisualStyleBackColor = true;
            // 
            // cbcName
            // 
            cbcName.DropDownStyle = ComboBoxStyle.DropDownList;
            cbcName.FormattingEnabled = true;
            cbcName.Items.AddRange(new object[] { "Saving Account Description", "Checking Account Description", "Trading Account Description", "Money Market Account Description" });
            cbcName.Location = new Point(192, 107);
            cbcName.Name = "cbcName";
            cbcName.Size = new Size(250, 28);
            cbcName.TabIndex = 17;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(192, 154);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(250, 27);
            dtpDate.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 159);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 19;
            label1.Text = "Date";
            // 
            // AddNewAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 450);
            Controls.Add(label1);
            Controls.Add(dtpDate);
            Controls.Add(cbcName);
            Controls.Add(txtReset);
            Controls.Add(btnCreate);
            Controls.Add(cbbTypeId);
            Controls.Add(txtBranch);
            Controls.Add(txtAccountId);
            Controls.Add(label5);
            Controls.Add(txtBranchName);
            Controls.Add(txtAccountName);
            Controls.Add(label2);
            Name = "AddNewAccount";
            Text = "AddNewAccount";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label txtAccountName;
        private Label txtBranchName;
        private Label label5;
        private TextBox txtAccountId;
        private TextBox txtBranch;
        private ComboBox cbbTypeId;
        private Button btnCreate;
        private Button txtReset;
        private ComboBox cbcName;
        private DateTimePicker dtpDate;
        private Label label1;
    }
}