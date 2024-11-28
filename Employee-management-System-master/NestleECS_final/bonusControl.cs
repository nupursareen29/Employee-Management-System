using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace NestleECS_final
{
    public partial class bonusControl : UserControl
    {
        int g_id = 0;
        string conn = "datasource=localhost;username=root;password=";
        public bonusControl()
        {
            InitializeComponent();
        }

        public void makeReadOnly()
        {
            idBox.ReadOnly = true;
            nameBox.ReadOnly = true;
            desBox.ReadOnly = true;
            deptBox.ReadOnly = true;
            // dateTimePicker2.ReadOnly = true;
            remarkBox.ReadOnly = true;
        }
        public void removeReadOnly()
        {
            idBox.ReadOnly = false;
            nameBox.ReadOnly = false;
            desBox.ReadOnly = false;
            deptBox.ReadOnly = false;
            // dateTimePicker2.ReadOnly = true;
            remarkBox.ReadOnly = false;
        }


        private void clear_all()
        {
            g_id = 0;
            removeReadOnly();
            searchBox.Text = "";

            idBox.Text = "";

            nameBox.Text = ""; desBox.Text = ""; deptBox.Text = ""; dateTimePicker2.Text = ""; remarkBox.Text = "";
            bonusBox.Text = "";
            comboBox1.SelectedIndex = -1;
            makeReadOnly();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            clear_all();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                g_id = Convert.ToInt32(searchBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            if (g_id == 0)
            {
                MessageBox.Show("Please Input Valid ID");
                return;
            }
            try
            {
                string query = "select emp.id,emp.name, emp.designation,emp.department,emp.doj, emp.remarks,  bo.bonus_type, bo.bonus_amount from employee.employee emp INNER JOIN employee.bonus bo ON bo.employee_id = emp.id where emp.id = " + g_id + " ";
                // MessageBox.Show(query);
                // g_id = 0;
                MySqlConnection conn2 = new MySqlConnection(conn);
                MySqlDataAdapter sda = new MySqlDataAdapter(query, conn2);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No result found!");
                    return;
                }
                if (dt.Rows.Count == 1)
                {
                    removeReadOnly();

                    foreach (DataRow item in dt.Rows)
                    {

                        //  idBox.ReadOnly = false;
                        idBox.Text = item[0].ToString();

                        //  idBox.ReadOnly = true;
                        nameBox.Text = item[1].ToString();



                        desBox.Text = item[2].ToString();
                        deptBox.Text = item[3].ToString();
                        dateTimePicker2.Text = item[4].ToString();
                        remarkBox.Text = item[5].ToString();
                        comboBox1.Text = item[6].ToString();
                        bonusBox.Text = item[7].ToString();
                    }
                    makeReadOnly();
                }
                else
                {
                    MessageBox.Show("Returns more than one row");
                    return;
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);

            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (idBox.Text == "")
            {
                MessageBox.Show("Please Insert Employee ID First.");
                return;
            }
            try
            {

                string query_bonus = "update  employee.bonus set bonus_type = '" + this.comboBox1.Text + "' ,bonus_amount = '" + this.bonusBox.Text + "'  where employee_id = " + g_id + " ";
                g_id = 0;
                MySqlConnection conn3 = new MySqlConnection(conn);

                // MessageBox.Show(query_bonus);

                MySqlCommand command1 = new MySqlCommand(query_bonus, conn3);
                MySqlDataReader myReader;
                conn3.Open();
                myReader = command1.ExecuteReader();
                MessageBox.Show("Saved!");
                clear_all();

                while (myReader.Read())
                {

                }
                conn3.Close();

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
    }
}
