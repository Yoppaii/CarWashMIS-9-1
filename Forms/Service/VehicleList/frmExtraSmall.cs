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

namespace CarWashMIS.Forms.Service
{
    public partial class frmViewVehicleLists : Form
    {
        private M_VehicleListTableAdapter adpV = new M_VehicleListTableAdapter();
        private Employee.M_VehicleListDataTable dtV = new Employee.M_VehicleListDataTable();
        public frmViewVehicleLists()
        {
            InitializeComponent();
        }

        private void frmViewVehicleLists_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employee.M_VehicleList' table. You can move, or remove it, as needed.
            this.m_VehicleListTableAdapter.FillByXS(this.employee.M_VehicleList);

            

        }

    }
}
