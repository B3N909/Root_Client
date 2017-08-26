<?php
include_once 'dbconnect.php';

$auth = trim(strip_tags(htmlspecialchars($_GET['auth'])));

if(mysqli_num_rows(mysqli_query($connection, "SELECT * FROM authLogins WHERE auth = '$auth'")) >= 1)
{
	print_r("Valid");
}
else
{
	print_r("Fake");
}
?>
