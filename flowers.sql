-- phpMyAdmin SQL Dump
-- version 4.9.5
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: May 31, 2022 at 09:02 AM
-- Server version: 5.7.24
-- PHP Version: 7.4.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `flowers`
--

-- --------------------------------------------------------

--
-- Table structure for table `backet`
--

CREATE TABLE `backet` (
  `ID` int(11) NOT NULL,
  `UserID` text NOT NULL,
  `FlowerID` int(11) NOT NULL,
  `Count` int(11) NOT NULL,
  `Price` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `backuptickets`
--

CREATE TABLE `backuptickets` (
  `ID` int(11) NOT NULL,
  `UserID` text NOT NULL,
  `UserName` text NOT NULL,
  `UserAddress` text NOT NULL,
  `UserNumber` text NOT NULL,
  `FlowerID` int(11) NOT NULL,
  `Count` int(11) NOT NULL,
  `Price` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `catalog`
--

CREATE TABLE `catalog` (
  `ID` int(11) NOT NULL,
  `Name` text NOT NULL,
  `Description` text NOT NULL,
  `Count` int(11) NOT NULL,
  `Price` int(11) NOT NULL,
  `Date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `catalog`
--

INSERT INTO `catalog` (`ID`, `Name`, `Description`, `Count`, `Price`, `Date`) VALUES
(11, 'Троянда Марічка', 'Малиново-рожевий біколор української селекції.  Квіти на міцних довгих стеблах, одиночні або в невеликих китицях. Аромат легкий, ніжний. Цвітіння триває впродовж літа й осені.', 500, 46, '2021-05-30'),
(12, 'Троянда Аваланч', 'Великоквітковий, витончений біло-персиковий, чайно-гібридної сорт. На кожному пагоні формується один зеленувато-білий бутон, у міру розпуску – квітка набуває кремового відтінку.', 500, 25, '2021-05-30'),
(13, 'Троянда Джумілія', 'Світла троянда з переходом в насичений рожевий відтінок до країв пелюсток. Має великий бутон.', 500, 24, '2021-05-30'),
(14, 'Гортензії Індиго', 'Букет з півонієподібними трояндами й гортензіями в коробці з доставкою допоможе вам у будь-якій ситуації висловити теплоту і щирість почуттів. Це подарунок, який символізує радість, світло.', 230, 340, '2021-05-30'),
(15, 'Гортензії Розкіш', 'Розкіш - це не тільки дорогі будинки і авто, розкіш - це дарувати ті квіти, які відповідають вашим почуттям, розкіш - це бажання балувати тих, кого любиш.', 74, 380, '2022-05-30'),
(16, 'Орхідея в кашпо', 'Орхідеї - квіти нового покоління. Ми в курсі останніх квіткових трендів, тонкощів створення композицій та дбайливого транспортування.', 46, 1985, '2022-05-30');

-- --------------------------------------------------------

--
-- Table structure for table `ticket`
--

CREATE TABLE `ticket` (
  `ID` int(11) NOT NULL,
  `UserID` text NOT NULL,
  `UserName` text NOT NULL,
  `UserAddress` text NOT NULL,
  `UserNumber` text NOT NULL,
  `FlowerID` int(11) NOT NULL,
  `Count` int(11) NOT NULL,
  `Price` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `usersdata`
--

CREATE TABLE `usersdata` (
  `ID` int(11) NOT NULL,
  `UserID` text NOT NULL,
  `UserName` text NOT NULL,
  `UserAdress` text NOT NULL,
  `UserPhone` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `backet`
--
ALTER TABLE `backet`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `backuptickets`
--
ALTER TABLE `backuptickets`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `catalog`
--
ALTER TABLE `catalog`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `ticket`
--
ALTER TABLE `ticket`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `usersdata`
--
ALTER TABLE `usersdata`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `backet`
--
ALTER TABLE `backet`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `backuptickets`
--
ALTER TABLE `backuptickets`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `catalog`
--
ALTER TABLE `catalog`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- AUTO_INCREMENT for table `ticket`
--
ALTER TABLE `ticket`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `usersdata`
--
ALTER TABLE `usersdata`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
