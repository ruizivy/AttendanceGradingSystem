CREATE DATABASE  IF NOT EXISTS `attendance_db` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `attendance_db`;
-- MySQL dump 10.13  Distrib 5.6.17, for Win64 (x86_64)
--
-- Host: localhost    Database: attendance_db
-- ------------------------------------------------------
-- Server version	5.6.21-log

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
-- Table structure for table `tblattendance`
--

DROP TABLE IF EXISTS `tblattendance`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblattendance` (
  `AttendanceID` bigint(20) NOT NULL AUTO_INCREMENT,
  `Date` varchar(500) DEFAULT NULL,
  `Time` varchar(500) DEFAULT NULL,
  `Remarks` varchar(500) DEFAULT NULL,
  `ClassID` bigint(20) DEFAULT NULL,
  `EntryDaysID` bigint(20) DEFAULT NULL,
  `TermName` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`AttendanceID`),
  KEY `CID_idx` (`ClassID`),
  KEY `EID_idx` (`EntryDaysID`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblattendance`
--

LOCK TABLES `tblattendance` WRITE;
/*!40000 ALTER TABLE `tblattendance` DISABLE KEYS */;
INSERT INTO `tblattendance` VALUES (1,'Friday, June 2, 2017','4:49:18 PM','Present',4,6,'Prelim'),(2,'Friday, June 9, 2017','10:58:05 PM','Present',4,6,'Prelim'),(3,'Friday, June 9, 2017','10:58:05 PM','Present',7,6,'Prelim'),(4,'Friday, June 9, 2017','10:58:05 PM','Absent',8,6,'Prelim');
/*!40000 ALTER TABLE `tblattendance` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblcourse`
--

DROP TABLE IF EXISTS `tblcourse`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblcourse` (
  `CourseID` bigint(20) NOT NULL AUTO_INCREMENT,
  `CourseName` varchar(1000) DEFAULT NULL,
  `Abbrv` varchar(100) DEFAULT NULL,
  `IsActive` varchar(100) DEFAULT NULL,
  `UserID` bigint(20) DEFAULT NULL,
  PRIMARY KEY (`CourseID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblcourse`
--

LOCK TABLES `tblcourse` WRITE;
/*!40000 ALTER TABLE `tblcourse` DISABLE KEYS */;
INSERT INTO `tblcourse` VALUES (1,'Bachelor Of Science In Computer Science','BSCS','Active',1);
/*!40000 ALTER TABLE `tblcourse` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblcriteria`
--

DROP TABLE IF EXISTS `tblcriteria`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblcriteria` (
  `CriteriaID` bigint(20) NOT NULL AUTO_INCREMENT,
  `CriteriaName` varchar(500) DEFAULT NULL,
  `Percentage` double DEFAULT NULL,
  `UserID` bigint(20) DEFAULT NULL,
  `Active` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`CriteriaID`),
  KEY `UID_idx` (`UserID`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblcriteria`
--

LOCK TABLES `tblcriteria` WRITE;
/*!40000 ALTER TABLE `tblcriteria` DISABLE KEYS */;
INSERT INTO `tblcriteria` VALUES (1,'Attendance',10,1,'1'),(2,'Quiz',20,1,'1'),(3,'Recitation',20,1,'1'),(4,'Major Exam',40,1,'1'),(5,'Problem Set',10,1,'1');
/*!40000 ALTER TABLE `tblcriteria` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblentrydays`
--

DROP TABLE IF EXISTS `tblentrydays`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblentrydays` (
  `ID` bigint(20) NOT NULL AUTO_INCREMENT,
  `DateDays` varchar(1000) DEFAULT NULL,
  `SubjectID` bigint(20) DEFAULT NULL,
  `ScheduleID` bigint(20) DEFAULT NULL,
  `UID` bigint(20) DEFAULT NULL,
  `Term` varchar(500) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `Subj_idx` (`SubjectID`),
  KEY `Sched_idx` (`ScheduleID`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblentrydays`
--

LOCK TABLES `tblentrydays` WRITE;
/*!40000 ALTER TABLE `tblentrydays` DISABLE KEYS */;
INSERT INTO `tblentrydays` VALUES (6,'Friday, June 2, 2017',1,1,1,'Prelim'),(7,'Friday, June 9, 2017',1,1,1,'Prelim'),(8,'Friday, June 16, 2017',1,1,1,'Midterm'),(9,'Friday, June 23, 2017',1,1,1,'Midterm'),(10,'Friday, June 30, 2017',1,1,1,'Finals'),(11,'Friday, July 7, 2017',1,1,1,'Finals');
/*!40000 ALTER TABLE `tblentrydays` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblgnames`
--

DROP TABLE IF EXISTS `tblgnames`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblgnames` (
  `GNID` bigint(20) NOT NULL AUTO_INCREMENT,
  `GradingName` varchar(500) DEFAULT NULL,
  `UserID` bigint(20) DEFAULT NULL,
  PRIMARY KEY (`GNID`),
  KEY `usID_idx` (`UserID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblgnames`
--

LOCK TABLES `tblgnames` WRITE;
/*!40000 ALTER TABLE `tblgnames` DISABLE KEYS */;
INSERT INTO `tblgnames` VALUES (1,'Prelim',1),(2,'Midterm',1),(3,'Finals',1);
/*!40000 ALTER TABLE `tblgnames` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblgradingdetails`
--

DROP TABLE IF EXISTS `tblgradingdetails`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblgradingdetails` (
  `GDID` bigint(20) NOT NULL AUTO_INCREMENT,
  `TermGradingID` bigint(20) DEFAULT NULL,
  `Name` varchar(500) DEFAULT NULL,
  `Percentage` double DEFAULT NULL,
  `OverScore` double DEFAULT NULL,
  `CriteriaName` varchar(500) DEFAULT NULL,
  `Type` varchar(500) DEFAULT NULL,
  PRIMARY KEY (`GDID`),
  KEY `TGID_idx` (`TermGradingID`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblgradingdetails`
--

LOCK TABLES `tblgradingdetails` WRITE;
/*!40000 ALTER TABLE `tblgradingdetails` DISABLE KEYS */;
INSERT INTO `tblgradingdetails` VALUES (1,1,'Attendance',0.1,100,'Attendance','Prelim'),(2,2,'Quiz 1',0.2,100,'Quiz','Prelim'),(3,3,'Recitation 1',0.2,100,'Recitation','Prelim'),(4,4,'Major Exam',0.4,100,'Major Exam','Prelim'),(5,5,'Problem Set 1',0.1,100,'Problem Set','Prelim'),(6,6,'Attendance',0.1,100,'Attendance','Midterm'),(7,7,'Quiz 1',0.2,100,'Quiz','Midterm'),(8,8,'Recitation 1',0.2,100,'Recitation','Midterm'),(9,9,'Major Exam',0.4,100,'Major Exam','Midterm'),(10,10,'Problem Set 1',0.1,100,'Problem Set','Midterm'),(11,11,'Attendance',0.1,100,'Attendance','Finals'),(12,12,'Quiz 1',0.2,100,'Quiz','Finals'),(13,13,'Recitation 1',0.2,100,'Recitation','Finals'),(14,14,'Major Exam',0.4,100,'Major Exam','Finals'),(15,15,'Problem Set 1',0.1,100,'Problem Set','Finals');
/*!40000 ALTER TABLE `tblgradingdetails` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblgradingperiod`
--

DROP TABLE IF EXISTS `tblgradingperiod`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblgradingperiod` (
  `GID` bigint(20) NOT NULL AUTO_INCREMENT,
  `GNID` bigint(20) DEFAULT NULL,
  `SubjectID` bigint(20) DEFAULT NULL,
  PRIMARY KEY (`GID`),
  KEY `SubjectID_idx` (`SubjectID`),
  KEY `ID_idx` (`GNID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblgradingperiod`
--

LOCK TABLES `tblgradingperiod` WRITE;
/*!40000 ALTER TABLE `tblgradingperiod` DISABLE KEYS */;
INSERT INTO `tblgradingperiod` VALUES (1,1,1),(2,2,1),(3,3,1);
/*!40000 ALTER TABLE `tblgradingperiod` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblschedule`
--

DROP TABLE IF EXISTS `tblschedule`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblschedule` (
  `ScheduleID` bigint(20) NOT NULL AUTO_INCREMENT,
  `ScheduleTimeFrom` varchar(500) DEFAULT NULL,
  `ScheduleTimeTo` varchar(500) DEFAULT NULL,
  `ScheduleDay` varchar(500) DEFAULT NULL,
  `ScheduleRoom` varchar(500) DEFAULT NULL,
  `SubjectID` bigint(20) DEFAULT NULL,
  PRIMARY KEY (`ScheduleID`),
  KEY `SubjectCode_idx` (`SubjectID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblschedule`
--

LOCK TABLES `tblschedule` WRITE;
/*!40000 ALTER TABLE `tblschedule` DISABLE KEYS */;
INSERT INTO `tblschedule` VALUES (1,'7:30:00 AM','10:30:00 AM','Friday','COMLAB 3',1);
/*!40000 ALTER TABLE `tblschedule` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblstudent`
--

DROP TABLE IF EXISTS `tblstudent`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblstudent` (
  `StudentID` bigint(20) NOT NULL AUTO_INCREMENT,
  `StudNum` varchar(500) DEFAULT NULL,
  `FName` varchar(500) DEFAULT NULL,
  `LName` varchar(500) DEFAULT NULL,
  `Section` varchar(500) DEFAULT NULL,
  `Status` varchar(500) DEFAULT NULL,
  `CourseID` bigint(20) DEFAULT NULL,
  `UserID` bigint(20) DEFAULT NULL,
  PRIMARY KEY (`StudentID`),
  KEY `CourseID_idx` (`CourseID`),
  KEY `Uids_idx` (`UserID`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblstudent`
--

LOCK TABLES `tblstudent` WRITE;
/*!40000 ALTER TABLE `tblstudent` DISABLE KEYS */;
INSERT INTO `tblstudent` VALUES (1,'140134','Ivyrose','Ruiz','BSCS4A','Active',1,1),(2,'140111','Jaimerie','Oliveros','BSCS4A','Active',1,1),(3,'140124','Dheo','Claveria','BSCS4A','Active',1,1),(4,'140225','Marighel','Galvez','BSCS4A','Active',1,1),(5,'140214 ','Bernard','Lao','BSCS4A','Active',1,1);
/*!40000 ALTER TABLE `tblstudent` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblstudentgrades`
--

DROP TABLE IF EXISTS `tblstudentgrades`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblstudentgrades` (
  `StudentGradesID` bigint(20) NOT NULL AUTO_INCREMENT,
  `ClassID` bigint(20) DEFAULT NULL,
  `GID` bigint(20) DEFAULT NULL,
  `GradingDetailsID` bigint(20) DEFAULT NULL,
  `GradingName` varchar(500) DEFAULT NULL,
  `CriteriaName` varchar(500) DEFAULT NULL,
  `Name` varchar(500) DEFAULT NULL,
  `Score` double DEFAULT NULL,
  `RawScore` double DEFAULT NULL,
  `Grade` double DEFAULT NULL,
  PRIMARY KEY (`StudentGradesID`),
  KEY `ClassID_idx` (`ClassID`),
  KEY `GDID_idx` (`GradingDetailsID`),
  KEY `gid1_idx` (`GID`)
) ENGINE=InnoDB AUTO_INCREMENT=46 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblstudentgrades`
--

LOCK TABLES `tblstudentgrades` WRITE;
/*!40000 ALTER TABLE `tblstudentgrades` DISABLE KEYS */;
INSERT INTO `tblstudentgrades` VALUES (1,4,1,1,'Prelim','Attendance','Attendance',100,100,10),(2,4,1,4,'Prelim','Major Exam','Major Exam',0,50,20),(3,4,1,5,'Prelim','Problem Set','Problem Set 1',0,50,5),(4,4,1,2,'Prelim','Quiz','Quiz 1',85,92.5,18.5),(5,4,1,3,'Prelim','Recitation','Recitation 1',0,50,10),(6,7,1,1,'Prelim','Attendance','Attendance',100,100,10),(7,7,1,4,'Prelim','Major Exam','Major Exam',0,50,20),(8,7,1,5,'Prelim','Problem Set','Problem Set 1',0,50,5),(9,7,1,2,'Prelim','Quiz','Quiz 1',0,50,10),(10,7,1,3,'Prelim','Recitation','Recitation 1',0,50,10),(11,8,1,1,'Prelim','Attendance','Attendance',99,99.5,9.95),(12,8,1,4,'Prelim','Major Exam','Major Exam',0,50,20),(13,8,1,5,'Prelim','Problem Set','Problem Set 1',0,50,5),(14,8,1,2,'Prelim','Quiz','Quiz 1',0,50,10),(15,8,1,3,'Prelim','Recitation','Recitation 1',0,50,10),(16,4,2,6,'Midterm','Attendance','Attendance',0,50,5),(17,4,2,9,'Midterm','Major Exam','Major Exam',0,50,20),(18,4,2,10,'Midterm','Problem Set','Problem Set 1',0,50,5),(19,4,2,7,'Midterm','Quiz','Quiz 1',0,50,10),(20,4,2,8,'Midterm','Recitation','Recitation 1',0,50,10),(21,7,2,6,'Midterm','Attendance','Attendance',0,50,5),(22,7,2,9,'Midterm','Major Exam','Major Exam',0,50,20),(23,7,2,10,'Midterm','Problem Set','Problem Set 1',0,50,5),(24,7,2,7,'Midterm','Quiz','Quiz 1',0,50,10),(25,7,2,8,'Midterm','Recitation','Recitation 1',0,50,10),(26,8,2,6,'Midterm','Attendance','Attendance',0,50,5),(27,8,2,9,'Midterm','Major Exam','Major Exam',0,50,20),(28,8,2,10,'Midterm','Problem Set','Problem Set 1',0,50,5),(29,8,2,7,'Midterm','Quiz','Quiz 1',0,50,10),(30,8,2,8,'Midterm','Recitation','Recitation 1',0,50,10),(31,4,3,11,'Finals','Attendance','Attendance',0,50,5),(32,4,3,14,'Finals','Major Exam','Major Exam',0,50,20),(33,4,3,15,'Finals','Problem Set','Problem Set 1',0,50,5),(34,4,3,12,'Finals','Quiz','Quiz 1',0,50,10),(35,4,3,13,'Finals','Recitation','Recitation 1',0,50,10),(36,7,3,11,'Finals','Attendance','Attendance',0,50,5),(37,7,3,14,'Finals','Major Exam','Major Exam',0,50,20),(38,7,3,15,'Finals','Problem Set','Problem Set 1',0,50,5),(39,7,3,12,'Finals','Quiz','Quiz 1',0,50,10),(40,7,3,13,'Finals','Recitation','Recitation 1',0,50,10),(41,8,3,11,'Finals','Attendance','Attendance',0,50,5),(42,8,3,14,'Finals','Major Exam','Major Exam',0,50,20),(43,8,3,15,'Finals','Problem Set','Problem Set 1',0,50,5),(44,8,3,12,'Finals','Quiz','Quiz 1',0,50,10),(45,8,3,13,'Finals','Recitation','Recitation 1',0,50,10);
/*!40000 ALTER TABLE `tblstudentgrades` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblsubject`
--

DROP TABLE IF EXISTS `tblsubject`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblsubject` (
  `SubjectID` bigint(20) NOT NULL AUTO_INCREMENT,
  `SubjectCode` varchar(45) DEFAULT NULL,
  `SubjectName` varchar(500) DEFAULT NULL,
  `SubjectUnits` int(11) DEFAULT NULL,
  `UserID` bigint(20) DEFAULT NULL,
  PRIMARY KEY (`SubjectID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblsubject`
--

LOCK TABLES `tblsubject` WRITE;
/*!40000 ALTER TABLE `tblsubject` DISABLE KEYS */;
INSERT INTO `tblsubject` VALUES (1,'CS101','Advance Database Management System',3,1);
/*!40000 ALTER TABLE `tblsubject` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblsubjectclass`
--

DROP TABLE IF EXISTS `tblsubjectclass`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblsubjectclass` (
  `ClassID` bigint(20) NOT NULL AUTO_INCREMENT,
  `StudID` bigint(20) DEFAULT NULL,
  `SubjectID` bigint(20) DEFAULT NULL,
  `ScheduleID` bigint(20) DEFAULT NULL,
  `UserID` bigint(20) DEFAULT NULL,
  PRIMARY KEY (`ClassID`),
  KEY `StudID_idx` (`StudID`),
  KEY `subjectID2_idx` (`SubjectID`),
  KEY `schedID_idx` (`ScheduleID`),
  KEY `userID_idx` (`UserID`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblsubjectclass`
--

LOCK TABLES `tblsubjectclass` WRITE;
/*!40000 ALTER TABLE `tblsubjectclass` DISABLE KEYS */;
INSERT INTO `tblsubjectclass` VALUES (1,1,0,0,1),(2,2,0,0,1),(3,3,0,0,1),(4,3,1,1,1),(5,4,0,0,1),(6,5,0,0,1),(7,5,1,1,1),(8,2,1,1,1);
/*!40000 ALTER TABLE `tblsubjectclass` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbltermgrading`
--

DROP TABLE IF EXISTS `tbltermgrading`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbltermgrading` (
  `ID` bigint(20) NOT NULL AUTO_INCREMENT,
  `GID` bigint(20) DEFAULT NULL,
  `CriteriaID` bigint(20) DEFAULT NULL,
  `ScheduleID` bigint(20) DEFAULT NULL,
  `SubjectID` bigint(20) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `CriteriaID_idx` (`CriteriaID`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbltermgrading`
--

LOCK TABLES `tbltermgrading` WRITE;
/*!40000 ALTER TABLE `tbltermgrading` DISABLE KEYS */;
INSERT INTO `tbltermgrading` VALUES (1,1,1,1,1),(2,1,2,1,1),(3,1,3,1,1),(4,1,4,1,1),(5,1,5,1,1),(6,2,1,1,1),(7,2,2,1,1),(8,2,3,1,1),(9,2,4,1,1),(10,2,5,1,1),(11,3,1,1,1),(12,3,2,1,1),(13,3,3,1,1),(14,3,4,1,1),(15,3,5,1,1);
/*!40000 ALTER TABLE `tbltermgrading` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbluser`
--

DROP TABLE IF EXISTS `tbluser`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbluser` (
  `UserID` bigint(20) NOT NULL AUTO_INCREMENT,
  `Username` varchar(500) DEFAULT NULL,
  `UserPassword` varchar(500) DEFAULT NULL,
  `UserProfile` varchar(500) DEFAULT NULL,
  PRIMARY KEY (`UserID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbluser`
--

LOCK TABLES `tbluser` WRITE;
/*!40000 ALTER TABLE `tbluser` DISABLE KEYS */;
INSERT INTO `tbluser` VALUES (1,'ivy','ivy','Ivy Rose');
/*!40000 ALTER TABLE `tbluser` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'attendance_db'
--
/*!50003 DROP PROCEDURE IF EXISTS `insertuser` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `insertuser`(user VARCHAR(45),
															pass VARCHAR(45),
                                                            userdp VARCHAR(200))
BEGIN

INSERT INTO tbluser(Username, UserPassword, UserProfile)
VALUES(user,pass, userdp);

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `insert_gradingdetails` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_gradingdetails`(trmGrading bigint,
														   gcname VARCHAR(250),
                                                           percent double,
                                                           scores double,
                                                           over double ,
                                                           ctype VARCHAR(45),
                                                           gdid bigint)
BEGIN
case 
WHEN ctype = "Insert" THEN INSERT INTO tblgradingdetails(TermGradingID, Name , Percentage , Score , OverScore)
						VALUES(trmGrading , gcname , percent , scores , over);
WHEN ctype = "Update" THEN UPDATE tblgradingdetails SET Name = gcname , Percentage = percent , Score  =scores ,
				OverScore = over WHERE GDID = gdid;
end case;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `insert_schedule` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_schedule`(timestart VARCHAR(45),
															timeend VARCHAR(45),
                                                            stype varchar(45),
                                                            daysched VARCHAR(45),
															schedroom VARCHAR(45),
                                                            subjID bigint,
                                                            schedID bigint)
BEGIN
case

WHEN stype = "Insert" THEN INSERT INTO tblschedule( ScheduleTimeFrom, ScheduleTimeTo , ScheduleDay, ScheduleRoom, SubjectID)
								VALUES(timestart, timeend , daysched, schedroom , subjID);
WHEN stype = "Update" THEN UPDATE tblschedule SET ScheduleTimeFrom = timestart , ScheduleTimeTo = timeend ,
								ScheduleDay = daysched , ScheduleRoom = schedroom , 
								SubjectID = subjID  WHERE ScheduleID = schedID;

end case;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `insert_student` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_student`(studnum1 varchar(100),
															fname1 VARCHAR(100),
                                                            stype varchar(45),
                                                            lname1 VARCHAR(100),
                                                            section1 VARCHAR(45),
															status1 VARCHAR(45),
                                                            courseID1 bigint)
BEGIN
case

WHEN stype = "Insert" THEN INSERT INTO tblstudent(StudNum , FName ,LName, Section, Status, CourseID)
								VALUES(studnum1, fname1 , lname1, section1, status1, courseID1);
WHEN stype = "Update" THEN UPDATE tblstudent SET StudNum = studnum1 ,FName = fname1 ,LName = lname1 ,
								Section = section1 ,Status= status1 , CourseID = courseID1
							    WHERE StudNum = studnum1;

end case;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `insert_studentgrades` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_studentgrades`(stud VARCHAR(100),
                                                           subj bigint,
                                                           termid bigint,
                                                           graDetail bigint,
                                                           score double,
                                                           ctype VARCHAR(45))
BEGIN
case 
WHEN ctype = "Insert" THEN INSERT INTO tblstudentgrades(StudNum, SubjectID , TermID , GradingDetailsID , RawScore)
						VALUES(stud, subj, termid, graDetail , score);
WHEN ctype = "Update" THEN UPDATE tblstudentgrades SET StudNum= stud , TermID = termid , GradeDetails = graDetail , RawScore = score 
						WHERE SubjectID = subj;
end case;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `insert_studgrades` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_studgrades`(clID bigint,
															    gradper bigint,
                                                                graddet bigint,
                                                                raw_score double,
																stype VARCHAR(45),
                                                                studg bigint)
BEGIN

CASE 
WHEN stype = "Insert" THEN INSERT INTO tblstudentgrades(ClassID , GID , GradingDetailsID , RawScore)
						VALUES(clID , gradper , graddet , raw_score);
WHEN stype = "Update" THEN UPDATE tblstudentgrades SET ClassID = clID , GID = gradper , GradingDetailsID = graddet , 
						RawScore = raw_score WHERE StudentGradesID = studg;
end case;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `insert_subject` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_subject`(subjcode VARCHAR(45),
															subjname VARCHAR(100),
                                                            stype varchar(45),
                                                            units INT(11),
                                                            subjID bigint ,
                                                            userid bigint)
BEGIN
case

WHEN stype = "Insert" THEN INSERT INTO tblsubject(SubjectCode , SubjectName , SubjectUnits , UserID)
								VALUES(subjcode, subjname , units , userid);
WHEN stype = "Update" THEN UPDATE tblsubject SET SubjectCode = subjcode , SubjectName = subjname ,
								 SubjectUnits = units , UserID = userid WHERE SubjectID = subjID;

end case;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-11-09 17:37:07
