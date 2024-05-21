<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Cuenta</title>
</head>
<body>
    <?php
        for ($i=2; $i<=100; $i+=2) {
            echo $i;
            if ($i < 100) 
                echo ", ";
        }

        echo "<br><br>";

        $j = 10;
        while ($j>=0) {
            echo $j;
            if ($j-->0) 
                echo " - ";
        }
    ?>
</body>
</html>