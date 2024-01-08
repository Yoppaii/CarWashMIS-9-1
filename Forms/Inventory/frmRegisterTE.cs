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
    public partial class frmRegisterTE : Form
    {
 
        public frmRegisterTE()
        {
            InitializeComponent();

            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtName.Text == "" || cmbType.Text == "" || txtQuantity.Text == "" || cmbCategory.Text == "")
            {
                MessageBox.Show("Please fill up all fields", "Validating", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    M_ToolsEquipmentsTableAdapter adp = new M_ToolsEquipmentsTableAdapter();
                    Employee.M_ToolsEquipmentsDataTable dt = new Employee.M_ToolsEquipmentsDataTable();

                    adp.InsertQuery(txtName.Text, cmbType.Text, Convert.ToInt32(txtQuantity.Text), cmbCategory.Text);
                    adp.Fill(dt);

                    MessageBox.Show("Record successfully inserted", "Insert Tools and Equipments", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please enter valid numeric values for Quantity.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }


            //try
            //{
            //    Table_InventoryTableAdapter adpInventory = new Table_InventoryTableAdapter();
            //    Employee.Table_InventoryDataTable dtInventory = new Employee.Table_InventoryDataTable();

            //    adpInventory.InsertInventory(txtName.Text, Convert.ToInt32(txtQuantity.Text), cmbCategory.Text);
            //    adpInventory.FillInventory(dtInventory);

            //    this.Close();
            //}
            //catch (FormatException)
            //{
            //    MessageBox.Show("Please enter valid numeric values for Quantity.");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"An error occurred: {ex.Message}");
            //}
            
          
            
        }

        private void frmRegisterEquipment_Load(object sender, EventArgs e)
        {

        }
    }
}
