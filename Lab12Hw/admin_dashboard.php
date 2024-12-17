<?php
$servername = "localhost:8889";
$username = $_POST['username'];
$password = $_POST['password'];
$dbname = "cust";

// Create connection
$conn = new mysqli($servername, $username, $password, $dbname);

// Check connection
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
}

// Fetch account data
$sql = "SELECT `No.`, `Name`, `bal` FROM account";
$result = $conn->query($sql);

if ($result->num_rows > 0) {
    echo "<h1>Account Details</h1>";
    echo "<table border='1'>";
    echo "<tr><th>Account No</th><th>Name</th><th>Balance</th></tr>";
    while ($row = $result->fetch_assoc()) {
        echo "<tr><td>" . $row["No."] . "</td><td>" . $row["Name"] . "</td><td>" . $row["bal"] . "</td></tr>";
    }
    echo "</table>";
} else {
    echo "No records found.";
}

$conn->close();
?>