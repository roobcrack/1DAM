<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Manejo textos</title>
</head>
<body>
    <?php
        $lado = 18.24;
        $areaCuadrado = $lado * $lado;

        $textoResultado = "El area calculada del cuadrado es: " . number_format($areaCuadrado, 2);
        echo $textoResultado;
        echo "<br>";

        $textoResultadoMayus = strtoupper($textoResultado);
        echo $textoResultadoMayus;
        echo "<br>";

        $textoResultadoModificado = str_replace("calculada", "obtenida", $textoResultado);
        echo $textoResultadoModificado;
        echo "<br>";

        $longitudTexto = strlen($textoResultadoModificado);
        echo "Longitud: " . $longitudTexto;
        echo "<br>";

        $posicionCuadrado = strpos($textoResultadoModificado, "cuadrado");
        echo "La palabra cuadrado esta situada en la posicion: " . $posicionCuadrado;
    ?>
</body>
</html>
