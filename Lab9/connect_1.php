
<?php
// Database credentials
$servername = "localhost";
$username = "root";
$password = "root";  // Replace with your actual MySQL root password if different
$dbname = "example_db";  // Replace with your database name

// Create connection
$conn = new mysqli($servername, $username, $password, $dbname);

// Check the connection
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
}
echo "Connected successfully";
?>