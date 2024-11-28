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
    public partial class updateEmployeeControl : UserControl
    {
        int g_id = 0;
        string gender = "";
        string conn = "datasource=localhost;username=root;password=";
        public updateEmployeeControl()
        {

            InitializeComponent();
            idBox.ReadOnly = true;


        }




        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            if (nameBox.Text == "" || fnameBox.Text == "" || addressBox.Text == "" || mobBox.Text == "" || cityBox.Text == "" || deptBox.Text == "" || desBox.Text == "")
            {
                MessageBox.Show("Please Fillup All the Required Fields.");
                return;
            }
            try
            {

                string query_update = "update  employee.employee set name = '" + this.nameBox.Text + "' ,father_name = '" + this.fnameBox.Text + "' ,gender = '" + gender + "',dob = '" + this.dateTimePicker1.Text + "',address = '" + this.addressBox.Text + "',city = '" + this.cityBox.Text + "', contact = '" + this.mobBox.Text + "', designation = '" + this.desBox.Text + "', department = '" + this.deptBox.Text + "', doj = '" + this.dateTimePicker2.Text + "', remarks = '" + this.remarkBox.Text + "' where id = " + g_id + " ";
                g_id = 0;
                MySqlConnection conn3 = new MySqlConnection(conn);

                //  MessageBox.Show(query_update);

                MySqlCommand command1 = new MySqlCommand(query_update, conn3);
                MySqlDataReader myReader;
                conn3.Open();
                myReader = command1.ExecuteReader();
                MessageBox.Show("Updated!");
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
        private void clear_all()
        {
            g_id = 0;
            searchBox.Text = "";
            gender = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            idBox.ReadOnly = false;
            idBox.Text = "";
            idBox.ReadOnly = true;

            nameBox.Text = ""; fnameBox.Text = ""; dateTimePicker1.Text = ""; addressBox.Text = ""; cityBox.Text = ""; mobBox.Text = ""; desBox.Text = ""; deptBox.Text = ""; dateTimePicker2.Text = ""; remarkBox.Text = "";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            clear_all();
        }

        private void button1_Click(object sender, EventArgs e)
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
            try
            {
                string query = "select * from employee.employee where id = '" + g_id + "' ";
                // g_id = 0;
                MySqlConnection conn2 = new MySqlConnection(conn);
                MySqlDataAdapter sda = new MySqlDataAdapter(query, conn2);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No result found!");
                    clear_all();
                    return;
                }
                if (dt.Rows.Count == 1)
                {

                    foreach (DataRow item in dt.Rows)
                    {
                        idBox.ReadOnly = false;
                        idBox.Text = item[0].ToString();

                        idBox.ReadOnly = true;
                        nameBox.Text = item[1].ToString();
                        fnameBox.Text = item[2].ToString();
                        if (item[3].ToString() == "Male")
                        {
                            radioButton1.Checked = true;
                            radioButton2.Checked = false;
                        }
                        else
                        {
                            radioButton1.Checked = false;
                            radioButton2.Checked = true;
                        }
                        dateTimePicker1.Text = item[4].ToString();
                        addressBox.Text = item[5].ToString();
                        cityBox.Text = item[6].ToString();
                        mobBox.Text = item[7].ToString();
                        desBox.Text = item[8].ToString();
                        deptBox.Text = item[9].ToString();
                        dateTimePicker2.Text = item[10].ToString();
                        remarkBox.Text = item[11].ToString();
                    }
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
    }
}
