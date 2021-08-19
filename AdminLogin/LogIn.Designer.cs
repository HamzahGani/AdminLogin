
namespace AdminLogin
{
    partial class Login
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
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.pnlLoggedIn = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLoggedIn = new System.Windows.Forms.Label();
            this.btnUserPage = new System.Windows.Forms.Button();
            this.btnProfilePage = new System.Windows.Forms.Button();
            this.pnlLogin.SuspendLayout();
            this.pnlLoggedIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLogin.Location = new System.Drawing.Point(3, 3);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(146, 65);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(3, 79);
            this.txtUser.Name = "txtUser";
            this.txtUser.PlaceholderText = "Username";
            this.txtUser.Size = new System.Drawing.Size(146, 23);
            this.txtUser.TabIndex = 3;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(3, 108);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.PlaceholderText = "Password";
            this.txtPass.Size = new System.Drawing.Size(146, 23);
            this.txtPass.TabIndex = 4;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.Location = new System.Drawing.Point(3, 137);
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
            this.pnlLogin.Location = new System.Drawing.Point(12, 12);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(200, 184);
            this.pnlLogin.TabIndex = 6;
            this.pnlLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLogin_Paint);
            // 
            // pnlLoggedIn
            // 
            this.pnlLoggedIn.Controls.Add(this.label2);
            this.pnlLoggedIn.Controls.Add(this.lblLoggedIn);
            this.pnlLoggedIn.Controls.Add(this.btnUserPage);
            this.pnlLoggedIn.Controls.Add(this.btnProfilePage);
            this.pnlLoggedIn.Location = new System.Drawing.Point(-1, 0);
            this.pnlLoggedIn.Name = "pnlLoggedIn";
            this.pnlLoggedIn.Size = new System.Drawing.Size(229, 212);
            this.pnlLoggedIn.TabIndex = 7;
            this.pnlLoggedIn.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "What page would you like to see?";
            // 
            // lblLoggedIn
            // 
            this.lblLoggedIn.AutoSize = true;
            this.lblLoggedIn.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLoggedIn.Location = new System.Drawing.Point(6, 3);
            this.lblLoggedIn.Name = "lblLoggedIn";
            this.lblLoggedIn.Size = new System.Drawing.Size(224, 65);
            this.lblLoggedIn.TabIndex = 6;
            this.lblLoggedIn.Text = "Welcome";
            // 
            // btnUserPage
            // 
            this.btnUserPage.Location = new System.Drawing.Point(128, 137);
            this.btnUserPage.Name = "btnUserPage";
            this.btnUserPage.Size = new System.Drawing.Size(75, 23);
            this.btnUserPage.TabIndex = 1;
            this.btnUserPage.Text = "Users";
            this.btnUserPage.UseVisualStyleBackColor = true;
            this.btnUserPage.Click += new System.EventHandler(this.btnUserPage_Click);
            // 
            // btnProfilePage
            // 
            this.btnProfilePage.Location = new System.Drawing.Point(3, 137);
            this.btnProfilePage.Name = "btnProfilePage";
            this.btnProfilePage.Size = new System.Drawing.Size(75, 23);
            this.btnProfilePage.TabIndex = 0;
            this.btnProfilePage.Text = "Profile";
            this.btnProfilePage.UseVisualStyleBackColor = true;
            this.btnProfilePage.Click += new System.EventHandler(this.btnProfilePage_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 212);
            this.Controls.Add(this.pnlLoggedIn);
            this.Controls.Add(this.pnlLogin);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.pnlLoggedIn.ResumeLayout(false);
            this.pnlLoggedIn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Panel pnlLoggedIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLoggedIn;
        private System.Windows.Forms.Button btnUserPage;
        private System.Windows.Forms.Button btnProfilePage;
    }
}

