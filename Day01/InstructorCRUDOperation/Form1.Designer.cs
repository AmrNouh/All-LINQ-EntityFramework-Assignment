namespace InstructorCRUDOperation
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cb_dept = new System.Windows.Forms.ComboBox();
            this.num_salary = new System.Windows.Forms.NumericUpDown();
            this.num_Id = new System.Windows.Forms.NumericUpDown();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_degree = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.col_Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_salary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.cb_dept);
            this.splitContainer1.Panel1.Controls.Add(this.num_salary);
            this.splitContainer1.Panel1.Controls.Add(this.num_Id);
            this.splitContainer1.Panel1.Controls.Add(this.txt_name);
            this.splitContainer1.Panel1.Controls.Add(this.txt_degree);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Add);
            this.splitContainer1.Panel1.Controls.Add(this.btn_update);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(1033, 610);
            this.splitContainer1.SplitterDistance = 424;
            this.splitContainer1.TabIndex = 0;
            // 
            // cb_dept
            // 
            this.cb_dept.FormattingEnabled = true;
            this.cb_dept.Location = new System.Drawing.Point(107, 213);
            this.cb_dept.Name = "cb_dept";
            this.cb_dept.Size = new System.Drawing.Size(239, 28);
            this.cb_dept.TabIndex = 16;
            // 
            // num_salary
            // 
            this.num_salary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num_salary.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.num_salary.DecimalPlaces = 2;
            this.num_salary.Location = new System.Drawing.Point(107, 166);
            this.num_salary.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.num_salary.Name = "num_salary";
            this.num_salary.Size = new System.Drawing.Size(151, 27);
            this.num_salary.TabIndex = 15;
            this.num_salary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // num_Id
            // 
            this.num_Id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num_Id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.num_Id.Location = new System.Drawing.Point(107, 25);
            this.num_Id.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_Id.Name = "num_Id";
            this.num_Id.Size = new System.Drawing.Size(89, 27);
            this.num_Id.TabIndex = 7;
            this.num_Id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_Id.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txt_name
            // 
            this.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_name.Location = new System.Drawing.Point(107, 72);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(243, 27);
            this.txt_name.TabIndex = 13;
            // 
            // txt_degree
            // 
            this.txt_degree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_degree.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_degree.Location = new System.Drawing.Point(107, 119);
            this.txt_degree.Name = "txt_degree";
            this.txt_degree.Size = new System.Drawing.Size(243, 27);
            this.txt_degree.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Departmet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Salary";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Degree";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(238, 296);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(108, 45);
            this.btn_Add.TabIndex = 18;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(238, 296);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(108, 45);
            this.btn_update.TabIndex = 17;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Visible = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Delete});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(605, 610);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // col_Delete
            // 
            this.col_Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle1.NullValue")));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.col_Delete.DefaultCellStyle = dataGridViewCellStyle1;
            this.col_Delete.Frozen = true;
            this.col_Delete.HeaderText = "";
            this.col_Delete.Image = ((System.Drawing.Image)(resources.GetObject("col_Delete.Image")));
            this.col_Delete.MinimumWidth = 6;
            this.col_Delete.Name = "col_Delete";
            this.col_Delete.ReadOnly = true;
            this.col_Delete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col_Delete.Width = 36;
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 610);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.num_salary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private ComboBox cb_dept;
        private NumericUpDown num_salary;
        private NumericUpDown num_Id;
        private TextBox txt_name;
        private TextBox txt_degree;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btn_update;
        private Button btn_Add;
        private DataGridView dataGridView1;
        private ErrorProvider error;
        private DataGridViewImageColumn col_Delete;
    }
}