using CarWashMIS.DataSets;
using CarWashMIS.DataSets.EmployeeTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarWashMIS.Forms
{
    public partial class frmEditEmployee : Form
    {
        public int id { get; set; }
        public string lname { get; set; }
        public string fname { get; set; }
        public string minitial { get; set; }
        public int houseNo { get; set; }
        public string street { get; set; }
        public string barangay { get; set; }
        public string municipality { get; set; }
        public string city { get; set; }
        public string sex { get; set; }
        public string birthdate { get; set; }
        public string contactNo { get; set; }
        public string position { get; set; }
        public string specialty { get; set; }
        public int salary { get; set; }


        public frmEditEmployee(string lname, string fname, string minitial, int houseNo, string street, string barangay, string municipality, string city, string sex, string birthdate, string contactNo, string position, string specialty, int salary, int id)
        {
            InitializeComponent();

            this.id = id;
            this.lname = lname;
            this.fname = fname;
            this.minitial = minitial;
            this.houseNo = houseNo;
            this.street = street;
            this.barangay = barangay;
            this.municipality = municipality;
            this.city = city;
            this.sex = sex;
            this.birthdate = birthdate;
            this.contactNo = contactNo;
            this.position = position;
            this.specialty = specialty;
            this.salary = salary;


            cmbPosition.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSex.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSpecialty.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void frmEditEmployee_Load(object sender, EventArgs e)
        {
            txtLname.Text = lname;
            txtFname.Text = fname;
            txtMI.Text = minitial;
            txtHouseNo.Text = houseNo.ToString();
            txtStreet.Text = street;
            txtBarangay.Text = barangay;
            txtMunicipality.Text = municipality;
            txtCity.Text = city;
            cmbSex.Text = sex;
            dtpBirthdate.Text = birthdate;
            txtContactNo.Text = contactNo;
            cmbPosition.Text = position;
            cmbSpecialty.Text = specialty;
            txtSalary.Text = salary.ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtLname.Text == "" || txtFname.Text == "" || txtMI.Text == "" || txtHouseNo.Text == "" || txtStreet.Text == "" ||
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
                    Employee.M_EmployeesDataTable dt = new Employee.M_EmployeesDataTable();

                    adp.UpdateQuery(txtLname.Text, txtFname.Text, txtMI.Text, Convert.ToInt32(txtHouseNo.Text),
                        txtStreet.Text, txtBarangay.Text, txtMunicipality.Text, txtCity.Text, cmbSex.Text, dtpBirthdate.Text,
                        txtContactNo.Text, cmbPosition.Text, cmbSpecialty.Text, Convert.ToInt32(txtSalary.Text), id);
                    adp.FillByWithAge(dt);

                    MessageBox.Show("Record successfully updated", "Update Employees", MessageBoxButtons.OK, MessageBoxIcon.Information);

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


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
