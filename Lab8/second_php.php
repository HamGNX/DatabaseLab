<!DOCTYPE html>
<html>
<body>
<table border="1">
<?php $i = 1; ?>
<?php while($i <= 10) { ?>
<tr><td><?= $i?></td><td><?= str_repeat("*"
, $i) ?></td></tr>
<?php $i++; ?>
<?php } ?>
</table>
</body>
</html>
<!DOCTYPE html>
<html>
<body>
<table border="1">
<?php for($i=1; $i<=10; $i++): ?>
<tr><td><?= $i?></td><td><?= str_repeat("*"
, $i)
?></td></tr>
<?php endfor; ?>
</table>
</body>
</html>