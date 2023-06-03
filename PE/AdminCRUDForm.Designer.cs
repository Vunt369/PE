namespace PE
{
    partial class AdminCRUDForm
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
            dgv_UserAccount = new DataGridView();
            groupBox1 = new GroupBox();
            btnClose = new Button();
            btnDelete = new Button();
            btnCreate = new Button();
            label1 = new Label();
            txtSearchValue = new TextBox();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_UserAccount).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgv_UserAccount
            // 
            dgv_UserAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_UserAccount.Location = new Point(12, 58);
            dgv_UserAccount.Name = "dgv_UserAccount";
            dgv_UserAccount.RowHeadersWidth = 51;
            dgv_UserAccount.RowTemplate.Height = 29;
            dgv_UserAccount.Size = new Size(1008, 307);
            dgv_UserAccount.TabIndex = 0;
            dgv_UserAccount.CellContentClick += dgv_UserAccount_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnClose);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnCreate);
            groupBox1.Location = new Point(134, 417);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(760, 60);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(591, 25);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 5;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(328, 25);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(89, 25);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 2;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(200, 380);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 2;
            label1.Text = "Search: ";
            // 
            // txtSearchValue
            // 
            txtSearchValue.Location = new Point(290, 373);
            txtSearchValue.Name = "txtSearchValue";
            txtSearchValue.Size = new Size(404, 27);
            txtSearchValue.TabIndex = 3;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(725, 371);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // AdminCRUDForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 489);
            Controls.Add(btnSearch);
            Controls.Add(txtSearchValue);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(dgv_UserAccount);
            Name = "AdminCRUDForm";
            Text = "User Account Management";
            ((System.ComponentModel.ISupportInitialize)dgv_UserAccount).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private Button btnClose;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnCreate;
        private Label label1;
        private TextBox txtSearchValue;
        private Button btnSearch;
        public DataGridView dgv_UserAccount;
    }
}