CREATE DATABASE  IF NOT EXISTS `quanlyhanghoa2` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `quanlyhanghoa2`;
-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: localhost    Database: quanlyhanghoa2
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
-- Table structure for table `chucnang`
--

DROP TABLE IF EXISTS `chucnang`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `chucnang` (
  `machucnang` int(11) NOT NULL AUTO_INCREMENT,
  `tenchucnang` varchar(1000) DEFAULT NULL,
  `loaichucnang` varchar(45) DEFAULT NULL,
  `mota` text,
  PRIMARY KEY (`machucnang`),
  UNIQUE KEY `machucnang_UNIQUE` (`machucnang`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8 COMMENT='phan quyen chuc nang';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `chucnang`
--

LOCK TABLES `chucnang` WRITE;
/*!40000 ALTER TABLE `chucnang` DISABLE KEYS */;
INSERT INTO `chucnang` VALUES (1,'mnuQuanLyHangHoa','menu','Quản lý nhóm hàng hóa'),(2,'mnuQuanLyNhaCungCap','menu','Quản lý nhà cung cấp'),(3,'mnuQuanLyKhachHang','menu','Quản lý khách hang'),(4,'mnuQLHangHoa','menu','Quản lý hàng hóa'),(5,'mnuDangKy','menu','Đăng ký tài khoản'),(6,'mnuHeThong','menu','Menu hệ thống chức năng nào cũng phải có bản gì này'),(7,'mnuQuanly','menu','Menu quản lý chức năng nào cũng phải có bản gì này');
/*!40000 ALTER TABLE `chucnang` ENABLE KEYS */;
UNLOCK TABLES;

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
INSERT INTO `hanghoa` VALUES ('MH000002','bánh kem',2345,1230000,'2018-05-29 18:53:19','2018-05-29 18:53:19',NULL,3,1),('MH000003','kẹo kéo',109,1000,'2018-05-29 19:16:57','2018-05-29 19:16:57',NULL,2,1),('MH000004','Bánh kẽm sữa Kinh Đô loại 125g',50,20000,'2018-05-29 19:26:46','2018-05-29 19:26:46',NULL,2,2),('MH000005','nước ngọt pessi',50,10000,'2018-05-30 08:41:48','2018-05-30 08:41:48',NULL,2,1);
/*!40000 ALTER TABLE `hanghoa` ENABLE KEYS */;
UNLOCK TABLES;

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

--
-- Table structure for table `loainhanvien`
--

DROP TABLE IF EXISTS `loainhanvien`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `loainhanvien` (
  `maloainhanvien` varchar(50) NOT NULL,
  `tenloainhanvien` varchar(1000) NOT NULL,
  `tiento` varchar(10) NOT NULL,
  PRIMARY KEY (`maloainhanvien`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `loainhanvien`
--

LOCK TABLES `loainhanvien` WRITE;
/*!40000 ALTER TABLE `loainhanvien` DISABLE KEYS */;
INSERT INTO `loainhanvien` VALUES ('GD','Giám đốc','GD'),('KD','Nhân viên kinh doanh','KD'),('TK','Thủ kho','TK');
/*!40000 ALTER TABLE `loainhanvien` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `nhacungcap`
--

DROP TABLE IF EXISTS `nhacungcap`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `nhacungcap` (
  `manhacungcap` int(11) NOT NULL AUTO_INCREMENT,
  `tennhacungcap` text,
  `diachi` text,
  `email` text,
  `dienthoai` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`manhacungcap`),
  UNIQUE KEY `manhacungcap_UNIQUE` (`manhacungcap`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `nhacungcap`
--

LOCK TABLES `nhacungcap` WRITE;
/*!40000 ALTER TABLE `nhacungcap` DISABLE KEYS */;
INSERT INTO `nhacungcap` VALUES (1,'Hải Hà','cầu giấy - hà nội','haiha@gmail.com','016689899'),(2,'Công ty TNHH bánh Kinh Đô ','Số 56 Đường Thụy Khuê - Quận Hoàn Kiếm - Hà Nội','kinhdo@gmail.com','024132436'),(4,'Công ty TNHH Mì ăn liền Acecook','Khu tập thể 15H - Quận Thanh Xuân - Hà Nội','Acecook@gmai.com','02456789'),(5,'Công ty TNHH bánh Kinh Đô ','Số 56 Đường Thụy Khuê - Quận Hoàn Kiếm - Hà Nội','kinhdo@gmail.com','024132436');
/*!40000 ALTER TABLE `nhacungcap` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `nhanvien`
--

DROP TABLE IF EXISTS `nhanvien`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `nhanvien` (
  `manhanvien` varchar(500) NOT NULL,
  `tenhannhan` varchar(45) DEFAULT NULL,
  `maloainhanvien` varchar(10) DEFAULT NULL,
  `diahchi` text,
  `dienthoai` varchar(15) DEFAULT NULL,
  `email` varchar(500) DEFAULT NULL,
  PRIMARY KEY (`manhanvien`),
  UNIQUE KEY `manhanvien_UNIQUE` (`manhanvien`),
  KEY `fk_nhanvien_loainhanvien_idx` (`maloainhanvien`),
  CONSTRAINT `fk_nhanvien_loainhanvien` FOREIGN KEY (`maloainhanvien`) REFERENCES `loainhanvien` (`maloainhanvien`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `nhanvien`
--

LOCK TABLES `nhanvien` WRITE;
/*!40000 ALTER TABLE `nhanvien` DISABLE KEYS */;
INSERT INTO `nhanvien` VALUES ('GD000001','OCEAN','GD','Hà Nội','0966888888','ocean@gmail.com'),('KD000001','Tạ Thị Hòa','KD','Phú Thọ','01649164396','tathihoa2@gmail.com');
/*!40000 ALTER TABLE `nhanvien` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `nhomhanghoa`
--

DROP TABLE IF EXISTS `nhomhanghoa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `nhomhanghoa` (
  `manhomhanghoa` int(11) NOT NULL AUTO_INCREMENT,
  `tennhomhanghoa` text NOT NULL,
  PRIMARY KEY (`manhomhanghoa`),
  UNIQUE KEY `manhomhanghoa_UNIQUE` (`manhomhanghoa`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `nhomhanghoa`
--

LOCK TABLES `nhomhanghoa` WRITE;
/*!40000 ALTER TABLE `nhomhanghoa` DISABLE KEYS */;
INSERT INTO `nhomhanghoa` VALUES (2,'Hàng tiêu dùng'),(3,'Chất tẩy rửa'),(6,'Hàng gia dụng'),(7,'Đồ uống');
/*!40000 ALTER TABLE `nhomhanghoa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `nhomuser`
--

DROP TABLE IF EXISTS `nhomuser`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `nhomuser` (
  `manhom` int(11) NOT NULL AUTO_INCREMENT,
  `tennhom` varchar(1000) NOT NULL,
  `mota` text,
  PRIMARY KEY (`manhom`),
  UNIQUE KEY `tennhom_UNIQUE` (`tennhom`),
  UNIQUE KEY `manhom_UNIQUE` (`manhom`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `nhomuser`
--

LOCK TABLES `nhomuser` WRITE;
/*!40000 ALTER TABLE `nhomuser` DISABLE KEYS */;
INSERT INTO `nhomuser` VALUES (1,'Giám đôc','Ban giám đôc'),(2,'Thủ kho','Quản lý kho'),(3,'Nhân viên kinh doan','Nhân viên kinh doanh');
/*!40000 ALTER TABLE `nhomuser` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `nhomuserchucnang`
--

DROP TABLE IF EXISTS `nhomuserchucnang`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `nhomuserchucnang` (
  `manhomuser` int(11) NOT NULL,
  `machucnang` int(11) NOT NULL,
  `mota` text,
  PRIMARY KEY (`manhomuser`,`machucnang`),
  KEY `fk_chucnang` (`machucnang`),
  CONSTRAINT `fk_chucnang` FOREIGN KEY (`machucnang`) REFERENCES `chucnang` (`machucnang`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fr_nhomuser` FOREIGN KEY (`manhomuser`) REFERENCES `nhomuser` (`manhom`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `nhomuserchucnang`
--

LOCK TABLES `nhomuserchucnang` WRITE;
/*!40000 ALTER TABLE `nhomuserchucnang` DISABLE KEYS */;
INSERT INTO `nhomuserchucnang` VALUES (1,1,'Quản lý nhóm hàng hóa'),(1,3,'Quản lý khách hang'),(1,5,'Quản lý nhóm hàng hóa'),(1,6,'Quản lý nhóm hàng hóa');
/*!40000 ALTER TABLE `nhomuserchucnang` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `user` (
  `tendangnhap` varchar(1000) NOT NULL,
  `matkhau` varchar(1000) DEFAULT NULL,
  `manhomuser` int(11) NOT NULL,
  `manhanvien` varchar(500) NOT NULL,
  `email` varchar(1000) DEFAULT NULL,
  `dienthoai` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`tendangnhap`),
  KEY `fk_user_nhanvien_idx` (`manhanvien`),
  KEY `fk_user_nhomuser_idx` (`manhomuser`),
  CONSTRAINT `fk_user_nhanvien` FOREIGN KEY (`manhanvien`) REFERENCES `nhanvien` (`manhanvien`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_user_nhomuser` FOREIGN KEY (`manhomuser`) REFERENCES `nhomuser` (`manhom`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user` VALUES ('hoacavang','123',3,'KD000001','cavang@gmail.com',''),('ocean','123',1,'GD000001','ocean@gmail.com','096688888');
/*!40000 ALTER TABLE `user` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-06-05 15:33:19
