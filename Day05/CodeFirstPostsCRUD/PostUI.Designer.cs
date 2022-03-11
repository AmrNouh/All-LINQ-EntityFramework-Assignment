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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.postControl1 = new CodeFirstPostsCRUD.CustomControl.PostControl();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Add);
            this.panel1.Controls.Add(this.txt_postBody);
            this.panel1.Controls.Add(this.txt_postTitle);
            this.panel1.Controls.Add(this.pPostTime);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pdate);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_Update);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 657);
            this.panel1.TabIndex = 0;
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Add.Location = new System.Drawing.Point(201, 262);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(92, 36);
            this.btn_Add.TabIndex = 13;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            // 
            // txt_postBody
            // 
            this.txt_postBody.Location = new System.Drawing.Point(93, 98);
            this.txt_postBody.Name = "txt_postBody";
            this.txt_postBody.Size = new System.Drawing.Size(200, 22);
            this.txt_postBody.TabIndex = 11;
            // 
            // txt_postTitle
            // 
            this.txt_postTitle.Location = new System.Drawing.Point(93, 46);
            this.txt_postTitle.Name = "txt_postTitle";
            this.txt_postTitle.Size = new System.Drawing.Size(200, 22);
            this.txt_postTitle.TabIndex = 12;
            // 
            // pPostTime
            // 
            this.pPostTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.pPostTime.Location = new System.Drawing.Point(93, 202);
            this.pPostTime.Name = "pPostTime";
            this.pPostTime.Size = new System.Drawing.Size(200, 22);
            this.pPostTime.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Time";
            // 
            // pdate
            // 
            this.pdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pdate.Location = new System.Drawing.Point(93, 150);
            this.pdate.Name = "pdate";
            this.pdate.Size = new System.Drawing.Size(200, 22);
            this.pdate.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Body";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Title";
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Update.Location = new System.Drawing.Point(201, 262);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(92, 36);
            this.btn_Update.TabIndex = 14;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Visible = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.postControl1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(315, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1019, 657);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // postControl1
            // 
            this.postControl1.Body = "This is Long long long article about java programming language";
            this.postControl1.Date = "3/11/2022";
            this.postControl1.Image = "F:\\ITI PD 9Month\\DataSource Manipulation\\All Assignments\\Day05\\CodeFirstPostsCRUD" +
    "\\Resources\\Default.png";
            this.postControl1.Location = new System.Drawing.Point(3, 3);
            this.postControl1.Name = "postControl1";
            this.postControl1.Padding = new System.Windows.Forms.Padding(10);
            this.postControl1.Size = new System.Drawing.Size(1004, 221);
            this.postControl1.TabIndex = 0;
            this.postControl1.Time = "12:00 AM";
            this.postControl1.Title = "Welcome To Jave";
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
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
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
        private CustomControl.PostControl postControl1;
    }
}