using CodeFirstPostsCRUD.Properties;

namespace CodeFirstPostsCRUD
{
    partial class PostUI
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.postControl2 = new CodeFirstPostsCRUD.CustomControl.PostControl();
            this.postControl1 = new CodeFirstPostsCRUD.CustomControl.PostControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_Add = new System.Windows.Forms.Button();
            this.txt_postBody = new System.Windows.Forms.TextBox();
            this.txt_postTitle = new System.Windows.Forms.TextBox();
            this.pPostTime = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.pdate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Update = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 657);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.postControl2);
            this.flowLayoutPanel1.Controls.Add(this.postControl1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(315, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1019, 657);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // postControl2
            // 
            this.postControl2.Body = "This is Long long long article about java programming language";
            this.postControl2.Date = "3/11/2022";
            this.postControl2.Image = "F:\\ITI PD 9Month\\DataSource Manipulation\\All Assignments\\Day05\\CodeFirstPostsCRUD" +
    "\\Resources\\Default.png";
            this.postControl2.Location = new System.Drawing.Point(3, 3);
            this.postControl2.Name = "postControl2";
            this.postControl2.Padding = new System.Windows.Forms.Padding(10);
            this.postControl2.Size = new System.Drawing.Size(1004, 221);
            this.postControl2.TabIndex = 0;
            this.postControl2.Time = "12:00 AM";
            this.postControl2.Title = "Welcome To Jave";
            // 
            // postControl1
            // 
            this.postControl1.Body = "This is Long long long article about java programming language";
            this.postControl1.Date = "3/11/2022";
            this.postControl1.Image = "F:\\ITI PD 9Month\\DataSource Manipulation\\All Assignments\\Day05\\CodeFirstPostsCRUD" +
    "\\Resources\\Default.png";
            this.postControl1.Location = new System.Drawing.Point(3, 230);
            this.postControl1.Name = "postControl1";
            this.postControl1.Padding = new System.Windows.Forms.Padding(10);
            this.postControl1.Size = new System.Drawing.Size(1004, 221);
            this.postControl1.TabIndex = 0;
            this.postControl1.Time = "12:00 AM";
            this.postControl1.Title = "Welcome To Jave";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btn_Add);
            this.splitContainer1.Panel2.Controls.Add(this.txt_postBody);
            this.splitContainer1.Panel2.Controls.Add(this.txt_postTitle);
            this.splitContainer1.Panel2.Controls.Add(this.pPostTime);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.pdate);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.btn_Update);
            this.splitContainer1.Size = new System.Drawing.Size(324, 657);
            this.splitContainer1.SplitterDistance = 110;
            this.splitContainer1.TabIndex = 0;
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Add.Location = new System.Drawing.Point(207, 361);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(92, 36);
            this.btn_Add.TabIndex = 23;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            // 
            // txt_postBody
            // 
            this.txt_postBody.Location = new System.Drawing.Point(99, 197);
            this.txt_postBody.Name = "txt_postBody";
            this.txt_postBody.Size = new System.Drawing.Size(200, 22);
            this.txt_postBody.TabIndex = 21;
            // 
            // txt_postTitle
            // 
            this.txt_postTitle.Location = new System.Drawing.Point(99, 145);
            this.txt_postTitle.Name = "txt_postTitle";
            this.txt_postTitle.Size = new System.Drawing.Size(200, 22);
            this.txt_postTitle.TabIndex = 22;
            // 
            // pPostTime
            // 
            this.pPostTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.pPostTime.Location = new System.Drawing.Point(99, 301);
            this.pPostTime.Name = "pPostTime";
            this.pPostTime.Size = new System.Drawing.Size(200, 22);
            this.pPostTime.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Time";
            // 
            // pdate
            // 
            this.pdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pdate.Location = new System.Drawing.Point(99, 249);
            this.pdate.Name = "pdate";
            this.pdate.Size = new System.Drawing.Size(200, 22);
            this.pdate.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Body";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Title";
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Update.Location = new System.Drawing.Point(207, 361);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(92, 36);
            this.btn_Update.TabIndex = 24;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Welcome";
            // 
            // PostUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 657);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "PostUI";
            this.Text = "PostUI";
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private CustomControl.PostControl postControl1;
        private CustomControl.PostControl postControl2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox txt_postBody;
        private System.Windows.Forms.TextBox txt_postTitle;
        private System.Windows.Forms.DateTimePicker pPostTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker pdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Update;
    }
}