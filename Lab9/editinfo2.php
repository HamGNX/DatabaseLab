<?php
$p_id = $_GET['id'];
require_once ('connect_1.php');
$q="SELECT * FROM product WHERE p_id=$p_id";
$result=$conn->query($q);
echo '<form action="editinfo.php" method="post">';
while($row=$result->fetch_array()){
    echo 
}