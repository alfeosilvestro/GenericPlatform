DROP TABLE IF EXISTS `platform_db`.`BM_Gallery`;


--
-- Table structure for table `bm_gallery`
--

CREATE TABLE `bm_gallery` (
  `Id` int(11) NOT NULL,
  `Name` varchar(100) DEFAULT NULL,
  `Description` longtext,
  `ThumbnailImage` longblob NOT NULL,
  `DetailImage` longblob NOT NULL,
  `DownloadableImage` longblob NOT NULL,
  `CreatedDate` datetime DEFAULT NULL,
  `CreatedBy` varchar(45) DEFAULT NULL,
  `UpdatedDate` datetime DEFAULT NULL,
  `UpdatedBy` varchar(45) DEFAULT NULL,
  `IsActive` bit(1) DEFAULT b'1',
  `Version` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf16;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `bm_gallery`
--
ALTER TABLE `bm_gallery`
  ADD PRIMARY KEY (`Id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `bm_gallery`
--
ALTER TABLE `bm_gallery`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
