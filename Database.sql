/*
SQLyog Ultimate v11.11 (64 bit)
MySQL - 5.5.5-10.1.21-MariaDB : Database - percetakan
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
  `absensiID` int(11) NOT NULL AUTO_INCREMENT,
  `karyawanID` varchar(10) NOT NULL,
  `absensiDATE` datetime NOT NULL,
  `absensiTIME` time NOT NULL,
  PRIMARY KEY (`absensiID`),
  KEY `FK_Absensi` (`karyawanID`),
  CONSTRAINT `FK_Absensi` FOREIGN KEY (`karyawanID`) REFERENCES `karyawan` (`KARYAWANID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `absensi` */

/*Table structure for table `bahan` */

DROP TABLE IF EXISTS `bahan`;

CREATE TABLE `bahan` (
  `BAHANID` varchar(10) NOT NULL,
  `BAHANNAME` varchar(30) NOT NULL,
  `BAHANSTOCK` int(11) NOT NULL,
  `BAHANUNIT` varchar(10) NOT NULL,
  `BAHANHARGA` double DEFAULT NULL,
  PRIMARY KEY (`BAHANID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `bahan` */

insert  into `bahan`(`BAHANID`,`BAHANNAME`,`BAHANSTOCK`,`BAHANUNIT`,`BAHANHARGA`) values ('BHN - 1','Bahan satu',3,'Meter',2000),('BHN - 10','Stiker Vinly (Kertas)',100,'Meter',10000),('BHN - 11','Stiker Bontak (Kertas)',100,'Unit',10000),('BHN - 12','Stiker Vinly Dop',20,'Unit',10000),('BHN - 13','Stiker Vinly (Outdoor)',7,'Meter',40000),('BHN - 14','Stiker Oneway',20,'Meter',50000),('BHN - 15','Mata Ayam',100,'Meter',500),('BHN - 2','Bahan Dua',20,'Meter',2000),('BHN - 3','Bahan Tiga',30,'Meter',2000),('BHN - 4','Bahan empat',4,'Meter',2000),('BHN - 5','Bahan lima',4,'Meter',1000),('BHN - 6','Bahan enam',3,'Meter',15000),('BHN - 7','Spanduk Standard',100,'Meter',14000),('BHN - 8','Spanduk Ritrama',20,'Meter',20000),('BHN - 9','Spanduk Backlit',110,'Meter',40000);

/*Table structure for table `jabatan` */

DROP TABLE IF EXISTS `jabatan`;

CREATE TABLE `jabatan` (
  `LEVELID` varchar(10) NOT NULL,
  `LEVELNAME` varchar(30) NOT NULL,
  PRIMARY KEY (`LEVELID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `jabatan` */

insert  into `jabatan`(`LEVELID`,`LEVELNAME`) values ('JBT-001','Admin'),('JBT-002','Operator'),('JBT-003','Kasir');

/*Table structure for table `karyawan` */

DROP TABLE IF EXISTS `karyawan`;

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

/*Data for the table `karyawan` */

insert  into `karyawan`(`KARYAWANID`,`LEVELID`,`KARYAWANNAME`,`KARYAWANUSERNAME`,`KARYAWANPASSWORD`,`KARYAWANALAMAT`,`KARYAWANTELP`) values ('KRY-1','JBT-001','Ambrizal Suryadinata','ambrizals','radiohead4403','Jl. Letda Made Putra','08115349997'),('KRY-2','JBT-003','Yasir Alamsyah','yasir','radiohead4403','Null bang','08112345678'),('KRY-3','JBT-002','Anggita','anggi','radiohead4403','Null bang','08112345677'),('KRY-4','JBT-002','Muhammad Ramadhan','Rama','radiohead4403','Wkwkwkwk woo','0811242141'),('KRY-5','JBT-003','Oconk','sabun','radiohead4403','asdjasdjqioj','08112345667');

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
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=utf8;

/*Data for the table `log_bahan` */

insert  into `log_bahan`(`MEMASUKKANID`,`KARYAWANID`,`BAHANID`,`MEMASUKKANDATE`,`MEMASUKKANSTATUS`) values (3,'KRY-1','BHN - 1','2017-06-04 00:12:12','TAMBAH BAHAN'),(4,'KRY-1','BHN - 2','2017-06-04 00:12:14','TAMBAH BAHAN'),(5,'KRY-1','BHN - 3','2017-06-04 00:12:20','TAMBAH BAHAN'),(6,'KRY-1','BHN - 4','2017-06-04 16:01:46','TAMBAH BAHAN'),(7,'KRY-1','BHN - 5','2017-06-04 16:04:32','TAMBAH BAHAN'),(8,'KRY-1','BHN - 6','2017-06-04 16:04:41','TAMBAH BAHAN'),(9,'KRY-1','BHN - 7','2017-06-04 16:05:00','TAMBAH BAHAN'),(10,'KRY-1','BHN - 8','2017-06-04 16:05:21','TAMBAH BAHAN'),(11,'KRY-1','BHN - 9','2017-06-04 16:05:36','TAMBAH BAHAN'),(12,'KRY-1','BHN - 10','2017-06-04 16:05:49','TAMBAH BAHAN'),(13,'KRY-1','BHN - 11','2017-06-04 16:06:08','TAMBAH BAHAN'),(14,'KRY-1','BHN - 12','2017-06-04 16:30:25','TAMBAH BAHAN'),(15,'KRY-1','BHN - 13','2017-06-04 16:48:10','TAMBAH BAHAN'),(16,'KRY-1','BHN - 14','2017-06-04 16:48:20','TAMBAH BAHAN'),(17,'KRY-1','BHN - 15','2017-06-04 16:48:30','TAMBAH BAHAN'),(18,'KRY-1','BHN - 6','2017-06-04 16:52:58','UBAH BAHAN'),(19,'KRY-1','BHN - 9','2017-06-04 16:52:58','TAMBAH STOCK');

/*Table structure for table `log_joblist` */

DROP TABLE IF EXISTS `log_joblist`;

CREATE TABLE `log_joblist` (
  `PROSESID` int(11) NOT NULL,
  `KARYAWANID` varchar(10) NOT NULL,
  `TASKID` varchar(10) NOT NULL,
  `PROSESDATE` datetime DEFAULT NULL,
  `PROSESSTATUS` varchar(30) NOT NULL,
  PRIMARY KEY (`PROSESID`),
  KEY `FK_DAPAT` (`KARYAWANID`),
  KEY `FK_MENGATUR` (`TASKID`),
  CONSTRAINT `FK_DAPAT` FOREIGN KEY (`KARYAWANID`) REFERENCES `karyawan` (`KARYAWANID`),
  CONSTRAINT `FK_MENGATUR` FOREIGN KEY (`TASKID`) REFERENCES `tasklist` (`TASKID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `log_joblist` */

/*Table structure for table `pesanan` */

DROP TABLE IF EXISTS `pesanan`;

CREATE TABLE `pesanan` (
  `ORDERID` varchar(10) NOT NULL,
  `KARYAWANID` varchar(10) NOT NULL,
  `ORDERCONSUMER` varchar(30) NOT NULL,
  `ORDERCONSUMERTELP` varchar(13) NOT NULL,
  `ORDERSTATUS` varchar(20) NOT NULL,
  `ORDERTOTAL` int(11) NOT NULL,
  `ORDERBAYAR` int(11) NOT NULL,
  PRIMARY KEY (`ORDERID`),
  KEY `FK_MELAKUKAN` (`KARYAWANID`),
  CONSTRAINT `FK_MELAKUKAN` FOREIGN KEY (`KARYAWANID`) REFERENCES `karyawan` (`KARYAWANID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `pesanan` */

insert  into `pesanan`(`ORDERID`,`KARYAWANID`,`ORDERCONSUMER`,`ORDERCONSUMERTELP`,`ORDERSTATUS`,`ORDERTOTAL`,`ORDERBAYAR`) values ('ORD-1','KRY-1','Anggun','0812345678','PENDING',650000,325000);

/*Table structure for table `tasklist` */

DROP TABLE IF EXISTS `tasklist`;

CREATE TABLE `tasklist` (
  `TASKID` varchar(30) NOT NULL,
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

/*Data for the table `tasklist` */

insert  into `tasklist`(`TASKID`,`BAHANID`,`ORDERID`,`TASKNAME`,`TASKQTY`,`TASKPRICE`,`TASKSTATUS`) values ('ORD-1-TLT-0','BHN - 10','ORD-1','Nama File : ituitu.png',10,100000,'Pending'),('ORD-1-TLT-1','BHN - 8','ORD-1','Nama File : iniitu,png; udah',20,400000,'Pending'),('ORD-1-TLT-2','BHN - 6','ORD-1','Coba aja ya',10,150000,'Pending');

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
