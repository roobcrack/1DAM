<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Resultado Videojuego</title>
</head>
<body>
    <?php
        $nombre = htmlspecialchars($_POST['nombre']);
        $buscar = htmlspecialchars($_POST['buscar']);
        $tipo = htmlspecialchars($_POST['tipo']);

        echo "<h2>Busqueda de videojuego</h2>";
        echo "<b>Texto de busqueda: </b>" . $nombre . "<br>";
        echo "<b>Buscar en: </b>" . $buscar . "<br>";
        echo "<b>Tipo de videojuego: </b>" . $tipo . "<br>";
    ?>
    <br>
    <a href="form_videojuegos.php">Volver al formulario</a>
</body>
</html>