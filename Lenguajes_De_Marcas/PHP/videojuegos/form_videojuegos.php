<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Videojuegos</title>
</head>
<body>
    <h1>Buscador de videojuegos</h1>
    <form action="result_videojuegos.php" method="post">
        <fieldset style="width: 400px;">
            <legend>Formulario busqueda</legend>
            <label for="nombre"><b>Texto de busqueda:</b></label>
            <input type="text" id="nombre" name="nombre"><br><br>

            <label><b>Buscar en:</b></label><br>
            <input type="radio" id="titulo" name="buscar" value="Titulo del videojuego"checked>
            <label for="accion">Titulo del videojuego</label><br>
            <input type="radio" id="nombre" name="buscar" value="Nombre del desarrollador">
            <label for="nombre">Nombre del desarrollador</label><br>
            <input type="radio" id="distribuidor" name="buscar" value="Distribuidor">
            <label for="distribuidor">Distribuidor</label><br><br>

            <label><b>Tipo de videojuego:</b></label>
            <select name="tipo">
                <option value="Accion">Accion</option>
                <option value="Aventura">Aventura</option>
                <option value="Estrategia">Estrategia</option>
            </select><br><br><br>

            <input type="submit" value="Enviar">
        </fieldset>
    </form>
</body>
</html>