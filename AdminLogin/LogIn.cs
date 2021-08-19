using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AdminLogin
{
    public partial class Login : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hgani\OneDrive\Documents\Users.mdf;Integrated Security=True;Connect Timeout=30";

        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
         SqlConnection sqlCon = new SqlConnection(connectionString);
         SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Login where username ='" + txtUser.Text + "' and password ='" + txtPass.Text + "'", sqlCon);
         DataTable dt = new DataTable();
         sda.Fill(dt);
         if (dt.Rows[0][0].ToString()=="1")
         {
             this.Hide();
             Profile mm = new Profile();
             mm.Show();
         } else
         {
             MessageBox.Show("Username or password is incorrect", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
         */
            /*
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT count(*) FROM Users where username ='" + txtUser.Text + "' and password ='" + txtPass.Text + "'", sqlCon);
                DataTable sqlDT = new DataTable();
                sqlDA.Fill(sqlDT);

                if (sqlDT.Rows[0][0].ToString() == "1")
                {
                    this.Hide();
                    Profile mm = new Profile();
                    mm.Show();
                }
                else
                {
                    MessageBox.Show("Username or password is incorrect", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                sqlCon.Close();
            }
            */

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                
                sqlCon.Open();
                SqlCommand sqlCom = new SqlCommand();
                sqlCom.Connection = sqlCon;
                sqlCom.CommandText = "SELECT * FROM Users";
                SqlDataReader sqlDR = sqlCom.ExecuteReader();
                if (sqlDR.Read())
                {
                    if(txtUser.Text.Equals(sqlDR["username"].ToString()) && txtPass.Text.Equals(sqlDR["password"].ToString()))
                    {
                        pnlLogin.Visible = false;
                        pnlLoggedIn.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Username or password is incorrect", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                sqlCon.Close();
            }
        }

        private void pnlLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUserPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Users userInstance = new Users();
            userInstance.Show();
        }

        private void btnProfilePage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile profileInstance = new Profile();
            profileInstance.Show();
        }
    }
}
