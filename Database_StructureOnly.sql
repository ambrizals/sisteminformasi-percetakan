/*
SQLyog Ultimate v11.11 (64 bit)
MySQL - 5.7.18-log : Database - percetakan
*********************************************************************
*/


/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`percetakan` /*!40100 DEFAULT CHARACTER SET utf8 */;

USE `percetakan`;

/*Table structure for table `absensi` */

DROP TABLE IF EXISTS `absensi`;

CREATE TABLE `absensi` (
  `karyawanID` varchar(10) NOT NULL,
  `absensiDATE` date NOT NULL,
  `absensiTIME` time NOT NULL,
  `absensiSTATUS` varchar(10) NOT NULL,
  KEY `FK_Absensi` (`karyawanID`),
  CONSTRAINT `FK_Absensi` FOREIGN KEY (`karyawanID`) REFERENCES `karyawan` (`KARYAWANID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Table structure for table `bahan` */

DROP TABLE IF EXISTS `bahan`;

CREATE TABLE `bahan` (
  `BAHANID` varchar(10) NOT NULL,
  `BAHANNAME` varchar(30) NOT NULL,
  `BAHANHARGA` double DEFAULT NULL,
  PRIMARY KEY (`BAHANID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Table structure for table `cuti` */

DROP TABLE IF EXISTS `cuti`;

CREATE TABLE `cuti` (
  `cutiID` int(11) NOT NULL AUTO_INCREMENT,
  `karyawanID` varchar(20) NOT NULL,
  `cutiAlasan` varchar(45) NOT NULL,
  `cutiMulai` date NOT NULL,
  `cutiAkhir` date NOT NULL,
  PRIMARY KEY (`cutiID`),
  KEY `FK_Karyawan_Cuti` (`karyawanID`),
  CONSTRAINT `FK_Karyawan_Cuti` FOREIGN KEY (`karyawanID`) REFERENCES `karyawan` (`KARYAWANID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Table structure for table `karyawan` */

DROP TABLE IF EXISTS `karyawan`;

CREATE TABLE `karyawan` (
  `KARYAWANID` varchar(10) NOT NULL,
  `KARYAWANLEVEL` varchar(10) NOT NULL,
  `KARYAWANNAME` varchar(30) NOT NULL,
  `KARYAWANUSERNAME` varchar(16) NOT NULL,
  `KARYAWANPASSWORD` varchar(16) NOT NULL,
  `KARYAWANALAMAT` text NOT NULL,
  `KARYAWANTELP` varchar(13) NOT NULL,
  PRIMARY KEY (`KARYAWANID`),
  KEY `FK_DIMILIKI_KARYAWAN` (`KARYAWANLEVEL`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/* INPUT USER DEFAULT */
INSERT INTO `karyawan` (`KARYAWANID`, `KARYAWANLEVEL`, `KARYAWANNAME`, `KARYAWANUSERNAME`, `KARYAWANPASSWORD`, `KARYAWANALAMAT`, `KARYAWANTELP`) VALUES ('KRY-1', 'ADMIN', 'admin', 'Administrator', 'admin', 'Alamat Admin', '036123456'); 

/*Table structure for table `log_bahan` */

DROP TABLE IF EXISTS `log_bahan`;

CREATE TABLE `log_bahan` (
  `MEMASUKKANID` int(11) NOT NULL AUTO_INCREMENT,
  `KARYAWANID` varchar(10) NOT NULL,
  `BAHANID` varchar(10) NOT NULL,
  `MEMASUKKANDATE` datetime NOT NULL,
  `MEMASUKKANSTATUS` varchar(30) NOT NULL,
  PRIMARY KEY (`MEMASUKKANID`),
  KEY `FK_RELATIONSHIP_8` (`KARYAWANID`),
  KEY `FK_RELATIONSHIP_9` (`BAHANID`),
  CONSTRAINT `FK_RELATIONSHIP_8` FOREIGN KEY (`KARYAWANID`) REFERENCES `karyawan` (`KARYAWANID`),
  CONSTRAINT `FK_RELATIONSHIP_9` FOREIGN KEY (`BAHANID`) REFERENCES `bahan` (`BAHANID`)
) ENGINE=InnoDB AUTO_INCREMENT=31 DEFAULT CHARSET=utf8;

/*Table structure for table `log_joblist` */

DROP TABLE IF EXISTS `log_joblist`;

CREATE TABLE `log_joblist` (
  `KARYAWANID` varchar(10) NOT NULL,
  `TASKID` varchar(30) NOT NULL,
  `PROSESDATE` datetime NOT NULL,
  `PROSESSTATUS` varchar(30) NOT NULL,
  KEY `FK_DAPAT` (`KARYAWANID`),
  KEY `FK_MENGATUR` (`TASKID`),
  CONSTRAINT `FK_DAPAT` FOREIGN KEY (`KARYAWANID`) REFERENCES `karyawan` (`KARYAWANID`),
  CONSTRAINT `FK_MENGATUR` FOREIGN KEY (`TASKID`) REFERENCES `tasklist` (`TASKID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Table structure for table `log_pesanan` */

DROP TABLE IF EXISTS `log_pesanan`;

CREATE TABLE `log_pesanan` (
  `karyawanID` varchar(10) NOT NULL,
  `orderID` varchar(10) NOT NULL,
  `logDate` datetime NOT NULL,
  `logStatus` varchar(30) NOT NULL,
  KEY `FK_Log_OrderID` (`orderID`),
  KEY `FK_Log_KaryawanID` (`karyawanID`),
  CONSTRAINT `FK_Log_KaryawanID` FOREIGN KEY (`karyawanID`) REFERENCES `karyawan` (`KARYAWANID`),
  CONSTRAINT `FK_Log_OrderID` FOREIGN KEY (`orderID`) REFERENCES `pesanan` (`ORDERID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Table structure for table `pengaturan` */

DROP TABLE IF EXISTS `pengaturan`;

CREATE TABLE `pengaturan` (
  `pengaturanName` varchar(30) NOT NULL,
  `pengaturanIsi` text NOT NULL,
  PRIMARY KEY (`pengaturanName`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Table structure for table `pesanan` */

DROP TABLE IF EXISTS `pesanan`;

CREATE TABLE `pesanan` (
  `ORDERID` varchar(10) NOT NULL,
  `ORDERCONSUMER` varchar(30) NOT NULL,
  `ORDERCONSUMERTELP` varchar(13) NOT NULL,
  `ORDERSTATUS` varchar(20) NOT NULL,
  `ORDERTOTAL` int(11) NOT NULL,
  `ORDERBAYAR` int(11) NOT NULL,
  PRIMARY KEY (`ORDERID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Table structure for table `tasklist` */

DROP TABLE IF EXISTS `tasklist`;

CREATE TABLE `tasklist` (
  `TASKID` varchar(30) NOT NULL,
  `BAHANID` varchar(10) NOT NULL,
  `ORDERID` varchar(10) NOT NULL,
  `TASKNAME` text NOT NULL,
  `TASKQTY` int(11) NOT NULL,
  `TASKPRICE` int(11) NOT NULL,
  `TASKSTATUS` varchar(16) NOT NULL,
  PRIMARY KEY (`TASKID`),
  KEY `FK_TERDAPAT_DI_TASK` (`BAHANID`),
  KEY `FK_TERDAPAT_PADA` (`ORDERID`),
  CONSTRAINT `FK_TERDAPAT_DI_TASK` FOREIGN KEY (`BAHANID`) REFERENCES `bahan` (`BAHANID`),
  CONSTRAINT `FK_TERDAPAT_PADA` FOREIGN KEY (`ORDERID`) REFERENCES `pesanan` (`ORDERID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
