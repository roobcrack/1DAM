-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 20, 2024 at 05:51 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `captura_creativa`
--

-- --------------------------------------------------------

--
-- Table structure for table `comentario`
--

CREATE TABLE `comentario` (
  `idcomentario` int(11) NOT NULL,
  `contenido` text NOT NULL,
  `idpublicacion` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `perfil`
--

CREATE TABLE `perfil` (
  `idperfil` int(11) NOT NULL,
  `nombreperfil` varchar(255) NOT NULL,
  `resumen` text DEFAULT NULL,
  `idusuario` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `perfil`
--

INSERT INTO `perfil` (`idperfil`, `nombreperfil`, `resumen`, `idusuario`) VALUES
(1, 'nocheoscura', 'frases que hipnotizan', 3),
(2, 'amanecer', 'pensamientos matutinos', 1),
(3, 'solitario', 'reflexiones de soledad', 2),
(4, 'viajero', 'aventuras alrededor del mundo', 5),
(5, 'poetaurbano', 'poesía en la ciudad', 4),
(6, 'musica', 'melodías para el alma', 6),
(7, 'arte', 'creaciones visuales', 7),
(8, 'naturaleza', 'belleza del entorno', 8),
(9, 'deporte', 'vida saludable', 9),
(10, 'cinefilo', 'críticas de cine', 10),
(11, 'lector', 'reseñas de libros', 1),
(12, 'gamer', 'mundo de videojuegos', 2),
(13, 'cocinero', 'recetas y gastronomía', 3),
(14, 'viajeastral', 'exploraciones místicas', 4),
(15, 'historia', 'relatos del pasado', 5),
(16, 'moda', 'tendencias actuales', 6),
(17, 'fotografo', 'capturas de momentos', 7),
(18, 'programador', 'código y desarrollo', 8),
(19, 'cientifico', 'descubrimientos e investigaciones', 9),
(20, 'filosofo', 'pensamientos profundos', 10),
(21, 'ingeniero', 'soluciones técnicas', 1),
(22, 'doctor', 'consejos de salud', 2),
(23, 'maestro', 'lecciones de vida', 3),
(24, 'investigador', 'misterios sin resolver', 4),
(25, 'bailarin', 'movimientos y ritmos', 5),
(26, 'cantante', 'voces y melodías', 6),
(27, 'pintor', 'colores y lienzos', 7),
(28, 'explorador', 'rutas y descubrimientos', 8),
(29, 'diseñador', 'creatividad digital', 9),
(30, 'astronomo', 'el universo y más allá', 10);

-- --------------------------------------------------------

--
-- Table structure for table `publicacion`
--

CREATE TABLE `publicacion` (
  `idpublicacion` int(11) NOT NULL,
  `titulo` varchar(255) NOT NULL,
  `descripcion` text DEFAULT NULL,
  `idperfil` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `publicacion`
--

INSERT INTO `publicacion` (`idpublicacion`, `titulo`, `descripcion`, `idperfil`) VALUES
(1, 'el misterio de la noche', 'en la profundidad de la noche, las estrellas brillan con un misterio eterno. cada una cuenta una historia, iluminando los secretos ocultos del universo.', 1),
(2, 'la magia del amanecer', 'el amanecer trae consigo un nuevo comienzo. los primeros rayos del sol despiertan la tierra, llenando el cielo de colores vibrantes y renovando nuestras esperanzas.', 2),
(3, 'reflexiones solitarias', 'la soledad puede ser un refugio para la mente. en esos momentos de silencio, encontramos claridad y entendimiento sobre nuestras vidas y el mundo que nos rodea.', 3),
(4, 'aventuras alrededor del mundo', 'viajar nos permite descubrir nuevas culturas y paisajes. cada destino ofrece una experiencia única, ampliando nuestra perspectiva y enriqueciendo nuestras vidas.', 4),
(5, 'poesía urbana', 'en la ciudad, la poesía se encuentra en cada esquina. los grafitis, los susurros del viento entre los edificios y las luces de neón crean una melodía poética única.', 5),
(6, 'melodías para el alma', 'la música tiene el poder de tocar el alma. cada nota, cada acorde, puede evocar emociones profundas y conectar a las personas de manera universal.', 6),
(7, 'creaciones visuales', 'el arte visual es una forma de expresión poderosa. a través de colores, formas y texturas, los artistas comunican ideas y sentimientos que van más allá de las palabras.', 7),
(8, 'belleza del entorno', 'la naturaleza nos muestra la belleza en su forma más pura. desde los majestuosos paisajes montañosos hasta los tranquilos bosques, cada rincón del mundo natural es un tesoro.', 8),
(9, 'vida saludable', 'el deporte y la actividad física son esenciales para una vida saludable. no solo fortalecen el cuerpo, sino que también mejoran el bienestar mental y emocional.', 9),
(10, 'críticas de cine', 'el cine es una ventana a diferentes mundos y realidades. a través de las películas, podemos explorar historias fascinantes y personajes complejos, enriqueciendo nuestra visión del mundo.', 10),
(11, 'reseñas de libros', 'la lectura nos abre puertas a nuevos conocimientos y experiencias. cada libro es una aventura, una fuente de sabiduría que nos permite crecer y aprender continuamente.', 11),
(12, 'mundo de videojuegos', 'los videojuegos son una forma de arte interactiva. nos sumergen en mundos virtuales donde podemos vivir historias épicas y desafiar nuestros límites.', 12),
(13, 'recetas y gastronomía', 'cocinar es una forma de arte que involucra todos los sentidos. las recetas y la gastronomía nos permiten explorar culturas y sabores, creando momentos memorables.', 13),
(14, 'exploraciones místicas', 'los viajes astrales nos llevan más allá de nuestra realidad física. a través de estas experiencias, exploramos dimensiones desconocidas y profundizamos en nuestro ser interior.', 14),
(15, 'relatos del pasado', 'la historia está llena de relatos fascinantes. al conocer el pasado, entendemos mejor nuestro presente y podemos aprender valiosas lecciones para el futuro.', 15),
(16, 'tendencias actuales', 'la moda refleja la cultura y el espíritu de cada época. a través de las tendencias, expresamos nuestra identidad y nos conectamos con el mundo que nos rodea.', 16),
(17, 'capturas de momentos', 'la fotografía es el arte de capturar momentos efímeros. cada imagen cuenta una historia y preserva recuerdos que podemos revivir una y otra vez.', 17),
(18, 'código y desarrollo', 'la programación es una habilidad poderosa en el mundo moderno. a través del código, creamos soluciones innovadoras y transformamos nuestras ideas en realidad.', 18),
(19, 'descubrimientos e investigaciones', 'la ciencia avanza gracias a la curiosidad y el esfuerzo humano. cada descubrimiento es un paso adelante en nuestro entendimiento del universo.', 1),
(20, 'pensamientos profundos', 'la filosofía nos invita a cuestionar y reflexionar sobre la vida. a través del pensamiento profundo, buscamos respuestas a las grandes preguntas de la existencia.', 2),
(21, 'soluciones técnicas', 'la ingeniería combina creatividad y precisión. los ingenieros diseñan soluciones técnicas que mejoran nuestra vida diaria y resuelven problemas complejos.', 3),
(22, 'consejos de salud', 'la medicina nos brinda herramientas para cuidar nuestra salud. los consejos médicos son esenciales para prevenir enfermedades y mantener un bienestar óptimo.', 4),
(23, 'lecciones de vida', 'los maestros nos guían en el camino del conocimiento. a través de sus lecciones, aprendemos no solo materias, sino también valores y habilidades para la vida.', 5),
(24, 'misterios sin resolver', 'los investigadores se enfrentan a los enigmas del mundo. resolver misterios es un desafío emocionante que nos acerca a la verdad.', 6),
(25, 'movimientos y ritmos', 'el baile es una expresión artística que combina movimientos y ritmos. a través de la danza, comunicamos emociones y nos conectamos con nuestra esencia.', 7),
(26, 'voces y melodías', 'el canto es una forma de expresión que toca el alma. las voces y melodías nos transportan a lugares emocionales profundos y nos unen como seres humanos.', 8);

-- --------------------------------------------------------

--
-- Table structure for table `usuario`
--

CREATE TABLE `usuario` (
  `idusuario` int(11) NOT NULL,
  `nombre` varchar(255) NOT NULL,
  `contraseña` varchar(255) NOT NULL,
  `rol` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `usuario`
--

INSERT INTO `usuario` (`idusuario`, `nombre`, `contraseña`, `rol`) VALUES
(1, 'juan', 'juan123', 'administrador'),
(2, 'maria', 'maria123', 'usuario'),
(3, 'pedro', 'pedro123', 'administrador'),
(4, 'laura', 'laura123', 'usuario'),
(5, 'carlos', 'carlos123', 'administrador'),
(6, 'ana', 'ana123', 'usuario'),
(7, 'diego', 'diego123', 'administrador'),
(8, 'elena', 'elena123', 'usuario'),
(9, 'miguel', 'miguel123', 'administrador'),
(10, 'sara', 'sara123', 'usuario'),
(11, 'javier', 'javier123', 'administrador'),
(12, 'lucia', 'lucia123', 'usuario'),
(13, 'alejandro', 'alejandro123', 'administrador'),
(14, 'carmen', 'carmen123', 'usuario'),
(15, 'pablo', 'pablo123', 'administrador');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `comentario`
--
ALTER TABLE `comentario`
  ADD PRIMARY KEY (`idcomentario`),
  ADD KEY `idpublicacion` (`idpublicacion`);

--
-- Indexes for table `perfil`
--
ALTER TABLE `perfil`
  ADD PRIMARY KEY (`idperfil`),
  ADD KEY `idusuario` (`idusuario`);

--
-- Indexes for table `publicacion`
--
ALTER TABLE `publicacion`
  ADD PRIMARY KEY (`idpublicacion`),
  ADD KEY `idperfil` (`idperfil`);

--
-- Indexes for table `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`idusuario`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `comentario`
--
ALTER TABLE `comentario`
  ADD CONSTRAINT `comentario_ibfk_1` FOREIGN KEY (`idpublicacion`) REFERENCES `publicacion` (`idpublicacion`) ON DELETE CASCADE;

--
-- Constraints for table `perfil`
--
ALTER TABLE `perfil`
  ADD CONSTRAINT `perfil_ibfk_1` FOREIGN KEY (`idusuario`) REFERENCES `usuario` (`idusuario`) ON DELETE CASCADE;

--
-- Constraints for table `publicacion`
--
ALTER TABLE `publicacion`
  ADD CONSTRAINT `publicacion_ibfk_1` FOREIGN KEY (`idperfil`) REFERENCES `perfil` (`idperfil`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
