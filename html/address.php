<?php
include_once 'dbconnect.php';

$user = trim(strip_tags(htmlspecialchars($_GET['user'])));

$query = mysqli_query($connection, "SELECT * FROM users WHERE username = '$user'");
if(mysqli_num_rows($query) != 0)
{
	while($row = mysqli_fetch_array($query))
	{
		print_r($row['btc_address']);
	}
}
else
{
	print_r("Error");
}

?>