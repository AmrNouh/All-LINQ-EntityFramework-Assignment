using System.Data.SqlClient;

namespace ThreeTierCourseCRUD
{
    public partial class Form1 : Form
    {
        Dictionary<string, object> _param = new Dictionary<string, object>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cb_Topics.DataSource = TopicRepository.GetAllTopics();
            RefreshDataGridView();
        }

        void RefreshDataGridView()
        {
            dgvCourses.DataSource = CourseRepository.GetAllCourses();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _param.Add("Id", num_Id.Value);
            _param.Add("Name", txtName.Text);
            _param.Add("Duration", num_Duration.Value);
            _param.Add("TopicName", cb_Topics.Text);

            if(CourseRepository.InsertCourse(_param) > 0)
            {
                ClearFields();
                MessageBox.Show("Data Saved Sucessfully", "Sucess Operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshDataGridView();
            }

            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _param.Add("Name", txtName.Text);
            _param.Add("Duration", num_Duration.Value);
            _param.Add("TopicName", cb_Topics.Text);
            _param.Add("Id", num_Id.Value);
            if (CourseRepository.UpdateCourse(_param) > 0)
            {
                MessageBox.Show("Data Upadated Sucessfully", "Sucess Operation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearFields();

                btnUpdate.Visible = false;
                btnAdd.Visible = true;
                num_Id.Enabled = true;
                RefreshDataGridView();
            }
            
        }

        private void dgvCourses_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnAdd.Visible = false;
            btnUpdate.Visible = true;
            num_Id.Enabled = false;

            num_Id.Value = (int)dgvCourses.SelectedRows[0].Cells[1].Value;
            txtName.Text = (string)dgvCourses.SelectedRows[0].Cells[2].Value;
            num_Duration.Value = (int)dgvCourses.SelectedRows[0].Cells[3].Value;
            cb_Topics.Text = (string)dgvCourses.SelectedRows[0].Cells[4].Value;
        }

        private void dgvCourses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (((DataGridView)sender).CurrentCell.ColumnIndex == 0)
            {
                _param.Add("Id",dgvCourses.CurrentRow.Cells[1].Value);
                if (CourseRepository.DeleteCourse(_param) > 0)
                {
                    MessageBox.Show("Data Deleted Sucessfully", "Sucess Operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshDataGridView();
                }
                
            }
        }

        void ClearFields()
        {
            // Clear Field
            num_Id.Value = num_Duration.Value = 1;
            txtName.Text = String.Empty;
            cb_Topics.SelectedIndex = 0;
        }

    }
}