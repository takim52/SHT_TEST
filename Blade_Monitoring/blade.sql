-- --------------------------------------------------------
-- 호스트:                          127.0.0.1
-- 서버 버전:                        10.4.12-MariaDB - mariadb.org binary distribution
-- 서버 OS:                        Win64
-- HeidiSQL 버전:                  10.2.0.5599
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- blade_db 데이터베이스 구조 내보내기
CREATE DATABASE IF NOT EXISTS `blade_db` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `blade_db`;

-- 테이블 blade_db.blade_table 구조 내보내기
CREATE TABLE IF NOT EXISTS `blade_table` (
  `time` datetime NOT NULL DEFAULT current_timestamp(),
  `barcode` varchar(20) NOT NULL,
  `P1` double DEFAULT NULL,
  `P2` double DEFAULT NULL,
  `P3` double DEFAULT NULL,
  `P4` double DEFAULT NULL,
  `DAN` varchar(20) DEFAULT NULL,
  `WIDTH1` double DEFAULT NULL,
  `WIDTH2` double NOT NULL,
  `P1_NOK` varchar(20) NOT NULL,
  `P2_NOK` varchar(20) NOT NULL,
  `P3_NOK` varchar(20) NOT NULL,
  `P4_NOK` varchar(20) NOT NULL,
  `WIDTH1_NOK` varchar(20) NOT NULL,
  `WIDTH2_NOK` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- 내보낼 데이터가 선택되어 있지 않습니다.

-- 테이블 blade_db.blocking_table 구조 내보내기
CREATE TABLE IF NOT EXISTS `blocking_table` (
  `Filtered_barcode` varchar(20) NOT NULL,
  `Registration_Date` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- 내보낼 데이터가 선택되어 있지 않습니다.

-- 테이블 blade_db.img_table 구조 내보내기
CREATE TABLE IF NOT EXISTS `img_table` (
  `NOK` varchar(5) DEFAULT NULL,
  `barcode` varchar(20) NOT NULL,
  `time` datetime(3) NOT NULL DEFAULT current_timestamp(3),
  `LOCATE_GRID` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- 내보낼 데이터가 선택되어 있지 않습니다.

-- 테이블 blade_db.nglist_table 구조 내보내기
CREATE TABLE IF NOT EXISTS `nglist_table` (
  `barcode` varchar(20) DEFAULT NULL,
  `NG_COUNT` int(11) DEFAULT NULL,
  `last_time` datetime(3) DEFAULT current_timestamp(3)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- 내보낼 데이터가 선택되어 있지 않습니다.

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
