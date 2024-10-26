
<?php
$mysql = new mysqli("localhost:8889", "root", "root", "lab9");
if($mysql->connect_errno){
    echo $mysql->connect_errno.": ".$mysql->connect_error;
}
 $p_id = $_GET['id'];
 $mysql = new mysqli("localhost:8889", "root", "root", "lab9");
if($mysql->connect_errno){
    echo $mysql->connect_errno.": ".$mysql->connect_error;
}
$q="DELETE FROM product WHERE p_id=$p_id";
if(!$mysql->query($q)){
    echo "DELETE failed. Error: ".$mysql->error;
}
$mysql->close();
header("Location: viewinfo.php");

?>

