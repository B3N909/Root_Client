<?php
include_once 'dbconnect.php';

ini_set('display_errors', 'on');

$requestedUsername = trim(strip_tags(htmlspecialchars($_GET["username"])));
$requestedPassword = trim(strip_tags(htmlspecialchars($_GET["password"])));

$userQuery = mysqli_query($connection, "SELECT * FROM users WHERE username = '$requestedUsername'");

if(!$userQuery)
{
	die("Error : " . "Failed to connect to database");
}
else if(mysqli_num_rows($userQuery) == 0)
{
	$password = hash("sha256", $requestedPassword);
	header("Location: newwallet.php?username=" . $requestedUsername . "&hash=" . $password);
}
else
{
	die("ResponseError : " . "Username already taken");
}
?>