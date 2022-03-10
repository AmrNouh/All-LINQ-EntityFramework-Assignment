using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityFrameworkStudentCURD.Model;

namespace EntityFrameworkStudentCURD
{
    public partial class frm_Student : Form
    {
        ITIContext context;
        
        public frm_Student()
        {
            InitializeComponent();
            context = new ITIContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillDataGridView();
            CreateDataGridViewColumn();
            FillComboBox();
        }

        void CreateDataGridViewColumn()
        {
            DataGridViewImageColumn dataGridViewColumn = new DataGridViewImageColumn();
            dataGridViewColumn.Width = 60;
            dataGridViewColumn.ReadOnly = true;
            dataGridViewColumn.Image = Image.FromFile(@"F:\ITI PD 9Month\DataSource Manipulation\All Assignments\delete.png");
            dgv_Students.Columns.Add(dataGridViewColumn);
        }

        void FillDataGridView()
        {
            dgv_Students.DataSource = context.Students.Select(s => new { s.St_Id, s.St_Fname, s.St_Lname, s.St_Age, s.Department.Dept_Name, s.St_Address }).ToList();
        }

        void FillComboBox()
        {
            //DataTable items = context.Departments.Select(d => new { d.Dept_Id, d.Dept_Name }).ToList();
            //DataRow dt = items.NewRow();
            //dt.ItemArray = new object[] { 0, "--Select Department---" };
            //items.Rows.InsertAt(dt, 0);
            cb_Departments.DisplayMember = "Dept_Name";
            cb_Departments.ValueMember = "Dept_Id";
            cb_Departments.DataSource = context.Departments.Select(d => new { d.Dept_Id, d.Dept_Name }).ToList();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.St_Id = (int)ud_Id.Value;
            student.St_Fname = txt_FirstName.Text;
            student.St_Lname = txt_LastName.Text;
            student.St_Age = (int)ud_Age.Value;
            student.St_Address = txt_Address.Text;
            student.Dept_Id = (int)cb_Departments.SelectedValue;
            context.Students.Add(student);
            context.SaveChanges();
            MessageBox.Show("Student Saved Sucessfully","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
            ResetInputsFields();
            FillDataGridView();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            int id = (int)ud_Id.Value;
            var student = context.Students.SingleOrDefault(s => s.St_Id == id);

            student.St_Fname = txt_FirstName.Text;
            student.St_Lname = txt_LastName.Text;
            student.St_Age = (int)ud_Age.Value;
            student.St_Address = txt_Address.Text;
            student.Dept_Id = (int)cb_Departments.SelectedValue;

            context.SaveChanges();
            ResetInputsFields();
            ChangeControlStatus(true,true,false);
            MessageBox.Show("Student Updated Sucessfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FillDataGridView();
        }

        private void dgv_Students_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (((DataGridView)sender).SelectedCells[dgv_Students.SelectedCells.Count-1].ColumnIndex == 6)
            {
                int id = (int)dgv_Students.SelectedRows[0].Cells["St_Id"].Value;
                var student = context.Students.SingleOrDefault(s => s.St_Id == id);
                context.Students.Remove(student);
                context.SaveChanges();
                MessageBox.Show("Student Deleted Sucessfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FillDataGridView();
            }
        }

        private void dgv_Students_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ChangeControlStatus(false,false,true);
            ud_Id.Value = (int)dgv_Students.SelectedRows[0].Cells["St_Id"].Value;
            txt_FirstName.Text = dgv_Students.SelectedRows[0].Cells["St_Fname"].Value.ToString();
            txt_LastName.Text = dgv_Students.SelectedRows[0].Cells["St_Lname"].Value.ToString();
            ud_Age.Value = (int)dgv_Students.SelectedRows[0].Cells["St_Age"].Value;
            txt_Address.Text = dgv_Students.SelectedRows[0].Cells["St_Address"].Value.ToString();
            cb_Departments.SelectedValue = context.Students.Where(s => s.St_Id == (int)ud_Id.Value).Select(s => s.Dept_Id).SingleOrDefault();

        }

        void ChangeControlStatus(bool idStatus,bool btn_AddStatus, bool btn_UpdateStatus)
        {
            ud_Id.Enabled = idStatus;
            btn_Add.Visible = btn_AddStatus;
            btn_Update.Visible = btn_UpdateStatus;
        }

        void ResetInputsFields()
        {
            ud_Id.Value = ud_Id.Minimum;
            txt_FirstName.Text = txt_LastName.Text = txt_Address.Text = String.Empty;
            ud_Age.Value = ud_Age.Minimum;
            cb_Departments.SelectedIndex = 0;
        }
    }
}
