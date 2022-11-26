-- MySQL dump 10.13  Distrib 8.0.29, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: sedena
-- ------------------------------------------------------
-- Server version	8.0.29

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `datos_academicos_discente`
--

DROP TABLE IF EXISTS `datos_academicos_discente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `datos_academicos_discente` (
  `id` int NOT NULL AUTO_INCREMENT,
  `matricula_discente` varchar(20) NOT NULL,
  `analisis_vectorial` double DEFAULT NULL,
  `calculo` double DEFAULT NULL,
  `matematicas_discretas` double DEFAULT NULL,
  `algoritmia_y_programacion_estructurada` double DEFAULT NULL,
  `fisica` double DEFAULT NULL,
  `ingenieria_etica_sociedad` double DEFAULT NULL,
  `ecuaciones_diferenciales` double DEFAULT NULL,
  `algebra_lineal` double DEFAULT NULL,
  `calculo_aplicado` double DEFAULT NULL,
  `estructuras_de_datos` double DEFAULT NULL,
  `comunicacion_oral_y_escrita` double DEFAULT NULL,
  `analisis_fundamental_de_circuitos` double DEFAULT NULL,
  `matematicas_avanzadas_para_la_ingenieria` double DEFAULT NULL,
  `fundamentos_economicos` double DEFAULT NULL,
  `fundamentos_de_diseño_digital` double DEFAULT NULL,
  `teoria_computacional` double DEFAULT NULL,
  `bases_de_datos` double DEFAULT NULL,
  `programacion_orientada_a_objetos` double DEFAULT NULL,
  `electronica_analogica` double DEFAULT NULL,
  `redes_de_computadoras` double DEFAULT NULL,
  `diseno_de_sistemas_computacionales` double DEFAULT NULL,
  `probabilidad_y_estadistica` double DEFAULT NULL,
  `sistemas_operativos` double DEFAULT NULL,
  `analisis_y_diseno_orientado_objetos` double DEFAULT NULL,
  `tecnologias_para_la_web` double DEFAULT NULL,
  `administracion_financiera` double DEFAULT NULL,
  `optativa_A` double DEFAULT NULL,
  `arquitectura_de_computadoras` double DEFAULT NULL,
  `analisis_de_algoritmos` double DEFAULT NULL,
  `optativa_B` double DEFAULT NULL,
  `ingenieria_de_software` double DEFAULT NULL,
  `administracion_de_proyectos` double DEFAULT NULL,
  `instrumentacion` double DEFAULT NULL,
  `teoria_de_comunicaciones_y_senales` double DEFAULT NULL,
  `aplicaciones_para_comunicaciones_en_red` double DEFAULT NULL,
  `metodos_cuantitativos_para_la_toma_de_decisiones` double DEFAULT NULL,
  `introduccion_a_los_microcontroladores` double DEFAULT NULL,
  `compiladores` double DEFAULT NULL,
  `optativa_C` double DEFAULT NULL,
  `optativa_D` double DEFAULT NULL,
  `desarrollo_de_sistemas_distribuidos` double DEFAULT NULL,
  `administracion_de_servicios_en_red` double DEFAULT NULL,
  `gestion_empresarial` double DEFAULT NULL,
  `liderazgo` double DEFAULT NULL,
  `trabajo_terminal_I` double DEFAULT NULL,
  `electiva` double DEFAULT NULL,
  `trabajo_terminal_II` double DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id_UNIQUE` (`id`),
  UNIQUE KEY `matricula_discente_UNIQUE` (`matricula_discente`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-11-23 22:48:24
