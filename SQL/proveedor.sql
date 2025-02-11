-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 11-02-2025 a las 18:06:23
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
-- Base de datos: `gestioncomercial`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `proveedor`
--

CREATE TABLE `proveedor` (
  `Cod_Prov` int(11) NOT NULL,
  `Nombre` varchar(50) NOT NULL,
  `Contacto` varchar(75) NOT NULL,
  `Telefono` varchar(9) NOT NULL,
  `Direccion` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `proveedor`
--

INSERT INTO `proveedor` (`Cod_Prov`, `Nombre`, `Contacto`, `Telefono`, `Direccion`) VALUES
(1, 'Vinyl World', 'contact@vinylworld.com', '+1 555-12', '123 Vinyl St, New York, USA'),
(2, 'Retro Discs', 'info@retrodiscs.com', '+44 20 79', '45 Abbey Road, London, UK'),
(3, 'Classic Records', 'sales@classicrecords.com', '+49 30 12', '78 Beethoven Str, Berlin, Germany'),
(4, 'Melody Press', 'support@melodypress.com', '+33 1 234', '12 Rue de la Musique, Paris, France'),
(5, 'Golden Tunes', 'contact@goldentunes.com', '+1 213-55', '999 Sunset Blvd, Los Angeles, USA'),
(6, 'Rock & Vinyl', 'sales@rockvinyl.com', '+34 91 55', 'Calle del Rock 22, Madrid, Spain'),
(7, 'Jazz Masters', 'info@jazzmasters.com', '+39 06 55', 'Via del Jazz 45, Rome, Italy'),
(8, 'Folk & Country Records', 'support@folkcountry.com', '+1 615-55', '16 Nashville Ave, Tennessee, USA'),
(9, 'Urban Beats', 'contact@urbanbeats.com', '+1 718-55', '88 Brooklyn St, New York, USA'),
(10, 'Disco Fever', 'info@discofever.com', '+49 40 55', '78 Funky Str, Hamburg, Germany');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `proveedor`
--
ALTER TABLE `proveedor`
  ADD PRIMARY KEY (`Cod_Prov`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `proveedor`
--
ALTER TABLE `proveedor`
  MODIFY `Cod_Prov` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
