namespace NestleECS_final
{
    partial class employeecontrol
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(employeecontrol));
            this.label_Payslip = new System.Windows.Forms.Label();
            this.label_ManageEmployee = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_Create = new System.Windows.Forms.Label();
            this.paneldrop = new System.Windows.Forms.Panel();
            this.panel_Create = new System.Windows.Forms.Panel();
            this.button_Create = new System.Windows.Forms.Button();
            this.panel_Update = new System.Windows.Forms.Panel();
            this.button_Update = new System.Windows.Forms.Button();
            this.label_Update = new System.Windows.Forms.Label();
            this.panel_Delete = new System.Windows.Forms.Panel();
            this.button_Delete = new System.Windows.Forms.Button();
            this.label_Delete = new System.Windows.Forms.Label();
            this.panel_dislplay = new System.Windows.Forms.Panel();
            this.button_display = new System.Windows.Forms.Button();
            this.label_display = new System.Windows.Forms.Label();
            this.panel_basic_salary = new System.Windows.Forms.Panel();
            this.button_basic_salary = new System.Windows.Forms.Button();
            this.label_basic_salary = new System.Windows.Forms.Label();
            this.panel_bonus_ = new System.Windows.Forms.Panel();
            this.button_bonus = new System.Windows.Forms.Button();
            this.label_bonus_ = new System.Windows.Forms.Label();
            this.panel_incentives = new System.Windows.Forms.Panel();
            this.button_incentives = new System.Windows.Forms.Button();
            this.label_incentives = new System.Windows.Forms.Label();
            this.panel_deductions = new System.Windows.Forms.Panel();
            this.button_deduction = new System.Windows.Forms.Button();
            this.label_deductions = new System.Windows.Forms.Label();
            this.panel_payslip = new System.Windows.Forms.Panel();
            this.button_payslip = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_manage_employee = new System.Windows.Forms.Button();
            this.panel_empCtrl = new System.Windows.Forms.Panel();
            this.addEmployeeControl1 = new NestleECS_final.addEmployeeControl();
            this.updateEmployeeControl1 = new NestleECS_final.updateEmployeeControl();
            this.deleteEmployeeControl1 = new NestleECS_final.deleteEmployeeControl();
            this.salaryControl1 = new NestleECS_final.salaryControl();
            this.bonusControl1 = new NestleECS_final.bonusControl();
            this.incentiveControl1 = new NestleECS_final.incentiveControl();
            this.deductionControl1 = new NestleECS_final.deductionControl();
            this.payslipControl1 = new NestleECS_final.payslipControl();
            this.displayControl1 = new NestleECS_final.displayControl();
            this.paneldrop.SuspendLayout();
            this.panel_Create.SuspendLayout();
            this.panel_Update.SuspendLayout();
            this.panel_Delete.SuspendLayout();
            this.panel_dislplay.SuspendLayout();
            this.panel_basic_salary.SuspendLayout();
            this.panel_bonus_.SuspendLayout();
            this.panel_incentives.SuspendLayout();
            this.panel_deductions.SuspendLayout();
            this.panel_payslip.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel_empCtrl.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Payslip
            // 
            this.label_Payslip.AutoSize = true;
            this.label_Payslip.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Payslip.ForeColor = System.Drawing.Color.Black;
            this.label_Payslip.Location = new System.Drawing.Point(12, 74);
            this.label_Payslip.Name = "label_Payslip";
            this.label_Payslip.Size = new System.Drawing.Size(51, 19);
            this.label_Payslip.TabIndex = 13;
            this.label_Payslip.Text = "Payslip";
            this.label_Payslip.Click += new System.EventHandler(this.button_payslip_Click);
            // 
            // label_ManageEmployee
            // 
            this.label_ManageEmployee.AutoSize = true;
            this.label_ManageEmployee.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ManageEmployee.ForeColor = System.Drawing.Color.Black;
            this.label_ManageEmployee.Location = new System.Drawing.Point(2, 74);
            this.label_ManageEmployee.Name = "label_ManageEmployee";
            this.label_ManageEmployee.Size = new System.Drawing.Size(122, 19);
            this.label_ManageEmployee.TabIndex = 13;
            this.label_ManageEmployee.Text = "Manage Employee";
            this.label_ManageEmployee.Click += new System.EventHandler(this.button_manage_employee_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // label_Create
            // 
            this.label_Create.AutoSize = true;
            this.label_Create.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Create.Location = new System.Drawing.Point(44, 11);
            this.label_Create.Name = "label_Create";
            this.label_Create.Size = new System.Drawing.Size(38, 19);
            this.label_Create.TabIndex = 13;
            this.label_Create.Text = "Add ";
            this.label_Create.Click += new System.EventHandler(this.button_Create_Click);
            // 
            // paneldrop
            // 
            this.paneldrop.BackColor = System.Drawing.Color.Transparent;
            this.paneldrop.Controls.Add(this.panel_Create);
            this.paneldrop.Controls.Add(this.panel_Update);
            this.paneldrop.Controls.Add(this.panel_Delete);
            this.paneldrop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.paneldrop.Location = new System.Drawing.Point(46, 232);
            this.paneldrop.MaximumSize = new System.Drawing.Size(150, 150);
            this.paneldrop.Name = "paneldrop";
            this.paneldrop.Size = new System.Drawing.Size(150, 150);
            this.paneldrop.TabIndex = 12;
            // 
            // panel_Create
            // 
            this.panel_Create.BackColor = System.Drawing.Color.Honeydew;
            this.panel_Create.Controls.Add(this.button_Create);
            this.panel_Create.Controls.Add(this.label_Create);
            this.panel_Create.Location = new System.Drawing.Point(15, 8);
            this.panel_Create.Name = "panel_Create";
            this.panel_Create.Size = new System.Drawing.Size(114, 40);
            this.panel_Create.TabIndex = 14;
            // 
            // button_Create
            // 
            this.button_Create.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Create.BackgroundImage")));
            this.button_Create.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Create.FlatAppearance.BorderSize = 0;
            this.button_Create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Create.Location = new System.Drawing.Point(6, 4);
            this.button_Create.Name = "button_Create";
            this.button_Create.Size = new System.Drawing.Size(32, 32);
            this.button_Create.TabIndex = 13;
            this.button_Create.UseVisualStyleBackColor = true;
            this.button_Create.Click += new System.EventHandler(this.button_Create_Click);
            // 
            // panel_Update
            // 
            this.panel_Update.BackColor = System.Drawing.Color.Azure;
            this.panel_Update.Controls.Add(this.button_Update);
            this.panel_Update.Controls.Add(this.label_Update);
            this.panel_Update.Location = new System.Drawing.Point(15, 54);
            this.panel_Update.Name = "panel_Update";
            this.panel_Update.Size = new System.Drawing.Size(114, 40);
            this.panel_Update.TabIndex = 14;
            // 
            // button_Update
            // 
            this.button_Update.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Update.BackgroundImage")));
            this.button_Update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Update.FlatAppearance.BorderSize = 0;
            this.button_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Update.Location = new System.Drawing.Point(6, 3);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(32, 32);
            this.button_Update.TabIndex = 13;
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // label_Update
            // 
            this.label_Update.AutoSize = true;
            this.label_Update.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Update.Location = new System.Drawing.Point(44, 11);
            this.label_Update.Name = "label_Update";
            this.label_Update.Size = new System.Drawing.Size(52, 19);
            this.label_Update.TabIndex = 13;
            this.label_Update.Text = "Modify";
            this.label_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // panel_Delete
            // 
            this.panel_Delete.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel_Delete.Controls.Add(this.button_Delete);
            this.panel_Delete.Controls.Add(this.label_Delete);
            this.panel_Delete.Location = new System.Drawing.Point(15, 100);
            this.panel_Delete.Name = "panel_Delete";
            this.panel_Delete.Size = new System.Drawing.Size(114, 40);
            this.panel_Delete.TabIndex = 14;
            // 
            // button_Delete
            // 
            this.button_Delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Delete.BackgroundImage")));
            this.button_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Delete.FlatAppearance.BorderSize = 0;
            this.button_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Delete.Location = new System.Drawing.Point(6, 4);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(32, 32);
            this.button_Delete.TabIndex = 13;
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // label_Delete
            // 
            this.label_Delete.AutoSize = true;
            this.label_Delete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Delete.Location = new System.Drawing.Point(44, 10);
            this.label_Delete.Name = "label_Delete";
            this.label_Delete.Size = new System.Drawing.Size(58, 19);
            this.label_Delete.TabIndex = 13;
            this.label_Delete.Text = "Remove";
            this.label_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // panel_dislplay
            // 
            this.panel_dislplay.Controls.Add(this.button_display);
            this.panel_dislplay.Controls.Add(this.label_display);
            this.panel_dislplay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_dislplay.Location = new System.Drawing.Point(703, 132);
            this.panel_dislplay.Name = "panel_dislplay";
            this.panel_dislplay.Size = new System.Drawing.Size(92, 100);
            this.panel_dislplay.TabIndex = 14;
            // 
            // button_display
            // 
            this.button_display.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_display.BackgroundImage")));
            this.button_display.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_display.FlatAppearance.BorderSize = 0;
            this.button_display.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_display.Location = new System.Drawing.Point(15, 6);
            this.button_display.Name = "button_display";
            this.button_display.Size = new System.Drawing.Size(64, 64);
            this.button_display.TabIndex = 13;
            this.button_display.UseVisualStyleBackColor = true;
            this.button_display.Click += new System.EventHandler(this.button_display_Click);
            // 
            // label_display
            // 
            this.label_display.AutoSize = true;
            this.label_display.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_display.ForeColor = System.Drawing.Color.Black;
            this.label_display.Location = new System.Drawing.Point(13, 74);
            this.label_display.Name = "label_display";
            this.label_display.Size = new System.Drawing.Size(78, 19);
            this.label_display.TabIndex = 13;
            this.label_display.Text = "Display List";
            // 
            // panel_basic_salary
            // 
            this.panel_basic_salary.Controls.Add(this.button_basic_salary);
            this.panel_basic_salary.Controls.Add(this.label_basic_salary);
            this.panel_basic_salary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_basic_salary.Location = new System.Drawing.Point(196, 132);
            this.panel_basic_salary.Name = "panel_basic_salary";
            this.panel_basic_salary.Size = new System.Drawing.Size(101, 100);
            this.panel_basic_salary.TabIndex = 14;
            // 
            // button_basic_salary
            // 
            this.button_basic_salary.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_basic_salary.BackgroundImage")));
            this.button_basic_salary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_basic_salary.FlatAppearance.BorderSize = 0;
            this.button_basic_salary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_basic_salary.Location = new System.Drawing.Point(19, 6);
            this.button_basic_salary.Name = "button_basic_salary";
            this.button_basic_salary.Size = new System.Drawing.Size(64, 64);
            this.button_basic_salary.TabIndex = 13;
            this.button_basic_salary.UseVisualStyleBackColor = true;
            this.button_basic_salary.Click += new System.EventHandler(this.button_basic_salary_Click);
            // 
            // label_basic_salary
            // 
            this.label_basic_salary.AutoSize = true;
            this.label_basic_salary.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_basic_salary.ForeColor = System.Drawing.Color.Black;
            this.label_basic_salary.Location = new System.Drawing.Point(8, 74);
            this.label_basic_salary.Name = "label_basic_salary";
            this.label_basic_salary.Size = new System.Drawing.Size(79, 19);
            this.label_basic_salary.TabIndex = 13;
            this.label_basic_salary.Text = "Basic Salary";
            this.label_basic_salary.Click += new System.EventHandler(this.button_basic_salary_Click);
            // 
            // panel_bonus_
            // 
            this.panel_bonus_.Controls.Add(this.button_bonus);
            this.panel_bonus_.Controls.Add(this.label_bonus_);
            this.panel_bonus_.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_bonus_.Location = new System.Drawing.Point(309, 132);
            this.panel_bonus_.Name = "panel_bonus_";
            this.panel_bonus_.Size = new System.Drawing.Size(76, 100);
            this.panel_bonus_.TabIndex = 14;
            // 
            // button_bonus
            // 
            this.button_bonus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_bonus.BackgroundImage")));
            this.button_bonus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_bonus.FlatAppearance.BorderSize = 0;
            this.button_bonus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_bonus.Location = new System.Drawing.Point(6, 6);
            this.button_bonus.Name = "button_bonus";
            this.button_bonus.Size = new System.Drawing.Size(64, 64);
            this.button_bonus.TabIndex = 13;
            this.button_bonus.UseVisualStyleBackColor = true;
            this.button_bonus.Click += new System.EventHandler(this.button_bonus_Click);
            // 
            // label_bonus_
            // 
            this.label_bonus_.AutoSize = true;
            this.label_bonus_.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bonus_.ForeColor = System.Drawing.Color.Black;
            this.label_bonus_.Location = new System.Drawing.Point(13, 74);
            this.label_bonus_.Name = "label_bonus_";
            this.label_bonus_.Size = new System.Drawing.Size(47, 19);
            this.label_bonus_.TabIndex = 13;
            this.label_bonus_.Text = "Bonus";
            this.label_bonus_.Click += new System.EventHandler(this.button_bonus_Click);
            // 
            // panel_incentives
            // 
            this.panel_incentives.Controls.Add(this.button_incentives);
            this.panel_incentives.Controls.Add(this.label_incentives);
            this.panel_incentives.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_incentives.Location = new System.Drawing.Point(397, 132);
            this.panel_incentives.Name = "panel_incentives";
            this.panel_incentives.Size = new System.Drawing.Size(93, 100);
            this.panel_incentives.TabIndex = 14;
            // 
            // button_incentives
            // 
            this.button_incentives.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_incentives.BackgroundImage")));
            this.button_incentives.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_incentives.FlatAppearance.BorderSize = 0;
            this.button_incentives.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_incentives.Location = new System.Drawing.Point(14, 6);
            this.button_incentives.Name = "button_incentives";
            this.button_incentives.Size = new System.Drawing.Size(64, 64);
            this.button_incentives.TabIndex = 13;
            this.button_incentives.UseVisualStyleBackColor = true;
            this.button_incentives.Click += new System.EventHandler(this.button_incentives_Click);
            // 
            // label_incentives
            // 
            this.label_incentives.AutoSize = true;
            this.label_incentives.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_incentives.ForeColor = System.Drawing.Color.Black;
            this.label_incentives.Location = new System.Drawing.Point(13, 74);
            this.label_incentives.Name = "label_incentives";
            this.label_incentives.Size = new System.Drawing.Size(70, 19);
            this.label_incentives.TabIndex = 13;
            this.label_incentives.Text = "Incentives";
            this.label_incentives.Click += new System.EventHandler(this.button_incentives_Click);
            // 
            // panel_deductions
            // 
            this.panel_deductions.Controls.Add(this.button_deduction);
            this.panel_deductions.Controls.Add(this.label_deductions);
            this.panel_deductions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_deductions.Location = new System.Drawing.Point(502, 132);
            this.panel_deductions.Name = "panel_deductions";
            this.panel_deductions.Size = new System.Drawing.Size(101, 100);
            this.panel_deductions.TabIndex = 14;
            // 
            // button_deduction
            // 
            this.button_deduction.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_deduction.BackgroundImage")));
            this.button_deduction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_deduction.FlatAppearance.BorderSize = 0;
            this.button_deduction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_deduction.Location = new System.Drawing.Point(17, 6);
            this.button_deduction.Name = "button_deduction";
            this.button_deduction.Size = new System.Drawing.Size(64, 64);
            this.button_deduction.TabIndex = 13;
            this.button_deduction.UseVisualStyleBackColor = true;
            this.button_deduction.Click += new System.EventHandler(this.button_deduction_Click);
            // 
            // label_deductions
            // 
            this.label_deductions.AutoSize = true;
            this.label_deductions.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_deductions.ForeColor = System.Drawing.Color.Black;
            this.label_deductions.Location = new System.Drawing.Point(13, 74);
            this.label_deductions.Name = "label_deductions";
            this.label_deductions.Size = new System.Drawing.Size(72, 19);
            this.label_deductions.TabIndex = 13;
            this.label_deductions.Text = "Deduction";
            this.label_deductions.Click += new System.EventHandler(this.button_deduction_Click);
            // 
            // panel_payslip
            // 
            this.panel_payslip.Controls.Add(this.label_Payslip);
            this.panel_payslip.Controls.Add(this.button_payslip);
            this.panel_payslip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_payslip.Location = new System.Drawing.Point(615, 132);
            this.panel_payslip.Name = "panel_payslip";
            this.panel_payslip.Size = new System.Drawing.Size(76, 100);
            this.panel_payslip.TabIndex = 14;
            // 
            // button_payslip
            // 
            this.button_payslip.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_payslip.BackgroundImage")));
            this.button_payslip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_payslip.FlatAppearance.BorderSize = 0;
            this.button_payslip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_payslip.Location = new System.Drawing.Point(6, 6);
            this.button_payslip.Name = "button_payslip";
            this.button_payslip.Size = new System.Drawing.Size(64, 64);
            this.button_payslip.TabIndex = 13;
            this.button_payslip.UseVisualStyleBackColor = true;
            this.button_payslip.Click += new System.EventHandler(this.button_payslip_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label_ManageEmployee);
            this.panel2.Controls.Add(this.button_manage_employee);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Location = new System.Drawing.Point(56, 132);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(128, 100);
            this.panel2.TabIndex = 14;
            // 
            // button_manage_employee
            // 
            this.button_manage_employee.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_manage_employee.BackgroundImage")));
            this.button_manage_employee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_manage_employee.FlatAppearance.BorderSize = 0;
            this.button_manage_employee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_manage_employee.Location = new System.Drawing.Point(32, 6);
            this.button_manage_employee.Name = "button_manage_employee";
            this.button_manage_employee.Size = new System.Drawing.Size(64, 64);
            this.button_manage_employee.TabIndex = 13;
            this.button_manage_employee.UseVisualStyleBackColor = true;
            this.button_manage_employee.Click += new System.EventHandler(this.button_manage_employee_Click);
            // 
            // panel_empCtrl
            // 
            this.panel_empCtrl.Controls.Add(this.panel_bonus_);
            this.panel_empCtrl.Controls.Add(this.panel_basic_salary);
            this.panel_empCtrl.Controls.Add(this.panel_dislplay);
            this.panel_empCtrl.Controls.Add(this.panel_payslip);
            this.panel_empCtrl.Controls.Add(this.panel_deductions);
            this.panel_empCtrl.Controls.Add(this.panel2);
            this.panel_empCtrl.Controls.Add(this.panel_incentives);
            this.panel_empCtrl.Controls.Add(this.paneldrop);
            this.panel_empCtrl.Location = new System.Drawing.Point(0, 0);
            this.panel_empCtrl.Name = "panel_empCtrl";
            this.panel_empCtrl.Size = new System.Drawing.Size(860, 444);
            this.panel_empCtrl.TabIndex = 15;
            // 
            // addEmployeeControl1
            // 
            this.addEmployeeControl1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployeeControl1.Location = new System.Drawing.Point(-3, 0);
            this.addEmployeeControl1.Name = "addEmployeeControl1";
            this.addEmployeeControl1.Size = new System.Drawing.Size(860, 476);
            this.addEmployeeControl1.TabIndex = 16;
            // 
            // updateEmployeeControl1
            // 
            this.updateEmployeeControl1.Location = new System.Drawing.Point(0, 0);
            this.updateEmployeeControl1.Name = "updateEmployeeControl1";
            this.updateEmployeeControl1.Size = new System.Drawing.Size(860, 444);
            this.updateEmployeeControl1.TabIndex = 17;
            // 
            // deleteEmployeeControl1
            // 
            this.deleteEmployeeControl1.Location = new System.Drawing.Point(0, 0);
            this.deleteEmployeeControl1.Name = "deleteEmployeeControl1";
            this.deleteEmployeeControl1.Size = new System.Drawing.Size(860, 444);
            this.deleteEmployeeControl1.TabIndex = 18;
            // 
            // salaryControl1
            // 
            this.salaryControl1.Location = new System.Drawing.Point(0, 0);
            this.salaryControl1.Name = "salaryControl1";
            this.salaryControl1.Size = new System.Drawing.Size(860, 444);
            this.salaryControl1.TabIndex = 19;
            // 
            // bonusControl1
            // 
            this.bonusControl1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bonusControl1.Location = new System.Drawing.Point(0, 0);
            this.bonusControl1.Name = "bonusControl1";
            this.bonusControl1.Size = new System.Drawing.Size(860, 444);
            this.bonusControl1.TabIndex = 20;
            // 
            // incentiveControl1
            // 
            this.incentiveControl1.Location = new System.Drawing.Point(0, 0);
            this.incentiveControl1.Name = "incentiveControl1";
            this.incentiveControl1.Size = new System.Drawing.Size(860, 444);
            this.incentiveControl1.TabIndex = 21;
            // 
            // deductionControl1
            // 
            this.deductionControl1.Location = new System.Drawing.Point(0, 0);
            this.deductionControl1.Name = "deductionControl1";
            this.deductionControl1.Size = new System.Drawing.Size(860, 444);
            this.deductionControl1.TabIndex = 22;
            // 
            // payslipControl1
            // 
            this.payslipControl1.Location = new System.Drawing.Point(0, 0);
            this.payslipControl1.Name = "payslipControl1";
            this.payslipControl1.Size = new System.Drawing.Size(1292, 546);
            this.payslipControl1.TabIndex = 23;
            // 
            // displayControl1
            // 
            this.displayControl1.Location = new System.Drawing.Point(0, 0);
            this.displayControl1.Name = "displayControl1";
            this.displayControl1.Size = new System.Drawing.Size(860, 444);
            this.displayControl1.TabIndex = 24;
            // 
            // employeecontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panel_empCtrl);
            this.Controls.Add(this.displayControl1);
            this.Controls.Add(this.payslipControl1);
            this.Controls.Add(this.deductionControl1);
            this.Controls.Add(this.incentiveControl1);
            this.Controls.Add(this.bonusControl1);
            this.Controls.Add(this.salaryControl1);
            this.Controls.Add(this.deleteEmployeeControl1);
            this.Controls.Add(this.updateEmployeeControl1);
            this.Controls.Add(this.addEmployeeControl1);
            this.Location = new System.Drawing.Point(13, 106);
            this.Name = "employeecontrol";
            this.Size = new System.Drawing.Size(860, 443);
            this.Load += new System.EventHandler(this.employeecontrol_Load_1);
            this.paneldrop.ResumeLayout(false);
            this.panel_Create.ResumeLayout(false);
            this.panel_Create.PerformLayout();
            this.panel_Update.ResumeLayout(false);
            this.panel_Update.PerformLayout();
            this.panel_Delete.ResumeLayout(false);
            this.panel_Delete.PerformLayout();
            this.panel_dislplay.ResumeLayout(false);
            this.panel_dislplay.PerformLayout();
            this.panel_basic_salary.ResumeLayout(false);
            this.panel_basic_salary.PerformLayout();
            this.panel_bonus_.ResumeLayout(false);
            this.panel_bonus_.PerformLayout();
            this.panel_incentives.ResumeLayout(false);
            this.panel_incentives.PerformLayout();
            this.panel_deductions.ResumeLayout(false);
            this.panel_deductions.PerformLayout();
            this.panel_payslip.ResumeLayout(false);
            this.panel_payslip.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel_empCtrl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_ManageEmployee;
        private System.Windows.Forms.Label label_Payslip;
        private System.Windows.Forms.Label label_Create;
        private System.Windows.Forms.Panel paneldrop;
        private System.Windows.Forms.Button button_Create;
        private System.Windows.Forms.Panel panel_Create;
        private System.Windows.Forms.Panel panel_Update;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Label label_Update;
        private System.Windows.Forms.Panel panel_Delete;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Label label_Delete;
        private System.Windows.Forms.Panel panel_dislplay;
        private System.Windows.Forms.Button button_display;
        private System.Windows.Forms.Label label_display;
        private System.Windows.Forms.Panel panel_basic_salary;
        private System.Windows.Forms.Button button_basic_salary;
        private System.Windows.Forms.Label label_basic_salary;
        private System.Windows.Forms.Panel panel_bonus_;
        private System.Windows.Forms.Button button_bonus;
        private System.Windows.Forms.Label label_bonus_;
        private System.Windows.Forms.Panel panel_incentives;
        private System.Windows.Forms.Button button_incentives;
        private System.Windows.Forms.Label label_incentives;
        private System.Windows.Forms.Panel panel_deductions;
        private System.Windows.Forms.Button button_deduction;
        private System.Windows.Forms.Label label_deductions;
        private System.Windows.Forms.Panel panel_payslip;
        private System.Windows.Forms.Button button_payslip;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_manage_employee;
        private addEmployeeControl addEmployeeControl1;
        public System.Windows.Forms.Panel panel_empCtrl;
        private updateEmployeeControl updateEmployeeControl1;
        private deleteEmployeeControl deleteEmployeeControl1;
        private salaryControl salaryControl1;
        private bonusControl bonusControl1;
        private incentiveControl incentiveControl1;
        private deductionControl deductionControl1;
        private payslipControl payslipControl1;
        private displayControl displayControl1;
    }
}
