namespace StudentProject
{
    partial class StudentForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.stextBoxName = new System.Windows.Forms.TextBox();
            this.stextBoxAddress = new System.Windows.Forms.TextBox();
            this.stextBoxPhone = new System.Windows.Forms.TextBox();
            this.stextBoxSem = new System.Windows.Forms.TextBox();
            this.sComboBoxBranch = new System.Windows.Forms.ComboBox();
            this.sTextBoxSearch = new System.Windows.Forms.TextBox();
            this.sButtonReset = new System.Windows.Forms.Button();
            this.sButtonAdd = new System.Windows.Forms.Button();
            this.sButtonUpdate = new System.Windows.Forms.Button();
            this.sButtonDelete = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Branch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(470, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Systems";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(206, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(206, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Student Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGreen;
            this.label4.Location = new System.Drawing.Point(191, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Search A Student";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGreen;
            this.label6.Location = new System.Drawing.Point(206, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Branch";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkGreen;
            this.label7.Location = new System.Drawing.Point(206, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Semester / Year";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkGreen;
            this.label8.Location = new System.Drawing.Point(206, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Phone ";
            // 
            // stextBoxName
            // 
            this.stextBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stextBoxName.Location = new System.Drawing.Point(406, 81);
            this.stextBoxName.Name = "stextBoxName";
            this.stextBoxName.Size = new System.Drawing.Size(354, 27);
            this.stextBoxName.TabIndex = 8;
            // 
            // stextBoxAddress
            // 
            this.stextBoxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stextBoxAddress.Location = new System.Drawing.Point(406, 127);
            this.stextBoxAddress.Name = "stextBoxAddress";
            this.stextBoxAddress.Size = new System.Drawing.Size(354, 27);
            this.stextBoxAddress.TabIndex = 9;
            // 
            // stextBoxPhone
            // 
            this.stextBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stextBoxPhone.Location = new System.Drawing.Point(406, 181);
            this.stextBoxPhone.Name = "stextBoxPhone";
            this.stextBoxPhone.Size = new System.Drawing.Size(354, 27);
            this.stextBoxPhone.TabIndex = 10;
            // 
            // stextBoxSem
            // 
            this.stextBoxSem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stextBoxSem.Location = new System.Drawing.Point(406, 230);
            this.stextBoxSem.Name = "stextBoxSem";
            this.stextBoxSem.Size = new System.Drawing.Size(354, 27);
            this.stextBoxSem.TabIndex = 11;
            // 
            // sComboBoxBranch
            // 
            this.sComboBoxBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sComboBoxBranch.FormattingEnabled = true;
            this.sComboBoxBranch.Items.AddRange(new object[] {
            "",
            "Computer Science",
            "Electronics",
            "Mechanical",
            "Civil",
            "Electrical"});
            this.sComboBoxBranch.Location = new System.Drawing.Point(406, 278);
            this.sComboBoxBranch.Name = "sComboBoxBranch";
            this.sComboBoxBranch.Size = new System.Drawing.Size(206, 28);
            this.sComboBoxBranch.TabIndex = 12;
            // 
            // sTextBoxSearch
            // 
            this.sTextBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sTextBoxSearch.Location = new System.Drawing.Point(380, 359);
            this.sTextBoxSearch.Name = "sTextBoxSearch";
            this.sTextBoxSearch.Size = new System.Drawing.Size(354, 27);
            this.sTextBoxSearch.TabIndex = 13;
            this.sTextBoxSearch.TextChanged += new System.EventHandler(this.sTextBoxSearch_TextChanged);
            // 
            // sButtonReset
            // 
            this.sButtonReset.Location = new System.Drawing.Point(920, 256);
            this.sButtonReset.Name = "sButtonReset";
            this.sButtonReset.Size = new System.Drawing.Size(182, 75);
            this.sButtonReset.TabIndex = 14;
            this.sButtonReset.Text = "New/Reset";
            this.sButtonReset.UseVisualStyleBackColor = true;
            this.sButtonReset.Click += new System.EventHandler(this.sButtonReset_Click);
            // 
            // sButtonAdd
            // 
            this.sButtonAdd.Location = new System.Drawing.Point(820, 61);
            this.sButtonAdd.Name = "sButtonAdd";
            this.sButtonAdd.Size = new System.Drawing.Size(182, 75);
            this.sButtonAdd.TabIndex = 15;
            this.sButtonAdd.Text = "Add Student";
            this.sButtonAdd.UseVisualStyleBackColor = true;
            this.sButtonAdd.Click += new System.EventHandler(this.sButtonAdd_Click);
            // 
            // sButtonUpdate
            // 
            this.sButtonUpdate.Location = new System.Drawing.Point(1073, 61);
            this.sButtonUpdate.Name = "sButtonUpdate";
            this.sButtonUpdate.Size = new System.Drawing.Size(182, 75);
            this.sButtonUpdate.TabIndex = 16;
            this.sButtonUpdate.Text = "Update Student";
            this.sButtonUpdate.UseVisualStyleBackColor = true;
            this.sButtonUpdate.Click += new System.EventHandler(this.sButtonUpdate_Click);
            // 
            // sButtonDelete
            // 
            this.sButtonDelete.Location = new System.Drawing.Point(920, 161);
            this.sButtonDelete.Name = "sButtonDelete";
            this.sButtonDelete.Size = new System.Drawing.Size(182, 75);
            this.sButtonDelete.TabIndex = 17;
            this.sButtonDelete.Text = "Delete Student";
            this.sButtonDelete.UseVisualStyleBackColor = true;
            this.sButtonDelete.Click += new System.EventHandler(this.sButtonDelete_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Address,
            this.Phone,
            this.Sem,
            this.Branch});
            this.dataGridView2.Location = new System.Drawing.Point(12, 404);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1300, 253);
            this.dataGridView2.TabIndex = 19;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Phone";
            this.Phone.MinimumWidth = 6;
            this.Phone.Name = "Phone";
            // 
            // Sem
            // 
            this.Sem.HeaderText = "Sem";
            this.Sem.MinimumWidth = 6;
            this.Sem.Name = "Sem";
            // 
            // Branch
            // 
            this.Branch.HeaderText = "Branch";
            this.Branch.MinimumWidth = 6;
            this.Branch.Name = "Branch";
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 691);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.sButtonDelete);
            this.Controls.Add(this.sButtonUpdate);
            this.Controls.Add(this.sButtonAdd);
            this.Controls.Add(this.sButtonReset);
            this.Controls.Add(this.sTextBoxSearch);
            this.Controls.Add(this.sComboBoxBranch);
            this.Controls.Add(this.stextBoxSem);
            this.Controls.Add(this.stextBoxPhone);
            this.Controls.Add(this.stextBoxAddress);
            this.Controls.Add(this.stextBoxName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            //this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox stextBoxName;
        private System.Windows.Forms.TextBox stextBoxAddress;
        private System.Windows.Forms.TextBox stextBoxPhone;
        private System.Windows.Forms.TextBox stextBoxSem;
        private System.Windows.Forms.ComboBox sComboBoxBranch;
        private System.Windows.Forms.TextBox sTextBoxSearch;
        private System.Windows.Forms.Button sButtonReset;
        private System.Windows.Forms.Button sButtonAdd;
        private System.Windows.Forms.Button sButtonUpdate;
        private System.Windows.Forms.Button sButtonDelete;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Branch;
    }
}

