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
-- Table structure for table `khachhang`
--

DROP TABLE IF EXISTS `khachhang`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `khachhang` (
  `MaKH` varchar(500) NOT NULL,
  `TenKH` text,
  `DiaChi` text,
  `DienThoai` text,
  `Email` text,
  PRIMARY KEY (`MaKH`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `khachhang`
--

LOCK TABLES `khachhang` WRITE;
/*!40000 ALTER TABLE `khachhang` DISABLE KEYS */;
INSERT INTO `khachhang` VALUES ('KH000001','Unik Nguyễn Lương Bằng','Tòa nhà 187 Nguyễn Lương Bằng - Quận Đống Đa - Hà Nội','02462691504','yenhoamark@gmail.com'),('KH000002','Unik Kim Mã ','Tòa nhà DMC, số 535 Kim Mã - Quận Ba Đình - Hà Nội','02422209566','kimmamark@gmail.com'),('KH000003','Unik Thụy Khuê','Tòa nhà HIPT, số 152 đường Thụy Khuê - Quận Tây Hồ - Hà Nội','02435505152','thuykhue@gmail.com'),('KH000004','Unik Nghĩa Đô','Tòa CT2A Khu đô thị mới Nghĩa Đô - Hoàng Quốc Việt - Quận Cầu Giấy - Hà Nội','02432247183','nghiado@gmail.com'),('KH000005','Unik Nguyễn Tuân','Tòa D chung cư Imperia Garden, số 143 Nguyễn Tuân - Phường Thanh Xuân Trung - Quận Thanh Xuân - Hà Nội','02432009528','nguyentuan@gmail.com'),('KH000006','Unik Văn Tiến Dũng','Tòa CT2 số 59 Văn Tiến Dũng - Quận Nam Từ Liêm - Hà Nội','02413234312','vantiendung@gmail.com'),('KH000007','Unik Ngô Xuân Quảng','24 Ngô Xuân Quảng - Huyện Gia Lâm - Hà Nội','02419673823','ngovanquang@gmail.com');
/*!40000 ALTER TABLE `khachhang` ENABLE KEYS */;
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
