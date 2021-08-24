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
    public partial class AdminLoginF : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hgani\Documents\Users.mdf;Integrated Security=True;Connect Timeout=30";

        public AdminLoginF()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
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
                        txtPass.Text = "";
                        loadPage("Menu");
                    }
                    else
                    {
                        lblError.Text = "Username or password is incorrect";
                        lblError.Visible = true;
                        //MessageBox.Show("Username or password is incorrect", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            loadPage("Users");
        }

        private void btnProfilePage_Click(object sender, EventArgs e)
        {
            loadPage("Profile");
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            loadPage("Login");
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

                }
                else
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

        private void lblMenu_Click(object sender, EventArgs e)
        {
            loadPage("Menu");
        }

        private void loadPage(string newPage)
        {
            pnlLogin.Visible = false;
            pnlMenu.Visible = false;
            pnlUsers.Visible = false;
            lblError.Visible = false;

            switch (newPage)
            {
                case "Login":
                    pnlLogin.Visible = true;
                    lblHeader.Text = "Login";
                    this.Text = "Login";
                    this.AcceptButton = btnLogin;
                    break;
                case "Menu":
                    pnlMenu.Visible = true;
                    lblHeader.Text = "Welcome";
                    this.Text = "Welcome";
                    this.AcceptButton = btnUserPage;
                    break;
                case "Users":
                    pnlUsers.Visible = true;
                    lblHeader.Text = "Users";
                    this.Text = "Users";
                    this.AcceptButton = btnSearch;
                    break;
                case "Profile":
                    break;
                default:
                    break;
            }
        }
    }
}
