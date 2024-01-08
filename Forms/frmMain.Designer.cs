namespace CarWashMIS
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlTopNav = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pnlParent = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnService = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.pnlSideBar = new System.Windows.Forms.Panel();
            this.btnArchives = new System.Windows.Forms.Button();
            this.pnlInventoryButton = new System.Windows.Forms.Panel();
            this.btnToolsEquipments = new System.Windows.Forms.Button();
            this.btnMaterials = new System.Windows.Forms.Button();
            this.InventoryTimer = new System.Windows.Forms.Timer(this.components);
            this.pnlTopNav.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnlSideBar.SuspendLayout();
            this.pnlInventoryButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopNav
            // 
            this.pnlTopNav.BackColor = System.Drawing.Color.Black;
            this.pnlTopNav.Controls.Add(this.btnClose);
            this.pnlTopNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopNav.Location = new System.Drawing.Point(0, 0);
            this.pnlTopNav.Name = "pnlTopNav";
            this.pnlTopNav.Size = new System.Drawing.Size(1700, 40);
            this.pnlTopNav.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1612, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(88, 40);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lblTitle);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(250, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1450, 70);
            this.panel3.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(553, 3);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(118, 65);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(250, 910);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1450, 40);
            this.panel4.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(1660, 110);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(40, 800);
            this.panel5.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(250, 110);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(40, 800);
            this.panel6.TabIndex = 6;
            // 
            // pnlParent
            // 
            this.pnlParent.BackColor = System.Drawing.Color.White;
            this.pnlParent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlParent.Location = new System.Drawing.Point(290, 110);
            this.pnlParent.Name = "pnlParent";
            this.pnlParent.Size = new System.Drawing.Size(1370, 800);
            this.pnlParent.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 211);
            this.panel1.TabIndex = 0;
            // 
            // pbLogo
            // 
            this.pbLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbLogo.BackgroundImage")));
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(250, 211);
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.White;
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 3;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(19)))), ((int)(((byte)(23)))));
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 211);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDashboard.MaximumSize = new System.Drawing.Size(250, 55);
            this.btnDashboard.MinimumSize = new System.Drawing.Size(250, 55);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(250, 55);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "      Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnService
            // 
            this.btnService.BackColor = System.Drawing.Color.White;
            this.btnService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnService.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnService.FlatAppearance.BorderSize = 3;
            this.btnService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnService.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(19)))), ((int)(((byte)(23)))));
            this.btnService.Image = ((System.Drawing.Image)(resources.GetObject("btnService.Image")));
            this.btnService.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnService.Location = new System.Drawing.Point(0, 266);
            this.btnService.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnService.MaximumSize = new System.Drawing.Size(250, 55);
            this.btnService.MinimumSize = new System.Drawing.Size(250, 55);
            this.btnService.Name = "btnService";
            this.btnService.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnService.Size = new System.Drawing.Size(250, 55);
            this.btnService.TabIndex = 2;
            this.btnService.Text = "      Service";
            this.btnService.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnService.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnService.UseVisualStyleBackColor = false;
            this.btnService.Click += new System.EventHandler(this.btnService_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.Color.White;
            this.btnEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmployee.FlatAppearance.BorderSize = 3;
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployee.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(19)))), ((int)(((byte)(23)))));
            this.btnEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployee.Image")));
            this.btnEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployee.Location = new System.Drawing.Point(0, 321);
            this.btnEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEmployee.MaximumSize = new System.Drawing.Size(250, 55);
            this.btnEmployee.MinimumSize = new System.Drawing.Size(250, 55);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnEmployee.Size = new System.Drawing.Size(250, 55);
            this.btnEmployee.TabIndex = 4;
            this.btnEmployee.Text = "      Employee";
            this.btnEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmployee.UseVisualStyleBackColor = false;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 852);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 58);
            this.panel2.TabIndex = 5;
            // 
            // btnInventory
            // 
            this.btnInventory.BackColor = System.Drawing.Color.White;
            this.btnInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInventory.FlatAppearance.BorderSize = 3;
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(19)))), ((int)(((byte)(23)))));
            this.btnInventory.Image = ((System.Drawing.Image)(resources.GetObject("btnInventory.Image")));
            this.btnInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventory.Location = new System.Drawing.Point(0, 0);
            this.btnInventory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnInventory.Size = new System.Drawing.Size(250, 55);
            this.btnInventory.TabIndex = 7;
            this.btnInventory.Text = "      Inventory";
            this.btnInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInventory.UseVisualStyleBackColor = false;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            this.btnInventory.MouseEnter += new System.EventHandler(this.btnInventory_MouseEnter);
            this.btnInventory.MouseLeave += new System.EventHandler(this.btnInventory_MouseLeave);
            this.btnInventory.MouseHover += new System.EventHandler(this.btnInventory_MouseHover);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.White;
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSettings.FlatAppearance.BorderSize = 3;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(19)))), ((int)(((byte)(23)))));
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(0, 797);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnSettings.Size = new System.Drawing.Size(250, 55);
            this.btnSettings.TabIndex = 8;
            this.btnSettings.Text = "      Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // pnlSideBar
            // 
            this.pnlSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(19)))), ((int)(((byte)(23)))));
            this.pnlSideBar.Controls.Add(this.btnArchives);
            this.pnlSideBar.Controls.Add(this.pnlInventoryButton);
            this.pnlSideBar.Controls.Add(this.btnSettings);
            this.pnlSideBar.Controls.Add(this.panel2);
            this.pnlSideBar.Controls.Add(this.btnEmployee);
            this.pnlSideBar.Controls.Add(this.btnService);
            this.pnlSideBar.Controls.Add(this.btnDashboard);
            this.pnlSideBar.Controls.Add(this.panel1);
            this.pnlSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideBar.Location = new System.Drawing.Point(0, 40);
            this.pnlSideBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.Size = new System.Drawing.Size(250, 910);
            this.pnlSideBar.TabIndex = 2;
            // 
            // btnArchives
            // 
            this.btnArchives.BackColor = System.Drawing.Color.White;
            this.btnArchives.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArchives.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnArchives.FlatAppearance.BorderSize = 3;
            this.btnArchives.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArchives.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArchives.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(19)))), ((int)(((byte)(23)))));
            this.btnArchives.Image = ((System.Drawing.Image)(resources.GetObject("btnArchives.Image")));
            this.btnArchives.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArchives.Location = new System.Drawing.Point(0, 431);
            this.btnArchives.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnArchives.MaximumSize = new System.Drawing.Size(250, 55);
            this.btnArchives.MinimumSize = new System.Drawing.Size(250, 55);
            this.btnArchives.Name = "btnArchives";
            this.btnArchives.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnArchives.Size = new System.Drawing.Size(250, 55);
            this.btnArchives.TabIndex = 10;
            this.btnArchives.Text = "      Archives";
            this.btnArchives.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArchives.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnArchives.UseVisualStyleBackColor = false;
            this.btnArchives.Click += new System.EventHandler(this.btnArchives_Click);
            // 
            // pnlInventoryButton
            // 
            this.pnlInventoryButton.Controls.Add(this.btnToolsEquipments);
            this.pnlInventoryButton.Controls.Add(this.btnMaterials);
            this.pnlInventoryButton.Controls.Add(this.btnInventory);
            this.pnlInventoryButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInventoryButton.Location = new System.Drawing.Point(0, 376);
            this.pnlInventoryButton.MaximumSize = new System.Drawing.Size(250, 145);
            this.pnlInventoryButton.MinimumSize = new System.Drawing.Size(250, 55);
            this.pnlInventoryButton.Name = "pnlInventoryButton";
            this.pnlInventoryButton.Size = new System.Drawing.Size(250, 55);
            this.pnlInventoryButton.TabIndex = 9;
            // 
            // btnToolsEquipments
            // 
            this.btnToolsEquipments.BackColor = System.Drawing.Color.White;
            this.btnToolsEquipments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToolsEquipments.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnToolsEquipments.FlatAppearance.BorderSize = 3;
            this.btnToolsEquipments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToolsEquipments.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToolsEquipments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(19)))), ((int)(((byte)(23)))));
            this.btnToolsEquipments.Image = ((System.Drawing.Image)(resources.GetObject("btnToolsEquipments.Image")));
            this.btnToolsEquipments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnToolsEquipments.Location = new System.Drawing.Point(0, 100);
            this.btnToolsEquipments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnToolsEquipments.Name = "btnToolsEquipments";
            this.btnToolsEquipments.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnToolsEquipments.Size = new System.Drawing.Size(250, 45);
            this.btnToolsEquipments.TabIndex = 9;
            this.btnToolsEquipments.Text = "      Tools and Equipments";
            this.btnToolsEquipments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnToolsEquipments.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnToolsEquipments.UseVisualStyleBackColor = false;
            this.btnToolsEquipments.Click += new System.EventHandler(this.btnToolsEquipments_Click);
            // 
            // btnMaterials
            // 
            this.btnMaterials.BackColor = System.Drawing.Color.White;
            this.btnMaterials.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaterials.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMaterials.FlatAppearance.BorderSize = 3;
            this.btnMaterials.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaterials.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaterials.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(19)))), ((int)(((byte)(23)))));
            this.btnMaterials.Image = ((System.Drawing.Image)(resources.GetObject("btnMaterials.Image")));
            this.btnMaterials.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaterials.Location = new System.Drawing.Point(0, 55);
            this.btnMaterials.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMaterials.Name = "btnMaterials";
            this.btnMaterials.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnMaterials.Size = new System.Drawing.Size(250, 45);
            this.btnMaterials.TabIndex = 8;
            this.btnMaterials.Text = "      Materials";
            this.btnMaterials.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaterials.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMaterials.UseVisualStyleBackColor = false;
            this.btnMaterials.Click += new System.EventHandler(this.btnMaterials_Click);
            // 
            // InventoryTimer
            // 
            this.InventoryTimer.Interval = 10;
            this.InventoryTimer.Tick += new System.EventHandler(this.Inventory_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1700, 950);
            this.Controls.Add(this.pnlParent);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlSideBar);
            this.Controls.Add(this.pnlTopNav);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlTopNav.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnlSideBar.ResumeLayout(false);
            this.pnlInventoryButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopNav;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel pnlParent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnService;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Panel pnlSideBar;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlInventoryButton;
        private System.Windows.Forms.Button btnToolsEquipments;
        private System.Windows.Forms.Button btnMaterials;
        private System.Windows.Forms.Timer InventoryTimer;
        private System.Windows.Forms.Button btnArchives;
    }
}

