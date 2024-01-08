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
    public partial class frmViewEmployee : Form
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
        public int age { get; set; }
        public string contactNo { get; set; }
        public string position { get; set; }
        public string specialty { get; set; }
        public int salary { get; set; }
        public frmViewEmployee(string lname, string fname, string minitial, int houseNo, string street, string barangay, string municipality, string city, string sex, string birthdate, int age, string contactNo, string position, string specialty, int salary, int id)
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
            this.age = age;
            this.contactNo = contactNo;
            this.position = position;
            this.specialty = specialty;
            this.salary = salary;

            txtLname.ReadOnly = true;
            txtFname.ReadOnly = true;
            txtMI.ReadOnly = true;
            txtHouseNo.ReadOnly = true;
            txtStreet.ReadOnly = true;
            txtBarangay.ReadOnly = true;
            txtMunicipality.ReadOnly = true;
            txtCity.ReadOnly = true;
            txtSex.ReadOnly = true;
            txtBirthdate.ReadOnly = true;
            txtAge.ReadOnly = true;
            txtContactNo.ReadOnly = true;
            txtPosition.ReadOnly = true;
            txtSpecialty.ReadOnly = true;
            txtSalary.ReadOnly = true;



        }

        private void frmViewEmployee_Load(object sender, EventArgs e)
        {
            txtLname.Text = lname;
            txtFname.Text = fname;
            txtMI.Text = minitial;
            txtHouseNo.Text = houseNo.ToString();
            txtStreet.Text = street;
            txtBarangay.Text = barangay;
            txtMunicipality.Text = municipality;
            txtCity.Text = city;
            txtSex.Text = sex;
            txtBirthdate.Text = birthdate;
            txtAge.Text = age.ToString();
            txtContactNo.Text = contactNo;
            txtPosition.Text = position;
            txtSpecialty.Text = specialty;
            txtSalary.Text = salary.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
