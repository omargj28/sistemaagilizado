CREATE DATABASE IF NOT EXISTS sistemaagilizado;
USE sistemaagilizado;

DROP TABLE IF EXISTS `pedidos`;
CREATE TABLE `pedidos` (
  `IDPedido` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(50) NOT NULL,
  `Fecha_reg` datetime DEFAULT NULL,
  `Fecha_entrega` datetime DEFAULT NULL,
  `Diseño` tinyint(1) NOT NULL,
  `Tarjetas` tinyint(1) NOT NULL,
  `Web` tinyint(1) NOT NULL,
  `Folletos` tinyint(1) NOT NULL,
  `Volantes` tinyint(1) NOT NULL,
  `Impresion` tinyint(1) NOT NULL,
  `IFolletos` tinyint(1) NOT NULL,
  `ITarjetas` tinyint(1) NOT NULL,
  `IVolantes` tinyint(1) NOT NULL,
  PRIMARY KEY (`IDPedido`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;