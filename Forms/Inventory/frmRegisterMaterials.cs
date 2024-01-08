using CarWashMIS.DataSets.EmployeeTableAdapters;
using CarWashMIS.DataSets;
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

    public partial class frmRegisterMaterials : Form
    {
        

        public frmRegisterMaterials()
        {
            InitializeComponent();

            cmbType.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || cmbType.Text == "" || txtUnit.Text == "" || txtPrice.Text == "" || txtQuantity.Text == "")
            {
                MessageBox.Show("Please fill up all fields", "Validating", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    M_MaterialsTableAdapter adp = new M_MaterialsTableAdapter();
                    Employee.M_MaterialsDataTable dt = new Employee.M_MaterialsDataTable();

                    adp.InsertQuery(txtName.Text, cmbType.Text, txtUnit.Text, Convert.ToInt32(txtPrice.Text), Convert.ToInt32(txtQuantity.Text), dtpAcquisition.Text, dtpExpiration.Text);
                    adp.Fill(dt);
                    MessageBox.Show("Record successfully inserted", "Insert Materials", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please enter valid numeric values for Price and Quantity.");
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
