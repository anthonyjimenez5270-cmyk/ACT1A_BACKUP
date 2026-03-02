namespace ACT_1A_DATABASE
{
    partial class StudentList
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
            label5 = new Label();
            btnSave = new Button();
            txtAge = new TextBox();
            txtLast = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblUser = new Label();
            btnDelete = new Button();
            btnrRefresh = new Button();
            btnSearch = new Button();
            cbCourse = new ComboBox();
            cbSection = new ComboBox();
            txtSearch = new TextBox();
            dataGridView1 = new DataGridView();
            label6 = new Label();
            label7 = new Label();
            txtFirst = new TextBox();
            txtId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(594, 53);
            label5.Name = "label5";
            label5.Size = new Size(275, 21);
            label5.TabIndex = 26;
            label5.Text = "REGISTER STUDENT INFORMATION";
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.ActiveBorder;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSave.Location = new Point(647, 285);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(214, 55);
            btnSave.TabIndex = 25;
            btnSave.Text = "SAVE RECORD";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(647, 243);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(214, 23);
            txtAge.TabIndex = 24;
            // 
            // txtLast
            // 
            txtLast.Location = new Point(647, 156);
            txtLast.Name = "txtLast";
            txtLast.Size = new Size(214, 23);
            txtLast.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(592, 241);
            label4.Name = "label4";
            label4.Size = new Size(44, 21);
            label4.TabIndex = 19;
            label4.Text = "Age:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(565, 212);
            label3.Name = "label3";
            label3.Size = new Size(71, 21);
            label3.TabIndex = 18;
            label3.Text = "Section:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(570, 183);
            label2.Name = "label2";
            label2.Size = new Size(66, 21);
            label2.TabIndex = 17;
            label2.Text = "Course:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(542, 158);
            label1.Name = "label1";
            label1.Size = new Size(94, 21);
            label1.TabIndex = 16;
            label1.Text = "Last Name:";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblUser.Location = new Point(540, 125);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(96, 21);
            lblUser.TabIndex = 15;
            lblUser.Text = "First Name:";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ActiveBorder;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDelete.Location = new Point(647, 355);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(214, 55);
            btnDelete.TabIndex = 27;
            btnDelete.Text = "DELETE RECORD";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnrRefresh
            // 
            btnrRefresh.BackColor = SystemColors.AppWorkspace;
            btnrRefresh.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnrRefresh.Location = new Point(372, 34);
            btnrRefresh.Name = "btnrRefresh";
            btnrRefresh.Size = new Size(127, 40);
            btnrRefresh.TabIndex = 28;
            btnrRefresh.Text = "REFRESH";
            btnrRefresh.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.ActiveBorder;
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSearch.Location = new Point(264, 87);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(112, 32);
            btnSearch.TabIndex = 29;
            btnSearch.Text = "SEARCH";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // cbCourse
            // 
            cbCourse.FormattingEnabled = true;
            cbCourse.Items.AddRange(new object[] { "ACT", "BSOA", "HM" });
            cbCourse.Location = new Point(647, 185);
            cbCourse.Name = "cbCourse";
            cbCourse.Size = new Size(214, 23);
            cbCourse.TabIndex = 30;
            // 
            // cbSection
            // 
            cbSection.FormattingEnabled = true;
            cbSection.Location = new Point(647, 214);
            cbSection.Name = "cbSection";
            cbSection.Size = new Size(214, 23);
            cbSection.TabIndex = 31;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(55, 93);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(203, 23);
            txtSearch.TabIndex = 32;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(55, 134);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(444, 348);
            dataGridView1.TabIndex = 33;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.Location = new Point(55, 34);
            label6.Name = "label6";
            label6.Size = new Size(185, 21);
            label6.TabIndex = 34;
            label6.Text = "STUDENT MASTER LIST";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.Location = new Point(605, 96);
            label7.Name = "label7";
            label7.Size = new Size(31, 21);
            label7.TabIndex = 35;
            label7.Text = "ID:";
            // 
            // txtFirst
            // 
            txtFirst.Location = new Point(647, 127);
            txtFirst.Name = "txtFirst";
            txtFirst.Size = new Size(214, 23);
            txtFirst.TabIndex = 20;
            // 
            // txtId
            // 
            txtId.Location = new Point(647, 98);
            txtId.Name = "txtId";
            txtId.Size = new Size(214, 23);
            txtId.TabIndex = 36;
            // 
            // StudentList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 536);
            Controls.Add(txtId);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(dataGridView1);
            Controls.Add(txtSearch);
            Controls.Add(cbSection);
            Controls.Add(cbCourse);
            Controls.Add(btnSearch);
            Controls.Add(btnrRefresh);
            Controls.Add(btnDelete);
            Controls.Add(label5);
            Controls.Add(btnSave);
            Controls.Add(txtAge);
            Controls.Add(txtLast);
            Controls.Add(txtFirst);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblUser);
            Name = "StudentList";
            Text = "StudentList";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Button btnSave;
        private TextBox txtAge;
        private TextBox txtLast;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblUser;
        private Button btnDelete;
        private Button btnrRefresh;
        private Button btnSearch;
        private ComboBox cbCourse;
        private ComboBox cbSection;
        private TextBox txtSearch;
        private DataGridView dataGridView1;
        private Label label6;
        private Label label7;
        private TextBox txtFirst;
        private TextBox txtId;
    }
}