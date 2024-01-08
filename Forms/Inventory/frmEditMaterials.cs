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
using System.Data.SqlClient;

namespace CarWashMIS.Forms
{
    public partial class frmEditMaterials : Form
    {
        public int id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string unit { get; set; }
        public int price { get; set; }
        public int quantity { get; set; }
        public string acquisition { get; set; }
        public string expiration { get; set; }


        public frmEditMaterials(string name, string type, string unit, int price, int quantity, string acquisition, string expiration, int id)
        {
            InitializeComponent();
            this.name = name;
            this.type = type;
            this.unit = unit;
            this.price = price;
            this.quantity = quantity;
            this.acquisition = acquisition;
            this.expiration = expiration;
            this.id = id;

            cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void frmEditMaterials_Load(object sender, EventArgs e)
        {
            txtName.Text = name;
            cmbType.Text = type;
            txtUnit.Text = unit;
            txtPrice.Text = price.ToString();
            txtQuantity.Text = quantity.ToString();
            dtpAcquisition.Text = acquisition.ToString();
            dtpExpiration.Text = expiration.ToString();
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
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

                    adp.UpdateQuery(txtName.Text, cmbType.Text, txtUnit.Text, Convert.ToInt32(txtPrice.Text), Convert.ToInt32(txtQuantity.Text), dtpAcquisition.Text, dtpExpiration.Text, id);
                    adp.Fill(dt);

                    MessageBox.Show("Record successfully updated", "Update Materials", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
