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
            int id = (int)dgv_Posts.SelectedRows[0].Cells["ID"].Value;
            Post post = socialMediaDB.Posts.SingleOrDefault(p => p.id == id);
            post.Title = txt_postTitle.Text;
            post.Body = txt_postBody.Text;
            post.PostDateTime = pdate.Value;
            post.BlogId = (int)cbBlogs.SelectedValue;
            post.AutorId = (int)cbAuthors.SelectedValue;
            socialMediaDB.SaveChanges();
            ResetInputsFields();
            ChangeControlStatus(true, false);
            MessageBox.Show("Post Updated Sucessfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FillDataGridView();

        }

        private void dgv_Posts_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ChangeControlStatus( false, true);
            txt_postTitle.Text = dgv_Posts.SelectedRows[0].Cells["PostTitle"].Value.ToString();
            txt_postBody.Text = dgv_Posts.SelectedRows[0].Cells["PostBody"].Value.ToString();
            pdate.Value = (DateTime)dgv_Posts.SelectedRows[0].Cells["PostDateTime"].Value;
            string authorName = dgv_Posts.SelectedRows[0].Cells["AuthorName"].Value.ToString();
            cbAuthors.SelectedValue = socialMediaDB.Authors.Where(a => a.Name == authorName).Select(a => a.Id).SingleOrDefault();
            string blogTitle = dgv_Posts.SelectedRows[0].Cells["BlogTitle"].Value.ToString();
            cbBlogs.SelectedValue = socialMediaDB.Blogs.Where(b => b.Title == blogTitle).Select(b => b.Id).SingleOrDefault();
        }

        private void ChangeControlStatus(bool v1, bool v2)
        {
            btn_Add.Visible = v1;
            btn_Update.Visible = v2;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Post post = new Post();
            post.Title = txt_postTitle.Text;
            post.Body = txt_postBody.Text;
            post.PostDateTime = pdate.Value;
            post.BlogId = (int)cbBlogs.SelectedValue;
            post.AutorId = (int)cbAuthors.SelectedValue;
            socialMediaDB.Posts.Add(post);
            socialMediaDB.SaveChanges();
            MessageBox.Show("Post Saved Sucessfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetInputsFields();
            FillDataGridView();
        }

        private void ResetInputsFields()
        {
            txt_postTitle.Text = txt_postBody.Text = String.Empty;
            pdate.Value = DateTime.Now;
            cbAuthors.SelectedIndex = 0;
            cbBlogs.SelectedIndex = 0;
            lblChooseImage.Text = "Choose Post Image...";

        }

        private void dgv_Posts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (((DataGridView)sender).SelectedCells[dgv_Posts.SelectedCells.Count - 1].ColumnIndex == 8)
            {
                int id = (int)dgv_Posts.SelectedRows[0].Cells["ID"].Value;
                var student = socialMediaDB.Posts.SingleOrDefault(p => p.id == id);
                socialMediaDB.Posts.Remove(student);
                socialMediaDB.SaveChanges();
                MessageBox.Show("Post Deleted Sucessfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FillDataGridView();
            }
        }




    }
}
