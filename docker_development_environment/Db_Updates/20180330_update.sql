/* Changes made by AMK - Start */

DROP TABLE IF EXISTS `platform_db`.`sys_file_system`;
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

