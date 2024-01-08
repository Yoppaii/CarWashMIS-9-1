namespace CarWashMIS.Forms
{
    partial class formViewMedium
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formViewMedium));
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.listBoxM = new System.Windows.Forms.ListBox();
            this.mVehicleListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employee = new CarWashMIS.DataSets.Employee();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.m_VehicleListTableAdapter = new CarWashMIS.DataSets.EmployeeTableAdapters.M_VehicleListTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.mVehicleListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.Location = new System.Drawing.Point(252, 106);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(37, 27);
            this.btnSearch.TabIndex = 84;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(10, 106);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(236, 27);
            this.txtSearch.TabIndex = 83;
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // listBoxM
            // 
            this.listBoxM.DataSource = this.mVehicleListBindingSource;
            this.listBoxM.DisplayMember = "Name";
            this.listBoxM.FormattingEnabled = true;
            this.listBoxM.ItemHeight = 20;
            this.listBoxM.Location = new System.Drawing.Point(11, 139);
            this.listBoxM.Name = "listBoxM";
            this.listBoxM.Size = new System.Drawing.Size(305, 284);
            this.listBoxM.TabIndex = 82;
            this.listBoxM.ValueMember = "Id";
            // 
            // mVehicleListBindingSource
            // 
            this.mVehicleListBindingSource.DataMember = "M_VehicleList";
            this.mVehicleListBindingSource.DataSource = this.employee;
            // 
            // employee
            // 
            this.employee.DataSetName = "Employee";
            this.employee.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(221, 30);
            this.label7.TabIndex = 81;
            this.label7.Text = "View Medium Vehicles";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 40);
            this.panel1.TabIndex = 80;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Black;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(242, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(88, 40);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // m_VehicleListTableAdapter
            // 
            this.m_VehicleListTableAdapter.ClearBeforeFill = true;
            // 
            // formViewMedium
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 450);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.listBoxM);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "formViewMedium";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "formViewMedium";
            this.Load += new System.EventHandler(this.formViewMedium_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mVehicleListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ListBox listBoxM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private DataSets.Employee employee;
        private System.Windows.Forms.BindingSource mVehicleListBindingSource;
        private DataSets.EmployeeTableAdapters.M_VehicleListTableAdapter m_VehicleListTableAdapter;
    }
}