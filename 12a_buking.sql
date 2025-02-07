-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2025. Jan 31. 09:06
-- Kiszolgáló verziója: 10.4.32-MariaDB
-- PHP verzió: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `12a_buking`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `esemeny`
--

CREATE TABLE `esemeny` (
  `esemeny_id` int(11) NOT NULL,
  `nev` varchar(255) NOT NULL,
  `idopont` datetime NOT NULL,
  `helyszin_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `esemeny`
--

INSERT INTO `esemeny` (`esemeny_id`, `nev`, `idopont`, `helyszin_id`) VALUES
(1, 'Marathon', '2025-05-30 02:09:15', 2),
(2, 'Marathon', '2025-07-21 16:32:09', 4),
(3, 'Rock Concert', '2025-01-04 18:43:49', 2),
(4, 'Art Exhibition', '2025-03-07 18:43:27', 2),
(5, 'Marathon', '2025-08-16 02:21:21', 2),
(6, 'Rock Concert', '2025-05-31 08:10:56', 3),
(7, 'Art Exhibition', '2025-10-04 01:15:18', 3),
(8, 'Food Festival', '2025-03-12 03:14:33', 4),
(9, 'Tech Conference', '2025-02-23 14:41:25', 3),
(10, 'Food Festival', '2025-05-16 01:46:08', 4);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `helyszin`
--

CREATE TABLE `helyszin` (
  `helyszin_id` int(11) NOT NULL,
  `megnev` varchar(255) NOT NULL,
  `cim` varchar(255) NOT NULL,
  `kapacitas` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `helyszin`
--

INSERT INTO `helyszin` (`helyszin_id`, `megnev`, `cim`, `kapacitas`) VALUES
(1, 'Budapest Arena', 'Budapest, Hungary', 12000),
(2, 'Debrecen Hall', 'Debrecen, Hungary', 5000),
(3, 'Szeged Stadium', 'Szeged, Hungary', 8000),
(4, 'Pecs Concert Hall', 'Pecs, Hungary', 3000);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `jegy`
--

CREATE TABLE `jegy` (
  `jegytipus` varchar(255) NOT NULL,
  `jegyar` int(11) NOT NULL,
  `esemeny_id` int(11) NOT NULL,
  `mennyiseg` int(11) NOT NULL,
  `jegy_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `jegy`
--

INSERT INTO `jegy` (`jegytipus`, `jegyar`, `esemeny_id`, `mennyiseg`, `jegy_id`) VALUES
('Group', 6494, 1, 339, 1),
('Group', 19831, 10, 346, 2),
('VIP', 12536, 9, 97, 3),
('VIP', 11088, 2, 209, 4),
('Standard', 5916, 3, 322, 5),
('VIP', 13792, 6, 204, 6),
('VIP', 14804, 9, 229, 7),
('Standard', 5535, 9, 450, 8),
('Standard', 7775, 4, 409, 9),
('Standard', 18107, 1, 255, 10),
('Student', 15855, 9, 307, 11),
('Student', 6394, 3, 241, 12),
('Group', 8515, 2, 307, 13),
('VIP', 15480, 10, 207, 14),
('Standard', 16491, 8, 101, 15),
('VIP', 8837, 7, 102, 16),
('Student', 18607, 6, 124, 17),
('Group', 5467, 1, 190, 18),
('Standard', 11769, 10, 465, 19),
('VIP', 14434, 5, 88, 20);

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `esemeny`
--
ALTER TABLE `esemeny`
  ADD PRIMARY KEY (`esemeny_id`),
  ADD KEY `esemeny_fk3` (`helyszin_id`);

--
-- A tábla indexei `helyszin`
--
ALTER TABLE `helyszin`
  ADD PRIMARY KEY (`helyszin_id`);

--
-- A tábla indexei `jegy`
--
ALTER TABLE `jegy`
  ADD PRIMARY KEY (`jegy_id`),
  ADD KEY `jegy_fk2` (`esemeny_id`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `esemeny`
--
ALTER TABLE `esemeny`
  MODIFY `esemeny_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT a táblához `helyszin`
--
ALTER TABLE `helyszin`
  MODIFY `helyszin_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=101;

--
-- AUTO_INCREMENT a táblához `jegy`
--
ALTER TABLE `jegy`
  MODIFY `jegy_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `esemeny`
--
ALTER TABLE `esemeny`
  ADD CONSTRAINT `esemeny_fk3` FOREIGN KEY (`helyszin_id`) REFERENCES `helyszin` (`helyszin_id`);

--
-- Megkötések a táblához `jegy`
--
ALTER TABLE `jegy`
  ADD CONSTRAINT `jegy_fk2` FOREIGN KEY (`esemeny_id`) REFERENCES `esemeny` (`esemeny_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
