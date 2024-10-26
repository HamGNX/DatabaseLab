
<?php

require_once ('connect_1.php');
$q = "SELECT * FROM product";
if($result=$conn->query($q)){
echo '<table border="1">';
echo '<tr><th>ID</th><th>Name</th><th>Price</th><th>Delete</th></tr>';
while($row=$result->fetch_array()){
echo '<tr>';
echo '<td>'.$row['p_id'].'</td>';
echo '<td>'.$row['p_name'].'</td>';
echo '<td>'.$row['p_price'].'</td>';
echo '<td><a href="editinfo2.php?id='.$row['p_id'].'">Edit</a></td>';
echo '</tr>';
}
echo '</table>';
$result->free();
}else{
    echo "Retrieval failed: " .$conn->error;
}

?>

