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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CarWashMIS
{
    public partial class frmRegisterEmployee : Form
    {
        public frmRegisterEmployee()
        {
            InitializeComponent();

            cmbPosition.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSex.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSpecialty.DropDownStyle = ComboBoxStyle.DropDownList;


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtLName.Text == "" || txtFname.Text == "" || txtMI.Text == "" || txtHouseNo.Text == "" || txtStreet.Text == "" ||
                txtBarangay.Text == "" || txtMunicipality.Text == "" || txtCity.Text == "" || cmbSex.Text == "" ||
                txtContactNo.Text == "" || cmbPosition.Text == "" || cmbSpecialty.Text == "" || txtSalary.Text == "")
            {
                MessageBox.Show("Please fill up all fields", "Validating", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    M_EmployeesTableAdapter adp = new M_EmployeesTableAdapter();

                    adp.InsertQuery(txtLName.Text, txtFname.Text, txtMI.Text, Convert.ToInt32(txtHouseNo.Text), txtStreet.Text,
                        txtBarangay.Text, txtMunicipality.Text, txtCity.Text, cmbSex.Text, dtpBirthdate.Text,
                        txtContactNo.Text, cmbPosition.Text, cmbSpecialty.Text, Convert.ToInt32(txtSalary.Text));

                    this.Close();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please enter valid numeric values for House No. and Salary.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }





            //try
            //{
            //    Table_EmployeeTableAdapter adpEmployee = new Table_EmployeeTableAdapter();
            //    Employee.Table_EmployeeDataTable dtEmployee = new Employee.Table_EmployeeDataTable();


            //    adpEmployee.InsertEmployee(txtFullName.Text, cmbGender.Text, Convert.ToInt32(txtAge.Text), txtAddress.Text, txtContactNumber.Text, Convert.ToInt32(txtSalary.Text), cmbPosition.Text);
            //    adpEmployee.FillEmployee(dtEmployee);

            //    this.Close();
            //}
            //catch (FormatException)
            //{
            //    MessageBox.Show("Please enter valid numeric values for Age and Salary.");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"An error occurred: {ex.Message}");
            //}


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
