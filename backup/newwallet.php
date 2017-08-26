<?php
require_once('block_io.php');

$apiKey = "f211-6aaa-c19e-46de";
$version = 2;
$pin = "GeG9uda29H4r2THM77Uu4hx";
$block_io = new BlockIo($apiKey, $pin, $version);

$connection = mysqli_connect("localhost", "root", "7admin123");
$database = mysqli_select_db($connection, "root");

if(!$connection)
{
	die("Error : Failed to connect to server");
}

if(!$database)
{
	die("Error : Failed to connect to database");
}

$username = trim(strip_tags(htmlspecialchars($_GET["username"])));
$password = $_GET["hash"];

$btc = $block_io->get_new_address(array('label' => $username));
if($btc->status != "success")
{
	die("Error : Failed to create unique address");
}

$address = $btc->address;

$updateQuery = mysqli_query($connection, "INSERT INTO users (username, password, btc_address) VALUES ('$username', '$password', '$address')");
if(!$updateQuery)
{
	die("Error : Failed to query database");
}
?>