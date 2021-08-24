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
    public partial class Users : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hgani\Documents\Users.mdf;Integrated Security=True;Connect Timeout=30";
        public Users()
        {
            InitializeComponent();

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


            /*
            this.Hide();
            Users userInstance = new Users();
            userInstance.Show();
            */
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                if (txtSearch.Text == "")
                {
                    SqlDataAdapter sqlDA = new SqlDataAdapter(
                        "SELECT Username, IsAdmin, Name, Surname, Number " +
                        "FROM Users", sqlCon);
                    DataTable sqlDT = new DataTable();
                    sqlDA.Fill(sqlDT);
                    dgvUsers.DataSource = sqlDT;

                } else
                {
                    SqlDataAdapter sqlDA = new SqlDataAdapter(
                    "SELECT Username, IsAdmin, Name, Surname, Number " +
                    "FROM Users WHERE Username ='" + txtSearch.Text +
                    "' or Name ='" + txtSearch.Text +
                    "' or Surname ='" + txtSearch.Text +
                    "' or Number ='" + txtSearch.Text + "'",
                    sqlCon);
                    DataTable sqlDT = new DataTable();
                    sqlDA.Fill(sqlDT);
                    dgvUsers.DataSource = sqlDT;
                }


                sqlCon.Close();
            }
        }
    }
}
