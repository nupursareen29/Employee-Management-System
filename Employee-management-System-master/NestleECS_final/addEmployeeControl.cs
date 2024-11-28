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
    public partial class addEmployeeControl : UserControl
    {
        string gender = "";
        string conn = "datasource=localhost;username=root;password=";

        public addEmployeeControl()
        {
            InitializeComponent();

        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            int id = 0;
            if (nameBox.Text == "" || fnameBox.Text == "" || addressBox.Text == "" || mobBox.Text == "" || cityBox.Text == "" || deptBox.Text == "" || desBox.Text == "")
            {
                MessageBox.Show("Please Fillup All the Required Fields.");
                return;
            }
            try
            {
                string query = "insert into employee.employee(id,name,father_name,gender,dob,address,city, contact, designation, department, doj, remarks) values(null,'" + this.nameBox.Text + "','" + this.fnameBox.Text + "','" + gender + "','" + this.dateTimePicker1.Text + "','" + this.addressBox.Text + "','" + this.cityBox.Text + "','" + this.mobBox.Text + "','" + this.desBox.Text + "','" + this.deptBox.Text + "','" + this.dateTimePicker2.Text + "','" + this.remarkBox.Text + "'); ";

                MySqlConnection conn2 = new MySqlConnection(conn);

                //  MessageBox.Show(query);

                MySqlCommand command1 = new MySqlCommand(query, conn2);
                MySqlDataReader myReader;
                conn2.Open();
                myReader = command1.ExecuteReader();
                MessageBox.Show("Saved!");
                clear_all();
                while (myReader.Read())
                {

                }
                conn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            try
            {
                // getting last inserted id
                string cmd = "select id from employee.employee where id = LAST_INSERT_ID()";
                MySqlConnection conn3 = new MySqlConnection(conn);
                MySqlCommand command2 = new MySqlCommand(cmd, conn3);
                conn3.Open();
                var query_id = command2.ExecuteScalar();
                conn3.Close();


                string current_id = Convert.ToString(query_id);
                id = Convert.ToInt32(current_id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            try
            {
                string query_others = "insert into employee.salary(id, employee_id, salary_type,salary_amount) values(null, " + id + ", null,null ); insert into employee.bonus(id, employee_id, bonus_type,bonus_amount) values(null, " + id + ", null,null );  insert into employee.deduction(id, employee_id, advance_pay,professional_tax, loan, professional_fund) values(null, " + id + ", null,null,null,null );  insert into employee.incentives(id, employee_id, medical, hra, ta) values(null, " + id + ", null,null,null);  ";

                MySqlConnection conn4 = new MySqlConnection(conn);

                //  MessageBox.Show(query);

                MySqlCommand command3 = new MySqlCommand(query_others, conn4);
                MySqlDataReader myReader;
                conn4.Open();
                myReader = command3.ExecuteReader();
                // MessageBox.Show("Saved!");
                clear_all();
                while (myReader.Read())
                {

                }
                conn4.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }





        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }
        private void clear_all()
        {
            gender = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;

            nameBox.Text = ""; fnameBox.Text = ""; dateTimePicker1.Text = ""; addressBox.Text = ""; cityBox.Text = ""; mobBox.Text = ""; desBox.Text = ""; deptBox.Text = ""; dateTimePicker2.Text = ""; remarkBox.Text = "";
        }
        private void clear_Click(object sender, EventArgs e)
        {

            clear_all();
        }

        private void addEmployeeControl_Load(object sender, EventArgs e)
        {
            /*
            string search = "select max(employee_id) from employee.employee";
            MySqlConnection conn3 = new MySqlConnection(conn);
            MySqlCommand command2 = new MySqlCommand(search, conn3);
            conn3.Open();
            var query_id = command2.ExecuteScalar();
            conn3.Close();
            int current_id = Convert.ToInt32(query_id);
            current_id++;
            id = (current_id).ToString();
            idBox.Text = id;
             */
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
