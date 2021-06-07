<?php
// Used to connect to the database which i saved in phpmyadmin

$dbServername = "localhost";
$dbUsername = "root";
$dbPassword = "";
$dbName = "aero_database";

$conn = mysqli_connect($dbServername, $dbUsername, $dbPassword, $dbName);


?>