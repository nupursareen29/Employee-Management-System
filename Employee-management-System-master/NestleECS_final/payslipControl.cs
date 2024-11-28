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
    public partial class payslipControl : UserControl
    {
        bool printt = false;
        int g_id = 0;
        string date = "";
        string conn = "datasource=localhost;username=root;password=";
        public payslipControl()
        {
            InitializeComponent();
            makeReadOnly();
            label_date.Text = DateTime.Now.ToString("dd/MM/yyyy");

        }

        public void makeReadOnly()
        {
            idBox.ReadOnly = true;
            nameBox.ReadOnly = true;
            desBox.ReadOnly = true;
            deptBox.ReadOnly = true;

            salaryBox.ReadOnly = true;
            amedBox.ReadOnly = true;
            ahraBox.ReadOnly = true;
            ataBox.ReadOnly = true;
            payBox.ReadOnly = true;
            taxBox.ReadOnly = true;
            loanBox.ReadOnly = true;
            fundBox.ReadOnly = true;
            incentiveBox.ReadOnly = true;
            deductionBox.ReadOnly = true;
            totalBox.ReadOnly = true;
            // dateTimePicker2.ReadOnly = true;
            // remarkBox.ReadOnly = true;
        }
        public void removeReadOnly()
        {
            idBox.ReadOnly = false;
            nameBox.ReadOnly = false;
            desBox.ReadOnly = false;
            deptBox.ReadOnly = false;

            salaryBox.ReadOnly = false;
            amedBox.ReadOnly = false;
            ahraBox.ReadOnly = false;
            ataBox.ReadOnly = false;
            payBox.ReadOnly = false;
            taxBox.ReadOnly = false;
            loanBox.ReadOnly = false;
            fundBox.ReadOnly = false;
            incentiveBox.ReadOnly = false;
            deductionBox.ReadOnly = false;
            totalBox.ReadOnly = false;
            // dateTimePicker2.ReadOnly = true;
            // remarkBox.ReadOnly = false;
        }


        private void clear_all()
        {
            g_id = 0;
            removeReadOnly();
            searchBox.Text = "";

            idBox.Text = "";

            nameBox.Text = ""; desBox.Text = ""; deptBox.Text = "";
            salaryBox.Text = "";
            amedBox.Text = "";
            ahraBox.Text = "";
            ataBox.Text = "";
            payBox.Text = "";
            taxBox.Text = "";
            loanBox.Text = "";
            fundBox.Text = "";
            incentiveBox.Text = "";
            deductionBox.Text = "";
            totalBox.Text = "";

            printt = false;

            makeReadOnly();
        }



        private void clear_Click_1(object sender, EventArgs e)
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
                string query = "select emp.id,emp.name, emp.designation,emp.department,sal.salary_amount, inc.medical, inc.hra, inc.ta,   ded.advance_pay, ded.professional_tax, ded.loan, ded.professional_fund from employee.employee emp INNER JOIN employee.salary sal ON sal.employee_id = emp.id INNER JOIN employee.incentives inc ON inc.employee_id = sal.employee_id INNER JOIN  employee.deduction ded ON ded.employee_id = inc.employee_id  where emp.id = " + g_id + " ";
                //  MessageBox.Show(query);
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
                    printt = true;

                    foreach (DataRow item in dt.Rows)
                    {
                        int salary = 0;
                        double pmed = 0;
                        double phra = 0;
                        double pta = 0, amed = 0, ahra = 0, ata = 0;

                        //  idBox.ReadOnly = false;
                        idBox.Text = item[0].ToString();

                        //  idBox.ReadOnly = true;
                        nameBox.Text = item[1].ToString();



                        desBox.Text = item[2].ToString();
                        deptBox.Text = item[3].ToString();
                        salaryBox.Text = item[4].ToString();
                        if (salaryBox.Text == null || salaryBox.Text == "0" || salaryBox.Text == "")
                        {
                            MessageBox.Show("Please add basic salary first!");
                            clear_all();
                            return;
                        }
                        else
                        {
                            salary = Convert.ToInt32(salaryBox.Text);
                        }
                        try
                        {
                            pmed = Convert.ToDouble(item[5].ToString());
                            amed = (salary / 100.00) * pmed;
                            amedBox.Text = (amed).ToString();
                        }
                        catch (Exception ex)
                        {
                            amedBox.Text = "0";
                        }

                        try
                        {
                            phra = Convert.ToDouble(item[6].ToString());
                            ahra = (salary / 100.00) * phra;
                            ahraBox.Text = (ahra).ToString();
                        }
                        catch (Exception ex)
                        {
                            ahraBox.Text = "0";
                        }

                        try
                        {
                            pta = Convert.ToDouble(item[7].ToString());
                            ata = (salary / 100.00) * pta;
                            ataBox.Text = (ata).ToString();
                        }
                        catch (Exception ex)
                        {
                            amedBox.Text = "0";
                        }

                        try
                        {
                            incentiveBox.Text = (amed + ahra + ata).ToString();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            incentiveBox.Text = "0";
                        }

                        payBox.Text = item[8].ToString();
                        taxBox.Text = item[9].ToString();
                        loanBox.Text = item[10].ToString();
                        fundBox.Text = item[11].ToString();

                        try
                        {
                            deductionBox.Text = (Convert.ToDouble(payBox.Text) + Convert.ToDouble(taxBox.Text) + Convert.ToDouble(loanBox.Text) + Convert.ToDouble(fundBox.Text)).ToString();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Please fill up Incentive and Deduction in previous Pages!");
                            deductionBox.Text = "0";
                        }

                        totalBox.Text = (salary + Convert.ToDouble(incentiveBox.Text) - Convert.ToDouble(deductionBox.Text)).ToString();
                        if (salaryBox.Text == "")
                        {
                            MessageBox.Show("Please add basic salary first!");
                            return;
                        }

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


        //printing method

        private void doc_printPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(print_panel.Width, print_panel.Height, print_panel.CreateGraphics());
            print_panel.DrawToBitmap(bmp, new Rectangle(0, 0, print_panel.Width, print_panel.Height));
            RectangleF bounds = e.PageSettings.PrintableArea;
            float factor = ((float)bmp.Height / (float)bmp.Width);
            e.Graphics.DrawImage(bmp, bounds.Left, bounds.Top, bounds.Width, factor * bounds.Width);
        }


        private void button_print_Click(object sender, EventArgs e)
        {
            if (!printt)
            {
                return;
            }
            System.Drawing.Printing.PrintDocument doc = new System.Drawing.Printing.PrintDocument();
            doc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(doc_printPage);
            doc.Print();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }




    }
}
