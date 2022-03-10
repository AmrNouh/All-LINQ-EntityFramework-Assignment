namespace DisconnectedCourseCRUD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.cb_Topics = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.num_Duration = new System.Windows.Forms.NumericUpDown();
            this.num_Id = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgvCourses = new System.Windows.Forms.DataGridView();
            this.col_del = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Duration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(4, 638);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(4, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnSaveChanges);
            this.splitContainer1.Panel1.Controls.Add(this.cb_Topics);
            this.splitContainer1.Panel1.Controls.Add(this.txtName);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_Id);
            this.splitContainer1.Panel1.Controls.Add(this.num_Duration);
            this.splitContainer1.Panel1.Controls.Add(this.num_Id);
            this.splitContainer1.Panel1.Controls.Add(this.btnAdd);
            this.splitContainer1.Panel1.Controls.Add(this.btnUpdate);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvCourses);
            this.splitContainer1.Size = new System.Drawing.Size(1097, 638);
            this.splitContainer1.SplitterDistance = 365;
            this.splitContainer1.TabIndex = 1;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(17, 576);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(322, 40);
            this.btnSaveChanges.TabIndex = 5;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // cb_Topics
            // 
            this.cb_Topics.DisplayMember = "Top_Name";
            this.cb_Topics.FormattingEnabled = true;
            this.cb_Topics.Location = new System.Drawing.Point(123, 191);
            this.cb_Topics.Name = "cb_Topics";
            this.cb_Topics.Size = new System.Drawing.Size(195, 28);
            this.cb_Topics.TabIndex = 3;
            this.cb_Topics.ValueMember = "Top_Id";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(123, 92);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(195, 27);
            this.txtName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Topic";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Duration";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Course Name";
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Location = new System.Drawing.Point(17, 46);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(73, 20);
            this.lbl_Id.TabIndex = 1;
            this.lbl_Id.Text = "Course ID";
            // 
            // num_Duration
            // 
            this.num_Duration.Location = new System.Drawing.Point(123, 139);
            this.num_Duration.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_Duration.Name = "num_Duration";
            this.num_Duration.Size = new System.Drawing.Size(150, 27);
            this.num_Duration.TabIndex = 2;
            this.num_Duration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_Duration.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // num_Id
            // 
            this.num_Id.Location = new System.Drawing.Point(123, 43);
            this.num_Id.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.num_Id.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_Id.Name = "num_Id";
            this.num_Id.Size = new System.Drawing.Size(150, 27);
            this.num_Id.TabIndex = 0;
            this.num_Id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_Id.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(219, 270);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 42);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(219, 270);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(99, 42);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dgvCourses
            // 
            this.dgvCourses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCourses.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCourses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_del});
            this.dgvCourses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCourses.Location = new System.Drawing.Point(0, 0);
            this.dgvCourses.Name = "dgvCourses";
            this.dgvCourses.RowHeadersWidth = 51;
            this.dgvCourses.RowTemplate.Height = 29;
            this.dgvCourses.Size = new System.Drawing.Size(728, 638);
            this.dgvCourses.TabIndex = 0;
            this.dgvCourses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvCourses.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCourses_RowHeaderMouseDoubleClick);
            // 
            // col_del
            // 
            this.col_del.FillWeight = 60F;
            this.col_del.Frozen = true;
            this.col_del.HeaderText = "";
            this.col_del.Image = ((System.Drawing.Image)(resources.GetObject("col_del.Image")));
            this.col_del.MinimumWidth = 60;
            this.col_del.Name = "col_del";
            this.col_del.Width = 60;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 638);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.splitter1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DisconnectedCRUD";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.num_Duration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Splitter splitter1;
        private SplitContainer splitContainer1;
        private TextBox txtName;
        private Label label1;
        private Label lbl_Id;
        private NumericUpDown num_Id;
        private DataGridView dgvCourses;
        private Label label2;
        private NumericUpDown num_Duration;
        private Button btnAdd;
        private ComboBox cb_Topics;
        private Label label3;
        private Button btnUpdate;
        private DataGridViewImageColumn col_del;
        private Button btnSaveChanges;
    }
}