CREATE DATABASE  IF NOT EXISTS `percetakan` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `percetakan`;
-- MySQL dump 10.13  Distrib 5.7.9, for Win64 (x86_64)
--
-- Host: localhost    Database: percetakan
-- ------------------------------------------------------
-- Server version	5.7.11-log

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
-- Table structure for table `bahan`
--

DROP TABLE IF EXISTS `bahan`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `bahan` (
  `BAHANID` varchar(10) NOT NULL,
  `BAHANNAME` varchar(30) NOT NULL,
  `BAHANSTOCK` int(11) NOT NULL,
  `BAHANUNIT` varchar(10) NOT NULL,
  PRIMARY KEY (`BAHANID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bahan`
--

LOCK TABLES `bahan` WRITE;
/*!40000 ALTER TABLE `bahan` DISABLE KEYS */;
/*!40000 ALTER TABLE `bahan` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `jabatan`
--

DROP TABLE IF EXISTS `jabatan`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `jabatan` (
  `LEVELID` varchar(10) NOT NULL,
  `LEVELNAME` varchar(30) NOT NULL,
  PRIMARY KEY (`LEVELID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `jabatan`
--

LOCK TABLES `jabatan` WRITE;
/*!40000 ALTER TABLE `jabatan` DISABLE KEYS */;
INSERT INTO `jabatan` VALUES ('JBT-001','Admin');
/*!40000 ALTER TABLE `jabatan` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `karyawan`
--

DROP TABLE IF EXISTS `karyawan`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `karyawan` (
  `KARYAWANID` varchar(10) NOT NULL,
  `LEVELID` varchar(10) NOT NULL,
  `KARYAWANNAME` varchar(30) NOT NULL,
  `KARYAWANUSERNAME` varchar(16) NOT NULL,
  `KARYAWANPASSWORD` varchar(16) NOT NULL,
  `KARYAWANALAMAT` text NOT NULL,
  `KARYAWANTELP` varchar(13) NOT NULL,
  PRIMARY KEY (`KARYAWANID`),
  KEY `FK_DIMILIKI_KARYAWAN` (`LEVELID`),
  CONSTRAINT `FK_DIMILIKI_KARYAWAN` FOREIGN KEY (`LEVELID`) REFERENCES `jabatan` (`LEVELID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `karyawan`
--

LOCK TABLES `karyawan` WRITE;
/*!40000 ALTER TABLE `karyawan` DISABLE KEYS */;
INSERT INTO `karyawan` VALUES ('KRY-001','JBT-001','Ambrizal Suryadinata','ambrizals','radiohead4403','Jl. Letda Made Putra','08115349997');
/*!40000 ALTER TABLE `karyawan` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `memasukkan`
--

DROP TABLE IF EXISTS `memasukkan`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `memasukkan` (
  `MEMASUKKANID` int(11) NOT NULL,
  `KARYAWANID` varchar(10) NOT NULL,
  `BAHANID` varchar(10) NOT NULL,
  `MEMASUKKANDATE` datetime NOT NULL,
  PRIMARY KEY (`MEMASUKKANID`),
  KEY `FK_RELATIONSHIP_8` (`KARYAWANID`),
  KEY `FK_RELATIONSHIP_9` (`BAHANID`),
  CONSTRAINT `FK_RELATIONSHIP_8` FOREIGN KEY (`KARYAWANID`) REFERENCES `karyawan` (`KARYAWANID`),
  CONSTRAINT `FK_RELATIONSHIP_9` FOREIGN KEY (`BAHANID`) REFERENCES `bahan` (`BAHANID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `memasukkan`
--

LOCK TABLES `memasukkan` WRITE;
/*!40000 ALTER TABLE `memasukkan` DISABLE KEYS */;
/*!40000 ALTER TABLE `memasukkan` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mengatur_task`
--

DROP TABLE IF EXISTS `mengatur_task`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `mengatur_task` (
  `PROSESID` int(11) NOT NULL,
  `KARYAWANID` varchar(10) NOT NULL,
  `TASKID` varchar(10) NOT NULL,
  `PROSESDATE` datetime DEFAULT NULL,
  PRIMARY KEY (`PROSESID`),
  KEY `FK_DAPAT` (`KARYAWANID`),
  KEY `FK_MENGATUR` (`TASKID`),
  CONSTRAINT `FK_DAPAT` FOREIGN KEY (`KARYAWANID`) REFERENCES `karyawan` (`KARYAWANID`),
  CONSTRAINT `FK_MENGATUR` FOREIGN KEY (`TASKID`) REFERENCES `tasklist` (`TASKID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mengatur_task`
--

LOCK TABLES `mengatur_task` WRITE;
/*!40000 ALTER TABLE `mengatur_task` DISABLE KEYS */;
/*!40000 ALTER TABLE `mengatur_task` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pesanan`
--

DROP TABLE IF EXISTS `pesanan`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pesanan` (
  `ORDERID` varchar(10) NOT NULL,
  `KARYAWANID` varchar(10) NOT NULL,
  `ORDERCONSUMER` varchar(30) NOT NULL,
  `ORDERCONSUMERTELP` varchar(13) NOT NULL,
  `ORDERSTATUS` varchar(20) NOT NULL,
  `ORDERTOTAL` int(11) NOT NULL,
  PRIMARY KEY (`ORDERID`),
  KEY `FK_MELAKUKAN` (`KARYAWANID`),
  CONSTRAINT `FK_MELAKUKAN` FOREIGN KEY (`KARYAWANID`) REFERENCES `karyawan` (`KARYAWANID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pesanan`
--

LOCK TABLES `pesanan` WRITE;
/*!40000 ALTER TABLE `pesanan` DISABLE KEYS */;
/*!40000 ALTER TABLE `pesanan` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tasklist`
--

DROP TABLE IF EXISTS `tasklist`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tasklist` (
  `TASKID` varchar(10) NOT NULL,
  `BAHANID` varchar(10) NOT NULL,
  `ORDERID` varchar(10) NOT NULL,
  `TASKNAME` varchar(30) NOT NULL,
  `TASKQTY` int(11) NOT NULL,
  `TASKPRICE` int(11) NOT NULL,
  `TASKSTATUS` varchar(16) NOT NULL,
  PRIMARY KEY (`TASKID`),
  KEY `FK_TERDAPAT_DI_TASK` (`BAHANID`),
  KEY `FK_TERDAPAT_PADA` (`ORDERID`),
  CONSTRAINT `FK_TERDAPAT_DI_TASK` FOREIGN KEY (`BAHANID`) REFERENCES `bahan` (`BAHANID`),
  CONSTRAINT `FK_TERDAPAT_PADA` FOREIGN KEY (`ORDERID`) REFERENCES `pesanan` (`ORDERID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tasklist`
--

LOCK TABLES `tasklist` WRITE;
/*!40000 ALTER TABLE `tasklist` DISABLE KEYS */;
/*!40000 ALTER TABLE `tasklist` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'percetakan'
--

--
-- Dumping routines for database 'percetakan'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-05-20 19:38:13
