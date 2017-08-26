using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Threading;
using System.ComponentModel;
using System.Windows;
using System.Windows.Forms;

namespace Root_Client
{
    public partial class StartupScreen : MetroForm
    {
	 ConnectionHandler connection = new ConnectionHandler();

	 public StartupScreen()
	 {
	     InitializeComponent();
	 }

	 private void Form1_Load(object sender, EventArgs e)
	 {

	 }

	 private Thread t;

	 private void registerButton_Click(object sender, EventArgs e)
	 {
	     if (t == null || !t.IsAlive)
	     {
		  errorLabel.ForeColor = System.Drawing.Color.Orange;
		  errorLabel.Text = "Loading, please wait...";

		  ThreadStart start = threadRegister;

		  t = new Thread(start);
		  t.Start();
	     }
	     else
	     {
		  errorLabel.Text = "Still loading...";
	     }
	 }

	 private void loginButton_Click(object sender, EventArgs e)
	 {
	     if(t == null || !t.IsAlive)
	     {
		  errorLabel.ForeColor = System.Drawing.Color.Orange;
		  errorLabel.Text = "Loading, please wait...";

		  ThreadStart start = threadLogin;

		  t = new Thread(start);
		  t.Start();
	     }
	     else
	     {
		  errorLabel.Text = "Still loading...";
	     }
	 }

	 private void threadRegister()
	 {
	     connection.register(usernameBox.Text, passwordBox.Text);
	     if (InvokeRequired == true)
	     {
		  Invoke(new MethodInvoker(UpdateLabel));
	     }
	 }


	 private void threadLogin()
	 {
	     if(connection.login(usernameBox.Text, passwordBox.Text))
	     {
		  if (InvokeRequired == true)
		  {
		      Invoke(new MethodInvoker(UpdateLabel));
		  }
		  if(connection.Validate(Program.auth))
		  {
		      if (InvokeRequired == true)
		      {
			   Invoke(new MethodInvoker(FadeOut));
		      }
		  }
		  else
		  {
		      if (InvokeRequired == true)
		      {
			   Invoke(new MethodInvoker(FailValidating));
		      }
		  }
	     }
	     else
	     {
		  if (InvokeRequired == true)
		  {
		      Invoke(new MethodInvoker(UpdateLabel));
		  }
	     }
	 }

	 private void FailValidating()
	 {
	     errorLabel.ForeColor = System.Drawing.Color.Red;
	     errorLabel.Text = "Failed to validate, please try again...";
	 }

	 private void UpdateLabel()
	 {
	     connection.responseLabel(errorLabel);
	     passwordBox.Clear();
	 }

	 private async void FadeOut()
	 {
	     errorLabel.ForeColor = System.Drawing.Color.Green;
	     errorLabel.Text = "Success!";
	     while(Opacity > 0)
	     {
		  await Task.Delay(1);
		  Opacity -= 0.01f;
	     }
	     Opacity = 0;
	     Visible = false;
	     new Dashboard()
		  .Show();
	 }

	 private void passwordBox_ButtonDown(object sender, KeyEventArgs e)
	 {
	     if(e.KeyCode == System.Windows.Forms.Keys.Return)
	     {
		  loginButton_Click(null, null);
	     }
	 }

    }
}
