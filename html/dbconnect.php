<?php

define("dbhost", "localhost");
define("dbuser", "root");
define("dbpassword", "7admin123");
define("dbname", "root");

$connection = mysqli_connect(dbhost, dbuser, dbpassword, dbname);
$database = mysqli_select_db($connection, dbname);

if(!$connection)
{
	die("Error : " . "Failed to connect to server");
}

if(!$database)
{
	die("Error : " . "Failed to connect to database");
}
?>