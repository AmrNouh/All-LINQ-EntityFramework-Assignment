namespace EntityFrameworkStudentCURD
{
    partial class frm_Student
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.cb_Departments = new System.Windows.Forms.ComboBox();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.txt_FirstName = new System.Windows.Forms.TextBox();
            this.ud_Age = new System.Windows.Forms.NumericUpDown();
            this.ud_Id = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.dgv_Students = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ud_Age)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ud_Id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Students)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txt_Address);
            this.splitContainer1.Panel1.Controls.Add(this.cb_Departments);
            this.splitContainer1.Panel1.Controls.Add(this.txt_LastName);
            this.splitContainer1.Panel1.Controls.Add(this.txt_FirstName);
            this.splitContainer1.Panel1.Controls.Add(this.ud_Age);
            this.splitContainer1.Panel1.Controls.Add(this.ud_Id);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Add);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Update);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgv_Students);
            this.splitContainer1.Size = new System.Drawing.Size(1201, 551);
            this.splitContainer1.SplitterDistance = 432;
            this.splitContainer1.TabIndex = 0;
            // 
            // txt_Address
            // 
            this.txt_Address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Address.Location = new System.Drawing.Point(130, 284);
            this.txt_Address.Multiline = true;
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(225, 93);
            this.txt_Address.TabIndex = 5;
            // 
            // cb_Departments
            // 
            this.cb_Departments.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cb_Departments.FormattingEnabled = true;
            this.cb_Departments.Location = new System.Drawing.Point(130, 239);
            this.cb_Departments.Name = "cb_Departments";
            this.cb_Departments.Size = new System.Drawing.Size(225, 24);
            this.cb_Departments.TabIndex = 4;
            // 
            // txt_LastName
            // 
            this.txt_LastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_LastName.Location = new System.Drawing.Point(130, 153);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(225, 22);
            this.txt_LastName.TabIndex = 2;
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_FirstName.Location = new System.Drawing.Point(130, 110);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(225, 22);
            this.txt_FirstName.TabIndex = 1;
            // 
            // ud_Age
            // 
            this.ud_Age.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ud_Age.Location = new System.Drawing.Point(130, 196);
            this.ud_Age.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.ud_Age.Name = "ud_Age";
            this.ud_Age.Size = new System.Drawing.Size(120, 22);
            this.ud_Age.TabIndex = 3;
            this.ud_Age.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ud_Age.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // ud_Id
            // 
            this.ud_Id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ud_Id.Location = new System.Drawing.Point(130, 67);
            this.ud_Id.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.ud_Id.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ud_Id.Name = "ud_Id";
            this.ud_Id.Size = new System.Drawing.Size(120, 22);
            this.ud_Id.TabIndex = 0;
            this.ud_Id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ud_Id.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Department";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "LastName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "FirstName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID";
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Add.Location = new System.Drawing.Point(248, 419);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(107, 38);
            this.btn_Add.TabIndex = 17;
            this.btn_Add.Text = "Add";
            this.btn_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Update.Location = new System.Drawing.Point(248, 419);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(107, 38);
            this.btn_Update.TabIndex = 6;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Visible = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // dgv_Students
            // 
            this.dgv_Students.AllowUserToAddRows = false;
            this.dgv_Students.AllowUserToDeleteRows = false;
            this.dgv_Students.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Students.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Students.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgv_Students.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Students.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Students.Location = new System.Drawing.Point(0, 0);
            this.dgv_Students.Name = "dgv_Students";
            this.dgv_Students.ReadOnly = true;
            this.dgv_Students.RowHeadersWidth = 51;
            this.dgv_Students.RowTemplate.Height = 24;
            this.dgv_Students.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Students.Size = new System.Drawing.Size(765, 551);
            this.dgv_Students.TabIndex = 0;
            this.dgv_Students.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Students_CellContentClick);
            this.dgv_Students.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Students_RowHeaderMouseDoubleClick);
            // 
            // frm_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 551);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frm_Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student CRUD";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ud_Age)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ud_Id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Students)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgv_Students;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.ComboBox cb_Departments;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.TextBox txt_FirstName;
        private System.Windows.Forms.NumericUpDown ud_Age;
        private System.Windows.Forms.NumericUpDown ud_Id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Update;
    }
}

