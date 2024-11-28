-- phpMyAdmin SQL Dump
-- version 4.8.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Feb 17, 2019 at 05:25 AM
-- Server version: 10.1.34-MariaDB
-- PHP Version: 7.2.7

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `employee`
--

-- --------------------------------------------------------

--
-- Table structure for table `bonus`
--

CREATE TABLE `bonus` (
  `id` int(12) NOT NULL,
  `employee_id` int(12) NOT NULL,
  `bonus_type` enum('Profit Sharing','Holiday') DEFAULT NULL,
  `bonus_amount` int(12) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `bonus`
--

INSERT INTO `bonus` (`id`, `employee_id`, `bonus_type`, `bonus_amount`) VALUES
(1, 8, 'Holiday', 30000),
(2, 9, 'Holiday', 30000),
(3, 10, NULL, NULL),
(4, 11, NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `deduction`
--

CREATE TABLE `deduction` (
  `id` int(12) NOT NULL,
  `employee_id` int(12) NOT NULL,
  `advance_pay` int(10) DEFAULT NULL,
  `professional_tax` int(10) DEFAULT NULL,
  `loan` int(10) DEFAULT NULL,
  `professional_fund` int(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `deduction`
--

INSERT INTO `deduction` (`id`, `employee_id`, `advance_pay`, `professional_tax`, `loan`, `professional_fund`) VALUES
(1, 8, NULL, NULL, NULL, NULL),
(2, 9, 5000, 1000, 500, 20000),
(3, 10, NULL, NULL, NULL, NULL),
(4, 11, 500, 0, 0, 1000);

-- --------------------------------------------------------

--
-- Table structure for table `employee`
--

CREATE TABLE `employee` (
  `id` int(12) NOT NULL,
  `name` varchar(64) NOT NULL,
  `father_name` varchar(64) NOT NULL,
  `gender` varchar(7) NOT NULL,
  `dob` date NOT NULL,
  `address` varchar(64) NOT NULL,
  `city` varchar(15) NOT NULL,
  `contact` varchar(13) NOT NULL,
  `designation` varchar(20) NOT NULL,
  `department` varchar(20) NOT NULL,
  `doj` date NOT NULL,
  `remarks` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `employee`
--

INSERT INTO `employee` (`id`, `name`, `father_name`, `gender`, `dob`, `address`, `city`, `contact`, `designation`, `department`, `doj`, `remarks`) VALUES
(9, 'zdgd', 'xdzgdx', 'Male', '2018-12-02', 'dxzg', 'xdgx', '01627389544', 'officer', 'sales', '2018-12-02', 'sfs'),
(10, 'fhdxh', 'fhdfhtf', 'Female', '1995-07-04', 'trur', 'tururu', '018346555', 'officer', 'HR', '2018-12-03', 'we4ye4y'),
(11, 'Arifur Rahman', 'Hasanur Rahman', 'Male', '1991-01-29', 'ShibBari, Khulna', 'Khulna', '01721543897', 'Commercial Officer', 'Sales', '2017-10-10', 'He is an Honest employee.');

-- --------------------------------------------------------

--
-- Table structure for table `incentives`
--

CREATE TABLE `incentives` (
  `id` int(12) NOT NULL,
  `employee_id` int(12) NOT NULL,
  `medical` double DEFAULT NULL,
  `hra` double DEFAULT NULL,
  `ta` double DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `incentives`
--

INSERT INTO `incentives` (`id`, `employee_id`, `medical`, `hra`, `ta`) VALUES
(1, 9, 3, 3, 2),
(2, 10, 0, 0, 0),
(3, 11, 3.5, 2.5, 1.5);

-- --------------------------------------------------------

--
-- Table structure for table `login`
--

CREATE TABLE `login` (
  `id` int(12) NOT NULL,
  `username` varchar(64) NOT NULL,
  `password` varchar(64) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `login`
--

INSERT INTO `login` (`id`, `username`, `password`) VALUES
(2, 'sanoth', '7nySlml7EBeGFlwj3DXvn+/bUGtrp6q5za+ihK0ZH9lbqeY6'),
(3, 'azharul', 'I+Ux7N+cgQlE+Xhzi3v+gs+gDWtmFq+DuCo/JDVYHHpoxMt8'),
(4, 'tamim', 'Ydt53rgBvVVWpirgozJgP6KXptOBJDvl6e4W0PUJr0D87buo'),
(5, 'sakib', 'GNc/ssYOwH1HQBcahwRgMHn4EqQzUIqG+PZmOn6/u4o0OJ94'),
(8, 's', 'IE2mDN9aYrC/obXktS2jJcSZR4CE/caeYdunamzBEYqxmT/w');

-- --------------------------------------------------------

--
-- Table structure for table `salary`
--

CREATE TABLE `salary` (
  `id` int(12) NOT NULL,
  `employee_id` int(12) NOT NULL,
  `salary_type` enum('Yearly','Monthly','Daily') DEFAULT NULL,
  `salary_amount` int(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `salary`
--

INSERT INTO `salary` (`id`, `employee_id`, `salary_type`, `salary_amount`) VALUES
(1, 7, 'Monthly', 20000),
(2, 8, 'Monthly', 100000),
(3, 9, 'Monthly', 100000),
(4, 10, NULL, NULL),
(5, 11, 'Monthly', 25000);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `bonus`
--
ALTER TABLE `bonus`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `deduction`
--
ALTER TABLE `deduction`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `employee`
--
ALTER TABLE `employee`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `incentives`
--
ALTER TABLE `incentives`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `login`
--
ALTER TABLE `login`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `salary`
--
ALTER TABLE `salary`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `bonus`
--
ALTER TABLE `bonus`
  MODIFY `id` int(12) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `deduction`
--
ALTER TABLE `deduction`
  MODIFY `id` int(12) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `employee`
--
ALTER TABLE `employee`
  MODIFY `id` int(12) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT for table `incentives`
--
ALTER TABLE `incentives`
  MODIFY `id` int(12) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `login`
--
ALTER TABLE `login`
  MODIFY `id` int(12) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `salary`
--
ALTER TABLE `salary`
  MODIFY `id` int(12) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
