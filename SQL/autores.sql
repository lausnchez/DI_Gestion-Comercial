-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 11-02-2025 a las 18:01:05
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
-- Estructura de tabla para la tabla `autores`
--

CREATE TABLE `autores` (
  `Cod_Aut` int(11) NOT NULL,
  `Nombre` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `autores`
--

INSERT INTO `autores` (`Cod_Aut`, `Nombre`) VALUES
(1, 'Michael Jackson'),
(2, 'Madonna'),
(3, 'Taylor Swift'),
(4, 'Prince'),
(5, 'ABBA'),
(6, 'The Weeknd'),
(7, 'Britney Spears'),
(8, 'Dua Lipa'),
(9, 'Lady Gaga'),
(10, 'Elton John'),
(11, 'The Beatles'),
(12, 'Queen'),
(13, 'The Rolling Stones'),
(14, 'Pink Floyd'),
(15, 'Led Zeppelin'),
(16, 'David Bowie'),
(17, 'The Who'),
(18, 'Nirvana'),
(19, 'U2'),
(20, 'Bruce Springsteen'),
(21, 'Metallica'),
(22, 'Iron Maiden'),
(23, 'Black Sabbath'),
(24, 'Megadeth'),
(25, 'Slayer'),
(26, 'Pantera'),
(27, 'Judas Priest'),
(28, 'System of a Down'),
(29, 'Tool'),
(30, 'Avenged Sevenfold'),
(31, 'Miles Davis'),
(32, 'John Coltrane'),
(33, 'Duke Ellington'),
(34, 'Ella Fitzgerald'),
(35, 'Louis Armstrong'),
(36, 'Bill Evans'),
(37, 'Thelonious Monk'),
(38, 'Chet Baker'),
(39, 'Charlie Parker'),
(40, 'Herbie Hancock'),
(41, 'Bob Dylan'),
(42, 'Joni Mitchell'),
(43, 'Leonard Cohen'),
(44, 'Simon & Garfunkel'),
(45, 'Nick Drake'),
(46, 'Joan Baez'),
(47, 'Cat Stevens'),
(48, 'Neil Young'),
(49, 'Peter, Paul and Mary'),
(50, 'Crosby, Stills & Nash'),
(51, 'Johnny Cash'),
(52, 'Dolly Parton'),
(53, 'Willie Nelson'),
(54, 'Hank Williams'),
(55, 'Shania Twain'),
(56, 'Garth Brooks'),
(57, 'Kenny Rogers'),
(58, 'Loretta Lynn'),
(59, 'Patsy Cline'),
(60, 'Chris Stapleton'),
(61, 'Bee Gees'),
(62, 'Donna Summer'),
(63, 'Chic'),
(64, 'Gloria Gaynor'),
(65, 'KC and the Sunshine Band'),
(66, 'Earth, Wind & Fire'),
(67, 'Village People'),
(68, 'The Trammps'),
(69, 'Sister Sledge'),
(70, 'Boney M.'),
(71, 'Tupac Shakur'),
(72, 'The Notorious B.I.G.'),
(73, 'Eminem'),
(74, 'Kanye West'),
(75, 'Jay-Z'),
(76, 'Nas'),
(77, 'Kendrick Lamar'),
(78, 'Dr. Dre'),
(79, 'Wu-Tang Clan'),
(80, 'OutKast'),
(81, 'Olivia Rodrigo'),
(82, 'Taylor Swift'),
(83, 'Dua Lipa'),
(84, 'Billie Eilish'),
(85, 'Madison Beer'),
(86, 'Selena Gomez'),
(87, 'Ariana Grande'),
(88, 'Camila Cabello'),
(89, 'Gracie Abrams'),
(90, 'Chappell Roan');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `autores`
--
ALTER TABLE `autores`
  ADD PRIMARY KEY (`Cod_Aut`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `autores`
--
ALTER TABLE `autores`
  MODIFY `Cod_Aut` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=91;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
