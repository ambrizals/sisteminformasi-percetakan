/*
SQLyog Ultimate v11.11 (64 bit)
MySQL - 5.7.11-log : Database - percetakan
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

/*Data for the table `absensi` */

insert  into `absensi`(`karyawanID`,`absensiDATE`,`absensiTIME`,`absensiSTATUS`) values ('KRY-1','2017-06-08','14:05:09','Masuk'),('KRY-1','2017-06-10','18:36:04','Masuk'),('KRY-2','2017-06-10','19:07:09','Masuk'),('KRY-1','2017-06-11','22:48:48','Masuk'),('KRY-1','2017-06-14','08:31:06','Masuk'),('KRY-1','2017-06-15','00:17:30','Masuk'),('KRY-2','2017-06-15','16:38:32','Masuk');

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

insert  into `bahan`(`BAHANID`,`BAHANNAME`,`BAHANSTOCK`,`BAHANUNIT`,`BAHANHARGA`) values ('BHN - 1','Bahan satu',3,'Meter',2000),('BHN - 10','Stiker Vinly (Kertas)',16,'Meter',10000),('BHN - 11','Stiker Bontak (Kertas)',60,'Unit',10000),('BHN - 12','Stiker Vinly Dop',0,'Unit',10000),('BHN - 13','Stiker Vinly (Outdoor)',2,'Meter',40000),('BHN - 14','Stiker Oneway',6,'Meter',50000),('BHN - 15','Mata Ayam',100,'Meter',500),('BHN - 2','Bahan Dua',16,'Meter',2000),('BHN - 3','Bahan Tiga',30,'Meter',2000),('BHN - 4','Bahan empat',4,'Meter',2000),('BHN - 5','Bahan lima',4,'Meter',1000),('BHN - 6','Bahan enam',-2,'Meter',15000),('BHN - 7','Spanduk Standard',100,'Meter',14000),('BHN - 8','Spanduk Ritrama',20,'Meter',20000),('BHN - 9','Spanduk Backlit',110,'Meter',40000);

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
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;

/*Data for the table `cuti` */

insert  into `cuti`(`cutiID`,`karyawanID`,`cutiAlasan`,`cutiMulai`,`cutiAkhir`) values (1,'KRY-1','Pulang','2017-06-10','2017-06-10'),(2,'KRY-1','Cuti bang','2017-06-10','2017-06-10'),(3,'KRY-1','Pulang cuy','2017-06-10','2017-06-10'),(4,'KRY-1','Pulang cuy','2017-06-10','2017-06-10'),(5,'KRY-1','Karena mabok','2017-06-10','2017-06-10'),(6,'KRY-2','Sakit','2017-06-14','2017-06-16');

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

insert  into `karyawan`(`KARYAWANID`,`LEVELID`,`KARYAWANNAME`,`KARYAWANUSERNAME`,`KARYAWANPASSWORD`,`KARYAWANALAMAT`,`KARYAWANTELP`) values ('KRY-1','JBT-001','Ambrizal Suryadinata','ambrizals','radiohead4403','Jl. Letda Made Putra','08115349997'),('KRY-2','JBT-003','Yasir Alamsyah','yasir','radiohead4403','Null bang','08112345678'),('KRY-3','JBT-002','Anggita','anggi','radiohead4403','Null bang','08112345677'),('KRY-4','JBT-002','Muhammad Ramadhan','Rama','radiohead4403','Wkwkwkwk woo','0811242141'),('KRY-5','JBT-003','Oconk','sabun','radiohead4403','asdjasdjqioj','08112345667'),('KRY-6','JBT-002','Gilang Permana Putra','gilang','1234','jalan danau buyan ','081xxxxxxx');

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
  `KARYAWANID` varchar(10) NOT NULL,
  `TASKID` varchar(30) NOT NULL,
  `PROSESDATE` datetime NOT NULL,
  `PROSESSTATUS` varchar(30) NOT NULL,
  KEY `FK_DAPAT` (`KARYAWANID`),
  KEY `FK_MENGATUR` (`TASKID`),
  CONSTRAINT `FK_DAPAT` FOREIGN KEY (`KARYAWANID`) REFERENCES `karyawan` (`KARYAWANID`),
  CONSTRAINT `FK_MENGATUR` FOREIGN KEY (`TASKID`) REFERENCES `tasklist` (`TASKID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `log_joblist` */

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

/*Data for the table `log_pesanan` */

insert  into `log_pesanan`(`karyawanID`,`orderID`,`logDate`,`logStatus`) values ('KRY-1','ORD-1','2017-06-14 20:25:20','Membuat Pesanan'),('KRY-1','ORD-2','2017-06-15 00:36:54','Membuat Pesanan'),('KRY-1','ORD-3','2017-06-15 01:12:45','Membuat Pesanan'),('KRY-1','ORD-4','2017-06-15 01:20:24','Membuat Pesanan'),('KRY-1','ORD-5','2017-06-15 16:34:45','Membuat Pesanan');

/*Table structure for table `pengaturan` */

DROP TABLE IF EXISTS `pengaturan`;

CREATE TABLE `pengaturan` (
  `pengaturanName` varchar(30) NOT NULL,
  `pengaturanIsi` text NOT NULL,
  PRIMARY KEY (`pengaturanName`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `pengaturan` */

insert  into `pengaturan`(`pengaturanName`,`pengaturanIsi`) values ('pengumuman','Aplikasi ini sedang dalam pengembangan :)\nVersi : 0.3\n\n----------------------------------\n\nFixed.');

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

/*Data for the table `pesanan` */

insert  into `pesanan`(`ORDERID`,`ORDERCONSUMER`,`ORDERCONSUMERTELP`,`ORDERSTATUS`,`ORDERTOTAL`,`ORDERBAYAR`) values ('ORD-1','Agus','081123456','FINISH',400000,400000),('ORD-2','Agus','0811241012','PROSES',100000,100000),('ORD-3','Agus Sumardjo','019102940','PROSES',100000,100000),('ORD-4','Saya ganteng','01010','PESANAN DIBATALKAN',100000,100000),('ORD-5','Agoes','0101020','PESANAN DIBATALKAN',100000,100000);

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

/*Data for the table `tasklist` */

insert  into `tasklist`(`TASKID`,`BAHANID`,`ORDERID`,`TASKNAME`,`TASKQTY`,`TASKPRICE`,`TASKSTATUS`) values ('ORD-1-TLT-0','BHN - 11','ORD-1','Stiker ini itu',20,200000,'FINISH'),('ORD-1-TLT-1','BHN - 12','ORD-1','Stiker ini itu',20,200000,'FINISH'),('ORD-2-TLT-0','BHN - 11','ORD-2','Tulisan',10,100000,'Pending'),('ORD-3-TLT-0','BHN - 10','ORD-3','Wow.png',10,100000,'Pending'),('ORD-4-TLT-0','BHN - 10','ORD-4','Begini.jpg',10,100000,'Pending'),('ORD-5-TLT-0','BHN - 10','ORD-5','Ini ya',10,100000,'CANCEL');

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
