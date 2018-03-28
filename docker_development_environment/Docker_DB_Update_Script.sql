-- MySQL dump 10.13  Distrib 5.7.17, for macos10.12 (x86_64)
--
-- Host: 127.0.0.1    Database: platform_db
-- ------------------------------------------------------
-- Server version	5.7.21

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `Sys_Setting_Code`
--

DROP TABLE IF EXISTS `Sys_Setting_Code`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Sys_Setting_Code` (
  `Id` int(11) NOT NULL,
  `ParentCodeId` int(11) DEFAULT NULL,
  `Name` varchar(45) DEFAULT NULL,
  `Description` varchar(100) DEFAULT NULL,
  `CreatedDate` datetime DEFAULT NULL,
  `CreatedBy` varchar(45) DEFAULT NULL,
  `UpdatedDate` datetime DEFAULT NULL,
  `UpdatedBy` varchar(45) DEFAULT NULL,
  `IsActive` bit(1) DEFAULT b'1',
  `Version` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `Name` (`Name`),
  KEY `Parent Code_idx` (`ParentCodeId`,`IsActive`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Sys_Setting_Code`
--

LOCK TABLES `Sys_Setting_Code` WRITE;
/*!40000 ALTER TABLE `Sys_Setting_Code` DISABLE KEYS */;
INSERT INTO `Sys_Setting_Code` VALUES (100100,NULL,'User Type','Type of Subscriptions','2018-03-25 00:00:00','admin','2018-03-25 00:00:00','admin','','054b5715-1379-4934'),(100101,100100,'Buyer','Buyer type','2018-03-25 00:00:00','admin','2018-03-25 00:00:00','admin','','4934-aba9'),(100102,100100,'Supplier','Supplier type','2018-03-25 00:00:00','admin','2018-03-25 00:00:00','admin','','rr54TuSLYk2J2WYxb7Jtlw==');
/*!40000 ALTER TABLE `Sys_Setting_Code` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'platform_db'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-03-26 23:12:04
