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

        /* When a new panel is required, this method is called with the new panel name
         * All panels visibility are set to false
         * the new panels visibility is set to true and the new panel is initialised
         **/
        private void loadPanel(string newPage)
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
                    this.AcceptButton = btnUserPnl;
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

        /* when the login button on the login panel is clicked
         * search the db for a username and password match and ensure the user is an admin
         * on successful login, store the username in a variable, clear the password textbox and load the menu panel
         */
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string loginToDB = "SELECT Username, Password, IsAdmin " + //selects the username, password and isAdmin fields
                "FROM Users " + // from the users table 
                "WHERE Username ='" + txtUser.Text + "' and Password ='" + txtPass.Text + "'"; //where the username and password matches the textboxes text
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                /* opens sql connection, 
                 * executes a select (search) command 
                 * and stores the search details
                 */
                sqlCon.Open();
                SqlCommand sqlCom = new SqlCommand();
                sqlCom.Connection = sqlCon;
                sqlCom.CommandText = loginToDB;
                SqlDataReader sqlDR = sqlCom.ExecuteReader();
                
                //tests if the username and password matched the database
                if (sqlDR.Read())
                {
                    //tests to ensure the user is an admin
                    if (sqlDR["IsAdmin"].ToString() == "True")
                    {
                        loggedUsername = txtUser.Text; //store logged in users username to a variable
                        txtPass.Text = ""; //clears the password textbox
                        loadPanel("Menu"); //call load panel method to initialise the menu panel
                    }
                    //if the user is not an admin, throw an error
                    else
                    {
                        lblError.Text = "Only Admins may login";
                        lblError.Visible = true;
                    }   
                }
                //f the username or password do not match the database, throw an error
                else
                {
                    lblError.Text = "Username or password is incorrect";
                    lblError.Visible = true;
                }

                sqlCon.Close();
            }
        }

        /* when the logout button on the menu panel is clicked
         * load the login panel
         */
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            loadPanel("Login"); //call load panel method to initialise the login panel
        }

        /* when the users button on the menu panel is clicked
         * load the users panel
         */
        private void btnUserPanel_Click(object sender, EventArgs e)
        {
            loadPanel("Users"); //call load panel method to initialise the users panel
        }

        /* when the search button on the users page is clicked
         * if the searchbox is empty select all users from users table
         * if there is text in the searchbox select users that match on username, name, surname or number from the users table
         * display matched users
         */
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string emptyUserSearch = "SELECT Username, IsAdmin, Name, Surname, Number " + //selects the username, isAdmin, name, surname and number fields
                "FROM Users"; // from the users table

            string userSearch = "SELECT Username, IsAdmin, Name, Surname, Number " + //selects the username, isAdmin, name, surname and number fields
                "FROM Users " + // from the users table where the username, name surname or number matches the searchbox's text
                "WHERE Username ='" + txtSearch.Text +
                "' or Name ='" + txtSearch.Text +
                "' or Surname ='" + txtSearch.Text +
                "' or Number ='" + txtSearch.Text + "'";

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                DataTable sqlDT = new DataTable();

                //if searchbox is empty, select all users
                if (txtSearch.Text == "")
                {
                    SqlDataAdapter sqlDA = new SqlDataAdapter(emptyUserSearch, sqlCon);
                    sqlDA.Fill(sqlDT);
                }
                // else display all users that match the search
                else
                {
                    SqlDataAdapter sqlDA = new SqlDataAdapter(userSearch, sqlCon);
                    sqlDA.Fill(sqlDT);
                }

                dgvUsers.DataSource = sqlDT; //display matched users
                sqlCon.Close(); //close sql connection
            }
        }

        /* When the menu button on the users panel is clicked
         * clear the search box
         * load the menu panel
         */
        private void btnMenuFromUsers_Click(object sender, EventArgs e)
        {
            txtSearch.Text = ""; //clear search box
            loadPanel("Menu"); //load panel menu
        }

        /* When the profile button on the menu panel is clicked
         * load the profile panel
         * retrieve the logged in users details from the database
         * place users details into text boxes that are disabled (uneditable)
         */
        private void btnProfilePanel_Click(object sender, EventArgs e)
        {
            loadPanel("Profile"); //call load panel method to initialise the profile panel

            string profileSearch = "SELECT Username, Name, Surname, Number " + //selects the username, name, surname and number
                "FROM Users WHERE Username ='" + loggedUsername + "'"; //from users table for the logged in user

            /* Declares which sql database to connect to.
             * (ConnectionString string declared at the beginning of program)
             * Executes a search command and stores the search details
             * if a user is found, fill users details into text boxes
             */
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                /* opens sql connection, 
                 * executes a select (search) command 
                 * and stores the search details
                 */
                con.Open(); 
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con; 
                cmd.CommandText = profileSearch;
                SqlDataReader dataR = cmd.ExecuteReader();

                //if the search finds the users details
                if (dataR.Read()) 
                {
                    //sets the textboxes details to the logged in users details
                    txtProfileUsername.Text = dataR["Username"].ToString();
                    txtProfileName.Text = dataR["Name"].ToString();
                    txtProfileSurname.Text = dataR["Surname"].ToString();
                    txtProfileNumber.Text = dataR["Number"].ToString();

                    // saves the logged in users details to variables
                    // this allows the data to be restored if the user cancels during an edit
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

        /* When the edit button on the profile panel is clicked
         * Disables the edit button and enables the update and cancel buttons
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

        /* When the update button on the profile panel is clicked
         * enables the edit button and sets it as the forms accept button
         * disables the update and cancel buttons
         * disable the textboxes so they may not be edited
         * save the logged in users updated details to the database
         */
        private void btnProfileUpdate_Click(object sender, EventArgs e)
        {
            /* enables the edit button and sets it as the forms accept button
             * disables the update and cancel buttons
             * disable the textboxes so they may not be edited
             */
            lockProfilePage();

            string updateProfile = "UPDATE Users " + //update string updates user table
                "SET Name = @Name, Surname = @Surname, Number = @Number " + //updates name, surname and number
                "WHERE Username ='" + loggedUsername + "'"; //updates for the logged in user.

            /* Declares which sql database to connect to.
             * (ConnectionString string declared at the beginning of program)
             * Executes an update command to update the db with logged in users new details
             */
            using (SqlConnection con = new SqlConnection(connectionString))
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

                // saves the logged in users new details to the correct variables
                // this allows the data to be restored if the user cancels during an edit
                loggedName = txtProfileName.Text;
                loggedSurname = txtProfileSurname.Text;
                loggedNumber = txtProfileNumber.Text;
            }
        }

        /* When the cancel button on the profile panel is clicked
         * enables the edit button and sets it as the forms accept button
         * disables the update and cancel buttons
         * disable the textboxes so they may not be edited
         * restores the details in the profile to before editing
         */
        private void btnCancelProfileUpdate_Click(object sender, EventArgs e)
        {
            /* enables the edit button and sets it as the forms accept button
             * disables the update and cancel buttons
             * disable the textboxes so they may not be edited
             */
            lockProfilePage();

            // restores the details in the profile to before editing
            txtProfileName.Text = loggedName;
            txtProfileSurname.Text = loggedSurname;
            txtProfileNumber.Text = loggedNumber;
        }

        /* When the menu button on the profile panel is clicked
         * enables the edit button and sets it as the forms accept button
         * disables the update and cancel buttons
         * disable the textboxes so they may not be edited
         * load the menu panel
         */
        private void btnMenuFromProfile_Click(object sender, EventArgs e)
        {
            /* enables the edit button and sets it as the forms accept button
             * disables the update and cancel buttons
             * disable the textboxes so they may not be edited
             */
            lockProfilePage();

            loadPanel("Menu"); //load panel menu
        }

        /* on the profile panel, when the update, cancel or menu buttons are clicked
         * enables the edit button and sets it as the forms accept button
         * disables the update and cancel buttons
         * disable the textboxes so they may not be edited
         */
        private void lockProfilePage()
        {
            btnProfileEdit.Enabled = true; //enable edit button
            this.AcceptButton = btnProfileEdit; //sets the forms accept button to the edit button
            btnProfileUpdate.Enabled = false; //disables the update button
            btnCancelProfileUpdate.Enabled = false; //disables the cancel button
            
            //disabls the textboxes and prevents them from being edited
            txtProfileUsername.Enabled = false;
            txtProfileName.Enabled = false;
            txtProfileSurname.Enabled = false;
            txtProfileNumber.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pnlLogin_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
