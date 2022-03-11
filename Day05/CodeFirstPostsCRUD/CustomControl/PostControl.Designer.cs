namespace CodeFirstPostsCRUD.CustomControl
{
    partial class PostControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlImage = new System.Windows.Forms.Panel();
            this.PicPostImage = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPostBody = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.pnlImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicPostImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlImage
            // 
            this.pnlImage.Controls.Add(this.PicPostImage);
            this.pnlImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlImage.Location = new System.Drawing.Point(10, 10);
            this.pnlImage.Name = "pnlImage";
            this.pnlImage.Size = new System.Drawing.Size(250, 260);
            this.pnlImage.TabIndex = 0;
            // 
            // PicPostImage
            // 
            this.PicPostImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PicPostImage.InitialImage = global::CodeFirstPostsCRUD.Properties.Resources.Default;
            this.PicPostImage.Location = new System.Drawing.Point(0, 0);
            this.PicPostImage.Name = "PicPostImage";
            this.PicPostImage.Size = new System.Drawing.Size(250, 260);
            this.PicPostImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicPostImage.TabIndex = 0;
            this.PicPostImage.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblTitle.Location = new System.Drawing.Point(266, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(578, 33);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPostBody
            // 
            this.lblPostBody.AutoEllipsis = true;
            this.lblPostBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostBody.Location = new System.Drawing.Point(271, 83);
            this.lblPostBody.Name = "lblPostBody";
            this.lblPostBody.Size = new System.Drawing.Size(578, 162);
            this.lblPostBody.TabIndex = 2;
            this.lblPostBody.Text = "Post Body";
            // 
            // lblTime
            // 
            this.lblTime.Location = new System.Drawing.Point(360, 60);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(97, 16);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "Time";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDate
            // 
            this.lblDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDate.Location = new System.Drawing.Point(266, 60);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(88, 16);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Date";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PostControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblPostBody);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlImage);
            this.Name = "PostControl";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(884, 280);
            this.pnlImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicPostImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlImage;
        private System.Windows.Forms.PictureBox PicPostImage;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPostBody;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
    }
}
