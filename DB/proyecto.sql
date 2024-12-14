-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 14-12-2024 a las 21:32:33
-- Versión del servidor: 10.4.25-MariaDB
-- Versión de PHP: 8.1.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `proyecto`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `consolesplay`
--

CREATE TABLE `consolesplay` (
  `Id` int(11) NOT NULL,
  `nombre` varchar(50) NOT NULL,
  `descripcion` text NOT NULL,
  `precio` int(50) NOT NULL,
  `Existencias` int(50) NOT NULL,
  `imagen` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `consolesplay`
--

INSERT INTO `consolesplay` (`Id`, `nombre`, `descripcion`, `precio`, `Existencias`, `imagen`) VALUES
(349, 'Playstation 5', 'PlayStation 5 is the fifth desktop video game console developed by Sony Interactive Entertainment, while being the third Sony console to be designed by Mark Cerny. It was announced in December 2019 as the successor to the PlayStation 4.', 11500, 19, 'Playstation5.jpg'),
(3455, 'PlayStation 4', 'PlayStation 4 (Playstation 4, officially abbreviated as PS4) is the fourth desktop game console produced by Sony Computer Entertainment. It was designed by Mark Cerny and is part of the eighth-generation game consoles. It was officially announced on February 20, 2013 at the PlayStation Meeting 2013 event, although the console\'s design was not unveiled until June 10 at E3 2013.', 5600, 22, 'PlayStation4.jpg'),
(87653, 'PSP', 'PlayStation Portable (PSP) is a portable video game console of the Japanese multinational company, and the fourth Sony console to be designed by Ken Kutaragi, PSP served for video games, connecting to the Internet and playing and watching multimedia. It is the first portable console worldwide Sony and the second launched in Japan.', 4164, 7, 'Playstation6.jpg'),
(302547, 'PlayStation 2', 'PlayStation 2 (Japanese: プレイステーション2 Pureisutēshon Tsu, officially abbreviated as PS2) is the second tabletop video game console produced by Sony Computer Entertainment. It was the third Sony console to be designed by Japanese Ken Kutaragi, as well as being the successor to the PlayStation. It competed with Dreamcast, GameCube and the first Xbox.', 3386, 20, 'PlayStation2.jpg'),
(302548, 'PlayStation 3', 'The PlayStation 3 is the third discontinued desktop video game console produced by Sony Computer Entertainment. It was Sony\'s fifth and final console to be designed by Ken Kutaragi and was part of the seventh-generation game consoles and its competitors were Microsoft\'s Xbox 360 and Nintendo\'s Wii.', 8030, 21, 'PlayStation3.jpg'),
(302550, 'PlayStation 1', 'PlayStation is the first discontinued desktop video game console produced by Sony Computer Entertainment. It was released in Japan on December 3, 1994,6 in North America on September 9, 1995, in Europe on September 29, 1995, and in Australia on November 15, 1995. As a fifth-generation console, PlayStation competed primarily with Nintendo 64 and the Sega Saturn.', 9300, 18, 'PlayStation1.jpg');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

CREATE TABLE `usuarios` (
  `ID` int(20) NOT NULL,
  `Nombre` varchar(50) NOT NULL,
  `Contraseña` varchar(50) NOT NULL,
  `rol` varchar(20) DEFAULT 'usuario',
  `Monto` int(20) NOT NULL,
  `Cuenta` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`ID`, `Nombre`, `Contraseña`, `rol`, `Monto`, `Cuenta`) VALUES
(0, 'guest', '1234Invitado', 'usuario', 500, ''),
(45, 'admin', '1234Admin', 'admin', 0, 'admin@gmail.com'),
(302545, 'Andres Joseph Pacheco Carlos', 'joseph44', 'usuario', 0, 'pache.andy@gmail.com'),
(386282, 'Osvaldo Yahir Serna Salazar', 'osvaldo81', 'usuario', 1000, 'osvaldoyairserna@gmail.com'),
(457704, 'Obed Alejandro Loera Quiroz', 'obed03', 'usuario', 28638, 'osvaldoyairserna@gmail.com'),
(514826, 'Brayan Alejandro Pamila Torres', 'alejandro25', 'usuario', 3000, 'alejandro.cuabe@gmail.com');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `consolesplay`
--
ALTER TABLE `consolesplay`
  ADD PRIMARY KEY (`Id`);

--
-- Indices de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
