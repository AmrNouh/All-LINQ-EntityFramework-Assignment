using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DisconnectedCourseCRUD
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        List<SqlParameter> parameters;
        public Form1()
        {
            InitializeComponent();
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ITI"].ConnectionString);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetAllToipcs();
            dgvCourses.DataSource = GetAllCourses();
        }

        DataTable GetAllCourses()
        {
            cmd = new SqlCommand("Select Crs_Id as ID, Crs_Name as [Course Name], Crs_Duration as [Course Duration],Top_Name as [Topic Name] From Course c,Topic t where c.Top_Id = t.Top_Id; ", conn);
            adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            dt = new DataTable();
            adapter.Fill(dt);
            return dt;

        }

        void GetAllToipcs()
        {
            cmd = new SqlCommand("Select * from Topic", conn);
            adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DataRow dr = dt.NewRow();
            dr.ItemArray = new object[] { 0, "--Select Topic--" };
            dt.Rows.InsertAt(dr, 0);
            cb_Topics.DataSource = dt;
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow dataRow = dt.NewRow();
            foreach (DataRow item in dt.Rows)
            {
                if ((int)item[0] == (int)num_Id.Value)
                {
                    MessageBox.Show("This Course ID Is Exists, Try to Enter another one", "Duplication", MessageBoxButtons.OK);
                    return;
                }
            }
            dataRow[0] = num_Id.Value;
            dataRow[1] = txtName.Text;
            dataRow[2] = num_Duration.Value;
            dataRow[3] = cb_Topics.Text;
            dt.Rows.Add(dataRow);

            ClearFields();

            MessageBox.Show("Data Saved Sucessfully","Sucess Operation",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        int ExecuteDMLQueriesDisconnectedMode(Dictionary<String, List<SqlParameter>> queries, SqlDataAdapter sqlAdapter, DataTable dataTable)
        {
            int i = 0;
            int affectedRows = -1;
            string queryType = string.Empty;

            foreach (string? query in queries.Keys)
            {
                SqlCommand sqlCommand = new SqlCommand(query, conn);
                queryType = query.Substring(0, 6);
                foreach (var param in queries.Values.ElementAt(i++))
                {
                    sqlCommand.Parameters.Add(param);

                }
                sqlAdapter = new SqlDataAdapter();
                switch (queryType.Trim().ToLower())
                {
                    case "insert":
                        adapter.InsertCommand = cmd;
                        break;
                    case "update":
                        adapter.UpdateCommand = cmd;
                        break;
                    case "delete":
                        adapter.DeleteCommand = cmd;
                        break;
                }
            }
            try
            {
                affectedRows = sqlAdapter.Update(dataTable);
            }
            catch (Exception)
            {
                MessageBox.Show("Error While Updating DataBase, Please Check Your Queries","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return affectedRows;
        }




        private void btnUpdate_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in dt.Rows)
            {
                if ((int)row[0] == (int)num_Id.Value)
                {
                    //update

                    row[1] = txtName.Text;
                    row[2] = num_Duration.Value;
                    row[3] = cb_Topics.Text;
                }
            }
            MessageBox.Show("Data Upadated Sucessfully", "Sucess Operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Clear Field
            ClearFields();

            btnUpdate.Visible = false;
            btnAdd.Visible = true;
            num_Id.Enabled = true;
        }

        void ClearFields()
        {
            // Clear Field
            num_Id.Value = num_Duration.Value = 1;
            txtName.Text = String.Empty;
            cb_Topics.SelectedIndex = 0;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(((DataGridView)sender).CurrentCell.ColumnIndex == 0)
            {
                dgvCourses.Rows.Remove(dgvCourses.CurrentRow);
                MessageBox.Show("Data Deleted Sucessfully", "Sucess Operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            SqlCommand insertcommand = new SqlCommand("Insert into course (crs_id,crs_Name,crs_Duration,Top_Id) values (@Id,@Name,@Duration,(Select Top_Id from Topic where Top_Name =@TopicName))", conn);
            insertcommand.Parameters.Add("Id",SqlDbType.Int,4,"ID");
            insertcommand.Parameters.Add("Name", SqlDbType.NVarChar,50,"Course Name");
            insertcommand.Parameters.Add("Duration", SqlDbType.Int,4,"Course Duration");
            insertcommand.Parameters.Add("TopicName", SqlDbType.NVarChar,50,"Topic Name");

            SqlCommand updatecommand = new SqlCommand("update course set crs_Name=@Name, crs_Duration=@Duration, Top_Id=(Select Top_Id from Topic where Top_Name =@TopicName) where crs_id=@Id", conn);
            updatecommand.Parameters.Add("Name", SqlDbType.NVarChar, 50, "Course Name");
            updatecommand.Parameters.Add("Duration", SqlDbType.Int, 4, "Course Duration");
            updatecommand.Parameters.Add("TopicName", SqlDbType.NVarChar, 50, "Topic Name");
            updatecommand.Parameters.Add("Id", SqlDbType.Int, 4, "ID");

            SqlCommand deletecomand = new SqlCommand("delete from course where Crs_Id=@Id", conn);
            deletecomand.Parameters.Add("Id", SqlDbType.Int, 4, "ID");

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.InsertCommand = insertcommand;
            adapter.UpdateCommand = updatecommand;
            adapter.DeleteCommand = deletecomand;

            adapter.Update(dt);

            MessageBox.Show("All Changes Saved Sucessfully", "Sucess Operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvCourses_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnAdd.Visible =false;
            btnUpdate.Visible =true;
            num_Id.Enabled=false;

            num_Id.Value = (int)dgvCourses.SelectedRows[0].Cells[1].Value;
            txtName.Text = (string)dgvCourses.SelectedRows[0].Cells[2].Value;
            num_Duration.Value = (int)dgvCourses.SelectedRows[0].Cells[3].Value;
            cb_Topics.Text = (string)dgvCourses.SelectedRows[0].Cells[4].Value;
        }
    }
}