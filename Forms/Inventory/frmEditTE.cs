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
    public partial class frmEditTE : Form
    {
        public int id { get; set; }
        public string name { get; set; }
        public string type { get; set; }

        public int quantity { get; set; }
        public string category { get; set; }


        public frmEditTE(string name, string type, int quantity, string category, int id)
        {
            InitializeComponent();
            this.id = id;
            this.name = name;
            this.type = type;
            this.quantity = quantity;
            this.category = category;

            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void frmEditEquipment_Load(object sender, EventArgs e)
        {
            txtName.Text = name;
            cmbType.Text = type;
            txtQuantity.Text = quantity.ToString();
            cmbCategory.Text = category;

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || cmbType.Text == "" || txtQuantity.Text == "" || cmbCategory.Text == "")
            {
                MessageBox.Show("Please fill up all fields", "Validating", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    M_ToolsEquipmentsTableAdapter adp = new M_ToolsEquipmentsTableAdapter();
                    Employee.M_ToolsEquipmentsDataTable dt = new Employee.M_ToolsEquipmentsDataTable();

                    adp.UpdateQuery(txtName.Text, cmbType.Text, Convert.ToInt32(txtQuantity.Text), cmbCategory.Text, id);
                    adp.Fill(dt);

                    MessageBox.Show("Record successfully updated", "Update Tools and Equipments", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

            //    adpInventory.UpdateInventory(txtName.Text, Convert.ToInt32(txtQuantity.Text), cmbCategory.Text, id);
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
