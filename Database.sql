/*
SQLyog - Free MySQL GUI v5.0
Host - 5.7.18-log : Database - percetakan
*********************************************************************
Server version : 5.7.18-log
*/


create database if not exists `percetakan`;

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

insert into `absensi` values 
('KRY-1','2017-06-08','14:05:09','Masuk'),
('KRY-1','2017-06-10','18:36:04','Masuk'),
('KRY-2','2017-06-10','19:07:09','Masuk'),
('KRY-1','2017-06-11','22:48:48','Masuk'),
('KRY-1','2017-06-14','08:31:06','Masuk'),
('KRY-1','2017-06-15','00:17:30','Masuk'),
('KRY-2','2017-06-15','16:38:32','Masuk'),
('KRY-1','2017-06-22','19:39:29','Masuk'),
('KRY-1','2017-07-06','19:37:04','Masuk'),
('KRY-1','2017-07-09','16:41:20','Masuk');

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

insert into `bahan` values 
('BHN - 1','Bahan satu',3,'Meter',2000),
('BHN - 10','Stiker Vinly (Kertas)',15,'Meter',10000),
('BHN - 11','Stiker Bontak (Kertas)',16,'Unit',10000),
('BHN - 12','Stiker Vinly Dop',0,'Unit',10000),
('BHN - 13','Stiker Vinly (Outdoor)',1,'Meter',40000),
('BHN - 14','Stiker Oneway',13,'Meter',50000),
('BHN - 15','Mata Ayam',90,'Meter',500),
('BHN - 2','Bahan Dua',16,'Meter',2000),
('BHN - 3','Bahan Tiga',30,'Meter',2000),
('BHN - 4','Bahan empat',4,'Meter',2000),
('BHN - 5','Bahan lima',4,'Meter',1000),
('BHN - 6','Bahan enam',-2,'Meter',15000),
('BHN - 7','Spanduk Standard',100,'Meter',14000),
('BHN - 8','Spanduk Ritrama',20,'Meter',20000),
('BHN - 9','Spanduk Backlit',110,'Meter',40000);

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

insert into `cuti` values 
(1,'KRY-1','Pulang','2017-06-10','2017-06-10'),
(2,'KRY-1','Cuti bang','2017-06-10','2017-06-10'),
(3,'KRY-1','Pulang cuy','2017-06-10','2017-06-10'),
(4,'KRY-1','Pulang cuy','2017-06-10','2017-06-10'),
(5,'KRY-1','Karena mabok','2017-06-10','2017-06-10'),
(6,'KRY-2','Sakit','2017-06-14','2017-06-16');

/*Table structure for table `finishing` */

DROP TABLE IF EXISTS `finishing`;

