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
using System.Security.Cryptography;

namespace NestleECS_final
{
    public partial class admincontrol1 : UserControl
    {
        string conn = "datasource=localhost;username=root;password=";
        public admincontrol1()
        {
            InitializeComponent();
        }

        private string exist()
        {
            string query_select = "select id from employee.login  where username ='" + this.namebox.Text + "' ";
            // squery = query_select;

            string conn = "datasource=localhost;username=root;password=";
            MySqlConnection conn2 = new MySqlConnection(conn);
            MySqlCommand command1 = new MySqlCommand(query_select, conn2);
            conn2.Open();
            var query_id = command1.ExecuteScalar();
            conn2.Close();
            string id = Convert.ToString(query_id);
            //   MessageBox.Show("id is :"+id);
            return id;
        }
        bool empty_check()
        {
            if (namebox.Text == "" || passbox.Text == "")
            {
                return true;
            }
            else
                return false;

        }
        public void clear_all()
        {
            namebox.Text = "";
            passbox.Text = "";
        }

        private void panel_DeleteUser_Click(object sender, EventArgs e)
        {
            if (empty_check())
            {
                MessageBox.Show("Please fill up all the fields!");
                return;
            }
            string id = exist();
            if (id == "" || id == null)
            {
                MessageBox.Show("Username not found!");
                return;
            }
            DialogResult result1 = MessageBox.Show("Are you sure ? ", "Warning!", MessageBoxButtons.OKCancel);
            if (result1 == DialogResult.Cancel)
            {
                return;
            }
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);
            var pbkdf2 = new Rfc2898DeriveBytes(passbox.Text, salt, 10000);
            byte[] hash = pbkdf2.GetBytes(20);
            byte[] hashbytes = new byte[36];
            Array.Copy(salt, 0, hashbytes, 0, 16);
            Array.Copy(hash, 0, hashbytes, 16, 20);
            string savedPasswordHash = Convert.ToBase64String(hashbytes);


            MySqlConnection conn2 = new MySqlConnection(conn);
            string query = "delete from employee.login   where id = '" + id + "'  ";
            MySqlCommand command1 = new MySqlCommand(query, conn2);
            MySqlDataReader myReader;
            conn2.Open();
            myReader = command1.ExecuteReader();
            MessageBox.Show("User deleted!");
            clear_all();

            while (myReader.Read())
            {

            }
            conn2.Close();
        }

        private void panel_CreateUser_Click(object sender, EventArgs e)
        {
            if (empty_check())
            {
                MessageBox.Show("Please fill up all the fields!");
                return;
            }
            string id = exist();
            if (id != "")
            {
                MessageBox.Show("Username Exists!");
                return;
            }
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);
            var pbkdf2 = new Rfc2898DeriveBytes(passbox.Text, salt, 10000);
            byte[] hash = pbkdf2.GetBytes(20);
            byte[] hashbytes = new byte[36];
            Array.Copy(salt, 0, hashbytes, 0, 16);
            Array.Copy(hash, 0, hashbytes, 16, 20);
            string savedPasswordHash = Convert.ToBase64String(hashbytes);


            MySqlConnection conn2 = new MySqlConnection(conn);
            string query = "Insert into employee.login (id, username, password) values (null, '" + namebox.Text + "', '" + savedPasswordHash + "' ) ";
            MySqlCommand command1 = new MySqlCommand(query, conn2);
            MySqlDataReader myReader;
            conn2.Open();
            myReader = command1.ExecuteReader();
            MessageBox.Show("Entry Saved!");
            clear_all();

            while (myReader.Read())
            {

            }
            conn2.Close();
        }

        private void panel_UpPaswd_Click(object sender, EventArgs e)
        {
            if (empty_check())
            {
                MessageBox.Show("Please fill up all the fields!");
                return;
            }
            string id = exist();
            if (id == "" || id == null)
            {
                MessageBox.Show("Username not found!");
                return;
            }
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);
            var pbkdf2 = new Rfc2898DeriveBytes(passbox.Text, salt, 10000);
            byte[] hash = pbkdf2.GetBytes(20);
            byte[] hashbytes = new byte[36];
            Array.Copy(salt, 0, hashbytes, 0, 16);
            Array.Copy(hash, 0, hashbytes, 16, 20);
            string savedPasswordHash = Convert.ToBase64String(hashbytes);


            MySqlConnection conn2 = new MySqlConnection(conn);
            string query = "update employee.login set password = '" + savedPasswordHash + "' where id = '" + id + "'  ";
            MySqlCommand command1 = new MySqlCommand(query, conn2);
            MySqlDataReader myReader;
            conn2.Open();
            myReader = command1.ExecuteReader();
            MessageBox.Show("User updated!");
            clear_all();

            while (myReader.Read())
            {

            }
            conn2.Close();

        }


    }
}
