/*
SQLyog Ultimate v10.00 Beta1
MySQL - 5.5.5-10.4.27-MariaDB : Database - mis
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`mis` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci */;

USE `mis`;

/*Table structure for table `accounts` */

DROP TABLE IF EXISTS `accounts`;

CREATE TABLE `accounts` (
  `account_id` int(10) NOT NULL AUTO_INCREMENT,
  `account_name` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci DEFAULT NULL,
  `account_password` varchar(17) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci DEFAULT NULL,
  `user_level` varchar(20) DEFAULT NULL,
  `question` varchar(100) DEFAULT NULL,
  `answer` varchar(20) DEFAULT NULL,
  `first_login` varchar(3) DEFAULT NULL,
  PRIMARY KEY (`account_id`)
) ENGINE=MyISAM AUTO_INCREMENT=7 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

/*Table structure for table `archived_residents` */

DROP TABLE IF EXISTS `archived_residents`;

CREATE TABLE `archived_residents` (
  `resident_id` int(100) NOT NULL,
  `household_id` int(100) NOT NULL,
  `first_name` varchar(100) NOT NULL,
  `middle_name` varchar(100) DEFAULT NULL,
  `last_name` varchar(100) NOT NULL,
  `ext_name` varchar(100) NOT NULL,
  `birthdate` date NOT NULL,
  `age` int(150) NOT NULL,
  `birthplace` varchar(100) NOT NULL,
  `civil_status` varchar(100) NOT NULL,
  `citizenship` varchar(100) NOT NULL,
  `sex` varchar(7) NOT NULL,
  `religion` varchar(100) DEFAULT NULL,
  `contact_no` varchar(100) NOT NULL,
  `is_pwd` varchar(5) NOT NULL,
  `disability` varchar(50) DEFAULT NULL,
  `is_voter` varchar(5) NOT NULL,
  `occupation` varchar(100) DEFAULT NULL,
  `household_role` varchar(10) NOT NULL COMMENT 'head or member',
  `month_registered` varchar(20) NOT NULL,
  `day_registered` varchar(20) NOT NULL,
  `year_registered` varchar(20) NOT NULL,
  `registered_by` varchar(100) NOT NULL,
  `date_archived` date DEFAULT NULL,
  `archived_by` varchar(100) DEFAULT NULL,
  `reason_archived` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`resident_id`),
  KEY `household_id` (`household_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

/*Table structure for table `audit_history` */

DROP TABLE IF EXISTS `audit_history`;

CREATE TABLE `audit_history` (
  `date` date DEFAULT NULL,
  `time` datetime DEFAULT NULL,
  `account_name` varchar(100) DEFAULT NULL,
  `transaction` varchar(250) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

/*Table structure for table `blotters` */

DROP TABLE IF EXISTS `blotters`;

CREATE TABLE `blotters` (
  `blotter_id` int(11) NOT NULL AUTO_INCREMENT,
  `blotter` varchar(50) DEFAULT NULL,
  `suspect` varchar(50) DEFAULT NULL,
  `suspect_address` varchar(50) DEFAULT NULL,
  `suspect_contactno` varchar(50) DEFAULT NULL,
  `submmited_by` varchar(50) DEFAULT NULL,
  `submitted_on` date DEFAULT NULL,
  `blotter_details` varchar(150) DEFAULT NULL,
  PRIMARY KEY (`blotter_id`)
) ENGINE=InnoDB AUTO_INCREMENT=302319 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

/*Table structure for table `brgyofficials` */

DROP TABLE IF EXISTS `brgyofficials`;

CREATE TABLE `brgyofficials` (
  `id` int(255) NOT NULL AUTO_INCREMENT,
  `official_name` varchar(100) NOT NULL,
  `official_position` varchar(100) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=30 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

/*Table structure for table `complaints` */

DROP TABLE IF EXISTS `complaints`;

CREATE TABLE `complaints` (
  `complaint_id` int(11) NOT NULL AUTO_INCREMENT,
  `complaint` varchar(20) DEFAULT NULL,
  `complainant` varchar(50) DEFAULT NULL,
  `complainant_address` varchar(50) DEFAULT NULL,
  `complainant_contactno` varchar(50) DEFAULT NULL,
  `defendant` varchar(50) DEFAULT NULL,
  `defendant_address` varchar(50) DEFAULT NULL,
  `defendat_contactno` varchar(50) DEFAULT NULL,
  `complaint_status` varchar(20) DEFAULT NULL,
  `date_filed` date DEFAULT NULL,
  `details` varchar(150) DEFAULT NULL,
  `first_date` date DEFAULT NULL,
  `first_result` varchar(20) DEFAULT NULL,
  `second_date` date DEFAULT NULL,
  `second_result` varchar(20) DEFAULT NULL,
  `third_date` date DEFAULT NULL,
  `third_result` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`complaint_id`)
) ENGINE=InnoDB AUTO_INCREMENT=202330 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

/*Table structure for table `household` */

DROP TABLE IF EXISTS `household`;

CREATE TABLE `household` (
  `household_id` varchar(100) NOT NULL,
  `bldg_no` varchar(100) NOT NULL,
  `street_name` varchar(100) NOT NULL,
  `residence_type` varchar(70) DEFAULT NULL,
  `house_type` varchar(70) DEFAULT NULL,
  `water_source` varchar(100) DEFAULT NULL,
  `electricity_source` varchar(100) DEFAULT NULL,
  `month_added` varchar(20) DEFAULT NULL,
  `day_added` varchar(20) DEFAULT NULL,
  `year_added` varchar(20) DEFAULT NULL,
  `added_by` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`household_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

/*Table structure for table `incidents` */

DROP TABLE IF EXISTS `incidents`;

CREATE TABLE `incidents` (
  `incident_id` int(11) NOT NULL AUTO_INCREMENT,
  `incident_name` varchar(20) DEFAULT NULL,
  `incident_details` varchar(150) DEFAULT NULL,
  `incident_date` date DEFAULT NULL,
  `incident_time` varchar(10) DEFAULT NULL,
  `reported_by` varchar(50) DEFAULT NULL,
  `reported_on` datetime DEFAULT NULL,
  PRIMARY KEY (`incident_id`)
) ENGINE=InnoDB AUTO_INCREMENT=102330 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

/*Table structure for table `item_borrowed` */

DROP TABLE IF EXISTS `item_borrowed`;

CREATE TABLE `item_borrowed` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `item_id` int(11) DEFAULT NULL,
  `quantity` int(11) DEFAULT NULL,
  `borrowed_date` date DEFAULT NULL,
  `return_date` date DEFAULT NULL,
  `borrowed_by` varchar(100) DEFAULT NULL,
  `reason` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=28 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

/*Table structure for table `item_history` */

DROP TABLE IF EXISTS `item_history`;

CREATE TABLE `item_history` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `item_id` int(11) DEFAULT NULL,
  `transaction_type` varchar(100) DEFAULT NULL,
  `item_state` varchar(50) DEFAULT NULL,
  `quantity` int(11) DEFAULT NULL,
  `transaction_by` varchar(100) DEFAULT NULL,
  `date` date DEFAULT NULL,
  `reason` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=107 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

/*Table structure for table `item_list` */

DROP TABLE IF EXISTS `item_list`;

CREATE TABLE `item_list` (
  `item_id` int(11) NOT NULL AUTO_INCREMENT,
  `item_name` varchar(20) DEFAULT NULL,
  `item_status` varchar(20) DEFAULT NULL,
  `item_reason` varchar(20) DEFAULT NULL,
  `item_color` varchar(20) DEFAULT NULL,
  `serial_no` varchar(100) DEFAULT NULL,
  `item_stock` int(11) DEFAULT NULL,
  `item_borrowed` int(11) DEFAULT NULL,
  `item_unusable` int(11) DEFAULT NULL,
  `added_by` varchar(100) DEFAULT NULL,
  `added_on` date DEFAULT NULL,
  `remarks` varchar(150) DEFAULT NULL,
  PRIMARY KEY (`item_id`)
) ENGINE=InnoDB AUTO_INCREMENT=32 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

/*Table structure for table `residents` */

DROP TABLE IF EXISTS `residents`;

CREATE TABLE `residents` (
  `resident_id` int(100) NOT NULL AUTO_INCREMENT,
  `household_id` int(100) NOT NULL,
  `first_name` varchar(100) NOT NULL,
  `middle_name` varchar(100) DEFAULT NULL,
  `last_name` varchar(100) NOT NULL,
  `ext_name` varchar(11) DEFAULT NULL,
  `birthdate` date NOT NULL,
  `age` int(150) NOT NULL,
  `birthplace` varchar(100) NOT NULL,
  `civil_status` varchar(100) NOT NULL,
  `citizenship` varchar(100) NOT NULL,
  `other_citizenship` varchar(100) DEFAULT NULL,
  `sex` varchar(7) NOT NULL,
  `religion` varchar(100) DEFAULT NULL,
  `contact_no` varchar(100) NOT NULL,
  `is_pwd` varchar(5) NOT NULL,
  `disability` varchar(50) DEFAULT NULL,
  `is_voter` varchar(5) NOT NULL,
  `occupation` varchar(100) DEFAULT NULL,
  `household_role` varchar(10) NOT NULL COMMENT 'head or member',
  `month_registered` varchar(20) NOT NULL,
  `day_registered` varchar(20) NOT NULL,
  `year_registered` varchar(20) NOT NULL,
  `registered_by` varchar(100) NOT NULL,
  PRIMARY KEY (`resident_id`),
  KEY `household_id` (`household_id`)
) ENGINE=InnoDB AUTO_INCREMENT=1188 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

/*Table structure for table `system_variables` */

DROP TABLE IF EXISTS `system_variables`;

CREATE TABLE `system_variables` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `variable_name` varchar(350) DEFAULT NULL,
  `variable_type` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=201 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

/*Table structure for table `vawc` */

DROP TABLE IF EXISTS `vawc`;

CREATE TABLE `vawc` (
  `case_id` int(11) NOT NULL AUTO_INCREMENT,
  `case_name` varchar(20) DEFAULT NULL,
  `victim` varchar(50) DEFAULT NULL,
  `suspect` varchar(50) DEFAULT NULL,
  `relationship` varchar(50) DEFAULT NULL,
  `case_status` varchar(20) DEFAULT NULL,
  `submitted_by` varchar(50) DEFAULT NULL,
  `submitted_on` date DEFAULT NULL,
  `case_details` varchar(150) DEFAULT NULL,
  PRIMARY KEY (`case_id`)
) ENGINE=InnoDB AUTO_INCREMENT=402311 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
