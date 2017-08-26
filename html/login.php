<?php
include_once 'dbconnect.php';

$username = trim(strip_tags(htmlspecialchars($_GET['username'])));
$hash = trim(strip_tags(htmlspecialchars($_GET['hash'])));

$query = mysqli_query($connection, "SELECT user_id FROM users WHERE (username = '$username' AND password = '$hash')");
if(!$query)
{
	die("ResponseError : Username or Password incorrect");
}
else
{
	$num = 0;
	while($row = mysqli_fetch_array($query))
	{
		$userId = $row[0];
		$num = 1;

		$auth = uniqid("auth");
		if(mysqli_num_rows(mysqli_query($connection, "SELECT * FROM authLogins WHERE user_id = '$userId'")) == 0)
		{
			//Insert
			$authQuery = mysqli_query($connection, "INSERT INTO authLogins (user_id, auth) VALUES ('$userId', '$auth')");
		}
		else
		{
			//Update
			$authQuery = mysqli_query($connection, "UPDATE authLogins SET auth = '$auth' WHERE user_id = '$userId'");
		}
		if(!$authQuery)
		{
			die("Error : Cannot authorize user");
		}
		else
		{
			print_r("Done : " . $auth);
		}
	}
	if($num == 0)
	{
		die("ResponseError : Username or Password incorrect");
	}
}
?>