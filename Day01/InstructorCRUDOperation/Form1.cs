using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace InstructorCRUDOperation
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader dataReader;
        int status;

        public Form1()
        {

            InitializeComponent();

            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["InstructorITI"].ConnectionString);
            FillDataGrid();
            GetAllDepartments();
        }

        void FillDataGrid()
        {
            command = new SqlCommand("Select * from Instructor;", connection);
            try
            {
                List<Instructor> list = new();
                connection.Open();
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    Instructor instructor = new Instructor();
                    instructor.Id = dataReader.GetInt32("Ins_Id");
                    instructor.Name = dataReader.GetString("Ins_Name");
                    instructor.Degree = dataReader.GetString("Ins_Degree");
                    instructor.Salary = dataReader.GetDecimal("Salary");
                    instructor.DepartmentId = dataReader.GetInt32("Dept_Id");
                    list.Add(instructor);
                }
                dataGridView1.DataSource = list;

            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error in Retrive Data","Error",MessageBoxButtons.OK);
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        void GetAllDepartments()
        {
            command = new SqlCommand("Select Dept_Id , Dept_Name from Department",connection);
            try
            {
                connection.Open();
                List<Department> departments = new List<Department>();
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    Department department = new Department();
                    department.Dept_Id = dataReader.GetInt32("Dept_Id");
                    department.Department_Name = dataReader.GetString("Dept_Name");
                    departments.Add(department);
                }

                cb_dept.DisplayMember = "Department_Name";
                cb_dept.ValueMember = "Dept_Id";
                cb_dept.DataSource = departments;
            }
            catch (Exception)
            {

                MessageBox.Show("Error While Getting Instructor Deptartments","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            num_Id.Value = (int)dataGridView1.SelectedRows[0].Cells[1].Value;
            txt_name.Text = (string)dataGridView1.SelectedRows[0].Cells[2].Value;
            txt_degree.Text = (string)dataGridView1.SelectedRows[0].Cells[3].Value;
            num_salary.Value = (decimal)dataGridView1.SelectedRows[0].Cells[4].Value;
            cb_dept.SelectedValue = dataGridView1.SelectedRows[0].Cells[5].Value;

            btn_Add.Visible = false;
            btn_update.Visible = true;
            num_Id.Enabled = false;
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (((DataGridView)sender).CurrentCell.ColumnIndex == 0)
            {
                int Id = (int)((DataGridView)sender).SelectedCells[1].Value;
                if (CheckIfIntructorTeachAnyCourses(Id) || !CheckIfIntructorTeachAnyCourses(Id))
                {
                    command = new SqlCommand("Delete From Instructor where Ins_Id = @Id", connection);
                    command.Parameters.AddWithValue("Id", Id);

                    try
                    {
                        connection.Open();

                        if (MessageBox.Show("This Instructor is Already Teach Some Courses,Are You Sure You Want to delete him ?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            status = command.ExecuteNonQuery();
                            if (status > 0)
                            {
                                MessageBox.Show("Instructor Deleted", "Sucess Operation", MessageBoxButtons.OK);
                                connection.Close();
                                FillDataGrid();
                            }
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Can not Delete This Instructor", "Delete Error", MessageBoxButtons.OK);
                    }
                }
            }
        }

        Boolean CheckIfIntructorTeachAnyCourses(int id)
        {
            command = new SqlCommand($"Select 1 from Ins_Course where Ins_Id = {id}", connection);
            try
            {
                connection.Open();
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    return true;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Can not Complete Check Opertation", "Error", MessageBoxButtons.OK);
            }
            finally
            {
                connection?.Close();
            }

            return false;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("insert into Instructor (ins_Id, Ins_Name, Ins_Degree,Salary,Dept_Id) values (@Id,@Name,@Degree,@Salary,@Dept_Id)", connection);
            command.Parameters.AddWithValue("Id",num_Id.Value);
            command.Parameters.AddWithValue("Name",txt_name.Text);
            command.Parameters.AddWithValue("Degree",txt_degree.Text);
            command.Parameters.AddWithValue("Salary",num_salary.Value);
            command.Parameters.AddWithValue("Dept_Id",cb_dept.SelectedValue);
            try
            {
                connection.Open();
                status = command.ExecuteNonQuery();
                connection.Close();
                if (status > 0)
                {
                    txt_name.Text = txt_degree.Text = String.Empty;
                    num_salary.Value = 0;
                    FillDataGrid();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error while Insert Instructor","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("update Instructor set Ins_Name=@Name, Ins_Degree=@Degree, Salary=@Salary, Dept_Id=@Dept_Id where ins_Id=@Id", connection);
            command.Parameters.AddWithValue("Id", num_Id.Value);
            command.Parameters.AddWithValue("Name", txt_name.Text);
            command.Parameters.AddWithValue("Degree", txt_degree.Text);
            command.Parameters.AddWithValue("Salary", num_salary.Value);
            command.Parameters.AddWithValue("Dept_Id", cb_dept.SelectedValue);
            try
            {
                connection.Open();
                status = command.ExecuteNonQuery();
                connection.Close();
                if (status > 0)
                {
                    num_Id.Value = 1;
                    txt_name.Text = txt_degree.Text = String.Empty;
                    num_salary.Value = 0;
                    cb_dept.SelectedIndex = 0;

                    btn_Add.Visible = true;
                    btn_update.Visible = false;
                    num_Id.Enabled = true;

                    FillDataGrid();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error while Insert Instructor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}