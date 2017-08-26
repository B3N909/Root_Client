using Root_Client;

namespace Root_Client
{
    partial class StartupScreen
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
	     System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartupScreen));
	     this.usernameBox = new MetroFramework.Controls.MetroTextBox();
	     this.passwordBox = new MetroFramework.Controls.MetroTextBox();
	     this.loginButton = new MetroFramework.Controls.MetroButton();
	     this.registerButton = new MetroFramework.Controls.MetroButton();
	     this.logo = new System.Windows.Forms.PictureBox();
	     this.copyright = new MetroFramework.Controls.MetroLabel();
	     this.errorLabel = new MetroFramework.Controls.MetroLabel();
	     ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
	     this.SuspendLayout();
	     // 
	     // usernameBox
	     // 
	     // 
	     // 
	     // 
	     this.usernameBox.CustomButton.Image = null;
	     this.usernameBox.CustomButton.Location = new System.Drawing.Point(226, 1);
	     this.usernameBox.CustomButton.Name = "";
	     this.usernameBox.CustomButton.Size = new System.Drawing.Size(23, 23);
	     this.usernameBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
	     this.usernameBox.CustomButton.TabIndex = 1;
	     this.usernameBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
	     this.usernameBox.CustomButton.UseSelectable = true;
	     this.usernameBox.CustomButton.Visible = false;
	     this.usernameBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
	     this.usernameBox.Lines = new string[0];
	     this.usernameBox.Location = new System.Drawing.Point(178, 220);
	     this.usernameBox.MaxLength = 32767;
	     this.usernameBox.Name = "usernameBox";
	     this.usernameBox.PasswordChar = '\0';
	     this.usernameBox.PromptText = "Username";
	     this.usernameBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
	     this.usernameBox.SelectedText = "";
	     this.usernameBox.SelectionLength = 0;
	     this.usernameBox.SelectionStart = 0;
	     this.usernameBox.ShortcutsEnabled = true;
	     this.usernameBox.ShowClearButton = true;
	     this.usernameBox.Size = new System.Drawing.Size(250, 25);
	     this.usernameBox.TabIndex = 0;
	     this.usernameBox.UseSelectable = true;
	     this.usernameBox.WaterMark = "Username";
	     this.usernameBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
	     this.usernameBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
	     // 
	     // passwordBox
	     // 
	     // 
	     // 
	     // 
	     this.passwordBox.CustomButton.Image = null;
	     this.passwordBox.CustomButton.Location = new System.Drawing.Point(226, 1);
	     this.passwordBox.CustomButton.Name = "";
	     this.passwordBox.CustomButton.Size = new System.Drawing.Size(23, 23);
	     this.passwordBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
	     this.passwordBox.CustomButton.TabIndex = 1;
	     this.passwordBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
	     this.passwordBox.CustomButton.UseSelectable = true;
	     this.passwordBox.CustomButton.Visible = false;
	     this.passwordBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
	     this.passwordBox.Lines = new string[0];
	     this.passwordBox.Location = new System.Drawing.Point(178, 261);
	     this.passwordBox.MaxLength = 32767;
	     this.passwordBox.Name = "passwordBox";
	     this.passwordBox.PasswordChar = '●';
	     this.passwordBox.PromptText = "Password";
	     this.passwordBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
	     this.passwordBox.SelectedText = "";
	     this.passwordBox.SelectionLength = 0;
	     this.passwordBox.SelectionStart = 0;
	     this.passwordBox.ShortcutsEnabled = true;
	     this.passwordBox.Size = new System.Drawing.Size(250, 25);
	     this.passwordBox.TabIndex = 1;
	     this.passwordBox.Theme = MetroFramework.MetroThemeStyle.Light;
	     this.passwordBox.UseSelectable = true;
	     this.passwordBox.UseSystemPasswordChar = true;
	     this.passwordBox.WaterMark = "Password";
	     this.passwordBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
	     this.passwordBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
	     this.passwordBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordBox_ButtonDown);
	     // 
	     // loginButton
	     // 
	     this.loginButton.Location = new System.Drawing.Point(178, 315);
	     this.loginButton.Name = "loginButton";
	     this.loginButton.Size = new System.Drawing.Size(120, 31);
	     this.loginButton.TabIndex = 2;
	     this.loginButton.Text = "Login";
	     this.loginButton.UseSelectable = true;
	     this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
	     // 
	     // registerButton
	     // 
	     this.registerButton.Location = new System.Drawing.Point(304, 315);
	     this.registerButton.Name = "registerButton";
	     this.registerButton.Size = new System.Drawing.Size(120, 31);
	     this.registerButton.TabIndex = 3;
	     this.registerButton.Text = "Register";
	     this.registerButton.UseSelectable = true;
	     this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
	     // 
	     // logo
	     // 
	     this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
	     this.logo.Location = new System.Drawing.Point(183, 118);
	     this.logo.Name = "logo";
	     this.logo.Size = new System.Drawing.Size(241, 88);
	     this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
	     this.logo.TabIndex = 4;
	     this.logo.TabStop = false;
	     // 
	     // copyright
	     // 
	     this.copyright.AutoSize = true;
	     this.copyright.FontSize = MetroFramework.MetroLabelSize.Small;
	     this.copyright.Location = new System.Drawing.Point(482, 475);
	     this.copyright.Name = "copyright";
	     this.copyright.Size = new System.Drawing.Size(111, 15);
	     this.copyright.TabIndex = 5;
	     this.copyright.Text = "@BT Electronics 2017";
	     this.copyright.TextAlign = System.Drawing.ContentAlignment.BottomRight;
	     // 
	     // errorLabel
	     // 
	     this.errorLabel.AutoSize = true;
	     this.errorLabel.BackColor = System.Drawing.Color.White;
	     this.errorLabel.ForeColor = System.Drawing.Color.Red;
	     this.errorLabel.Location = new System.Drawing.Point(175, 289);
	     this.errorLabel.Name = "errorLabel";
	     this.errorLabel.Size = new System.Drawing.Size(0, 0);
	     this.errorLabel.TabIndex = 6;
	     this.errorLabel.UseCustomForeColor = true;
	     // 
	     // StartupScreen
	     // 
	     this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
	     this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
	     this.ClientSize = new System.Drawing.Size(600, 500);
	     this.Controls.Add(this.errorLabel);
	     this.Controls.Add(this.copyright);
	     this.Controls.Add(this.logo);
	     this.Controls.Add(this.registerButton);
	     this.Controls.Add(this.loginButton);
	     this.Controls.Add(this.passwordBox);
	     this.Controls.Add(this.usernameBox);
	     this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
	     this.MaximizeBox = false;
	     this.Name = "StartupScreen";
	     this.Resizable = false;
	     this.Text = "Login or Register";
	     this.Theme = MetroFramework.MetroThemeStyle.Default;
	     this.Load += new System.EventHandler(this.Form1_Load);
	     ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
	     this.ResumeLayout(false);
	     this.PerformLayout();

	 }

	 #endregion

	 private MetroFramework.Controls.MetroTextBox usernameBox;
	 private MetroFramework.Controls.MetroTextBox passwordBox;
	 private MetroFramework.Controls.MetroButton loginButton;
	 private MetroFramework.Controls.MetroButton registerButton;
	 private System.Windows.Forms.PictureBox logo;
	 private MetroFramework.Controls.MetroLabel copyright;
	 private MetroFramework.Controls.MetroLabel errorLabel;
    }
}

