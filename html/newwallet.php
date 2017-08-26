<?php
include_once 'dbconnect.php';
require_once('block_io.php');

$apiKey = "f211-6aaa-c19e-46de";
$version = 2;
$pin = "GeG9uda29H4r2THM77Uu4hx";
$block_io = new BlockIo($apiKey, $pin, $version);

$username = trim(strip_tags(htmlspecialchars($_GET["username"])));
$password = trim(strip_tags(htmlspecialchars($_GET["hash"])));

$btc = $block_io->get_new_address(array('label' => $username));
if($btc->status != "success")
{
	die("Error : Failed to create unique address");
}
$address = $btc->data->address;

$updateQuery = mysqli_query($connection, "INSERT INTO users (username, password, btc_address) VALUES ('$username', '$password', '$address')");
if(!$updateQuery)
{
	die("Error : Failed to query database");
}
else
{
	print("Done");
}
?>