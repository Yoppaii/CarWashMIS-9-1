namespace CarWashMIS.Forms
{
    partial class frmRegisterAddOns
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegisterAddOns));
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSmall = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMedium = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtExtraLarge = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLarge = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtExtraSmall = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(217, 389);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 40);
            this.btnSave.TabIndex = 35;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 40);
            this.panel1.TabIndex = 30;
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
            this.btnClose.Location = new System.Drawing.Point(262, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(88, 40);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(36, 135);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(281, 27);
            this.txtName.TabIndex = 37;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "Add Ons Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtSmall
            // 
            this.txtSmall.Location = new System.Drawing.Point(189, 209);
            this.txtSmall.Name = "txtSmall";
            this.txtSmall.Size = new System.Drawing.Size(127, 27);
            this.txtSmall.TabIndex = 38;
            this.txtSmall.TextChanged += new System.EventHandler(this.txtSmall_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "Small";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 41;
            this.label3.Text = "Medium";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtMedium
            // 
            this.txtMedium.Location = new System.Drawing.Point(36, 277);
            this.txtMedium.Name = "txtMedium";
            this.txtMedium.Size = new System.Drawing.Size(127, 27);
            this.txtMedium.TabIndex = 40;
            this.txtMedium.TextChanged += new System.EventHandler(this.txtMedium_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 45;
            this.label4.Text = "Extra Large";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtExtraLarge
            // 
            this.txtExtraLarge.Location = new System.Drawing.Point(36, 347);
            this.txtExtraLarge.Name = "txtExtraLarge";
            this.txtExtraLarge.Size = new System.Drawing.Size(127, 27);
            this.txtExtraLarge.TabIndex = 44;
            this.txtExtraLarge.TextChanged += new System.EventHandler(this.txtExtraLarge_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(185, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 43;
            this.label5.Text = "Large";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtLarge
            // 
            this.txtLarge.Location = new System.Drawing.Point(189, 277);
            this.txtLarge.Name = "txtLarge";
            this.txtLarge.Size = new System.Drawing.Size(127, 27);
            this.txtLarge.TabIndex = 42;
            this.txtLarge.TextChanged += new System.EventHandler(this.txtLarge_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 47;
            this.label6.Text = "Extra Small";
            // 
            // txtExtraSmall
            // 
            this.txtExtraSmall.Location = new System.Drawing.Point(36, 209);
            this.txtExtraSmall.Name = "txtExtraSmall";
            this.txtExtraSmall.Size = new System.Drawing.Size(127, 27);
            this.txtExtraSmall.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(84, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 30);
            this.label7.TabIndex = 60;
            this.label7.Text = "Register Add Ons";
            // 
            // frmRegisterAddOns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 444);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtExtraSmall);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtExtraLarge);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLarge);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMedium);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSmall);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmRegisterAddOns";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRegisterService";
            this.Load += new System.EventHandler(this.frmRegisterService_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSmall;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMedium;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtExtraLarge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLarge;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtExtraSmall;
        private System.Windows.Forms.Label label7;
    }
}