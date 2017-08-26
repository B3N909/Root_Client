using MetroFramework;
using MetroFramework.Forms;

namespace Root_Client
{
    partial class Dashboard : MetroForm
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
	     System.Windows.Forms.ListViewGroup listViewGroup16 = new System.Windows.Forms.ListViewGroup("Pending", System.Windows.Forms.HorizontalAlignment.Left);
	     System.Windows.Forms.ListViewGroup listViewGroup17 = new System.Windows.Forms.ListViewGroup("Processed", System.Windows.Forms.HorizontalAlignment.Left);
	     System.Windows.Forms.ListViewGroup listViewGroup18 = new System.Windows.Forms.ListViewGroup("Error", System.Windows.Forms.HorizontalAlignment.Left);
	     System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem(new string[] {
            "Savant Whillsmiter",
            "1 BTC",
            "Pending"}, -1);
	     System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem(new string[] {
            "John Doe",
            "45 LTC",
            "Error"}, -1);
	     System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
	     this.metroListView1 = new MetroFramework.Controls.MetroListView();
	     this.From = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
	     this.Amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
	     this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
	     this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
	     this.accountButton = new MetroFramework.Controls.MetroButton();
	     this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
	     this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
	     this.pictureBox1 = new System.Windows.Forms.PictureBox();
	     ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
	     this.SuspendLayout();
	     // 
	     // metroListView1
	     // 
	     this.metroListView1.Activation = System.Windows.Forms.ItemActivation.TwoClick;
	     this.metroListView1.CheckBoxes = true;
	     this.metroListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.From,
            this.Amount,
            this.Status});
	     this.metroListView1.Font = new System.Drawing.Font("Segoe UI", 12F);
	     this.metroListView1.FullRowSelect = true;
	     this.metroListView1.GridLines = true;
	     listViewGroup16.Header = "Pending";
	     listViewGroup16.Name = "Pending";
	     listViewGroup17.Header = "Processed";
	     listViewGroup17.Name = "Processed";
	     listViewGroup18.Header = "Error";
	     listViewGroup18.Name = "Error";
	     this.metroListView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup16,
            listViewGroup17,
            listViewGroup18});
	     this.metroListView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
	     listViewItem11.Group = listViewGroup16;
	     listViewItem11.StateImageIndex = 0;
	     listViewItem12.Group = listViewGroup17;
	     listViewItem12.StateImageIndex = 0;
	     this.metroListView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem11,
            listViewItem12});
	     this.metroListView1.Location = new System.Drawing.Point(381, 91);
	     this.metroListView1.Name = "metroListView1";
	     this.metroListView1.OwnerDraw = true;
	     this.metroListView1.Size = new System.Drawing.Size(317, 362);
	     this.metroListView1.TabIndex = 1;
	     this.metroListView1.UseCompatibleStateImageBehavior = false;
	     this.metroListView1.UseSelectable = true;
	     this.metroListView1.View = System.Windows.Forms.View.Details;
	     this.metroListView1.SelectedIndexChanged += new System.EventHandler(this.metroListView1_SelectedIndexChanged);
	     // 
	     // From
	     // 
	     this.From.Text = "From";
	     this.From.Width = 437;
	     // 
	     // Amount
	     // 
	     this.Amount.Text = "Amount";
	     this.Amount.Width = 77;
	     // 
	     // Status
	     // 
	     this.Status.Text = "Status";
	     this.Status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
	     this.Status.Width = 157;
	     // 
	     // metroLabel1
	     // 
	     this.metroLabel1.AutoSize = true;
	     this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
	     this.metroLabel1.Location = new System.Drawing.Point(23, 60);
	     this.metroLabel1.Name = "metroLabel1";
	     this.metroLabel1.Size = new System.Drawing.Size(65, 25);
	     this.metroLabel1.TabIndex = 0;
	     this.metroLabel1.Text = "History";
	     // 
	     // accountButton
	     // 
	     this.accountButton.Location = new System.Drawing.Point(528, 459);
	     this.accountButton.Name = "accountButton";
	     this.accountButton.Size = new System.Drawing.Size(170, 29);
	     this.accountButton.TabIndex = 2;
	     this.accountButton.Text = "Accounts...";
	     this.accountButton.UseSelectable = true;
	     this.accountButton.Click += new System.EventHandler(this.accountButton_Click);
	     // 
	     // metroLabel2
	     // 
	     this.metroLabel2.AutoSize = true;
	     this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
	     this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
	     this.metroLabel2.Location = new System.Drawing.Point(562, 48);
	     this.metroLabel2.Name = "metroLabel2";
	     this.metroLabel2.Size = new System.Drawing.Size(118, 25);
	     this.metroLabel2.TabIndex = 3;
	     this.metroLabel2.Text = "$503.23 USD";
	     // 
	     // metroLabel3
	     // 
	     this.metroLabel3.AutoSize = true;
	     this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
	     this.metroLabel3.Location = new System.Drawing.Point(579, 23);
	     this.metroLabel3.Name = "metroLabel3";
	     this.metroLabel3.Size = new System.Drawing.Size(85, 25);
	     this.metroLabel3.TabIndex = 4;
	     this.metroLabel3.Text = "Summary";
	     // 
	     // pictureBox1
	     // 
	     this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
	     this.pictureBox1.Location = new System.Drawing.Point(-2, -4);
	     this.pictureBox1.Name = "pictureBox1";
	     this.pictureBox1.Size = new System.Drawing.Size(195, 593);
	     this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
	     this.pictureBox1.TabIndex = 5;
	     this.pictureBox1.TabStop = false;
	     this.pictureBox1.WaitOnLoad = true;
	     // 
	     // Dashboard
	     // 
	     this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
	     this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
	     this.ClientSize = new System.Drawing.Size(721, 496);
	     this.Controls.Add(this.pictureBox1);
	     this.Controls.Add(this.metroLabel3);
	     this.Controls.Add(this.metroLabel2);
	     this.Controls.Add(this.accountButton);
	     this.Controls.Add(this.metroListView1);
	     this.Controls.Add(this.metroLabel1);
	     this.MaximizeBox = false;
	     this.Name = "Dashboard";
	     this.Resizable = false;
	     this.Text = "Dashboard";
	     this.Theme = MetroFramework.MetroThemeStyle.Default;
	     ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
	     this.ResumeLayout(false);
	     this.PerformLayout();

	 }
	 #endregion

	 private MetroFramework.Controls.MetroListView metroListView1;
	 private System.Windows.Forms.ColumnHeader From;
	 private System.Windows.Forms.ColumnHeader Amount;
	 private System.Windows.Forms.ColumnHeader Status;
	 private MetroFramework.Controls.MetroLabel metroLabel1;
	 private MetroFramework.Controls.MetroButton accountButton;
	 private MetroFramework.Controls.MetroLabel metroLabel2;
	 private MetroFramework.Controls.MetroLabel metroLabel3;
	 private System.Windows.Forms.PictureBox pictureBox1;




    }
}