using PostsCRUDoperation.Models;
using Microsoft.EntityFrameworkCore;

namespace PostsCRUDoperation
{
    public partial class Form1 : Form
    {

        private BlogPostDbContext db;
        public Form1()
        {
            InitializeComponent();
            db = new BlogPostDbContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillDataGridView();
            CreateDataGridViewColumn();
            FillAuthorCombobox();
            FillBlogCombobox();
        }

        void FillDataGridView()
        {
            dgvPosts.DataSource = db.Posts.Select(p => new { ID = p.PostId, PostTitle = p.Title, PostBody = p.Body, AuthorName = p.PostAuthor.Name, BlogTitle = p.PostBlog.Title, ImagePath = p.Image.ImagePath, PostDateTime = p.PostDate }).ToList();
        }

        void CreateDataGridViewColumn()
        {
            DataGridViewImageColumn dataGridViewColumn = new DataGridViewImageColumn();
            dataGridViewColumn.Width = 60;
            dataGridViewColumn.Image = Image.FromFile(@"F:\ITI PD 9Month\DataSource Manipulation\All Assignments\delete.png");
            dgvPosts.Columns.Add(dataGridViewColumn);
        }

        void FillAuthorCombobox()
        {
            cmbAuthors.DisplayMember = "Name";
            cmbAuthors.ValueMember = "Id";
            cmbAuthors.DataSource = db.Authors.Select(a => new { Id = a.AuthorId, Name = a.Name }).ToList();
        }

        void FillBlogCombobox()
        {
            cmbBlogs.DisplayMember = "Title";
            cmbBlogs.ValueMember = "Id";
            cmbBlogs.DataSource = db.Blogs.Select(b => new { Id = b.BlogId, Title = b.Title }).ToList();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            Post post = new Post();
            post.Title = txtPostTitle.Text;
            post.Body = txtPostBody.Text;
            post.PostDate = pdate.Value;
            post.BlogId = (int)cmbBlogs.SelectedValue;
            post.AuthorId = (int)cmbAuthors.SelectedValue;
            db.Posts.Add(post);
            db.SaveChanges();
            MessageBox.Show("Post Saved Sucessfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetInputsFields();
            FillDataGridView();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = (int)dgvPosts.SelectedRows[0].Cells["ID"].Value;
            Post post = db.Posts.SingleOrDefault(p => p.PostId == id);
            post.Title = txtPostTitle.Text;
            post.Body = txtPostBody.Text;
            post.PostDate = pdate.Value;
            post.BlogId = (int)cmbBlogs.SelectedValue;
            post.AuthorId = (int)cmbAuthors.SelectedValue;
            db.SaveChanges();
            ResetInputsFields();
            ChangeControlStatus(true, false);
            MessageBox.Show("Post Updated Sucessfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FillDataGridView();
        }

        private void dgvPosts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (((DataGridView)sender).CurrentCell.ColumnIndex == 0)
            {
                int id = (int)dgvPosts.SelectedRows[0].Cells["ID"].Value;
                var student = db.Posts.SingleOrDefault(p => p.PostId == id);
                db.Posts.Remove(student);
                db.SaveChanges();
                MessageBox.Show("Post Deleted Sucessfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FillDataGridView();
            }
        }

        private void dgvPosts_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ChangeControlStatus(false, true);
            txtPostTitle.Text = dgvPosts.SelectedRows[0].Cells["PostTitle"].Value.ToString();
            txtPostBody.Text = dgvPosts.SelectedRows[0].Cells["PostBody"].Value.ToString();
            pdate.Value = (DateTime)dgvPosts.SelectedRows[0].Cells["PostDateTime"].Value;
            string authorName = dgvPosts.SelectedRows[0].Cells["AuthorName"].Value.ToString();
            cmbAuthors.SelectedValue = db.Authors.Where(a => a.Name == authorName).Select(a => a.AuthorId).SingleOrDefault();
            string blogTitle = dgvPosts.SelectedRows[0].Cells["BlogTitle"].Value.ToString();
            cmbBlogs.SelectedValue = db.Blogs.Where(b => b.Title == blogTitle).Select(b => b.BlogId).SingleOrDefault();
        }

        private void ResetInputsFields()
        {
            txtPostTitle.Text = txtPostBody.Text = String.Empty;
            pdate.Value = DateTime.Now;
            cmbAuthors.SelectedIndex = 0;
            cmbBlogs.SelectedIndex = 0;
            lblChooseImage.Text = "Choose Post Image...";

        }

        private void ChangeControlStatus(bool v1, bool v2)
        {
            btnAdd.Visible = v1;
            btnUpdate.Visible = v2;
        }

    }
}