using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Security.Cryptography;

namespace Root_Client
{
    class ConnectionHandler
    {
	 public static String response;

	 WebClient wc;

	 public ConnectionHandler()
	 {
	     response = "";
	     wc = new WebClient();
	 }

	 public bool register(string username, string password)
	 {
	     if(username.Contains(" "))
	     {
		  response = "No spaces allowed in usernames";
		  return false;
	     }
	     if(username.Length < 5)
	     {
		  response = "Username is less than 5 characters";
		  return false;
	     }
	     if(password.Contains(" "))
	     {
		  response = "No spaces allowed in passwords";
		  return false;
	     }
	     if(password.Length < 9)
	     {
		  response = "Password is less than 8 characters";
		  return false;
	     }
	     string str = wc.DownloadString("http://144.217.90.56/newuser.php?username=" + username + "&password=" + password);
	     if(str == "Done")
	     {
		  response = "Successfully registered, please log in!";
		  return true;
	     }
	     if(str.Contains(" : "))
	     {
		  String prefix = str.Split(new String[] {" : "}, StringSplitOptions.None)[0];
		  String error = str.Split(new String[] { " : " }, StringSplitOptions.None)[1];
		  if(prefix == "Error")
		  {
		      response = error;
		  }
		  else if(prefix == "ResponseError")
		  {
		      response = error;
		  }
		  return false;
	     }
	     response = "A fatal error has occurred";
	     return false;
	 }

	 public bool login(string username, string password)
	 {
	     if (username.Contains(" "))
	     {
		  response = "No spaces allowed in usernames";
		  return false;
	     }
	     if (username.Length < 5)
	     {
		  response = "Username is less than 5 characters";
		  return false;
	     }
	     if (password.Contains(" "))
	     {
		  response = "No spaces allowed in passwords";
		  return false;
	     }
	     if (password.Length < 9)
	     {
		  response = "Password is less than 8 characters";
		  return false;
	     }

	     SHA256Managed sha = new SHA256Managed();
	     byte[] h = sha.ComputeHash(Encoding.ASCII.GetBytes(password), 0, Encoding.ASCII.GetByteCount(password));
	     string hash = "";
	     foreach(byte b in h)
	     {
		  hash += b.ToString("x2");
	     }
	     string str = wc.DownloadString("http://144.217.90.56/login.php?username=" + username + "&hash=" + hash);

	     if (str.Contains(" : "))
	     {
		  String prefix = str.Split(new String[] { " : " }, StringSplitOptions.None)[0];
		  String error = str.Split(new String[] { " : " }, StringSplitOptions.None)[1];
		  if (prefix == "Error")
		  {
		      response = error;
		  }
		  else if (prefix == "ResponseError")
		  {
		      response = error;
		  }
		  else if(prefix == "Done")
		  {
		      Program.auth = error;
		      Program.username = username;
		      response = "Validating authorization";
		      return true;
		  }
		  return false;
	     }
	     response = "A fatal error has occurred";
	     return false;
	 }

	 public String getBitcoinAddress()
	 {
	     if (Validate(Program.auth))
	     {
		  string str = wc.DownloadString("http://144.217.90.56/address.php?user=" + Program.username);
		  if(str == "Error")
		  {
		      return str;
		  }
		  else
		  {
		      return "Error, cannot find address";
		  }
	     }
	     return "Error, try logging in again";
	 }

	 public bool Validate(string auth)
	 {
	     string str = wc.DownloadString("http://144.217.90.56/auth.php?auth=" + auth);
	     return str == "Valid";
	 }

	 public void responseLabel(MetroFramework.Controls.MetroLabel label)
	 {
	     if(response.Contains("Successfully"))
	     {
		  label.ForeColor = System.Drawing.Color.Green;
	     }
	     else if(response.Contains("Validating"))
	     {
		  label.ForeColor = System.Drawing.Color.Orange;
	     }
	     else
	     {
		  label.ForeColor = System.Drawing.Color.Red;
	     }
	     label.Text = response;
	 }
    }
}
