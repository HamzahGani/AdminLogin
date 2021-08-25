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
    public partial class AdminLoginForm : Form
    {
        // stores the connection string to the db
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hgani\Documents\Users.mdf;Integrated Security=True;Connect Timeout=30";
        
        //variables to store the details of the admin that logs in
        string loggedUsername = ""; 
        string loggedName = "";
        string loggedSurname = "";
        string loggedNumber = "";

        public AdminLoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void pnlLogin_Paint(object sender, PaintEventArgs e)
        {
        }

        /* When a new page loads this method is called with the new page name
         * All panels visibility are set to false
         * the new page visibility is set to true and the new page is initialised
         **/
        private void loadPage(string newPage)
        {
            //sets all panel's visibility to false
            pnlLogin.Visible = false;
            pnlMenu.Visible = false;
            pnlUsers.Visible = false;
            pnlProfile.Visible = false;
            lblError.Visible = false;

            /* Sets the new page panel visibility to true
             * sets the form tex, header text and accept
             * sets the form text
             * */
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
            //declares which sql database to connect to.
            //connectionString string delcred at the beginning of program
            {
                sqlCon.Open();
                SqlCommand sqlCom = new SqlCommand();
                sqlCom.Connection = sqlCon;
                sqlCom.CommandText = "SELECT * FROM Users WHERE Username ='" + txtUser.Text + "' and Password ='" + txtPass.Text + "'";
                SqlDataReader sqlDR = sqlCom.ExecuteReader();
                if (sqlDR.Read())
                {
                    if (sqlDR["IsAdmin"].ToString() == "True")
                    {
                        loggedUsername = txtUser.Text;
                        txtPass.Text = "";
                        loadPage("Menu");
                    } else
                    {
                        lblError.Text = "Only Admins may login";
                        lblError.Visible = true;
                    }   
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
            //declares which sql database to connect to.
            //connectionString string delcred at the beginning of program
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

        /* When the profile page loads
         * Connect to the database
         */
        private void btnProfilePage_Click(object sender, EventArgs e)
        {
            loadPage("Profile");
            string profileSearch = "SELECT Username, Name, Surname, Number " + //selects the username, name, surname and number
                "FROM Users WHERE Username ='" + loggedUsername + "'"; //from users table for the logged in user

            using (SqlConnection con = new SqlConnection(connectionString))
            //declares which sql database to connect to.
            //connectionString string delcred at the beginning of program
            {
                /*opens sql connections, 
                 * executes a search command 
                 * and stores the search details
                 * */
                con.Open(); 
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con; 
                cmd.CommandText = profileSearch;
                SqlDataReader dataR = cmd.ExecuteReader();

                //if there is a result stored in the data reader
                if (dataR.Read()) 
                {
                    //sets the textbox details to the logged in users details
                    txtProfileUsername.Text = dataR["Username"].ToString();
                    txtProfileName.Text = dataR["Name"].ToString();
                    txtProfileSurname.Text = dataR["Surname"].ToString();
                    txtProfileNumber.Text = dataR["Number"].ToString();

                    //saves the logged in users details to variables
                    loggedName = txtProfileName.Text;
                    loggedSurname = txtProfileSurname.Text;
                    loggedNumber = txtProfileNumber.Text;

                }
                //if the user cannot be found throw an error
                else
                {
                    lblError.Text = "Cannot find username";
                    lblError.Visible = true;
                }

                con.Close(); //close sql connection
            }
        }

        /* When the edit button is clicked
         * Diables the edit button and enable the update and cancel buttons
         * Sets the forms accept button to the cancel button
         * Makes the textboxes editable
         */
        private void btnProfileEdit_Click(object sender, EventArgs e)
        {
            /* disable the edit button and enable the update and cancel buttons
             * set the accept button to the cancel button
             * */
            btnProfileEdit.Enabled = false; 
            btnProfileUpdate.Enabled = true;
            btnCancelProfileUpdate.Enabled = true;
            this.AcceptButton = btnCancelProfileUpdate;

            // make the users name, surname and number editable
            txtProfileName.Enabled = true;
            txtProfileSurname.Enabled = true;
            txtProfileNumber.Enabled = true;
        }

        private void btnProfileUpdate_Click(object sender, EventArgs e)
        {
            lockProfilePage(); //After clicking update, page fields are locked from further editing

            string updateProfile = "UPDATE Users " + //update string updates user table
                "SET Name = @Name, Surname = @Surname, Number = @Number " + //updates name, surname and number
                "WHERE Username ='" + loggedUsername + "'"; //updates for the logged in user.

            using (SqlConnection con = new SqlConnection(connectionString))
            //declares which sql database to connect to.
            //connectionString string delcred at the beginning of program
            {
                SqlCommand cmd = new SqlCommand(); //new command to execute update
                cmd.Connection = con; //command uses connection above
                cmd.CommandText = updateProfile; //Use the update string above
                cmd.Parameters.AddWithValue("@Name", txtProfileName.Text); //@Name = updated name.
                cmd.Parameters.AddWithValue("@Surname", txtProfileSurname.Text); //@Surname = updated surname
                cmd.Parameters.AddWithValue("@Number", txtProfileNumber.Text); //@Number = updated number

                //open sql connection, execute command and close connection
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                //saves the logged in users new details to te correct variables
                loggedName = txtProfileName.Text;
                loggedSurname = txtProfileSurname.Text;
                loggedNumber = txtProfileNumber.Text;
            }
        }

        private void btnCancelProfileUpdate_Click(object sender, EventArgs e)
        {
            //After clicking update, page fields are locked from further editing
            lockProfilePage();

            //after cancelling the edit, textbox fields are reset to teh correct data
            txtProfileName.Text = loggedName;
            txtProfileSurname.Text = loggedSurname;
            txtProfileNumber.Text = loggedNumber;
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
