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
        string loggedUser = "";

        public AdminLoginF()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void pnlLogin_Paint(object sender, PaintEventArgs e)
        {
        }

        private void loadPage(string newPage)
        {
            pnlLogin.Visible = false;
            pnlMenu.Visible = false;
            pnlUsers.Visible = false;
            pnlProfile.Visible = false;
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
                    pnlProfile.Visible = true;
                    lblHeader.Text = "My Profile";
                    this.Text = "My Profile";
                    this.AcceptButton = btnProfileEdit;
                    break;
                default:
                    break;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCom = new SqlCommand();
                sqlCom.Connection = sqlCon;
                sqlCom.CommandText = "SELECT * FROM Users WHERE Username ='" + txtUser.Text + "' and Password ='" + txtPass.Text + "'";
                SqlDataReader sqlDR = sqlCom.ExecuteReader();
                if (sqlDR.Read())
                {
                        loggedUser = txtUser.Text;
                        txtPass.Text = "";
                        loadPage("Menu");
                    
                }
                else
                {
                    lblError.Text = "Username or password is incorrect";
                    lblError.Visible = true;
                }

                sqlCon.Close();
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            loadPage("Login");
        }

        private void btnUserPage_Click(object sender, EventArgs e)
        {
            loadPage("Users");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string emptyUserSearch = "SELECT Username, IsAdmin, Name, Surname, Number FROM Users";
            string userSearch = "SELECT Username, IsAdmin, Name, Surname, Number " +
                "FROM Users WHERE Username ='" + txtSearch.Text +
                "' or Name ='" + txtSearch.Text +
                "' or Surname ='" + txtSearch.Text +
                "' or Number ='" + txtSearch.Text + "'";

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                DataTable sqlDT = new DataTable();
                if (txtSearch.Text == "")
                {
                    SqlDataAdapter sqlDA = new SqlDataAdapter(emptyUserSearch, sqlCon);
                    sqlDA.Fill(sqlDT);
                }
                else
                {
                    SqlDataAdapter sqlDA = new SqlDataAdapter(userSearch, sqlCon);
                    sqlDA.Fill(sqlDT);
                }
                dgvUsers.DataSource = sqlDT;
                sqlCon.Close();
            }
        }

        private void btnMenuFromUsers_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            loadPage("Menu");
        }

        private void btnProfilePage_Click(object sender, EventArgs e)
        {
            loadPage("Profile");
            string profileSearch = "SELECT Username, Name, Surname, Number " +
                "FROM Users WHERE Username ='" + loggedUser + "'";

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCom = new SqlCommand();
                sqlCom.Connection = sqlCon;
                sqlCom.CommandText = profileSearch;
                SqlDataReader sqlDR = sqlCom.ExecuteReader();
                if (sqlDR.Read())
                {
                    txtProfileUsername.Text = sqlDR["Username"].ToString();
                    txtProfileName.Text = sqlDR["Name"].ToString();
                    txtProfileSurname.Text = sqlDR["Surname"].ToString();
                    txtProfileNumber.Text = sqlDR["Number"].ToString();

                }
                else
                {
                    lblError.Text = "Cannot find username";
                    lblError.Visible = true;
                }

                sqlCon.Close();
            }
        }

        private void btnProfileEdit_Click(object sender, EventArgs e)
        {
            btnProfileEdit.Enabled = false;
            btnProfileUpdate.Enabled = true;
            btnCancelProfileUpdate.Enabled = true;
            this.AcceptButton = btnCancelProfileUpdate;

            //txtProfileUsername.Enabled = true;
            txtProfileName.Enabled = true;
            txtProfileSurname.Enabled = true;
            txtProfileNumber.Enabled = true;
        }

        private void btnProfileUpdate_Click(object sender, EventArgs e)
        {
            lockProfilePage();
            //update db

             /*
            string updateProfile = "UPDATE Users Set Username, Name, Surname, Number " +
                "FROM Users WHERE Username ='" + loggedUser + "'";

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCom = new SqlCommand();
                sqlCom.Connection = sqlCon;
                sqlCom.CommandText = updateProfile;
                SqlDataReader sqlDR = sqlCom.ExecuteReader();
                if (sqlDR.Read())
                {
                    txtProfileUsername.Text = sqlDR["Username"].ToString();
                    txtProfileName.Text = sqlDR["Name"].ToString();
                    txtProfileSurname.Text = sqlDR["Surname"].ToString();
                    txtProfileNumber.Text = sqlDR["Number"].ToString();

                }
                else
                {
                    lblError.Text = "Cannot find username";
                    lblError.Visible = true;
                }

                sqlCon.Close();
            }
            // */
        }

        private void btnCancelProfileUpdate_Click(object sender, EventArgs e)
        {
            lockProfilePage();
        }  

        private void btnMenuFromProfile_Click(object sender, EventArgs e)
        {
            lockProfilePage();
            loadPage("Menu");
        }

        private void lockProfilePage()
        {
            btnProfileEdit.Enabled = true;
            btnProfileUpdate.Enabled = false;
            btnCancelProfileUpdate.Enabled = false;
            this.AcceptButton = btnProfileEdit;

            txtProfileUsername.Enabled = false;
            txtProfileName.Enabled = false;
            txtProfileSurname.Enabled = false;
            txtProfileNumber.Enabled = false;
        }
    }
}
