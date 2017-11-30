-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Nov 30, 2017 at 10:24 AM
-- Server version: 5.7.19
-- PHP Version: 5.6.31

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `cheques`
--

-- --------------------------------------------------------

--
-- Table structure for table `banks`
--

DROP TABLE IF EXISTS `banks`;
CREATE TABLE IF NOT EXISTS `banks` (
  `name` char(4) NOT NULL,
  PRIMARY KEY (`name`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `banks`
--

INSERT INTO `banks` (`name`) VALUES
('BOC'),
('COM'),
('HNB'),
('NTB');

-- --------------------------------------------------------

--
-- Table structure for table `chequesreceived`
--

DROP TABLE IF EXISTS `chequesreceived`;
CREATE TABLE IF NOT EXISTS `chequesreceived` (
  `chqNo` char(6) NOT NULL,
  `customer` varchar(30) NOT NULL,
  `date` date NOT NULL,
  `amount` double NOT NULL,
  `bank` char(4) NOT NULL,
  `type` varchar(7) NOT NULL,
  `memo` varchar(20) NOT NULL,
  PRIMARY KEY (`chqNo`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `customers`
--

DROP TABLE IF EXISTS `customers`;
CREATE TABLE IF NOT EXISTS `customers` (
  `id` int(3) NOT NULL AUTO_INCREMENT,
  `name` varchar(30) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `mybanks`
--

DROP TABLE IF EXISTS `mybanks`;
CREATE TABLE IF NOT EXISTS `mybanks` (
  `bank` char(4) NOT NULL,
  `name` varchar(30) NOT NULL,
  `acno` varchar(12) NOT NULL,
  `branch` varchar(12) DEFAULT NULL,
  `type` char(7) NOT NULL,
  PRIMARY KEY (`name`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `mybanks`
--

INSERT INTO `mybanks` (`bank`, `name`, `acno`, `branch`, `type`) VALUES
('COM', 'EWING TEST', '25959DS9D491', 'BASELINE', 'SAVINGS');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
