-- phpMyAdmin SQL Dump
-- version 4.5.4.1deb2ubuntu2
-- http://www.phpmyadmin.net
--
-- Client :  localhost
-- Généré le :  Lun 26 Mars 2018 à 09:46
-- Version du serveur :  5.7.21-0ubuntu0.16.04.1
-- Version de PHP :  7.0.25-0ubuntu0.16.04.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
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

CREATE TABLE `cours` (
  `ID_Cours` int(11) NOT NULL,
  `Libelle_Cours` varchar(250) NOT NULL,
  `Coefficient_Cours` int(11) NOT NULL,
  `Couleur_Cours` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `cours`
--

INSERT INTO `cours` (`ID_Cours`, `Libelle_Cours`, `Coefficient_Cours`, `Couleur_Cours`) VALUES
(2, 'C# B2', 5, '000000'),
(3, 'SQL B2', 2, '0000ff');

-- --------------------------------------------------------

--
-- Structure de la table `cours_membre`
--

CREATE TABLE `cours_membre` (
  `ID_Cours` int(11) NOT NULL,
  `ID_membre` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Doublure de structure pour la vue `Emploi`
--
CREATE TABLE `Emploi` (
`ID_Groupe` int(11)
,`Date_Seance` varchar(25)
,`Debut_Seance` tinyint(1)
,`Libelle_Cours` varchar(250)
,`Couleur_Cours` varchar(25)
);

-- --------------------------------------------------------

--
-- Structure de la table `emploiedutemps`
--

CREATE TABLE `emploiedutemps` (
  `ID_EDT` int(11) NOT NULL,
  `Libelle` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `emploiedutemps_seance`
--

CREATE TABLE `emploiedutemps_seance` (
  `ID_Seance` int(11) NOT NULL,
  `ID_EDT` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `groupe`
--

CREATE TABLE `groupe` (
  `ID_Groupe` int(11) NOT NULL,
  `Libelle_Groupe` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `groupe`
--

INSERT INTO `groupe` (`ID_Groupe`, `Libelle_Groupe`) VALUES
(1, 'Professeurs'),
(2, 'Formation21C'),
(3, 'Formation21A');

-- --------------------------------------------------------

--
-- Structure de la table `groupe_seance`
--

CREATE TABLE `groupe_seance` (
  `ID_Seance` int(11) NOT NULL,
  `ID_Groupe` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `groupe_seance`
--

INSERT INTO `groupe_seance` (`ID_Seance`, `ID_Groupe`) VALUES
(1, 2);

-- --------------------------------------------------------

--
-- Structure de la table `membre`
--

CREATE TABLE `membre` (
  `ID_membre` int(11) NOT NULL,
  `Role_Membre` int(11) NOT NULL,
  `User_Membre` varchar(25) NOT NULL,
  `MotdePasse_Membre` varchar(255) NOT NULL,
  `Salt_Membre` varchar(25) NOT NULL,
  `Prenom_Membre` varchar(25) NOT NULL,
  `Nom_Membre` varchar(25) NOT NULL,
  `PremiereCo_Membre` tinyint(1) NOT NULL DEFAULT '0',
  `ID_Groupe` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `membre`
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

CREATE TABLE `note` (
  `ID_Note` int(11) NOT NULL,
  `Note` float NOT NULL,
  `Libelle_Note` varchar(250) NOT NULL,
  `ID_membre` int(11) NOT NULL,
  `ID_Cours` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `note`
--

INSERT INTO `note` (`ID_Note`, `Note`, `Libelle_Note`, `ID_membre`, `ID_Cours`) VALUES
(1, 12, 'TP', 7, 3),
(2, 17, 'TP', 10, 3);

-- --------------------------------------------------------

--
-- Structure de la table `seance`
--

CREATE TABLE `seance` (
  `ID_Seance` int(11) NOT NULL,
  `Date_Seance` varchar(25) NOT NULL,
  `Debut_Seance` tinyint(1) NOT NULL,
  `Note_Seance` varchar(250) DEFAULT NULL,
  `NotePersonnel_Seance` varchar(250) DEFAULT NULL,
  `ID_Cours` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `seance`
--

INSERT INTO `seance` (`ID_Seance`, `Date_Seance`, `Debut_Seance`, `Note_Seance`, `NotePersonnel_Seance`, `ID_Cours`) VALUES
(1, '22/03/2018', 1, '', '', 2);

-- --------------------------------------------------------

--
-- Structure de la table `travauxpratique`
--

CREATE TABLE `travauxpratique` (
  `ID_TP` int(11) NOT NULL,
  `Libelle_TP` varchar(250) NOT NULL,
  `Date_TP` date NOT NULL,
  `ID_Cours` int(11) NOT NULL,
  `ID_Groupe` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la vue `Emploi`
--
DROP TABLE IF EXISTS `Emploi`;

CREATE ALGORITHM=UNDEFINED DEFINER=`application`@`%` SQL SECURITY DEFINER VIEW `Emploi`  AS  select `groupe_seance`.`ID_Groupe` AS `ID_Groupe`,`seance`.`Date_Seance` AS `Date_Seance`,`seance`.`Debut_Seance` AS `Debut_Seance`,`cours`.`Libelle_Cours` AS `Libelle_Cours`,`cours`.`Couleur_Cours` AS `Couleur_Cours` from (((`groupe_seance` join `groupe` on((`groupe_seance`.`ID_Groupe` = `groupe`.`ID_Groupe`))) join `seance` on((`groupe_seance`.`ID_Seance` = `seance`.`ID_Seance`))) join `cours` on((`seance`.`ID_Cours` = `cours`.`ID_Cours`))) ;

--
-- Index pour les tables exportées
--

--
-- Index pour la table `cours`
--
ALTER TABLE `cours`
  ADD PRIMARY KEY (`ID_Cours`);

--
-- Index pour la table `cours_membre`
--
ALTER TABLE `cours_membre`
  ADD PRIMARY KEY (`ID_Cours`,`ID_membre`),
  ADD KEY `FK_Cours_Membre_ID_membre` (`ID_membre`);

--
-- Index pour la table `emploiedutemps`
--
ALTER TABLE `emploiedutemps`
  ADD PRIMARY KEY (`ID_EDT`);

--
-- Index pour la table `emploiedutemps_seance`
--
ALTER TABLE `emploiedutemps_seance`
  ADD PRIMARY KEY (`ID_Seance`,`ID_EDT`),
  ADD KEY `FK_EmploieDuTemps_Seance_ID_EDT` (`ID_EDT`);

--
-- Index pour la table `groupe`
--
ALTER TABLE `groupe`
  ADD PRIMARY KEY (`ID_Groupe`);

--
-- Index pour la table `groupe_seance`
--
ALTER TABLE `groupe_seance`
  ADD PRIMARY KEY (`ID_Seance`,`ID_Groupe`),
  ADD KEY `FK_Groupe_Seance_ID_Groupe` (`ID_Groupe`);

--
-- Index pour la table `membre`
--
ALTER TABLE `membre`
  ADD PRIMARY KEY (`ID_membre`),
  ADD KEY `FK_Membre_ID_Groupe` (`ID_Groupe`);

--
-- Index pour la table `note`
--
ALTER TABLE `note`
  ADD PRIMARY KEY (`ID_Note`),
  ADD KEY `FK_Note_ID_membre` (`ID_membre`),
  ADD KEY `FK_Note_ID_Cours` (`ID_Cours`);

--
-- Index pour la table `seance`
--
ALTER TABLE `seance`
  ADD PRIMARY KEY (`ID_Seance`),
  ADD KEY `FK_Seance_ID_Cours` (`ID_Cours`);

--
-- Index pour la table `travauxpratique`
--
ALTER TABLE `travauxpratique`
  ADD PRIMARY KEY (`ID_TP`),
  ADD KEY `FK_TravauxPratique_ID_Cours` (`ID_Cours`),
  ADD KEY `FK_TravauxPratique_ID_Groupe` (`ID_Groupe`);

--
-- AUTO_INCREMENT pour les tables exportées
--

--
-- AUTO_INCREMENT pour la table `cours`
--
ALTER TABLE `cours`
  MODIFY `ID_Cours` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT pour la table `emploiedutemps`
--
ALTER TABLE `emploiedutemps`
  MODIFY `ID_EDT` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT pour la table `groupe`
--
ALTER TABLE `groupe`
  MODIFY `ID_Groupe` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT pour la table `membre`
--
ALTER TABLE `membre`
  MODIFY `ID_membre` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;
--
-- AUTO_INCREMENT pour la table `note`
--
ALTER TABLE `note`
  MODIFY `ID_Note` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT pour la table `seance`
--
ALTER TABLE `seance`
  MODIFY `ID_Seance` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT pour la table `travauxpratique`
--
ALTER TABLE `travauxpratique`
  MODIFY `ID_TP` int(11) NOT NULL AUTO_INCREMENT;
--
-- Contraintes pour les tables exportées
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

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
