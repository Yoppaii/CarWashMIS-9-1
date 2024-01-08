using CarWashMIS.Class;
using CarWashMIS.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarWashMIS
{
    public partial class frmMain : Form
    {
        Form activeForm = new Form();
        private Color originalColor;

        bool inventoryCollapse = true;

        public frmMain()
        {
            InitializeComponent();
 
        }

        public void OpenChildForm(Form childForm, object sender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Dock = DockStyle.Fill;
            this.pnlParent.Controls.Add(childForm);
            this.pnlParent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

            lblTitle.Text = activeForm.Text;


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.frmDashboard(), e);
        }
        private void btnService_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.frmService(), e);
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.frmEmployee(), e);
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            InventoryTimer.Start();
            OpenChildForm(new Forms.frmMaterials(), e);

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.frmSettings(), e);

        }

        private void btnInventory_MouseEnter(object sender, EventArgs e)
        {
            originalColor = btnInventory.BackColor;

            Color hoverColor = Color.FromArgb(0xFE, 0xFC, 0xD6);
            btnInventory.BackColor = hoverColor;
        }

        private void btnInventory_MouseLeave(object sender, EventArgs e)
        {
            btnInventory.BackColor = originalColor;
        }

        private void btnInventory_MouseHover(object sender, EventArgs e)
        {
            Color hoverColor = Color.FromArgb(0xFE, 0xFC, 0xD6);
            btnInventory.BackColor = hoverColor;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.frmDashboard(), e);

        }

        private void Inventory_Tick(object sender, EventArgs e)
        {
            if (inventoryCollapse)
            {
                pnlInventoryButton.Height += 10;
                if(pnlInventoryButton.Height == pnlInventoryButton.MaximumSize.Height)
                {
                    inventoryCollapse = false;
                    InventoryTimer.Stop();
                }
            }
            else
            {
                pnlInventoryButton.Height -= 10;
                if(pnlInventoryButton.Height == pnlInventoryButton.MinimumSize.Height)
                {
                    inventoryCollapse = true;
                    InventoryTimer.Stop();
                }
            }
        }

        private void btnToolsEquipments_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.frmTE(), e);
        }

        private void btnMaterials_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.frmMaterials(), e);
        }

        private void btnArchives_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.frmArchives(), e);

        }
    }
}
