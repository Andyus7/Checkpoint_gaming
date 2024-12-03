-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 03-12-2024 a las 01:13:33
-- Versión del servidor: 10.4.32-MariaDB
-- Versión de PHP: 8.2.12

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
-- Estructura de tabla para la tabla `productosx`
--

CREATE TABLE `productosx` (
  `Id` int(11) NOT NULL,
  `nombre` varchar(50) NOT NULL,
  `descripcion` varchar(50) NOT NULL,
  `precio` int(11) NOT NULL,
  `Existencias` int(11) NOT NULL,
  `imagen` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `productosx`
--

INSERT INTO `productosx` (`Id`, `nombre`, `descripcion`, `precio`, `Existencias`, `imagen`) VALUES
(248, 'Xbox', 'La consola revolucionaria de Microsoft', 3000, 15, 'Xbox1.jpg'),
(456, 'Xbox 360', 'La consola Xbox con el cambio generacional mas dra', 3300, 20, 'Xbox2.jpg'),
(1547, 'Xbox one', 'La consola Xbox mas vendida de la historia', 4000, 20, 'Xbox3.jpg'),
(3897, 'Xbox series s', 'La mejor consola calidad precio del mercado', 4500, 23, 'Xbox4.jpg'),
(6749, 'Xbox Series X', 'La consola Xbox mas potente y exclusiva de Microso', 10000, 19, 'Xbox5.jpg');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `productosx`
--
ALTER TABLE `productosx`
  ADD PRIMARY KEY (`Id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
