namespace TINYHOME
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtGebruikersnaam = new System.Windows.Forms.TextBox();
            this.txtWachtwoord = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblGebruikersnaam = new System.Windows.Forms.Label();
            this.lblWachtwoord = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtGebruikersnaam
            // 
            this.txtGebruikersnaam.Location = new System.Drawing.Point(12, 25);
            this.txtGebruikersnaam.Name = "txtGebruikersnaam";
            this.txtGebruikersnaam.Size = new System.Drawing.Size(129, 20);
            this.txtGebruikersnaam.TabIndex = 0;
            // 
            // txtWachtwoord
            // 
            this.txtWachtwoord.Location = new System.Drawing.Point(12, 76);
            this.txtWachtwoord.Name = "txtWachtwoord";
            this.txtWachtwoord.Size = new System.Drawing.Size(129, 20);
            this.txtWachtwoord.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(12, 116);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(129, 45);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // lblGebruikersnaam
            // 
            this.lblGebruikersnaam.AutoSize = true;
            this.lblGebruikersnaam.Location = new System.Drawing.Point(12, 9);
            this.lblGebruikersnaam.Name = "lblGebruikersnaam";
            this.lblGebruikersnaam.Size = new System.Drawing.Size(87, 13);
            this.lblGebruikersnaam.TabIndex = 3;
            this.lblGebruikersnaam.Text = "Gebruikersnaam:";
            // 
            // lblWachtwoord
            // 
            this.lblWachtwoord.AutoSize = true;
            this.lblWachtwoord.Location = new System.Drawing.Point(12, 60);
            this.lblWachtwoord.Name = "lblWachtwoord";
            this.lblWachtwoord.Size = new System.Drawing.Size(71, 13);
            this.lblWachtwoord.TabIndex = 4;
            this.lblWachtwoord.Text = "Wachtwoord:";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(156, 174);
            this.Controls.Add(this.lblWachtwoord);
            this.Controls.Add(this.lblGebruikersnaam);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtWachtwoord);
            this.Controls.Add(this.txtGebruikersnaam);
            this.Name = "Login";
            this.Text = "login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGebruikersnaam;
        private System.Windows.Forms.TextBox txtWachtwoord;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblGebruikersnaam;
        private System.Windows.Forms.Label lblWachtwoord;
    }
}