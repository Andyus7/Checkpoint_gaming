-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 04-12-2024 a las 17:43:34
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
(249, 'PlayStation 5', 'La consola más potente de PlayStation hasta la fecha.', 11500, 11, 'PlayStation5.jpg'),
(3455, 'PlayStation 4', 'La consola que definió una generación de jugadores.', 8249, 23, 'PlayStation4.jpg'),
(121341, 'PSP', 'La mejor consola portatil de sony', 2400, 6, 'Playstation6.jpg'),
(302547, 'PlayStation 2', 'La consola más vendida de todos los tiempos.', 3831, 20, 'PlayStation2.jpg'),
(302548, 'PlayStation 3', 'La primera consola de PlayStation con soporte para juegos en alta definición.', 4446, 12, 'PlayStation3.jpg'),
(302550, 'PlayStation 1', 'La consola que revolucionó la industria de los videojuegos.', 3524, 18, 'PlayStation1.jpg');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

CREATE TABLE `usuarios` (
  `ID` int(20) NOT NULL,
  `Nombre` varchar(50) NOT NULL,
  `Contraseña` varchar(50) NOT NULL,
  `rol` varchar(20) DEFAULT 'usuario',
  `Monto` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`ID`, `Nombre`, `Contraseña`, `rol`, `Monto`) VALUES
(0, 'Invitado', '1234Invitado', 'usuario', 0),
(302545, 'Andres Joseph Pacheco Carlos', 'joseph44', 'admin', 0),
(386282, 'Osvaldo Yahir Serna Salazar', 'osvaldo81', 'usuario', 0),
(457704, 'Obed Alejandro Loera Quiroz', 'obed03', 'usuario', 0),
(514826, 'Brayan Alejandro Pamila Torres', 'alejandro25', 'usuario', 0);

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
