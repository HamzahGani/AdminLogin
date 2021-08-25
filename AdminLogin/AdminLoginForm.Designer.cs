
namespace AdminLogin
{
    partial class AdminLoginForm
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
            this.btnUserPnl = new System.Windows.Forms.Button();
            this.btnProfilePnl = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.pnlUsers = new System.Windows.Forms.Panel();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.btnMenuFromUsers = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pnlProfile = new System.Windows.Forms.Panel();
            this.txtProfileNumber = new System.Windows.Forms.TextBox();
            this.txtProfileSurname = new System.Windows.Forms.TextBox();
            this.txtProfileName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProfileUsername = new System.Windows.Forms.TextBox();
            this.btnProfileEdit = new System.Windows.Forms.Button();
            this.btnMenuFromProfile = new System.Windows.Forms.Button();
            this.btnCancelProfileUpdate = new System.Windows.Forms.Button();
            this.btnProfileUpdate = new System.Windows.Forms.Button();
            this.pnlLogin.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.pnlProfile.SuspendLayout();
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
            this.pnlMenu.Controls.Add(this.btnUserPnl);
            this.pnlMenu.Controls.Add(this.btnProfilePnl);
            this.pnlMenu.Controls.Add(this.btnLogOut);
            this.pnlMenu.Controls.Add(this.lblWelcome);
            this.pnlMenu.Location = new System.Drawing.Point(12, 87);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(229, 168);
            this.pnlMenu.TabIndex = 7;
            this.pnlMenu.Visible = false;
            // 
            // btnUserPnl
            // 
            this.btnUserPnl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUserPnl.Location = new System.Drawing.Point(3, 54);
            this.btnUserPnl.Name = "btnUserPnl";
            this.btnUserPnl.Size = new System.Drawing.Size(91, 33);
            this.btnUserPnl.TabIndex = 0;
            this.btnUserPnl.Text = "Users";
            this.btnUserPnl.UseVisualStyleBackColor = true;
            this.btnUserPnl.Click += new System.EventHandler(this.btnUserPanel_Click);
            // 
            // btnProfilePnl
            // 
            this.btnProfilePnl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProfilePnl.Location = new System.Drawing.Point(135, 54);
            this.btnProfilePnl.Name = "btnProfilePnl";
            this.btnProfilePnl.Size = new System.Drawing.Size(91, 33);
            this.btnProfilePnl.TabIndex = 1;
            this.btnProfilePnl.Text = "Profile";
            this.btnProfilePnl.UseVisualStyleBackColor = true;
            this.btnProfilePnl.Click += new System.EventHandler(this.btnProfilePanel_Click);
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
            this.pnlUsers.Controls.Add(this.dgvUsers);
            this.pnlUsers.Controls.Add(this.btnMenuFromUsers);
            this.pnlUsers.Controls.Add(this.btnSearch);
            this.pnlUsers.Controls.Add(this.txtSearch);
            this.pnlUsers.Location = new System.Drawing.Point(12, 84);
            this.pnlUsers.Name = "pnlUsers";
            this.pnlUsers.Size = new System.Drawing.Size(645, 316);
            this.pnlUsers.TabIndex = 10;
            this.pnlUsers.Visible = false;
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
            // btnMenuFromUsers
            // 
            this.btnMenuFromUsers.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMenuFromUsers.Location = new System.Drawing.Point(547, 3);
            this.btnMenuFromUsers.Name = "btnMenuFromUsers";
            this.btnMenuFromUsers.Size = new System.Drawing.Size(91, 25);
            this.btnMenuFromUsers.TabIndex = 6;
            this.btnMenuFromUsers.Text = "Menu";
            this.btnMenuFromUsers.UseVisualStyleBackColor = true;
            this.btnMenuFromUsers.Click += new System.EventHandler(this.btnMenuFromUsers_Click);
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
            // pnlProfile
            // 
            this.pnlProfile.Controls.Add(this.txtProfileNumber);
            this.pnlProfile.Controls.Add(this.txtProfileSurname);
            this.pnlProfile.Controls.Add(this.txtProfileName);
            this.pnlProfile.Controls.Add(this.label4);
            this.pnlProfile.Controls.Add(this.label3);
            this.pnlProfile.Controls.Add(this.label2);
            this.pnlProfile.Controls.Add(this.label1);
            this.pnlProfile.Controls.Add(this.txtProfileUsername);
            this.pnlProfile.Controls.Add(this.btnProfileEdit);
            this.pnlProfile.Controls.Add(this.btnMenuFromProfile);
            this.pnlProfile.Controls.Add(this.btnCancelProfileUpdate);
            this.pnlProfile.Controls.Add(this.btnProfileUpdate);
            this.pnlProfile.Location = new System.Drawing.Point(12, 87);
            this.pnlProfile.Name = "pnlProfile";
            this.pnlProfile.Size = new System.Drawing.Size(645, 313);
            this.pnlProfile.TabIndex = 11;
            this.pnlProfile.Visible = false;
            // 
            // txtProfileNumber
            // 
            this.txtProfileNumber.Enabled = false;
            this.txtProfileNumber.Location = new System.Drawing.Point(112, 158);
            this.txtProfileNumber.Name = "txtProfileNumber";
            this.txtProfileNumber.Size = new System.Drawing.Size(146, 23);
            this.txtProfileNumber.TabIndex = 15;
            // 
            // txtProfileSurname
            // 
            this.txtProfileSurname.Enabled = false;
            this.txtProfileSurname.Location = new System.Drawing.Point(112, 121);
            this.txtProfileSurname.Name = "txtProfileSurname";
            this.txtProfileSurname.Size = new System.Drawing.Size(146, 23);
            this.txtProfileSurname.TabIndex = 14;
            // 
            // txtProfileName
            // 
            this.txtProfileName.Enabled = false;
            this.txtProfileName.Location = new System.Drawing.Point(112, 84);
            this.txtProfileName.Name = "txtProfileName";
            this.txtProfileName.Size = new System.Drawing.Size(146, 23);
            this.txtProfileName.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(7, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(7, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Surname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(7, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(7, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Username";
            // 
            // txtProfileUsername
            // 
            this.txtProfileUsername.Enabled = false;
            this.txtProfileUsername.Location = new System.Drawing.Point(112, 51);
            this.txtProfileUsername.Name = "txtProfileUsername";
            this.txtProfileUsername.Size = new System.Drawing.Size(146, 23);
            this.txtProfileUsername.TabIndex = 8;
            // 
            // btnProfileEdit
            // 
            this.btnProfileEdit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProfileEdit.Location = new System.Drawing.Point(7, 3);
            this.btnProfileEdit.Name = "btnProfileEdit";
            this.btnProfileEdit.Size = new System.Drawing.Size(91, 25);
            this.btnProfileEdit.TabIndex = 7;
            this.btnProfileEdit.Text = "Edit";
            this.btnProfileEdit.UseVisualStyleBackColor = true;
            this.btnProfileEdit.Click += new System.EventHandler(this.btnProfileEdit_Click);
            // 
            // btnMenuFromProfile
            // 
            this.btnMenuFromProfile.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMenuFromProfile.Location = new System.Drawing.Point(547, 3);
            this.btnMenuFromProfile.Name = "btnMenuFromProfile";
            this.btnMenuFromProfile.Size = new System.Drawing.Size(91, 25);
            this.btnMenuFromProfile.TabIndex = 6;
            this.btnMenuFromProfile.Text = "Menu";
            this.btnMenuFromProfile.UseVisualStyleBackColor = true;
            this.btnMenuFromProfile.Click += new System.EventHandler(this.btnMenuFromProfile_Click);
            // 
            // btnCancelProfileUpdate
            // 
            this.btnCancelProfileUpdate.Enabled = false;
            this.btnCancelProfileUpdate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelProfileUpdate.Location = new System.Drawing.Point(223, 3);
            this.btnCancelProfileUpdate.Name = "btnCancelProfileUpdate";
            this.btnCancelProfileUpdate.Size = new System.Drawing.Size(91, 25);
            this.btnCancelProfileUpdate.TabIndex = 5;
            this.btnCancelProfileUpdate.Text = "Cancel";
            this.btnCancelProfileUpdate.UseVisualStyleBackColor = true;
            this.btnCancelProfileUpdate.Click += new System.EventHandler(this.btnCancelProfileUpdate_Click);
            // 
            // btnProfileUpdate
            // 
            this.btnProfileUpdate.Enabled = false;
            this.btnProfileUpdate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProfileUpdate.Location = new System.Drawing.Point(112, 3);
            this.btnProfileUpdate.Name = "btnProfileUpdate";
            this.btnProfileUpdate.Size = new System.Drawing.Size(91, 25);
            this.btnProfileUpdate.TabIndex = 16;
            this.btnProfileUpdate.Text = "Update";
            this.btnProfileUpdate.UseVisualStyleBackColor = true;
            this.btnProfileUpdate.Click += new System.EventHandler(this.btnProfileUpdate_Click);
            // 
            // AdminLoginForm
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 455);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlUsers);
            this.Controls.Add(this.pnlProfile);
            this.Controls.Add(this.pnlLogin);
            this.Name = "AdminLoginForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.pnlUsers.ResumeLayout(false);
            this.pnlUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.pnlProfile.ResumeLayout(false);
            this.pnlProfile.PerformLayout();
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
        private System.Windows.Forms.Button btnUserPnl;
        private System.Windows.Forms.Button btnProfilePnl;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Panel pnlUsers;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnMenuFromUsers;
        private System.Windows.Forms.Panel pnlProfile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProfileUsername;
        private System.Windows.Forms.Button btnProfileEdit;
        private System.Windows.Forms.Button btnMenuFromProfile;
        private System.Windows.Forms.Button btnCancelProfileUpdate;
        private System.Windows.Forms.TextBox txtProfileSurname;
        private System.Windows.Forms.TextBox txtProfileName;
        private System.Windows.Forms.TextBox txtProfileNumber;
        private System.Windows.Forms.Button btnProfileUpdate;
    }
}

