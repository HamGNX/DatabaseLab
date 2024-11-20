-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: localhost:8889
-- Generation Time: Nov 20, 2024 at 07:17 PM
-- Server version: 8.0.35
-- PHP Version: 8.3.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `bank`
--

DELIMITER $$
--
-- Procedures
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `DepositMoney` (`accid` INT, `amount` FLOAT)   BEGIN
    DECLARE existing_bal FLOAT;
    -- Check if account exists and get the current balance
    SELECT bal INTO existing_bal 
    FROM `account` 
    WHERE ID = accid;
    IF existing_bal IS NULL THEN
        SIGNAL SQLSTATE '45000'
        SET MESSAGE_TEXT = 'Account not found';
    ELSEIF amount <= 0 THEN
        SIGNAL SQLSTATE '45000'
        SET MESSAGE_TEXT = 'Invalid amount';
    ELSE

          UPDATE `account` 
          SET bal = bal + amount 
          WHERE ID = accid;
          INSERT INTO `transaction` (type, amount, date, accid) 
          VALUES ('D', amount, NOW(), accid);
    END IF;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `WidthdrawMoney` (`accid` INT, `amount` FLOAT)   BEGIN
    DECLARE existing_bal FLOAT;
    SELECT bal into existing_bal from `account` where ID = accid ;
   IF existing_bal IS NULL THEN
        SIGNAL SQLSTATE '45000'
        SET MESSAGE_TEXT = 'Account not found';
    ELSEIF amount <= 0 THEN
        SIGNAL SQLSTATE '45000'
        SET MESSAGE_TEXT = 'Invalid amount';
    ELSE

        IF existing_bal < amount THEN
            SIGNAL SQLSTATE '45000'
            SET MESSAGE_TEXT = 'Insufficient balance';
        ELSE

          UPDATE `account` 
          SET bal = bal - amount 
          WHERE ID = accid;
          INSERT INTO `transaction` (type, amount, date, accid) 
          VALUES ('W', amount, NOW(), accid);
        END IF;
    END IF;
END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `account`
--

CREATE TABLE `account` (
  `ID` int NOT NULL,
  `No.` varchar(20) DEFAULT NULL,
  `Name` varchar(200) DEFAULT NULL,
  `CreditLimit` double DEFAULT NULL,
  `bal` float DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `account`
--

INSERT INTO `account` (`ID`, `No.`, `Name`, `CreditLimit`, `bal`) VALUES
(105, 'N01', 'John Morris', 20000, 3000);

-- --------------------------------------------------------

--
-- Table structure for table `transaction`
--

CREATE TABLE `transaction` (
  `id` int NOT NULL,
  `type` char(1) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `amount` float DEFAULT NULL,
  `date` datetime DEFAULT NULL,
  `accid` int DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Triggers `transaction`
--
DELIMITER $$
CREATE TRIGGER `check_balance` BEFORE INSERT ON `transaction` FOR EACH ROW BEGIN
    DECLARE existing_bal FLOAT;
    SELECT bal INTO existing_bal FROM `account` WHERE ID = NEW.accid;
    IF NEW.type = 'W' THEN
        IF existing_bal < NEW.amount THEN
            SIGNAL SQLSTATE '45000'
            SET MESSAGE_TEXT = 'Not enough money';
        ELSE
          
            UPDATE `account`
            SET bal = bal - NEW.amount
            WHERE ID = NEW.accid;
        END IF;
    ELSEIF NEW.type = 'D' THEN
       
        UPDATE `account`
        SET bal = bal + NEW.amount
        WHERE ID = NEW.accid;
    END IF;
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `prevent_transaction_delete` BEFORE DELETE ON `transaction` FOR EACH ROW BEGIN
    SIGNAL SQLSTATE '45000'
    SET MESSAGE_TEXT = 'Deletion of transactions is not allowed';
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `prevent_transaction_update` BEFORE UPDATE ON `transaction` FOR EACH ROW BEGIN
    SIGNAL SQLSTATE '45000' 
    SET MESSAGE_TEXT = 'Updates to existing transactions are not allowed';
END
$$
DELIMITER ;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `account`
--
ALTER TABLE `account`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `transaction`
--
ALTER TABLE `transaction`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `transaction`
--
ALTER TABLE `transaction`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
