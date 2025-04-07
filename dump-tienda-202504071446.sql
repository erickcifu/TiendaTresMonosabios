-- MySQL dump 10.13  Distrib 8.0.19, for Win64 (x86_64)
--
-- Host: localhost    Database: tienda
-- ------------------------------------------------------
-- Server version	5.5.5-10.4.32-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `ciudades`
--

DROP TABLE IF EXISTS `ciudades`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ciudades` (
  `IdCiudad` int(11) NOT NULL AUTO_INCREMENT,
  `NombreCiudad` varchar(60) NOT NULL,
  `Pais` varchar(60) NOT NULL,
  `Region` varchar(60) NOT NULL,
  PRIMARY KEY (`IdCiudad`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ciudades`
--

LOCK TABLES `ciudades` WRITE;
/*!40000 ALTER TABLE `ciudades` DISABLE KEYS */;
INSERT INTO `ciudades` VALUES (1,'Acatenango','Guatemala','Chimaltenango Department'),(2,'Acatenango','Guatemala','Chimaltenango Department'),(3,'Acul','Guatemala','Quiché Department'),(4,'Almolonga','Guatemala','Quetzaltenango Department');
/*!40000 ALTER TABLE `ciudades` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `clienteproducto`
--

DROP TABLE IF EXISTS `clienteproducto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `clienteproducto` (
  `IdClienteProducto` int(11) NOT NULL AUTO_INCREMENT,
  `Idproducto` int(11) DEFAULT NULL,
  `IdCliente` int(11) DEFAULT NULL,
  PRIMARY KEY (`IdClienteProducto`),
  KEY `Idproducto` (`Idproducto`),
  KEY `IdCliente` (`IdCliente`),
  CONSTRAINT `clienteproducto_ibfk_1` FOREIGN KEY (`Idproducto`) REFERENCES `productos` (`Idproducto`),
  CONSTRAINT `clienteproducto_ibfk_2` FOREIGN KEY (`IdCliente`) REFERENCES `clientes` (`IdCliente`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clienteproducto`
--

LOCK TABLES `clienteproducto` WRITE;
/*!40000 ALTER TABLE `clienteproducto` DISABLE KEYS */;
INSERT INTO `clienteproducto` VALUES (1,3,2),(2,4,3),(3,3,3),(4,4,5);
/*!40000 ALTER TABLE `clienteproducto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `clientes`
--

DROP TABLE IF EXISTS `clientes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `clientes` (
  `IdCliente` int(11) NOT NULL AUTO_INCREMENT,
  `NombreCliente` varchar(150) NOT NULL,
  `Nit` int(11) DEFAULT NULL,
  `DPI` int(11) DEFAULT NULL,
  `Direccion` varchar(200) DEFAULT NULL,
  `Telefono` int(11) DEFAULT NULL,
  `FechaNacimiento` date DEFAULT NULL,
  `IdCiudad` int(11) DEFAULT NULL,
  PRIMARY KEY (`IdCliente`),
  KEY `IdCiudad` (`IdCiudad`),
  CONSTRAINT `clientes_ibfk_1` FOREIGN KEY (`IdCiudad`) REFERENCES `ciudades` (`IdCiudad`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clientes`
--

LOCK TABLES `clientes` WRITE;
/*!40000 ALTER TABLE `clientes` DISABLE KEYS */;
INSERT INTO `clientes` VALUES (2,'cliente dos',12345678,1234567891,'direccion cliente dos',12345678,'1989-03-02',3),(3,'cliente tres',123456789,1234567891,'direccion cliente tres',12345678,'1999-03-03',3),(5,'cliente tres',12345678,123456789,'cliente tres direccion',12345678,'2000-04-11',2);
/*!40000 ALTER TABLE `clientes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `productos`
--

DROP TABLE IF EXISTS `productos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `productos` (
  `Idproducto` int(11) NOT NULL AUTO_INCREMENT,
  `Descripcion` varchar(20) DEFAULT NULL,
  `Precio` int(11) DEFAULT NULL,
  `Categoria` varchar(200) DEFAULT NULL,
  `Cantidad` int(11) DEFAULT NULL,
  `nombreProducto` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Idproducto`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `productos`
--

LOCK TABLES `productos` WRITE;
/*!40000 ALTER TABLE `productos` DISABLE KEYS */;
INSERT INTO `productos` VALUES (3,'Camaras de seguridad',600,'Camaras',12,'Camara de seguridad'),(4,'Seguridad',21,'Seguridad',50,'Candados');
/*!40000 ALTER TABLE `productos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuarios` (
  `IdUsuario` int(11) NOT NULL AUTO_INCREMENT,
  `Usuario` varchar(50) NOT NULL,
  `Contrasenia` varchar(255) NOT NULL,
  PRIMARY KEY (`IdUsuario`),
  UNIQUE KEY `Usuario` (`Usuario`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarios`
--

LOCK TABLES `usuarios` WRITE;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios` VALUES (1,'admin','1234');
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'tienda'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-04-07 14:46:54
