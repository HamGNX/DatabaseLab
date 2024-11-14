
<?php

require_once "connect_1.php";

$p_id = $_POST['p_id'];
$p_name = $_POST['p_name'];
$p_price = $_POST['p_price'];

$q = "UPDATE product SET p_name = '$p_name', p_price = $p_price WHERE p_id = $p_id";

if ($conn->query($q)) {
    echo "Record updated successfully<br>";
} else {
    echo "UPDATE failed. ERROR: {$conn->error}<br>";
}
$conn->close();
header("Location: practice_2.php");