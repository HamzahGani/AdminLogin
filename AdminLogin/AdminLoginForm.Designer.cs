
namespace AdminLogin
{
    partial class AdminLoginF
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblHeader = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.lblLogin = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnUserPage = new System.Windows.Forms.Button();
            this.btnProfilePage = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.pnlUsers = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.lblMenu = new System.Windows.Forms.Button();
            this.pnlLogin.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHeader.Location = new System.Drawing.Point(12, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(146, 65);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Login";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(0, 54);
            this.txtUser.Name = "txtUser";
            this.txtUser.PlaceholderText = "Username";
            this.txtUser.Size = new System.Drawing.Size(146, 23);
            this.txtUser.TabIndex = 3;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(0, 83);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.PlaceholderText = "Password";
            this.txtPass.Size = new System.Drawing.Size(146, 23);
            this.txtPass.TabIndex = 4;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.Location = new System.Drawing.Point(0, 112);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(91, 33);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.lblLogin);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.txtUser);
            this.pnlLogin.Controls.Add(this.txtPass);
            this.pnlLogin.Location = new System.Drawing.Point(12, 84);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(346, 174);
            this.pnlLogin.TabIndex = 6;
            this.pnlLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLogin_Paint);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLogin.Location = new System.Drawing.Point(3, 16);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(326, 17);
            this.lblLogin.TabIndex = 8;
            this.lblLogin.Text = "Please enter your username and password to continue";
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnUserPage);
            this.pnlMenu.Controls.Add(this.btnProfilePage);
            this.pnlMenu.Controls.Add(this.btnLogOut);
            this.pnlMenu.Controls.Add(this.lblWelcome);
            this.pnlMenu.Location = new System.Drawing.Point(12, 87);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(229, 168);
            this.pnlMenu.TabIndex = 7;
            this.pnlMenu.Visible = false;
            // 
            // btnUserPage
            // 
            this.btnUserPage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUserPage.Location = new System.Drawing.Point(3, 54);
            this.btnUserPage.Name = "btnUserPage";
            this.btnUserPage.Size = new System.Drawing.Size(91, 33);
            this.btnUserPage.TabIndex = 0;
            this.btnUserPage.Text = "Users";
            this.btnUserPage.UseVisualStyleBackColor = true;
            this.btnUserPage.Click += new System.EventHandler(this.btnUserPage_Click);
            // 
            // btnProfilePage
            // 
            this.btnProfilePage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProfilePage.Location = new System.Drawing.Point(135, 54);
            this.btnProfilePage.Name = "btnProfilePage";
            this.btnProfilePage.Size = new System.Drawing.Size(91, 33);
            this.btnProfilePage.TabIndex = 1;
            this.btnProfilePage.Text = "Profile";
            this.btnProfilePage.UseVisualStyleBackColor = true;
            this.btnProfilePage.Click += new System.EventHandler(this.btnProfilePage_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogOut.Location = new System.Drawing.Point(63, 105);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(91, 33);
            this.btnLogOut.TabIndex = 9;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWelcome.Location = new System.Drawing.Point(3, 14);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(167, 17);
            this.lblWelcome.TabIndex = 7;
            this.lblWelcome.Text = "What would you like to do?";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(12, 403);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(45, 17);
            this.lblError.TabIndex = 9;
            this.lblError.Text = "Error: ";
            this.lblError.Visible = false;
            // 
            // pnlUsers
            // 
            this.pnlUsers.Controls.Add(this.lblMenu);
            this.pnlUsers.Controls.Add(this.btnSearch);
            this.pnlUsers.Controls.Add(this.txtSearch);
            this.pnlUsers.Controls.Add(this.dgvUsers);
            this.pnlUsers.Location = new System.Drawing.Point(12, 84);
            this.pnlUsers.Name = "pnlUsers";
            this.pnlUsers.Size = new System.Drawing.Size(645, 316);
            this.pnlUsers.TabIndex = 10;
            this.pnlUsers.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.Location = new System.Drawing.Point(209, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(91, 25);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearch.Location = new System.Drawing.Point(7, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Search";
            this.txtSearch.Size = new System.Drawing.Size(197, 25);
            this.txtSearch.TabIndex = 4;
            // 
            // dgvUsers
            // 
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(0, 34);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowTemplate.Height = 25;
            this.dgvUsers.Size = new System.Drawing.Size(645, 279);
            this.dgvUsers.TabIndex = 2;
            // 
            // lblMenu
            // 
            this.lblMenu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMenu.Location = new System.Drawing.Point(547, 3);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(91, 25);
            this.lblMenu.TabIndex = 6;
            this.lblMenu.Text = "Menu";
            this.lblMenu.UseVisualStyleBackColor = true;
            this.lblMenu.Click += new System.EventHandler(this.lblMenu_Click);
            // 
            // AdminLoginF
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 455);
            this.Controls.Add(this.pnlUsers);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlLogin);
            this.Name = "AdminLoginF";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.pnlUsers.ResumeLayout(false);
            this.pnlUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnUserPage;
        private System.Windows.Forms.Button btnProfilePage;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Panel pnlUsers;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button lblMenu;
    }
}

