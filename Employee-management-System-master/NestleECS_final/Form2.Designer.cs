namespace NestleECS_final
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_Title = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button_Home = new System.Windows.Forms.Button();
            this.button_Logout = new System.Windows.Forms.Button();
            this.button_AdminPanel = new System.Windows.Forms.Button();
            this.button_Settings = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel_Curtain = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.employeecontrol1 = new NestleECS_final.employeecontrol();
            this.homecontrol1 = new NestleECS_final.homecontrol();
            this.admincontrol1 = new NestleECS_final.admincontrol1();
            this.exitControl1 = new NestleECS_final.exitControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel_Curtain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Calibri", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label_Title.Location = new System.Drawing.Point(178, 30);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(334, 37);
            this.label_Title.TabIndex = 1;
            this.label_Title.Text = "Employee Control System";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label_Title);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(884, 99);
            this.panel2.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button_Home);
            this.panel4.Controls.Add(this.button_Logout);
            this.panel4.Controls.Add(this.button_AdminPanel);
            this.panel4.Controls.Add(this.button_Settings);
            this.panel4.Location = new System.Drawing.Point(637, 15);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(235, 67);
            this.panel4.TabIndex = 2;
            // 
            // button_Home
            // 
            this.button_Home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Home.BackgroundImage")));
            this.button_Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Home.FlatAppearance.BorderSize = 0;
            this.button_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Home.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Home.Location = new System.Drawing.Point(9, 6);
            this.button_Home.Name = "button_Home";
            this.button_Home.Size = new System.Drawing.Size(50, 50);
            this.button_Home.TabIndex = 1;
            this.button_Home.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_Home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.button_Home, "Home");
            this.button_Home.UseVisualStyleBackColor = true;
            this.button_Home.Click += new System.EventHandler(this.button_Home_Click);
            // 
            // button_Logout
            // 
            this.button_Logout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Logout.BackgroundImage")));
            this.button_Logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Logout.FlatAppearance.BorderSize = 0;
            this.button_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Logout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Logout.Location = new System.Drawing.Point(180, 6);
            this.button_Logout.Name = "button_Logout";
            this.button_Logout.Size = new System.Drawing.Size(50, 50);
            this.button_Logout.TabIndex = 1;
            this.button_Logout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_Logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.button_Logout, "Logout");
            this.button_Logout.UseVisualStyleBackColor = true;
            this.button_Logout.Click += new System.EventHandler(this.button_Logout_Click);
            // 
            // button_AdminPanel
            // 
            this.button_AdminPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_AdminPanel.BackgroundImage")));
            this.button_AdminPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_AdminPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_AdminPanel.FlatAppearance.BorderSize = 0;
            this.button_AdminPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AdminPanel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AdminPanel.Location = new System.Drawing.Point(66, 6);
            this.button_AdminPanel.Name = "button_AdminPanel";
            this.button_AdminPanel.Size = new System.Drawing.Size(50, 50);
            this.button_AdminPanel.TabIndex = 1;
            this.button_AdminPanel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_AdminPanel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.button_AdminPanel, "Admin Panel");
            this.button_AdminPanel.UseVisualStyleBackColor = true;
            this.button_AdminPanel.Click += new System.EventHandler(this.button_AdminPanel_Click);
            // 
            // button_Settings
            // 
            this.button_Settings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Settings.BackgroundImage")));
            this.button_Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Settings.FlatAppearance.BorderSize = 0;
            this.button_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Settings.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Settings.Location = new System.Drawing.Point(123, 6);
            this.button_Settings.Name = "button_Settings";
            this.button_Settings.Size = new System.Drawing.Size(50, 50);
            this.button_Settings.TabIndex = 1;
            this.button_Settings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_Settings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.button_Settings, "Employee Control");
            this.button_Settings.UseVisualStyleBackColor = true;
            this.button_Settings.Click += new System.EventHandler(this.button_Settings_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Location = new System.Drawing.Point(-14, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(908, 4);
            this.panel3.TabIndex = 0;
            // 
            // panel_Curtain
            // 
            this.panel_Curtain.BackColor = System.Drawing.SystemColors.Control;
            this.panel_Curtain.Controls.Add(this.panel1);
            this.panel_Curtain.Location = new System.Drawing.Point(-4, 89);
            this.panel_Curtain.Name = "panel_Curtain";
            this.panel_Curtain.Size = new System.Drawing.Size(900, 470);
            this.panel_Curtain.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Location = new System.Drawing.Point(-2, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(910, 4);
            this.panel1.TabIndex = 0;
            // 
            // employeecontrol1
            // 
            this.employeecontrol1.BackColor = System.Drawing.SystemColors.Control;
            this.employeecontrol1.Location = new System.Drawing.Point(11, 108);
            this.employeecontrol1.Name = "employeecontrol1";
            this.employeecontrol1.Size = new System.Drawing.Size(860, 444);
            this.employeecontrol1.TabIndex = 1;
            // 
            // homecontrol1
            // 
            this.homecontrol1.Location = new System.Drawing.Point(297, 124);
            this.homecontrol1.Name = "homecontrol1";
            this.homecontrol1.Size = new System.Drawing.Size(291, 349);
            this.homecontrol1.TabIndex = 4;
            // 
            // admincontrol1
            // 
            this.admincontrol1.Location = new System.Drawing.Point(238, 127);
            this.admincontrol1.Name = "admincontrol1";
            this.admincontrol1.Size = new System.Drawing.Size(420, 249);
            this.admincontrol1.TabIndex = 5;
            // 
            // exitControl1
            // 
            this.exitControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.exitControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.exitControl1.Location = new System.Drawing.Point(290, 197);
            this.exitControl1.Name = "exitControl1";
            this.exitControl1.Size = new System.Drawing.Size(333, 193);
            this.exitControl1.TabIndex = 7;
            this.exitControl1.Load += new System.EventHandler(this.exitControl1_Load);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.panel_Curtain);
            this.Controls.Add(this.employeecontrol1);
            this.Controls.Add(this.homecontrol1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.admincontrol1);
            this.Controls.Add(this.exitControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Control System - Nestlé";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel_Curtain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Panel panel2;
        private admincontrol1 admincontrol1;
        private homecontrol homecontrol1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_Home;
        private System.Windows.Forms.Button button_AdminPanel;
        private System.Windows.Forms.Button button_Settings;
        private System.Windows.Forms.Button button_Logout;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ToolTip toolTip1;
        private employeecontrol employeecontrol1;
        private exitControl exitControl1;
        private System.Windows.Forms.Panel panel_Curtain;
    }
}