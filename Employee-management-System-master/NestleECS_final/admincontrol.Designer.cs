namespace NestleECS_final
{
    partial class admincontrol1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admincontrol1));
            this.namebox = new System.Windows.Forms.TextBox();
            this.passbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox_CreateUser = new System.Windows.Forms.PictureBox();
            this.label_CreateUser = new System.Windows.Forms.Label();
            this.panel_CreateUser = new System.Windows.Forms.Panel();
            this.panel_DeleteUser = new System.Windows.Forms.Panel();
            this.pictureBox_DeleteUser = new System.Windows.Forms.PictureBox();
            this.label_DeleteUser = new System.Windows.Forms.Label();
            this.panel_UpPaswd = new System.Windows.Forms.Panel();
            this.pictureBox_UpPaswd = new System.Windows.Forms.PictureBox();
            this.label_UpPaswd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CreateUser)).BeginInit();
            this.panel_CreateUser.SuspendLayout();
            this.panel_DeleteUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_DeleteUser)).BeginInit();
            this.panel_UpPaswd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_UpPaswd)).BeginInit();
            this.SuspendLayout();
            // 
            // namebox
            // 
            this.namebox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.namebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.namebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namebox.Location = new System.Drawing.Point(17, 51);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(186, 30);
            this.namebox.TabIndex = 2;
            // 
            // passbox
            // 
            this.passbox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.passbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passbox.Location = new System.Drawing.Point(220, 51);
            this.passbox.Name = "passbox";
            this.passbox.PasswordChar = '*';
            this.passbox.Size = new System.Drawing.Size(180, 30);
            this.passbox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label3.Location = new System.Drawing.Point(272, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label2.Location = new System.Drawing.Point(68, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username";
            // 
            // pictureBox_CreateUser
            // 
            this.pictureBox_CreateUser.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_CreateUser.Image")));
            this.pictureBox_CreateUser.Location = new System.Drawing.Point(15, 3);
            this.pictureBox_CreateUser.Name = "pictureBox_CreateUser";
            this.pictureBox_CreateUser.Size = new System.Drawing.Size(64, 64);
            this.pictureBox_CreateUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_CreateUser.TabIndex = 3;
            this.pictureBox_CreateUser.TabStop = false;
            this.pictureBox_CreateUser.Click += new System.EventHandler(this.panel_CreateUser_Click);
            // 
            // label_CreateUser
            // 
            this.label_CreateUser.AutoSize = true;
            this.label_CreateUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CreateUser.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label_CreateUser.Location = new System.Drawing.Point(2, 70);
            this.label_CreateUser.Name = "label_CreateUser";
            this.label_CreateUser.Size = new System.Drawing.Size(91, 21);
            this.label_CreateUser.TabIndex = 4;
            this.label_CreateUser.Text = "Create User";
            this.label_CreateUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_CreateUser.Click += new System.EventHandler(this.panel_CreateUser_Click);
            // 
            // panel_CreateUser
            // 
            this.panel_CreateUser.Controls.Add(this.pictureBox_CreateUser);
            this.panel_CreateUser.Controls.Add(this.label_CreateUser);
            this.panel_CreateUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_CreateUser.Location = new System.Drawing.Point(16, 140);
            this.panel_CreateUser.Name = "panel_CreateUser";
            this.panel_CreateUser.Size = new System.Drawing.Size(95, 100);
            this.panel_CreateUser.TabIndex = 5;
            this.panel_CreateUser.Click += new System.EventHandler(this.panel_CreateUser_Click);
            // 
            // panel_DeleteUser
            // 
            this.panel_DeleteUser.Controls.Add(this.pictureBox_DeleteUser);
            this.panel_DeleteUser.Controls.Add(this.label_DeleteUser);
            this.panel_DeleteUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_DeleteUser.Location = new System.Drawing.Point(304, 140);
            this.panel_DeleteUser.Name = "panel_DeleteUser";
            this.panel_DeleteUser.Size = new System.Drawing.Size(95, 100);
            this.panel_DeleteUser.TabIndex = 5;
            this.panel_DeleteUser.Click += new System.EventHandler(this.panel_DeleteUser_Click);
            // 
            // pictureBox_DeleteUser
            // 
            this.pictureBox_DeleteUser.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_DeleteUser.Image")));
            this.pictureBox_DeleteUser.Location = new System.Drawing.Point(15, 3);
            this.pictureBox_DeleteUser.Name = "pictureBox_DeleteUser";
            this.pictureBox_DeleteUser.Size = new System.Drawing.Size(64, 64);
            this.pictureBox_DeleteUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_DeleteUser.TabIndex = 3;
            this.pictureBox_DeleteUser.TabStop = false;
            this.pictureBox_DeleteUser.Click += new System.EventHandler(this.panel_DeleteUser_Click);
            // 
            // label_DeleteUser
            // 
            this.label_DeleteUser.AutoSize = true;
            this.label_DeleteUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DeleteUser.ForeColor = System.Drawing.Color.DarkRed;
            this.label_DeleteUser.Location = new System.Drawing.Point(2, 70);
            this.label_DeleteUser.Name = "label_DeleteUser";
            this.label_DeleteUser.Size = new System.Drawing.Size(90, 21);
            this.label_DeleteUser.TabIndex = 4;
            this.label_DeleteUser.Text = "Delete User";
            this.label_DeleteUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_DeleteUser.Click += new System.EventHandler(this.panel_DeleteUser_Click);
            // 
            // panel_UpPaswd
            // 
            this.panel_UpPaswd.Controls.Add(this.pictureBox_UpPaswd);
            this.panel_UpPaswd.Controls.Add(this.label_UpPaswd);
            this.panel_UpPaswd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_UpPaswd.Location = new System.Drawing.Point(141, 140);
            this.panel_UpPaswd.Name = "panel_UpPaswd";
            this.panel_UpPaswd.Size = new System.Drawing.Size(135, 100);
            this.panel_UpPaswd.TabIndex = 5;
            this.panel_UpPaswd.Click += new System.EventHandler(this.panel_UpPaswd_Click);
            // 
            // pictureBox_UpPaswd
            // 
            this.pictureBox_UpPaswd.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_UpPaswd.Image")));
            this.pictureBox_UpPaswd.Location = new System.Drawing.Point(35, 3);
            this.pictureBox_UpPaswd.Name = "pictureBox_UpPaswd";
            this.pictureBox_UpPaswd.Size = new System.Drawing.Size(64, 64);
            this.pictureBox_UpPaswd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_UpPaswd.TabIndex = 3;
            this.pictureBox_UpPaswd.TabStop = false;
            this.pictureBox_UpPaswd.Click += new System.EventHandler(this.panel_UpPaswd_Click);
            // 
            // label_UpPaswd
            // 
            this.label_UpPaswd.AutoSize = true;
            this.label_UpPaswd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_UpPaswd.ForeColor = System.Drawing.Color.DarkGreen;
            this.label_UpPaswd.Location = new System.Drawing.Point(2, 70);
            this.label_UpPaswd.Name = "label_UpPaswd";
            this.label_UpPaswd.Size = new System.Drawing.Size(130, 21);
            this.label_UpPaswd.TabIndex = 4;
            this.label_UpPaswd.Text = "Update Password";
            this.label_UpPaswd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_UpPaswd.Click += new System.EventHandler(this.panel_UpPaswd_Click);
            // 
            // admincontrol1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_UpPaswd);
            this.Controls.Add(this.panel_DeleteUser);
            this.Controls.Add(this.panel_CreateUser);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.passbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "admincontrol1";
            this.Size = new System.Drawing.Size(420, 276);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CreateUser)).EndInit();
            this.panel_CreateUser.ResumeLayout(false);
            this.panel_CreateUser.PerformLayout();
            this.panel_DeleteUser.ResumeLayout(false);
            this.panel_DeleteUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_DeleteUser)).EndInit();
            this.panel_UpPaswd.ResumeLayout(false);
            this.panel_UpPaswd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_UpPaswd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.TextBox passbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox_CreateUser;
        private System.Windows.Forms.Label label_CreateUser;
        private System.Windows.Forms.Panel panel_CreateUser;
        private System.Windows.Forms.Panel panel_DeleteUser;
        private System.Windows.Forms.PictureBox pictureBox_DeleteUser;
        private System.Windows.Forms.Label label_DeleteUser;
        private System.Windows.Forms.Panel panel_UpPaswd;
        private System.Windows.Forms.PictureBox pictureBox_UpPaswd;
        private System.Windows.Forms.Label label_UpPaswd;
    }
}
