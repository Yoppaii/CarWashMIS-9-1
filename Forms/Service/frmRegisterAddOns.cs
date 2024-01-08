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
    public partial class frmRegisterAddOns : Form
    {
        public frmRegisterAddOns()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
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

                    adp.InsertQuery(txtName.Text, Convert.ToInt32(txtExtraSmall.Text), Convert.ToInt32(txtSmall.Text), Convert.ToInt32(txtMedium.Text), Convert.ToInt32(txtLarge.Text), Convert.ToInt32(txtExtraLarge.Text));
                    adp.Fill(dt);

                    MessageBox.Show("Record successfully inserted", "Insert Add Ons", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            
            //try
            //{
            //    Table_ServiceTableAdapter adpService = new Table_ServiceTableAdapter();
            //    Employee.Table_ServiceDataTable dtService = new Employee.Table_ServiceDataTable();

            //    adpService.InsertService(txtName.Text, Convert.ToInt32(txtPrice.Text));
            //    adpService.FillService(dtService);

            //    this.Close();
            //}
            //catch (FormatException)
            //{
            //    MessageBox.Show("Please enter valid numeric values for Price.");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"An error occurred: {ex.Message}");
            //}
            
          
            
        }

        private void frmRegisterService_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtExtraLarge_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtLarge_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtMedium_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtSmall_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
