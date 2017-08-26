<?php
include_once 'dbconnect.php';

$user = trim(strip_tags(htmlspecialchars($_GET['user'])));

$query = mysqli_query($connection, "SELECT * FROM users WHERE username = '$user'");
while($row = mysqli_fetch_array($query))
{
	print_r($query['btc_address']);
}

?>