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
    public partial class incentiveControl : UserControl
    {
        int g_id = 0;
        string conn = "datasource=localhost;username=root;password=";
        public incentiveControl()
        {
            InitializeComponent();
            makeReadOnly();
        }


        public void makeReadOnly()
        {
            idBox.ReadOnly = true;
            nameBox.ReadOnly = true;
            desBox.ReadOnly = true;
            deptBox.ReadOnly = true;
            // dateTimePicker2.ReadOnly = true;
            remarkBox.ReadOnly = true;
            salaryBox.ReadOnly = true;
            amedBox.ReadOnly = true;
            ahraBox.ReadOnly = true;
            ataBox.ReadOnly = true;
        }
        public void removeReadOnly()
        {
            idBox.ReadOnly = false;
            nameBox.ReadOnly = false;
            desBox.ReadOnly = false;
            deptBox.ReadOnly = false;
            // dateTimePicker2.ReadOnly = true;
            remarkBox.ReadOnly = false;
            salaryBox.ReadOnly = false;
            amedBox.ReadOnly = false; ;
            ahraBox.ReadOnly = false;
            ataBox.ReadOnly = false;
        }


        private void clear_all()
        {
            g_id = 0;
            removeReadOnly();
            searchBox.Text = "";

            idBox.Text = "";

            nameBox.Text = ""; desBox.Text = ""; deptBox.Text = ""; dateTimePicker2.Text = ""; remarkBox.Text = "";
            salaryBox.Text = "";
            pmedBox.Text = "";
            amedBox.Text = "";
            phraBox.Text = "";
            ahraBox.Text = "";
            ptaBox.Text = "";
            ataBox.Text = "";

            makeReadOnly();
        }

        /*  public double parcentage(double amount,int salary)
          {
              return amount * 100.00 / salary;
          }
         * */

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
                string query = "select emp.id,emp.name, emp.designation,emp.department,emp.doj, sal.salary_amount, emp.remarks,  inc.medical, inc.hra, inc.ta from employee.employee emp INNER JOIN employee.salary sal ON sal.employee_id = emp.id INNER JOIN employee.incentives  inc ON inc.employee_id = sal.employee_id where emp.id = " + g_id + " ";
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
                        salaryBox.Text = item[5].ToString();
                        remarkBox.Text = item[6].ToString();
                        pmedBox.Text = item[7].ToString();
                        phraBox.Text = item[8].ToString();
                        ptaBox.Text = item[9].ToString();

                    }
                    try
                    {

                        /*  if (amedBox.Text == null || amedBox.Text == "" || salaryBox.Text == null || salaryBox.Text == "0" || salaryBox.Text == "")
                          {
                              amedBox.Text = "0";
                              pmedBox.Text = "0";
                          }
                          else
                          {
                              double parcnt = parcentage((Convert.ToDouble(amedBox.Text)), (Convert.ToInt32(salaryBox.Text)));
                              pmedBox.Text = parcnt.ToString();
                          }
                          if (ahraBox.Text == null || ahraBox.Text == "" || salaryBox.Text == null || salaryBox.Text == "0" || salaryBox.Text == "")
                          {
                              ahraBox.Text = "0";
                              phraBox.Text = "0";
                          }
                          else
                          {
                              double parcnt = parcentage((Convert.ToDouble(ahraBox.Text)), (Convert.ToInt32(salaryBox.Text)));
                              phraBox.Text = parcnt.ToString();
                          }
                          if (ataBox.Text == null || ataBox.Text == "" || salaryBox.Text == null || salaryBox.Text == "0" || salaryBox.Text == "")
                          {
                              ataBox.Text = "0";
                              ptaBox.Text = "0";
                          }
                          else
                          {
                              double parcnt = parcentage((Convert.ToDouble(ataBox.Text)), (Convert.ToInt32(salaryBox.Text)));
                              ptaBox.Text = parcnt.ToString();
                          }
                          */

                        amount();


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(amedBox.Text + " " + pmedBox.Text);
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

                string query_bonus = "update  employee.incentives set medical = '" + this.pmedBox.Text + "' ,hra = '" + this.phraBox.Text + "',ta = '" + this.ptaBox.Text + "'  where employee_id = " + g_id + " ";
                g_id = 0;
                MySqlConnection conn3 = new MySqlConnection(conn);

                //  MessageBox.Show(query_bonus);

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

        public void amount()
        {
            removeReadOnly();
            if (salaryBox.Text == null || salaryBox.Text == "0" || salaryBox.Text == "")
            {
                MessageBox.Show("Salary is Not set or Zero!");
                return;
            }
            int salary = Convert.ToInt32(salaryBox.Text);
            if (pmedBox.Text == null || pmedBox.Text == "")
            {
                pmedBox.Text = "0";
                amedBox.Text = "0";
            }
            else
            {
                amedBox.Text = ((salary / 100.00) * (Convert.ToDouble(pmedBox.Text))).ToString();
            }
            if (phraBox.Text == null || phraBox.Text == "")
            {
                phraBox.Text = "0";
                ahraBox.Text = "0";
            }
            else
            {
                ahraBox.Text = ((salary / 100.00) * (Convert.ToDouble(phraBox.Text))).ToString();
            }
            if (ptaBox.Text == null || ptaBox.Text == "")
            {
                ptaBox.Text = "0";
                ataBox.Text = "0";
            }
            else
            {
                ataBox.Text = ((salary / 100.00) * (Convert.ToDouble(ptaBox.Text))).ToString();
            }
            makeReadOnly();
        }

        private void button_calculate_Click(object sender, EventArgs e)
        {
            amount();
        }
    }
}
