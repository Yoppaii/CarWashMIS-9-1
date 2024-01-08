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
    public partial class frmEditAddOns : Form
    {
        public int id { get; set; }
        public string name { get; set; }
        public int extraSmall { get; set; }
        public int small { get; set; }
        public int medium { get; set; }
        public int large { get; set; }
        public int extraLarge{ get; set; }

        public frmEditAddOns(string name,int extraSmall, int small, int medium, int large, int extraLarge, int id)
        {
            InitializeComponent();
            this.extraSmall = extraSmall;
            this.id = id;
            this.name = name;
            this.small = small;
            this.medium = medium;
            this.large = large;
            this.extraLarge = extraLarge;
           
        }

        private void frmEditService_Load(object sender, EventArgs e)
        {
            txtExtraSmall.Text = extraSmall.ToString();
            txtName.Text = name;
            txtSmall.Text = small.ToString();
            txtMedium.Text = medium.ToString();
            txtLarge.Text = large.ToString();
            txtExtraLarge.Text = extraLarge.ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtExtraSmall.Text == "" || txtSmall.Text == "" || txtMedium.Text == "" || txtLarge.Text == "" || txtExtraLarge.Text == "")
            {
                MessageBox.Show("Please fill up all fields", "Validating", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    M_AddOnsTableAdapter adp = new M_AddOnsTableAdapter();
                    Employee.M_AddOnsDataTable dt = new Employee.M_AddOnsDataTable();

                    adp.UpdateQuery(txtName.Text, Convert.ToInt32(txtExtraSmall.Text), Convert.ToInt32(txtSmall.Text), Convert.ToInt32(txtMedium.Text), Convert.ToInt32(txtLarge.Text), Convert.ToInt32(txtExtraLarge.Text), id);
                    adp.Fill(dt);

                    MessageBox.Show("Record successfully updated", "Update Add Ons", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please enter valid numeric values for ExtraSmall, Small, Medium, Large, and ExtraLarge Prices.");
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
