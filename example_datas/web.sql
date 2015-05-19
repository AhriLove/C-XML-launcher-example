/*!40101 SET NAMES utf8 */;
/*!40101 SET SQL_MODE=''*/;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

/* Table structure for table `news` */
DROP TABLE IF EXISTS `news`;

CREATE TABLE `news` (
  `id` int(5) unsigned NOT NULL AUTO_INCREMENT,
  `title` varchar(300) NOT NULL DEFAULT '',
  `summary` varchar(600) NOT NULL DEFAULT '',
  `date` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;

/* Data for the table `news` */
LOCK TABLES `news` WRITE;

INSERT INTO `news` (`id`,`title`,`summary`,`date`) VALUES
(1, 'Nuevo launcher', 'Estrenamos nuevo launcher con un montón de novedades', '2015-05-19 14:41:32'),
(2, 'Publicado parche v1.0', 'El parche v1.0 ya esta disponible para descargar', '2015-05-19 14:41:56'),
(3, 'Actualizacion a v1.1', 'Hemos corregido varios errores de nuestro parche', '2015-05-19 14:42:02'),
(4, 'Llegan las GuildHouses', 'Ya estan disponibles las nuevas GuildHouses en nuestro servidor', '2015-05-19 14:44:10'),
(5, 'Mantenimiento programado', 'Estamos realizando un mantenimiento programado en nuestros servidores', '2015-05-19 14:44:33');

UNLOCK TABLES;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
