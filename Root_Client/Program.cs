using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Root_Client
{
    static class Program
    {
	 public static string auth;
	 public static string username;

	 /// <summary>
	 /// The main entry point for the application.
	 /// </summary>
	 [STAThread]
	 static void Main()
	 {
	     Application.EnableVisualStyles();
	     Application.SetCompatibleTextRenderingDefault(false);
	     Application.Run(new StartupScreen());
	 }
    }
}
