-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3308
-- Generation Time: Sep 30, 2021 at 08:17 AM
-- Server version: 10.4.14-MariaDB
-- PHP Version: 7.2.33

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `csm`
--

-- --------------------------------------------------------

--
-- Table structure for table `currentstock_table`
--

CREATE TABLE `currentstock_table` (
  `Item_Id` int(11) NOT NULL,
  `Item_Name` varchar(50) NOT NULL,
  `Date` varchar(50) NOT NULL,
  `Quantity` int(11) NOT NULL,
  `Unit_Price` varchar(50) NOT NULL,
  `Min_quantity` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `currentstock_table`
--

INSERT INTO `currentstock_table` (`Item_Id`, `Item_Name`, `Date`, `Quantity`, `Unit_Price`, `Min_quantity`) VALUES
(7, 'pins', '2021 / 9 / 22', 210, '20', '200'),
(12, 'lubricants', '2021 / 9 / 17', 100, '3000', '30'),
(16, 'tubes', '2021 / 9 / 16', 2000, '1300', '26'),
(17, 'Coolant', '2021 / 9 / 17', 100, '800', '80'),
(18, 'Cabin filters', '2021 / 9 / 29', 80, '1590', '50'),
(25, 'break oil', '2021 / 9 / 17', 10, '300', '18'),
(26, 'Oil', '2021 / 9 / 29', 1000, '400', '1000'),
(27, 'engine oil', '2021 / 9 / 29', 1000, '500', '500'),
(28, 'Greese', '2021 / 9 / 29', 300, '200', '1000'),
(29, 'Washing liquid', '2021 / 9 / 29', 1000, '500', '800'),
(30, 'Wax', '2021 / 9 / 29', 68, '700', '50');

-- --------------------------------------------------------

--
-- Table structure for table `liststock_table`
--

CREATE TABLE `liststock_table` (
  `Order_Id` int(11) NOT NULL,
  `Item_Id` varchar(50) NOT NULL,
  `Item_Name` varchar(50) NOT NULL,
  `Date` varchar(50) NOT NULL,
  `Req_Quantity` varchar(50) NOT NULL,
  `Unit_Price` varchar(50) NOT NULL,
  `Total_Price` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `liststock_table`
--

INSERT INTO `liststock_table` (`Order_Id`, `Item_Id`, `Item_Name`, `Date`, `Req_Quantity`, `Unit_Price`, `Total_Price`) VALUES
(16, '16', 'tubes', '2021 / 9 / 16', '1000', '1300', '1300000'),
(24, '25', 'break oil', '2021 / 9 / 29', '1000', '300', '300000'),
(25, '28', 'Greese', '2021 / 9 / 29', '2500', '200', '500000'),
(26, '17', 'Coolant', '2021 / 9 / 29', '110', '800', '88000'),
(27, '29', 'Washing liquid', '2021 / 9 / 29', '500', '500', '250000'),
(28, '26', 'Oil', '2021 / 9 / 30', '2000', '400', '800000');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `currentstock_table`
--
ALTER TABLE `currentstock_table`
  ADD PRIMARY KEY (`Item_Id`);

--
-- Indexes for table `liststock_table`
--
ALTER TABLE `liststock_table`
  ADD PRIMARY KEY (`Order_Id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `currentstock_table`
--
ALTER TABLE `currentstock_table`
  MODIFY `Item_Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=32;

--
-- AUTO_INCREMENT for table `liststock_table`
--
ALTER TABLE `liststock_table`
  MODIFY `Order_Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=29;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
