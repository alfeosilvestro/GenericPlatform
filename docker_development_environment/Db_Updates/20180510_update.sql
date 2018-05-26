DROP TABLE IF EXISTS `platform_db`.`BM_Gallery`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `platform_db`.`BM_Gallery` (
  `Id` INT(11) NOT NULL AUTO_INCREMENT,
  `Name` VARCHAR(100) NULL DEFAULT NULL,
  `Description` longtext NULL DEFAULT NULL,
  `ThumbnailImage` longblob NOT NULL,
  `DetailImage` longblob NOT NULL,
  `DownloadableImage` longblob NOT NULL,
  `CreatedDate` DATETIME NULL DEFAULT NULL,
  `CreatedBy` VARCHAR(45) NULL DEFAULT NULL,
  `UpdatedDate` DATETIME NULL DEFAULT NULL,
  `UpdatedBy` VARCHAR(45) NULL DEFAULT NULL,
  `IsActive` BIT(1) NULL DEFAULT b'1',
  `Version` VARCHAR(45) NULL DEFAULT NULL,
  PRIMARY KEY (`Id`));
  
  /*!40101 SET character_set_client = @saved_cs_client */;
