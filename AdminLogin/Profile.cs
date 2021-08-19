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
    public partial class Profile : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hgani\OneDrive\Documents\Users.mdf;Integrated Security=True;Connect Timeout=30";
        public Profile()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT * FROM Users", sqlCon);
                DataTable sqlDT = new DataTable();
                sqlDA.Fill(sqlDT);

                //method1 - direct method
                
                dgvUsers.DataSource = sqlDT;

                //method2


                sqlCon.Close();
            }
        }
    }
}
