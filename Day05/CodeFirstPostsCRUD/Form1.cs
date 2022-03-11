using CodeFirstPostsCRUD.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFirstPostsCRUD
{
    public partial class frm_posts : Form
    {
        PostDbContext socialMediaDB;

        public frm_posts()
        {
            InitializeComponent();
            socialMediaDB = new PostDbContext();
        }

        private void frm_posts_Load(object sender, EventArgs e)
        {
            FillDataGridView();
            CreateDataGridViewColumn();
            FillAuthorCombobox();
            FillBlogCombobox();
        }

        void FillDataGridView()
        {
            dgv_Posts.DataSource = socialMediaDB.Posts.Select(p => new { ID = p.id, PostTitle= p.Title, PostBody= p.Body, AuthorName = p.author.Name,BlogTitle = p.blog.Title, ImagePath= p.postImage, PostDateTime= p.PostDateTime }).ToList();
        }
        void CreateDataGridViewColumn()
        {
            DataGridViewImageColumn dataGridViewColumn = new DataGridViewImageColumn();
            dataGridViewColumn.Width = 60;
            dataGridViewColumn.ReadOnly = true;
            dataGridViewColumn.Image = Image.FromFile(@"F:\ITI PD 9Month\DataSource Manipulation\All Assignments\delete.png");
            dgv_Posts.Columns.Add(dataGridViewColumn);
        }

        void FillAuthorCombobox()
        {
            cbAuthors.DisplayMember = "Name";
            cbAuthors.ValueMember = "Id";
            cbAuthors.DataSource = socialMediaDB.Authors.Select(a => new { Id = a.Id, Name = a.Name }).ToList();
        }

        void FillBlogCombobox()
        {
            cbBlogs.DisplayMember = "Title";
            cbBlogs.ValueMember = "Id";
            cbBlogs.DataSource = socialMediaDB.Blogs.Select(b => new { Id = b.Id, Title = b.Title }).ToList();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Post post = new Post();
            post.Title = txt_postTitle.Text;
            post.Body = txt_postBody.Text;
            post.PostDateTime.AddDays(pdate.Value.Day);
            post.PostDateTime.AddMonths(pdate.Value.Month);
            post.PostDateTime.AddYears(pdate.Value.Year);
            post.PostDateTime.AddHours(pPostTime.Value.Hour);
            post.PostDateTime.AddMinutes(pPostTime.Value.Minute);
            post.PostDateTime.AddSeconds(pPostTime.Value.Second);
            post.BlogId = (int)cbBlogs.SelectedValue;
            post.AutorId = (int)cbAuthors.SelectedValue;
            socialMediaDB.Posts.Add(post);
            MessageBox.Show("Student Saved Sucessfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetInputsFields();
            FillDataGridView();
        }

        private void ResetInputsFields()
        {
            txt_postTitle.Text = txt_postBody.Text = String.Empty;
            pdate.Value = DateTime.Now;
            pPostTime.Value.AddHours(DateTime.Now.Hour);
            pPostTime.Value.AddMinutes(DateTime.Now.Minute);
            pPostTime.Value.AddSeconds(DateTime.Now.Second);
            cbAuthors.SelectedIndex = 0;
            cbBlogs.SelectedIndex = 0;
            lblChooseImage.Text = "Choose Post Image";

        }

        private void dgv_Posts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_Posts_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }


    }
}
