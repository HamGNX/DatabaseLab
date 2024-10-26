
<?php
// Database credentials
$servername = "localhost:8889";
$username = "root";
$password = "root";  // Replace with your actual MySQL root password if different
$dbname = "lab9";  // Replace with your database name

// Create connection
$conn = new mysqli($servername, $username, $password, $dbname);

// Check the connection
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
}
echo "Connected successfully";

$q = "SELECT * FROM product";
if($result=$conn->query($q)){
echo '<table border="1">';
echo '<tr><th>Name</th><th>Price</th><th>Delete</th></tr>';
while($row=$result->fetch_array()){
echo '<tr>';
echo '<td>'.$row['p_name'].'</td>';
echo '<td>'.$row['p_price'].'</td>';
echo '<td><a href="delinfo.php?id='.$row['p_id'].'">Delete</a></td>';
echo '</tr>';
}
echo '</table>';
$result->free();
}else{
    echo "Retrieval failed: " .$conn->error;
}
?>

