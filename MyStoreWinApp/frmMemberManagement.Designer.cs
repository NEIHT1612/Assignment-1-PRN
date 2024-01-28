namespace MyStoreWinApp
{
    partial class frmMemberManagement
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
            dgvMember = new DataGridView();
            txtMemberID = new TextBox();
            txtCountry = new TextBox();
            txtCity = new TextBox();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            txtMemberName = new TextBox();
            lbMemberID = new Label();
            lbMemberName = new Label();
            lbEmail = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnAdd = new Button();
            btnDelete = new Button();
            txtSearch = new TextBox();
            btnSeach = new Button();
            txtSearchCT = new TextBox();
            btnFilter = new Button();
            btnSort = new Button();
            btnLoad = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMember).BeginInit();
            SuspendLayout();
            // 
            // dgvMember
            // 
            dgvMember.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMember.Location = new Point(12, 12);
            dgvMember.Name = "dgvMember";
            dgvMember.RowHeadersWidth = 51;
            dgvMember.Size = new Size(460, 266);
            dgvMember.TabIndex = 0;
            dgvMember.CellContentClick += dgvMember_CellContentClick;
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new Point(651, 24);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new Size(125, 27);
            txtMemberID.TabIndex = 1;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(651, 189);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(125, 27);
            txtCountry.TabIndex = 2;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(651, 156);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(125, 27);
            txtCity.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(651, 123);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(125, 27);
            txtPassword.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(651, 90);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 5;
            // 
            // txtMemberName
            // 
            txtMemberName.Location = new Point(651, 57);
            txtMemberName.Name = "txtMemberName";
            txtMemberName.Size = new Size(125, 27);
            txtMemberName.TabIndex = 6;
            // 
            // lbMemberID
            // 
            lbMemberID.AutoSize = true;
            lbMemberID.Location = new Point(538, 27);
            lbMemberID.Name = "lbMemberID";
            lbMemberID.Size = new Size(80, 20);
            lbMemberID.TabIndex = 7;
            lbMemberID.Text = "MemberID";
            // 
            // lbMemberName
            // 
            lbMemberName.AutoSize = true;
            lbMemberName.Location = new Point(538, 64);
            lbMemberName.Name = "lbMemberName";
            lbMemberName.Size = new Size(105, 20);
            lbMemberName.TabIndex = 8;
            lbMemberName.Text = "MemberName";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(538, 97);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(46, 20);
            lbEmail.TabIndex = 9;
            lbEmail.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(538, 130);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 10;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(538, 163);
            label5.Name = "label5";
            label5.Size = new Size(34, 20);
            label5.TabIndex = 11;
            label5.Text = "City";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(538, 196);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 12;
            label6.Text = "Country";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(490, 295);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(378, 293);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 295);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(125, 27);
            txtSearch.TabIndex = 15;
            // 
            // btnSeach
            // 
            btnSeach.Location = new Point(143, 295);
            btnSeach.Name = "btnSeach";
            btnSeach.Size = new Size(158, 29);
            btnSeach.TabIndex = 16;
            btnSeach.Text = "SeachByNameAndId";
            btnSeach.UseVisualStyleBackColor = true;
            btnSeach.Click += btnSeach_Click;
            // 
            // txtSearchCT
            // 
            txtSearchCT.Location = new Point(12, 328);
            txtSearchCT.Name = "txtSearchCT";
            txtSearchCT.Size = new Size(125, 27);
            txtSearchCT.TabIndex = 17;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(143, 328);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(158, 29);
            btnFilter.TabIndex = 18;
            btnFilter.Text = "FilterCityAndCountry";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // btnSort
            // 
            btnSort.Location = new Point(347, 328);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(163, 29);
            btnSort.TabIndex = 19;
            btnSort.Text = "SortMemberByName";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(490, 249);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 20;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            // 
            // frmMemberManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLoad);
            Controls.Add(btnSort);
            Controls.Add(btnFilter);
            Controls.Add(txtSearchCT);
            Controls.Add(btnSeach);
            Controls.Add(txtSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lbEmail);
            Controls.Add(lbMemberName);
            Controls.Add(lbMemberID);
            Controls.Add(txtMemberName);
            Controls.Add(txtEmail);
            Controls.Add(txtPassword);
            Controls.Add(txtCity);
            Controls.Add(txtCountry);
            Controls.Add(txtMemberID);
            Controls.Add(dgvMember);
            Name = "frmMemberManagement";
            Text = "frmMemberManagement";
            Load += frmMemberManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMember).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMember;
        private TextBox txtMemberID;
        private TextBox txtCountry;
        private TextBox txtCity;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private TextBox txtMemberName;
        private Label lbMemberID;
        private Label lbMemberName;
        private Label lbEmail;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnAdd;
        private Button btnDelete;
        private TextBox txtSearch;
        private Button btnSeach;
        private TextBox txtSearchCT;
        private Button btnFilter;
        private Button btnSort;
        private Button btnLoad;
    }
}