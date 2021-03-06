-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le :  lun. 26 mars 2018 à 11:18
-- Version du serveur :  5.7.19
-- Version de PHP :  5.6.31

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `extranet`
--

-- --------------------------------------------------------

--
-- Structure de la table `cours`
--

DROP TABLE IF EXISTS `cours`;
CREATE TABLE IF NOT EXISTS `cours` (
  `ID_Cours` int(11) NOT NULL AUTO_INCREMENT,
  `Libelle_Cours` varchar(250) NOT NULL,
  `Coefficient_Cours` int(11) NOT NULL,
  `Couleur_Cours` int(25) NOT NULL,
  PRIMARY KEY (`ID_Cours`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `cours`
--

INSERT INTO `cours` (`ID_Cours`, `Libelle_Cours`, `Coefficient_Cours`, `Couleur_Cours`) VALUES
(1, 'C#', 5, -16776961);

-- --------------------------------------------------------

--
-- Structure de la table `cours_membre`
--

DROP TABLE IF EXISTS `cours_membre`;
CREATE TABLE IF NOT EXISTS `cours_membre` (
  `ID_Cours` int(11) NOT NULL,
  `ID_membre` int(11) NOT NULL,
  PRIMARY KEY (`ID_Cours`,`ID_membre`),
  KEY `FK_Cours_Membre_ID_membre` (`ID_membre`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Doublure de structure pour la vue `emploi`
-- (Voir ci-dessous la vue réelle)
--
DROP VIEW IF EXISTS `emploi`;
CREATE TABLE IF NOT EXISTS `emploi` (
`ID_Groupe` int(11)
,`Date_Seance` varchar(25)
,`Debut_Seance` tinyint(1)
,`Libelle_Cours` varchar(250)
,`Couleur_Cours` int(25)
);

-- --------------------------------------------------------

--
-- Structure de la table `emploiedutemps`
--

DROP TABLE IF EXISTS `emploiedutemps`;
CREATE TABLE IF NOT EXISTS `emploiedutemps` (
  `ID_EDT` int(11) NOT NULL AUTO_INCREMENT,
  `Libelle` varchar(25) NOT NULL,
  PRIMARY KEY (`ID_EDT`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `emploiedutemps_seance`
--

DROP TABLE IF EXISTS `emploiedutemps_seance`;
CREATE TABLE IF NOT EXISTS `emploiedutemps_seance` (
  `ID_Seance` int(11) NOT NULL,
  `ID_EDT` int(11) NOT NULL,
  PRIMARY KEY (`ID_Seance`,`ID_EDT`),
  KEY `FK_EmploieDuTemps_Seance_ID_EDT` (`ID_EDT`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `groupe`
--

DROP TABLE IF EXISTS `groupe`;
CREATE TABLE IF NOT EXISTS `groupe` (
  `ID_Groupe` int(11) NOT NULL AUTO_INCREMENT,
  `Libelle_Groupe` varchar(250) NOT NULL,
  PRIMARY KEY (`ID_Groupe`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `groupe`
--

INSERT INTO `groupe` (`ID_Groupe`, `Libelle_Groupe`) VALUES
(1, 'Professeurs'),
(2, 'Formation21C'),
(3, 'Formation21A');

-- --------------------------------------------------------

--
-- Structure de la table `groupe_seance`
--

DROP TABLE IF EXISTS `groupe_seance`;
CREATE TABLE IF NOT EXISTS `groupe_seance` (
  `ID_Seance` int(11) NOT NULL,
  `ID_Groupe` int(11) NOT NULL,
  PRIMARY KEY (`ID_Seance`,`ID_Groupe`),
  KEY `FK_Groupe_Seance_ID_Groupe` (`ID_Groupe`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `groupe_seance`
--

INSERT INTO `groupe_seance` (`ID_Seance`, `ID_Groupe`) VALUES
(1, 2);

-- --------------------------------------------------------

--
-- Structure de la table `membre`
--

DROP TABLE IF EXISTS `membre`;
CREATE TABLE IF NOT EXISTS `membre` (
  `ID_membre` int(11) NOT NULL AUTO_INCREMENT,
  `Role_Membre` int(11) NOT NULL,
  `User_Membre` varchar(25) NOT NULL,
  `MotdePasse_Membre` varchar(255) NOT NULL,
  `Salt_Membre` varchar(25) NOT NULL,
  `Prenom_Membre` varchar(25) NOT NULL,
  `Nom_Membre` varchar(25) NOT NULL,
  `PremiereCo_Membre` tinyint(1) NOT NULL DEFAULT '0',
  `ID_Groupe` int(11) NOT NULL,
  PRIMARY KEY (`ID_membre`),
  KEY `FK_Membre_ID_Groupe` (`ID_Groupe`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `membre`
--

INSERT INTO `membre` (`ID_membre`, `Role_Membre`, `User_Membre`, `MotdePasse_Membre`, `Salt_Membre`, `Prenom_Membre`, `Nom_Membre`, `PremiereCo_Membre`, `ID_Groupe`) VALUES
(2, 4, 'user2', 'f133d09e1ab9ac0bca7f48432314317f', 'NM16DQ==', 'Jean', 'Bonbeur', 1, 2),
(7, 4, 'cgengoo', '2dd939790934c0a9c5666e6812a7b4c4', 'wpBcpA==', 'Christopher', 'Gengoo', 1, 2),
(9, 5, 'srobbe', 'c4a27dad5b71986c63d9cb25c279ff24', 'hqdj+w==', 'Stephane', 'Robbe', 0, 1),
(10, 4, 'mjacob', 'b64ecd6691e25eabfc2655af357aca7d', 'tSdZEg==', 'Marine', 'Jacob', 0, 2),
(11, 1, 'acampos', 'e4e93f2bd100898440326cda26afd0ea', 'cVvBzw==', 'Alex', 'Campos', 0, 2),
(12, 2, 'ecabret', '2b738f22b45285382ef6111a5058d4fe', 'Y2M/MQ==', 'Eric', 'Cabret', 0, 1);

-- --------------------------------------------------------

--
-- Structure de la table `note`
--

DROP TABLE IF EXISTS `note`;
CREATE TABLE IF NOT EXISTS `note` (
  `ID_Note` int(11) NOT NULL AUTO_INCREMENT,
  `Note` int(11) NOT NULL,
  `Libelle_Note` varchar(250) NOT NULL,
  `ID_membre` int(11) NOT NULL,
  `ID_Cours` int(11) NOT NULL,
  PRIMARY KEY (`ID_Note`),
  KEY `FK_Note_ID_membre` (`ID_membre`),
  KEY `FK_Note_ID_Cours` (`ID_Cours`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `seance`
--

DROP TABLE IF EXISTS `seance`;
CREATE TABLE IF NOT EXISTS `seance` (
  `ID_Seance` int(11) NOT NULL AUTO_INCREMENT,
  `Date_Seance` varchar(25) NOT NULL,
  `Debut_Seance` tinyint(1) NOT NULL,
  `Note_Seance` varchar(250) DEFAULT NULL,
  `NotePersonnel_Seance` varchar(250) DEFAULT NULL,
  `ID_Cours` int(11) NOT NULL,
  PRIMARY KEY (`ID_Seance`),
  KEY `FK_Seance_ID_Cours` (`ID_Cours`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `seance`
--

INSERT INTO `seance` (`ID_Seance`, `Date_Seance`, `Debut_Seance`, `Note_Seance`, `NotePersonnel_Seance`, `ID_Cours`) VALUES
(1, '26/03/2018', 1, '', '', 1);

-- --------------------------------------------------------

--
-- Structure de la table `travauxpratique`
--

DROP TABLE IF EXISTS `travauxpratique`;
CREATE TABLE IF NOT EXISTS `travauxpratique` (
  `ID_TP` int(11) NOT NULL AUTO_INCREMENT,
  `Libelle_TP` varchar(250) NOT NULL,
  `Date_TP` date NOT NULL,
  `ID_Cours` int(11) NOT NULL,
  `ID_Groupe` int(11) NOT NULL,
  PRIMARY KEY (`ID_TP`),
  KEY `FK_TravauxPratique_ID_Cours` (`ID_Cours`),
  KEY `FK_TravauxPratique_ID_Groupe` (`ID_Groupe`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la vue `emploi`
--
DROP TABLE IF EXISTS `emploi`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `emploi`  AS  select `groupe_seance`.`ID_Groupe` AS `ID_Groupe`,`seance`.`Date_Seance` AS `Date_Seance`,`seance`.`Debut_Seance` AS `Debut_Seance`,`cours`.`Libelle_Cours` AS `Libelle_Cours`,`cours`.`Couleur_Cours` AS `Couleur_Cours` from (((`groupe_seance` join `groupe` on((`groupe_seance`.`ID_Groupe` = `groupe`.`ID_Groupe`))) join `seance` on((`groupe_seance`.`ID_Seance` = `seance`.`ID_Seance`))) join `cours` on((`seance`.`ID_Cours` = `cours`.`ID_Cours`))) ;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `cours_membre`
--
ALTER TABLE `cours_membre`
  ADD CONSTRAINT `FK_Cours_Membre_ID_Cours` FOREIGN KEY (`ID_Cours`) REFERENCES `cours` (`ID_Cours`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_Cours_Membre_ID_membre` FOREIGN KEY (`ID_membre`) REFERENCES `membre` (`ID_membre`) ON DELETE CASCADE;

--
-- Contraintes pour la table `emploiedutemps_seance`
--
ALTER TABLE `emploiedutemps_seance`
  ADD CONSTRAINT `FK_EmploieDuTemps_Seance_ID_EDT` FOREIGN KEY (`ID_EDT`) REFERENCES `emploiedutemps` (`ID_EDT`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_EmploieDuTemps_Seance_ID_Seance` FOREIGN KEY (`ID_Seance`) REFERENCES `seance` (`ID_Seance`) ON DELETE CASCADE;

--
-- Contraintes pour la table `groupe_seance`
--
ALTER TABLE `groupe_seance`
  ADD CONSTRAINT `FK_Groupe_Seance_ID_Groupe` FOREIGN KEY (`ID_Groupe`) REFERENCES `groupe` (`ID_Groupe`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_Groupe_Seance_ID_Seance` FOREIGN KEY (`ID_Seance`) REFERENCES `seance` (`ID_Seance`) ON DELETE CASCADE;

--
-- Contraintes pour la table `membre`
--
ALTER TABLE `membre`
  ADD CONSTRAINT `FK_Membre_ID_Groupe` FOREIGN KEY (`ID_Groupe`) REFERENCES `groupe` (`ID_Groupe`) ON DELETE CASCADE;

--
-- Contraintes pour la table `note`
--
ALTER TABLE `note`
  ADD CONSTRAINT `FK_Note_ID_Cours` FOREIGN KEY (`ID_Cours`) REFERENCES `cours` (`ID_Cours`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_Note_ID_membre` FOREIGN KEY (`ID_membre`) REFERENCES `membre` (`ID_membre`) ON DELETE CASCADE;

--
-- Contraintes pour la table `seance`
--
ALTER TABLE `seance`
  ADD CONSTRAINT `FK_Seance_ID_Cours` FOREIGN KEY (`ID_Cours`) REFERENCES `cours` (`ID_Cours`) ON DELETE CASCADE;

--
-- Contraintes pour la table `travauxpratique`
--
ALTER TABLE `travauxpratique`
  ADD CONSTRAINT `FK_TravauxPratique_ID_Cours` FOREIGN KEY (`ID_Cours`) REFERENCES `cours` (`ID_Cours`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_TravauxPratique_ID_Groupe` FOREIGN KEY (`ID_Groupe`) REFERENCES `groupe` (`ID_Groupe`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
