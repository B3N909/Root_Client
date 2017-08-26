using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace Root_Client
{
    public partial class Dashboard : MetroForm
    {
	 public Dashboard()
	 {
	     InitializeComponent();
	 }

	 private void metroTile1_Click(object sender, EventArgs e)
	 {

	 }

	 private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
	 {

	 }

	 private void metroListView1_SelectedIndexChanged(object sender, EventArgs e)
	 {

	 }

	 private void usdAmount_Click(object sender, EventArgs e)
	 {

	 }

	 private void metroTextBox1_Click(object sender, EventArgs e)
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
	     new AccountsWindow()
		  .Show();
	 }

	 private void accountButton_Click(object sender, EventArgs e)
	 {
	     FadeOut();
	 }

	 protected override void OnClosed(EventArgs args)
	 {
	     Application.Exit();
	 }
    }
}
