namespace CodeFirstPostsCRUD
{
    partial class frm_posts
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
            this.btn_Add = new System.Windows.Forms.Button();
            this.txt_postBody = new System.Windows.Forms.TextBox();
            this.txt_postTitle = new System.Windows.Forms.TextBox();
            this.pdate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Update = new System.Windows.Forms.Button();
            this.dgv_Posts = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbBlogs = new System.Windows.Forms.ComboBox();
            this.cbAuthors = new System.Windows.Forms.ComboBox();
            this.dlgChoosePostImage = new System.Windows.Forms.OpenFileDialog();
            this.lblChooseImage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Posts)).BeginInit();
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
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.cbAuthors);
            this.splitContainer1.Panel1.Controls.Add(this.cbBlogs);
            this.splitContainer1.Panel1.Controls.Add(this.txt_postBody);
            this.splitContainer1.Panel1.Controls.Add(this.txt_postTitle);
            this.splitContainer1.Panel1.Controls.Add(this.lblChooseImage);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.pdate);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Add);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Update);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgv_Posts);
            this.splitContainer1.Size = new System.Drawing.Size(1449, 548);
            this.splitContainer1.SplitterDistance = 337;
            this.splitContainer1.TabIndex = 0;
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Add.Location = new System.Drawing.Point(194, 385);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(92, 36);
            this.btn_Add.TabIndex = 4;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // txt_postBody
            // 
            this.txt_postBody.Location = new System.Drawing.Point(86, 86);
            this.txt_postBody.Name = "txt_postBody";
            this.txt_postBody.Size = new System.Drawing.Size(200, 22);
            this.txt_postBody.TabIndex = 3;
            // 
            // txt_postTitle
            // 
            this.txt_postTitle.Location = new System.Drawing.Point(86, 38);
            this.txt_postTitle.Name = "txt_postTitle";
            this.txt_postTitle.Size = new System.Drawing.Size(200, 22);
            this.txt_postTitle.TabIndex = 3;
            // 
            // pdate
            // 
            this.pdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pdate.Location = new System.Drawing.Point(86, 134);
            this.pdate.Name = "pdate";
            this.pdate.Size = new System.Drawing.Size(200, 22);
            this.pdate.TabIndex = 2;
            this.pdate.Value = new System.DateTime(2022, 3, 11, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "DateTime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Body";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Update.Location = new System.Drawing.Point(194, 385);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(92, 36);
            this.btn_Update.TabIndex = 4;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Visible = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // dgv_Posts
            // 
            this.dgv_Posts.AllowUserToAddRows = false;
            this.dgv_Posts.AllowUserToDeleteRows = false;
            this.dgv_Posts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Posts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Posts.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_Posts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Posts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Posts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Posts.Location = new System.Drawing.Point(0, 0);
            this.dgv_Posts.Name = "dgv_Posts";
            this.dgv_Posts.ReadOnly = true;
            this.dgv_Posts.RowHeadersWidth = 51;
            this.dgv_Posts.RowTemplate.Height = 24;
            this.dgv_Posts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Posts.Size = new System.Drawing.Size(1108, 548);
            this.dgv_Posts.TabIndex = 0;
            this.dgv_Posts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Posts_CellContentClick);
            this.dgv_Posts.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Posts_RowHeaderMouseDoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Blog";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Autor";
            // 
            // cbBlogs
            // 
            this.cbBlogs.FormattingEnabled = true;
            this.cbBlogs.Location = new System.Drawing.Point(86, 179);
            this.cbBlogs.Name = "cbBlogs";
            this.cbBlogs.Size = new System.Drawing.Size(200, 24);
            this.cbBlogs.TabIndex = 5;
            // 
            // cbAuthors
            // 
            this.cbAuthors.FormattingEnabled = true;
            this.cbAuthors.Location = new System.Drawing.Point(86, 227);
            this.cbAuthors.Name = "cbAuthors";
            this.cbAuthors.Size = new System.Drawing.Size(200, 24);
            this.cbAuthors.TabIndex = 5;
            // 
            // dlgChoosePostImage
            // 
            this.dlgChoosePostImage.Filter = "\"Post Image|*.png|All files|*.*\"";
            // 
            // lblChooseImage
            // 
            this.lblChooseImage.AutoSize = true;
            this.lblChooseImage.Location = new System.Drawing.Point(13, 282);
            this.lblChooseImage.Name = "lblChooseImage";
            this.lblChooseImage.Size = new System.Drawing.Size(134, 16);
            this.lblChooseImage.TabIndex = 1;
            this.lblChooseImage.Text = "Choose Post Image...\r\n";
            // 
            // frm_posts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1449, 548);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frm_posts";
            this.Text = "Posts CRUD";
            this.Load += new System.EventHandler(this.frm_posts_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Posts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox txt_postBody;
        private System.Windows.Forms.TextBox txt_postTitle;
        private System.Windows.Forms.DateTimePicker pdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Posts;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.ComboBox cbAuthors;
        private System.Windows.Forms.ComboBox cbBlogs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog dlgChoosePostImage;
        private System.Windows.Forms.Label lblChooseImage;
    }
}

