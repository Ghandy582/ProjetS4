-- phpMyAdmin SQL Dump
-- version 4.6.4
-- https://www.phpmyadmin.net/
--
-- Client :  127.0.0.1
-- Généré le :  Lun 16 Avril 2018 à 11:52
-- Version du serveur :  5.7.14
-- Version de PHP :  7.0.10

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
  `Couleur_Cours` int(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `cours`
--

INSERT INTO `cours` (`ID_Cours`, `Libelle_Cours`, `Coefficient_Cours`, `Couleur_Cours`) VALUES
(1, 'C#', 5, -16776961),
(2, 'sql', 4, -16744448),
(3, 'Communication écrite', 1, -128),
(4, 'Windev', 3, -1846812),
(5, 'XML', 3, -9805),
(6, 'WEB', 3, -2753281),
(7, 'Linux Client', 2, -922398),
(8, 'Linux Serveur', 4, -10795);

-- --------------------------------------------------------

--
-- Structure de la table `cours_membre`
--

CREATE TABLE `cours_membre` (
  `ID_Cours` int(11) NOT NULL,
  `ID_membre` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `cours_membre`
--

INSERT INTO `cours_membre` (`ID_Cours`, `ID_membre`) VALUES
(5, 9),
(6, 9),
(7, 9),
(8, 9),
(1, 14),
(4, 15),
(3, 16),
(2, 17);

-- --------------------------------------------------------

--
-- Doublure de structure pour la vue `emploi`
-- (Voir ci-dessous la vue réelle)
--
CREATE TABLE `emploi` (
`ID_Groupe` int(11)
,`ID_Seance` int(11)
,`Date_Seance` varchar(25)
,`Debut_Seance` tinyint(1)
,`Note_Seance` varchar(250)
,`Libelle_Cours` varchar(250)
,`Prenom` varchar(25)
,`Nom` varchar(25)
,`Couleur_Cours` int(25)
);

-- --------------------------------------------------------

--
-- Doublure de structure pour la vue `emploi2`
-- (Voir ci-dessous la vue réelle)
--
CREATE TABLE `emploi2` (
`Libelle_Groupe` varchar(250)
,`ID_Seance` int(11)
,`Date_Seance` varchar(25)
,`Debut_Seance` tinyint(1)
,`NotePersonnel_Seance` varchar(250)
,`Note_Seance` varchar(250)
,`ID_membre` int(11)
,`Libelle_Cours` varchar(250)
,`Couleur_Cours` int(25)
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
(3, 'Formation21A'),
(4, 'Formation22C'),
(5, 'Formation20C'),
(6, 'Formation20A');

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
(1, 2),
(2, 2),
(4, 2),
(6, 2),
(7, 2),
(8, 2),
(11, 2),
(12, 2),
(13, 2),
(14, 2),
(16, 2),
(19, 2),
(20, 2),
(21, 2),
(22, 2),
(23, 2),
(3, 3),
(5, 3),
(9, 3),
(10, 3),
(17, 3),
(15, 4),
(18, 4);

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
(9, 5, 'srobbe', 'c4a27dad5b71986c63d9cb25c279ff24', 'hqdj+w==', 'Stephane', 'Robbe', 1, 1),
(10, 4, 'mjacob', 'b64ecd6691e25eabfc2655af357aca7d', 'tSdZEg==', 'Marine', 'Jacob', 1, 2),
(11, 1, 'acampos', 'e4e93f2bd100898440326cda26afd0ea', 'cVvBzw==', 'Alex', 'Campos', 1, 2),
(12, 2, 'ecabret', '2b738f22b45285382ef6111a5058d4fe', 'Y2M/MQ==', 'Eric', 'Cabret', 1, 1),
(13, 1, 'eleve', '95e744e888183d93d6bc32f964b4b216', 'dqrrnw==', 'Prénom', 'Nom', 1, 3),
(14, 5, 'fdroullion', 'b9b6ada3a280d45627ac96bd8ae55cec', 'mxY8og==', 'Frédéric', 'Drouillon', 0, 1),
(15, 2, 'taurousseau', 'c24d55b11ffd9c944bbb7be432644e01', '7rocmA==', 'Thierry', 'Aurousseau', 1, 1),
(16, 2, 'fherve', 'bbccc1abc2e4a355e26923322dab51a3', 's/ZoBA==', 'Françoise', 'Hervé-Manche', 0, 1),
(17, 2, 'tthomas', '400d9ffa9d87e867f883dc02b52d20c4', 'bjiRFg==', 'Teddy', 'Thomas', 1, 1);

-- --------------------------------------------------------

--
-- Structure de la table `note`
--

CREATE TABLE `note` (
  `ID_Note` int(11) NOT NULL,
  `Note` int(11) NOT NULL,
  `Libelle_Note` varchar(250) NOT NULL,
  `ID_membre` int(11) NOT NULL,
  `ID_Cours` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `note`
--

INSERT INTO `note` (`ID_Note`, `Note`, `Libelle_Note`, `ID_membre`, `ID_Cours`) VALUES
(1, 15, 'tp 1', 10, 1),
(2, 17, 'tp 1', 10, 2),
(3, 12, 'serveur ', 10, 4),
(4, 13, 'serveur 2', 10, 4),
(5, 18, 'xml schémas', 10, 5),
(6, 5, 'cv', 10, 3);

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
(1, '26/03/2018', 1, '', 'ma note personnelle', 1),
(2, '26/03/2018', 0, '', '', 2),
(3, '26/03/2018', 1, '', '', 2),
(4, '27/03/2018', 1, '', '', 3),
(5, '27/03/2018', 0, '', '', 4),
(6, '28/03/2018', 0, '', '', 4),
(7, '29/03/2018', 0, '', '', 1),
(8, '30/03/2018', 1, '', '', 5),
(9, '30/03/2018', 1, '', '', 3),
(10, '27/03/2018', 1, '', '', 5),
(11, '02/04/2018', 1, 'xml ', '', 5),
(12, '02/04/2018', 0, '', '', 2),
(13, '04/04/2018', 1, 'première séance', '', 4),
(14, '06/04/2018', 1, 'pensez à installer une vm', 'note que seulement moi je peux voir', 4),
(15, '12/04/2018', 1, '', '', 6),
(16, '', 0, '', '', 8),
(17, '13/04/2018', 1, 'pensez à choisir vos groupes de travail', 'amenez les clefs avec les iso', 8),
(18, '13/04/2018', 0, 'note seance publique', 'note seance personnelle', 7),
(19, '09/04/2018', 1, 'linux serveur note', '', 8),
(20, '13/04/2018', 1, '', '', 5),
(21, '13/04/2018', 1, '', '', 1),
(22, '12/04/2018', 1, '', '', 2),
(23, '12/04/2018', 0, '', '', 3);

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
-- Structure de la vue `emploi`
--
DROP TABLE IF EXISTS `emploi`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `emploi`  AS  select `groupe_seance`.`ID_Groupe` AS `ID_Groupe`,`seance`.`ID_Seance` AS `ID_Seance`,`seance`.`Date_Seance` AS `Date_Seance`,`seance`.`Debut_Seance` AS `Debut_Seance`,`seance`.`Note_Seance` AS `Note_Seance`,`cours`.`Libelle_Cours` AS `Libelle_Cours`,`membre`.`Prenom_Membre` AS `Prenom`,`membre`.`Nom_Membre` AS `Nom`,`cours`.`Couleur_Cours` AS `Couleur_Cours` from (((((`groupe_seance` join `groupe` on((`groupe_seance`.`ID_Groupe` = `groupe`.`ID_Groupe`))) join `seance` on((`groupe_seance`.`ID_Seance` = `seance`.`ID_Seance`))) join `cours` on((`seance`.`ID_Cours` = `cours`.`ID_Cours`))) join `cours_membre` on((`cours`.`ID_Cours` = `cours_membre`.`ID_Cours`))) join `membre` on((`cours_membre`.`ID_membre` = `membre`.`ID_membre`))) ;

-- --------------------------------------------------------

--
-- Structure de la vue `emploi2`
--
DROP TABLE IF EXISTS `emploi2`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `emploi2`  AS  select `groupe`.`Libelle_Groupe` AS `Libelle_Groupe`,`seance`.`ID_Seance` AS `ID_Seance`,`seance`.`Date_Seance` AS `Date_Seance`,`seance`.`Debut_Seance` AS `Debut_Seance`,`seance`.`NotePersonnel_Seance` AS `NotePersonnel_Seance`,`seance`.`Note_Seance` AS `Note_Seance`,`membre`.`ID_membre` AS `ID_membre`,`cours`.`Libelle_Cours` AS `Libelle_Cours`,`cours`.`Couleur_Cours` AS `Couleur_Cours` from (((((`groupe_seance` join `groupe` on((`groupe_seance`.`ID_Groupe` = `groupe`.`ID_Groupe`))) join `seance` on((`groupe_seance`.`ID_Seance` = `seance`.`ID_Seance`))) join `cours` on((`seance`.`ID_Cours` = `cours`.`ID_Cours`))) join `cours_membre` on((`cours`.`ID_Cours` = `cours_membre`.`ID_Cours`))) join `membre` on((`cours_membre`.`ID_membre` = `membre`.`ID_membre`))) ;

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
  MODIFY `ID_Cours` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
--
-- AUTO_INCREMENT pour la table `emploiedutemps`
--
ALTER TABLE `emploiedutemps`
  MODIFY `ID_EDT` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT pour la table `groupe`
--
ALTER TABLE `groupe`
  MODIFY `ID_Groupe` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
--
-- AUTO_INCREMENT pour la table `membre`
--
ALTER TABLE `membre`
  MODIFY `ID_membre` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;
--
-- AUTO_INCREMENT pour la table `note`
--
ALTER TABLE `note`
  MODIFY `ID_Note` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
--
-- AUTO_INCREMENT pour la table `seance`
--
ALTER TABLE `seance`
  MODIFY `ID_Seance` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=24;
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
