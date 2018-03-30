﻿/* Changes made by AMK - Start */

CREATE TABLE `platform_db`.`sys_file_system` (
  `Id` INT NOT NULL,
  `FileName` VARCHAR(100) NOT NULL,
  `FileDescription` VARCHAR(100) NULL,
  `OriginalFileName` VARCHAR(100) NOT NULL,
  `FileContent` LONGTEXT NULL,
  `ApplicationId` VARCHAR(100) NULL,
  `Reference1` VARCHAR(100) NULL,
  `Reference2` VARCHAR(100) NULL,
  `Reference3` VARCHAR(100) NULL,
  `CreatedDate` DATETIME NULL,
  `CreatedBy` VARCHAR(45) NULL,
  `UpdatedDate` DATETIME NULL,
  `UpdatedBy` VARCHAR(45) NULL,
  `IsActive` BIT(1) NULL DEFAULT b'1',
  `Version` VARCHAR(45) NULL,
  PRIMARY KEY (`Id`));

  /* Changes made by AMK - End */

  /* Changes made by thantsin - Start */
--
-- Table structure for table `Sys_Role` 
--

DROP TABLE IF EXISTS `Sys_Role`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `platform_db`.`Sys_Role` (
  `Id` INT(11) NOT NULL,
  `Name` VARCHAR(100) NULL DEFAULT NULL,
  `Description` VARCHAR(100) NULL DEFAULT NULL,
  `CreatedDate` DATETIME NULL DEFAULT NULL,
  `CreatedBy` VARCHAR(45) NULL DEFAULT NULL,
  `UpdatedDate` DATETIME NULL DEFAULT NULL,
  `UpdatedBy` VARCHAR(45) NULL DEFAULT NULL,
  `IsActive` BIT(1) NULL DEFAULT b'1',
  `Version` VARCHAR(45) NULL DEFAULT NULL,
  PRIMARY KEY (`Id`));

/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Sys_Role`
--

--
-- Table structure for table `Sys_Permission`
--

DROP TABLE IF EXISTS `Sys_Permission`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `platform_db`.`Sys_Permission` (
  `Id` INT(11) NOT NULL,
  `Sys_Role_Id` INT(11) NULL,
  `Name` VARCHAR(100) NULL DEFAULT NULL,
  `Description` VARCHAR(100) NULL DEFAULT NULL,
  `CreatedDate` DATETIME NULL DEFAULT NULL,
  `CreatedBy` VARCHAR(45) NULL DEFAULT NULL,
  `UpdatedDate` DATETIME NULL DEFAULT NULL,
  `UpdatedBy` VARCHAR(45) NULL DEFAULT NULL,
  `IsActive` BIT(1) NULL DEFAULT b'1',
  `Version` VARCHAR(45) NULL DEFAULT NULL,
  PRIMARY KEY (`Id`),
  CONSTRAINT `Sys_Role_Id`
    FOREIGN KEY (`Id`)
    REFERENCES `platform_db`.`Sys_Role` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);

/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Sys_Permission` 
--
/* Changes made by thantsin - End */