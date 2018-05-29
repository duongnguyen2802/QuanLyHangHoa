CREATE DATABASE  IF NOT EXISTS `quanlyhanghoa` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `quanlyhanghoa`;
-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: localhost    Database: quanlyhanghoa
-- ------------------------------------------------------
-- Server version	5.7.19-log

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
-- Table structure for table `hanghoa`
--

DROP TABLE IF EXISTS `hanghoa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `hanghoa` (
  `mamathang` varchar(500) NOT NULL,
  `tenmathang` varchar(45) DEFAULT NULL,
  `soluong` int(11) DEFAULT NULL,
  `dongia` float DEFAULT NULL,
  `ngaysanxuat` datetime DEFAULT NULL,
  `ngayhethan` datetime DEFAULT NULL,
  `tinhtrang` varchar(45) DEFAULT NULL,
  `manhomhanghoa` int(11) NOT NULL,
  `manhacungcap` int(11) NOT NULL,
  PRIMARY KEY (`mamathang`),
  UNIQUE KEY `mamathang_UNIQUE` (`mamathang`),
  UNIQUE KEY `tenmathang_UNIQUE` (`tenmathang`),
  KEY `hanghoa_nhomhanghoa_idx` (`manhomhanghoa`),
  KEY `hanghoa_nhacuncap_idx` (`manhacungcap`),
  CONSTRAINT `hanghoa_nhacuncap` FOREIGN KEY (`manhacungcap`) REFERENCES `nhacungcap` (`manhacungcap`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `hanghoa_nhomhanghoa` FOREIGN KEY (`manhomhanghoa`) REFERENCES `nhomhanghoa` (`manhomhanghoa`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `hanghoa`
--

LOCK TABLES `hanghoa` WRITE;
/*!40000 ALTER TABLE `hanghoa` DISABLE KEYS */;
INSERT INTO `hanghoa` VALUES ('MH000002','bánh kem',2345,1230000,'2018-05-29 18:53:19','2018-05-29 18:53:19',NULL,3,1),('MH000003','kẹo kéo',109,1000,'2018-05-29 19:16:57','2018-05-29 19:16:57',NULL,2,1),('MH000004','bcsmbuj',3455,13442,'2018-05-29 19:26:46','2018-05-29 19:26:46',NULL,2,2);
/*!40000 ALTER TABLE `hanghoa` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-05-29 19:34:57
