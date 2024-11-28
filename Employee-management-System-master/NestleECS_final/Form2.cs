using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NestleECS_final
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            panel_Curtain.BringToFront();
            homecontrol1.BringToFront();
        }



        private void button_Home_Click(object sender, EventArgs e)
        {
            this.Text = "Home - Nestlé ECS";
            panel_Curtain.BringToFront();
            homecontrol1.BringToFront();
        }

        private void button_AdminPanel_Click(object sender, EventArgs e)
        {
            this.Text = "Admin Panel - Nestlé ECS";
            homecontrol1.SendToBack();
            panel_Curtain.BringToFront();
            admincontrol1.BringToFront();
        }

        private void button_Settings_Click(object sender, EventArgs e)
        {
            panel_Curtain.BringToFront();
            employeecontrol1.BringToFront();
            employeecontrol1.panel_empCtrl.BringToFront();
            this.Text = "Settings - Nestlé ECS";

        }

        private void button_Logout_Click(object sender, EventArgs e)
        {
            this.Text = "Logout - Nestlé ECS";
            exitControl1.BringToFront();
        }

        private void exitControl1_Load(object sender, EventArgs e)
        {

        }

    }
}
