using CarWashMIS.DataSets;
using CarWashMIS.DataSets.EmployeeTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarWashMIS.Forms
{
    public partial class frmEmployee : Form
    {
        //M_EmployeesTableAdapter adpEmployee = new M_EmployeesTableAdapter();
        //Employee.M_EmployeesDataTable dtEmployee = new Employee.M_EmployeesDataTable();
        private string placeholderText = "Enter text here";
        public frmEmployee()
        {
            InitializeComponent();

            SetPlaceholder();

            //adpEmployee.FillByWithAge(dtEmployee);
            //dgvEmployees.DataSource = dtEmployee;

            //dgvEmployees.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dgvEmployees.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //dgvEmployees.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //dgvEmployees.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dgvEmployees.Columns[4].Visible = false;
            //dgvEmployees.Columns[5].Visible = false;
            //dgvEmployees.Columns[6].Visible = false;
            //dgvEmployees.Columns[7].Visible = false;
            //dgvEmployees.Columns[8].Visible = false;
            //dgvEmployees.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dgvEmployees.Columns[10].Visible = false;
            //dgvEmployees.Columns[15].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dgvEmployees.Columns[15].DisplayIndex = 11;
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employee1.M_Employees' table. You can move, or remove it, as needed.
            this.m_EmployeesTableAdapter.FillByWithAge(this.employee1.M_Employees);

      


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmRegisterEmployee re = new frmRegisterEmployee();
            re.ShowDialog();

            this.m_EmployeesTableAdapter.FillByWithAge(this.employee1.M_Employees);

            
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvEmployees.CurrentRow.Cells[0].Value);
            string lname = dgvEmployees.CurrentRow.Cells["Lname"].Value.ToString();
            string fname = dgvEmployees.CurrentRow.Cells["Fname"].Value.ToString();
            string minitial = dgvEmployees.CurrentRow.Cells["Minitial"].Value.ToString();
            int houseNo = Convert.ToInt32(dgvEmployees.CurrentRow.Cells["HouseNo"].Value);
            string street = dgvEmployees.CurrentRow.Cells["St"].Value.ToString();
            string barangay = dgvEmployees.CurrentRow.Cells["Barangay"].Value.ToString();
            string municipality = dgvEmployees.CurrentRow.Cells["Municipality"].Value.ToString();
            string city = dgvEmployees.CurrentRow.Cells["City"].Value.ToString();
            string sex = dgvEmployees.CurrentRow.Cells["Sex"].Value.ToString();
            string birthdate = dgvEmployees.CurrentRow.Cells["Birthdate"].Value.ToString();
            string contactNo = dgvEmployees.CurrentRow.Cells["ContactNo"].Value.ToString();
            string position = dgvEmployees.CurrentRow.Cells["Position"].Value.ToString();
            string specialty = dgvEmployees.CurrentRow.Cells["Specialty"].Value.ToString();
            int salary = Convert.ToInt32(dgvEmployees.CurrentRow.Cells["Salary"].Value);

            frmEditEmployee ee = new frmEditEmployee(lname, fname, minitial, houseNo, street, barangay, municipality, city, sex, birthdate, contactNo, position, specialty, salary, id);
            ee.ShowDialog();

            this.m_EmployeesTableAdapter.FillByWithAge(this.employee1.M_Employees);


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Enter text here")
            {
                this.m_EmployeesTableAdapter.FillByWithAge(this.employee1.M_Employees);
            }
            else
            {
                if (!string.IsNullOrEmpty(txtSearch.Text))
                {
                    this.m_EmployeesTableAdapter.FillBySearch(this.employee1.M_Employees, txtSearch.Text);


                }
                else
                {
                    this.m_EmployeesTableAdapter.FillByWithAge(this.employee1.M_Employees);


                }
            }
            
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvEmployees.CurrentRow.Cells[0].Value);
            string lname = dgvEmployees.CurrentRow.Cells["Lname"].Value.ToString();
            string fname = dgvEmployees.CurrentRow.Cells["Fname"].Value.ToString();
            string minitial = dgvEmployees.CurrentRow.Cells["Minitial"].Value.ToString();
            int houseNo = Convert.ToInt32(dgvEmployees.CurrentRow.Cells["HouseNo"].Value);
            string street = dgvEmployees.CurrentRow.Cells["St"].Value.ToString();
            string barangay = dgvEmployees.CurrentRow.Cells["Barangay"].Value.ToString();
            string municipality = dgvEmployees.CurrentRow.Cells["Municipality"].Value.ToString();
            string city = dgvEmployees.CurrentRow.Cells["City"].Value.ToString();
            string sex = dgvEmployees.CurrentRow.Cells["Sex"].Value.ToString();

            DateTime selectedDate = (DateTime)dgvEmployees.CurrentRow.Cells["Birthdate"].Value;
            string birthdate = selectedDate.ToString("dd-MM-yyyy");
            int age = Convert.ToInt32(dgvEmployees.CurrentRow.Cells["Age"].Value);
            string contactNo = dgvEmployees.CurrentRow.Cells["ContactNo"].Value.ToString();
            string position = dgvEmployees.CurrentRow.Cells["Position"].Value.ToString();
            string specialty = dgvEmployees.CurrentRow.Cells["Specialty"].Value.ToString();
            int salary = Convert.ToInt32(dgvEmployees.CurrentRow.Cells["Salary"].Value);

            frmViewEmployee ve = new frmViewEmployee(lname, fname, minitial, houseNo, street, barangay, municipality, city, sex, birthdate, age, contactNo, position, specialty, salary, id);
            ve.ShowDialog();

            this.m_EmployeesTableAdapter.FillByWithAge(this.employee1.M_Employees);

        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to archive record?", "Archive Tools and Equipments", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgvEmployees.CurrentRow.Cells[0].Value.ToString());

                M_EmployeesTableAdapter adp = new M_EmployeesTableAdapter();

                adp.ArchiveQuery(id);

                this.m_EmployeesTableAdapter.FillByWithAge(this.employee1.M_Employees);
            }

        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnSearch.PerformClick();
            }
        }

        private void SetPlaceholder()
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text) || txtSearch.Text == placeholderText)
            {
                // Set the placeholder text and change its color
                txtSearch.Text = placeholderText;
                txtSearch.ForeColor = System.Drawing.SystemColors.GrayText;
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == placeholderText)
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = System.Drawing.SystemColors.WindowText;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            SetPlaceholder();

        }

    }
}
