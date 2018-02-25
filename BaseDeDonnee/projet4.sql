-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le :  Dim 25 fév. 2018 à 15:22
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
-- Base de données :  `projet4`
--

-- --------------------------------------------------------

--
-- Structure de la table `cours`
--

DROP TABLE IF EXISTS `cours`;
CREATE TABLE IF NOT EXISTS `cours` (
  `ID_Cours` int(11) NOT NULL AUTO_INCREMENT,
  `Libelle_Cours` varchar(25) NOT NULL,
  `Coefficient` int(11) NOT NULL,
  PRIMARY KEY (`ID_Cours`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

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
  `Libelle_Groupe` varchar(25) NOT NULL,
  PRIMARY KEY (`ID_Groupe`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `groupe`
--

INSERT INTO `groupe` (`ID_Groupe`, `Libelle_Groupe`) VALUES
(2, 'Professeurs'),
(3, 'B221');

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
  `ID_Groupe` int(11) NOT NULL,
  PRIMARY KEY (`ID_membre`),
  KEY `FK_Membre_ID_Groupe` (`ID_Groupe`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `membre`
--

INSERT INTO `membre` (`ID_membre`, `Role_Membre`, `User_Membre`, `MotdePasse_Membre`, `Salt_Membre`, `Prenom_Membre`, `Nom_Membre`, `ID_Groupe`) VALUES
(1, 5, 'c.gengoo', '81dc9bdb52d04dc20036dbd8313ed055', '1o67vw==', 'Christopher', 'Gengoo', 3);

-- --------------------------------------------------------

--
-- Structure de la table `note`
--

DROP TABLE IF EXISTS `note`;
CREATE TABLE IF NOT EXISTS `note` (
  `ID_Note` int(11) NOT NULL AUTO_INCREMENT,
  `Note` int(11) NOT NULL,
  `Libelle_Note` varchar(25) NOT NULL,
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
  `Date_Seance` date NOT NULL,
  `Debut_Seance` tinyint(1) NOT NULL,
  `Note_Seance` varchar(25) DEFAULT NULL,
  `NotePersonnel_Seance` varchar(25) DEFAULT NULL,
  `ID_Cours` int(11) NOT NULL,
  PRIMARY KEY (`ID_Seance`),
  KEY `FK_Seance_ID_Cours` (`ID_Cours`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `travauxpratique`
--

DROP TABLE IF EXISTS `travauxpratique`;
CREATE TABLE IF NOT EXISTS `travauxpratique` (
  `ID_TP` int(11) NOT NULL AUTO_INCREMENT,
  `Libelle` varchar(25) DEFAULT NULL,
  `Date_TP` date NOT NULL,
  `ID_Cours` int(11) NOT NULL,
  PRIMARY KEY (`ID_TP`),
  KEY `FK_TravauxPratique_ID_Cours` (`ID_Cours`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `cours_membre`
--
ALTER TABLE `cours_membre`
  ADD CONSTRAINT `FK_Cours_Membre_ID_Cours` FOREIGN KEY (`ID_Cours`) REFERENCES `cours` (`ID_Cours`),
  ADD CONSTRAINT `FK_Cours_Membre_ID_membre` FOREIGN KEY (`ID_membre`) REFERENCES `membre` (`ID_membre`);

--
-- Contraintes pour la table `emploiedutemps_seance`
--
ALTER TABLE `emploiedutemps_seance`
  ADD CONSTRAINT `FK_EmploieDuTemps_Seance_ID_EDT` FOREIGN KEY (`ID_EDT`) REFERENCES `emploiedutemps` (`ID_EDT`),
  ADD CONSTRAINT `FK_EmploieDuTemps_Seance_ID_Seance` FOREIGN KEY (`ID_Seance`) REFERENCES `seance` (`ID_Seance`);

--
-- Contraintes pour la table `groupe_seance`
--
ALTER TABLE `groupe_seance`
  ADD CONSTRAINT `FK_Groupe_Seance_ID_Groupe` FOREIGN KEY (`ID_Groupe`) REFERENCES `groupe` (`ID_Groupe`),
  ADD CONSTRAINT `FK_Groupe_Seance_ID_Seance` FOREIGN KEY (`ID_Seance`) REFERENCES `seance` (`ID_Seance`);

--
-- Contraintes pour la table `membre`
--
ALTER TABLE `membre`
  ADD CONSTRAINT `FK_Membre_ID_Groupe` FOREIGN KEY (`ID_Groupe`) REFERENCES `groupe` (`ID_Groupe`);

--
-- Contraintes pour la table `note`
--
ALTER TABLE `note`
  ADD CONSTRAINT `FK_Note_ID_Cours` FOREIGN KEY (`ID_Cours`) REFERENCES `cours` (`ID_Cours`),
  ADD CONSTRAINT `FK_Note_ID_membre` FOREIGN KEY (`ID_membre`) REFERENCES `membre` (`ID_membre`);

--
-- Contraintes pour la table `seance`
--
ALTER TABLE `seance`
  ADD CONSTRAINT `FK_Seance_ID_Cours` FOREIGN KEY (`ID_Cours`) REFERENCES `cours` (`ID_Cours`);

--
-- Contraintes pour la table `travauxpratique`
--
ALTER TABLE `travauxpratique`
  ADD CONSTRAINT `FK_TravauxPratique_ID_Cours` FOREIGN KEY (`ID_Cours`) REFERENCES `cours` (`ID_Cours`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
