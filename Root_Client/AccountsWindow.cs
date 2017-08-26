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

namespace Root_Client
{
    public partial class AccountsWindow : MetroForm
    {
	 public AccountsWindow()
	 {
	     InitializeComponent();
	 }

	 private void AccountsWindow_Load(object sender, EventArgs e)
	 {

	 }

	 private async void FadeOut()
	 {
	     while (Opacity > 0)
	     {
		  await Task.Delay(1);
		  Opacity -= 0.035f;
	     }
	     Opacity = 0;
	     Visible = false;
	     new Dashboard()
		  .Show();
	 }

	 protected override void OnClosing(CancelEventArgs args)
	 {
	     args.Cancel = true;
	     FadeOut();
	 }
    }
}
