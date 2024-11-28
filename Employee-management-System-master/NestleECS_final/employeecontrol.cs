using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using System.IO;

namespace NestleECS_final
{
    public partial class employeecontrol : UserControl
    {
        string conn = "datasource=localhost;username=root;password=";
        bool isCollapsed = true;
        int g_id = 0;

        public employeecontrol()
        {

            InitializeComponent();
            // preliControl1.BringToFront();
            //  paneldrop.BringToFront();
            paneldrop.Height = 0;
            isCollapsed = true;
        }


        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                paneldrop.Height += 15;
                if (paneldrop.Size == paneldrop.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                paneldrop.Height -= 30;
                if (paneldrop.Height == 0)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            }
        }


        private void employeecontrol_Load_1(object sender, EventArgs e)
        {

            paneldrop.BringToFront();
        }

        private void button_manage_employee_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button_Create_Click(object sender, EventArgs e)
        {
            panel_empCtrl.SendToBack();
            addEmployeeControl1.BringToFront();
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            updateEmployeeControl1.BringToFront();
            paneldrop.BringToFront();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            deleteEmployeeControl1.BringToFront();
            paneldrop.BringToFront();
        }

        private void button_basic_salary_Click(object sender, EventArgs e)
        {
            salaryControl1.BringToFront();
            paneldrop.BringToFront();
        }

        private void button_bonus_Click(object sender, EventArgs e)
        {
            bonusControl1.BringToFront();
            paneldrop.BringToFront();
        }

        private void button_incentives_Click(object sender, EventArgs e)
        {
            incentiveControl1.BringToFront();
            paneldrop.BringToFront();
        }

        private void button_deduction_Click(object sender, EventArgs e)
        {
            deductionControl1.BringToFront();
            paneldrop.BringToFront();
        }

        private void button_payslip_Click(object sender, EventArgs e)
        {
            payslipControl1.BringToFront();
            paneldrop.BringToFront();
        }

        private void button_display_Click(object sender, EventArgs e)
        {
            displayControl1.BringToFront();
            paneldrop.BringToFront();
            displayControl1.display();
        }



        //
        //      private void panel_BasicSalary_Click(object sender, EventArgs e)
        //      {
        //         
        //         
        //      }
        //
        //      private void panel_Bonus_Click(object sender, EventArgs e)
        //      {
        //          
        //          
        //      }
        //
        //      private void panel_Deduction_Click(object sender, EventArgs e)
        //      {
        //          
        //          
        //      }
        //
        //      private void panel_Incentive_Click(object sender, EventArgs e)
        //      {
        //         
        //         
        //      }
        //
        //      private void panel_Payslip_Click(object sender, EventArgs e)
        //      {
        //          
        //          
        //      }
        //            
        //      private void panel_DisplayList_Click(object sender, EventArgs e)
        //      {
        //          
        //          
        //      }
        //
        //      private void panel_CreateButton_Click(object sender, EventArgs e)
        //      {
        //          addEmployeeControl1.BringToFront();
        //          paneldrop.BringToFront();
        //      }
        //
        //      private void panel_Update_Click(object sender, EventArgs e)
        //      {
        //          
        //          
        //      }
        //
        //      private void panel_Delete_Click(object sender, EventArgs e)
        //      {
        //          
        //          
        //      }
    }
}