CREATE TABLE `finishing` (
  `finishing_Id` varchar(13) NOT NULL,
  `finishing_name` varchar(50) NOT NULL,
  `finishing_harga` int(11) NOT NULL,
  PRIMARY KEY (`finishing_Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `finishing` */

/*Table structure for table `finishing_detail` */

DROP TABLE IF EXISTS `finishing_detail`;

CREATE TABLE `finishing_detail` (
  `finishing_detail_id` varchar(13) NOT NULL,
  `finishing_id` varchar(13) NOT NULL,
  `bahanid` varchar(13) NOT NULL,
  `finishing_detail_harga` int(11) NOT NULL,
  PRIMARY KEY (`finishing_detail_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `finishing_detail` */

/*Table structure for table `jabatan` */

DROP TABLE IF EXISTS `jabatan`;

CREATE TABLE `jabatan` (
  `LEVELID` varchar(10) NOT NULL,
  `LEVELNAME` varchar(30) NOT NULL,
  PRIMARY KEY (`LEVELID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `jabatan` */

insert into `jabatan` values 
('JBT-001','Admin'),
('JBT-002','Operator'),
('JBT-003','Kasir');

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

insert into `karyawan` values 
('KRY-1','JBT-001','Ambrizal Suryadinata','ambrizals','radiohead4403','Jl. Letda Made Putra','08115349997'),
('KRY-2','JBT-003','Yasir Alamsyah','yasir','radiohead4403','Null bang','08112345678'),
('KRY-3','JBT-002','Anggita','anggi','radiohead4403','Null bang','08112345677'),
('KRY-4','JBT-002','Muhammad Ramadhan','Rama','radiohead4403','Wkwkwkwk woo','0811242141'),
('KRY-5','JBT-003','Oconk','sabun','radiohead4403','asdjasdjqioj','08112345667'),
('KRY-6','JBT-002','Gilang Permana Putra','gilang','1234','jalan danau buyan OK','081xxxxxxx');

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

insert into `log_bahan` values 
(3,'KRY-1','BHN - 1','2017-06-04 00:12:12','TAMBAH BAHAN'),
(4,'KRY-1','BHN - 2','2017-06-04 00:12:14','TAMBAH BAHAN'),
(5,'KRY-1','BHN - 3','2017-06-04 00:12:20','TAMBAH BAHAN'),
(6,'KRY-1','BHN - 4','2017-06-04 16:01:46','TAMBAH BAHAN'),
(7,'KRY-1','BHN - 5','2017-06-04 16:04:32','TAMBAH BAHAN'),
(8,'KRY-1','BHN - 6','2017-06-04 16:04:41','TAMBAH BAHAN'),
(9,'KRY-1','BHN - 7','2017-06-04 16:05:00','TAMBAH BAHAN'),
(10,'KRY-1','BHN - 8','2017-06-04 16:05:21','TAMBAH BAHAN'),
(11,'KRY-1','BHN - 9','2017-06-04 16:05:36','TAMBAH BAHAN'),
(12,'KRY-1','BHN - 10','2017-06-04 16:05:49','TAMBAH BAHAN'),
(13,'KRY-1','BHN - 11','2017-06-04 16:06:08','TAMBAH BAHAN'),
(14,'KRY-1','BHN - 12','2017-06-04 16:30:25','TAMBAH BAHAN'),
(15,'KRY-1','BHN - 13','2017-06-04 16:48:10','TAMBAH BAHAN'),
(16,'KRY-1','BHN - 14','2017-06-04 16:48:20','TAMBAH BAHAN'),
(17,'KRY-1','BHN - 15','2017-06-04 16:48:30','TAMBAH BAHAN'),
(18,'KRY-1','BHN - 6','2017-06-04 16:52:58','UBAH BAHAN'),
(19,'KRY-1','BHN - 9','2017-06-04 16:52:58','TAMBAH STOCK');

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

insert into `log_pesanan` values 
('KRY-1','ORD-1','2017-06-14 20:25:20','Membuat Pesanan'),
('KRY-1','ORD-2','2017-06-15 00:36:54','Membuat Pesanan'),
('KRY-1','ORD-3','2017-06-15 01:12:45','Membuat Pesanan'),
('KRY-1','ORD-4','2017-06-15 01:20:24','Membuat Pesanan'),
('KRY-1','ORD-5','2017-06-15 16:34:45','Membuat Pesanan'),
('KRY-1','ORD-6','2017-06-22 20:20:08','Membuat Pesanan'),
('KRY-1','ORD-7','2017-07-06 19:40:53','Membuat Pesanan'),
('KRY-1','ORD-8','2017-07-06 21:44:21','Membuat Pesanan'),
('KRY-1','ORD-9','2017-07-06 23:22:49','Membuat Pesanan'),
('KRY-1','ORD-10','2017-07-06 23:22:49','Membuat Pesanan'),
('KRY-1','ORD-11','2017-07-06 23:26:28','Membuat Pesanan');

/*Table structure for table `pengaturan` */

DROP TABLE IF EXISTS `pengaturan`;

CREATE TABLE `pengaturan` (
  `pengaturanName` varchar(30) NOT NULL,
  `pengaturanIsi` text NOT NULL,
  PRIMARY KEY (`pengaturanName`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `pengaturan` */

insert into `pengaturan` values 
('pengumuman','Aplikasi ini sedang dalam pengembangan :)\nVersi : 0.3\n\n----------------------------------\n\nFixed.');

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

insert into `pesanan` values 
('ORD-1','Agus','081123456','FINISH',400000,400000),
('ORD-10','Agoes','0182041','PROSES',20000,10000),
('ORD-11','asdas13','51313','PENDING',15000,15000),
('ORD-2','Agus','0811241012','PESANAN DIBATALKAN',100000,100000),
('ORD-3','Agus Sumardjo','019102940','PESANAN DIBATALKAN',100000,100000),
('ORD-4','Saya ganteng','01010','PESANAN DIBATALKAN',100000,100000),
('ORD-5','Agoes','0101020','PESANAN DIBATALKAN',100000,100000),
('ORD-6','Abdil','01811820','FINISH',200000,200000),
('ORD-7','nita','889898','PENDING',250000,300000),
('ORD-8','asdsa25','12412','PROSES',5000,2500),
('ORD-9','DIla','00912031','FINISH',140000,70000);

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

insert into `tasklist` values 
('ORD-1-TLT-0','BHN - 11','ORD-1','Stiker ini itu',20,200000,'FINISH'),
('ORD-1-TLT-1','BHN - 12','ORD-1','Stiker ini itu',20,200000,'FINISH'),
('ORD-10-TLT-0','BHN - 10','ORD-10','asfas',1,10000,'PROSES'),
('ORD-10-TLT-1','BHN - 15','ORD-10','dsada',20,10000,'Pending'),
('ORD-11-TLT-0','BHN - 15','ORD-11','dsadas',10,5000,'PENDING'),
('ORD-11-TLT-1','BHN - 10','ORD-11','adsa',1,10000,'PENDING'),
('ORD-2-TLT-0','BHN - 11','ORD-2','Tulisan',10,100000,'CANCEL'),
('ORD-3-TLT-0','BHN - 10','ORD-3','Wow.png',10,100000,'CANCEL'),
('ORD-4-TLT-0','BHN - 10','ORD-4','Begini.jpg',10,100000,'CANCEL'),
('ORD-5-TLT-0','BHN - 10','ORD-5','Ini ya',10,100000,'CANCEL'),
('ORD-6-TLT-0','BHN - 11','ORD-6','MotoGP.png',10,100000,'FINISH'),
('ORD-6-TLT-1','BHN - 11','ORD-6','Wow.png',10,100000,'FINISH'),
('ORD-7-TLT-0','BHN - 14','ORD-7','stiker ',2,100000,'PENDING'),
('ORD-7-TLT-1','BHN - 14','ORD-7','stiker',3,150000,'CANCEL'),
('ORD-8-TLT-0','BHN - 15','ORD-8','asdsada',10,5000,'PROSES'),
('ORD-9-TLT-0','BHN - 11','ORD-9','adsad',12,120000,'FINISH'),
('ORD-9-TLT-1','BHN - 11','ORD-9','adasda',2,20000,'FINISH');
