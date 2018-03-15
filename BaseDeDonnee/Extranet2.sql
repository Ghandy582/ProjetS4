#------------------------------------------------------------
#        Script MySQL.
#------------------------------------------------------------


#------------------------------------------------------------
# Table: Membre
#------------------------------------------------------------

CREATE TABLE Membre(
        ID_membre         int (11) Auto_increment  NOT NULL ,
        Role_Membre       Int NOT NULL ,
        User_Membre       Varchar (25) NOT NULL ,
        MotdePasse_Membre Varchar (255) NOT NULL ,
        Salt_Membre       Varchar (25) NOT NULL ,
        Prenom_Membre     Varchar (25) NOT NULL ,
        Nom_Membre        Varchar (25) NOT NULL ,
        PremiereCo_Membre Bool NOT NULL ,
        ID_Groupe         Int NOT NULL ,
        PRIMARY KEY (ID_membre )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: Groupe
#------------------------------------------------------------

CREATE TABLE Groupe(
        ID_Groupe      int (11) Auto_increment  NOT NULL ,
        Libelle_Groupe Varchar (250) NOT NULL ,
        PRIMARY KEY (ID_Groupe )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: Cours
#------------------------------------------------------------

CREATE TABLE Cours(
        ID_Cours          int (11) Auto_increment  NOT NULL ,
        Libelle_Cours     Varchar (250) NOT NULL ,
        Coefficient_Cours Int NOT NULL ,
        Couleur_Cours     Varchar (25) NOT NULL ,
        PRIMARY KEY (ID_Cours )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: Note
#------------------------------------------------------------

CREATE TABLE Note(
        ID_Note      int (11) Auto_increment  NOT NULL ,
        Note         Int NOT NULL ,
        Libelle_Note Varchar (250) NOT NULL ,
        ID_membre    Int NOT NULL ,
        ID_Cours     Int NOT NULL ,
        PRIMARY KEY (ID_Note )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: Seance
#------------------------------------------------------------

CREATE TABLE Seance(
        ID_Seance            int (11) Auto_increment  NOT NULL ,
        Date_Seance          Varchar (25) NOT NULL ,
        Debut_Seance         Bool NOT NULL ,
        Note_Seance          Varchar (250) ,
        NotePersonnel_Seance Varchar (250) ,
        ID_Cours             Int NOT NULL ,
        PRIMARY KEY (ID_Seance )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: EmploieDuTemps
#------------------------------------------------------------

CREATE TABLE EmploieDuTemps(
        ID_EDT  int (11) Auto_increment  NOT NULL ,
        Libelle Varchar (25) NOT NULL ,
        PRIMARY KEY (ID_EDT )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: TravauxPratique
#------------------------------------------------------------

CREATE TABLE TravauxPratique(
        ID_TP      int (11) Auto_increment  NOT NULL ,
        Libelle_TP Varchar (250) NOT NULL ,
        Date_TP    Date NOT NULL ,
        ID_Cours   Int NOT NULL ,
        ID_Groupe  Int NOT NULL ,
        PRIMARY KEY (ID_TP )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: Groupe_Seance
#------------------------------------------------------------

CREATE TABLE Groupe_Seance(
        ID_Seance Int NOT NULL ,
        ID_Groupe Int NOT NULL ,
        PRIMARY KEY (ID_Seance ,ID_Groupe )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: EmploieDuTemps_Seance
#------------------------------------------------------------

CREATE TABLE EmploieDuTemps_Seance(
        ID_Seance Int NOT NULL ,
        ID_EDT    Int NOT NULL ,
        PRIMARY KEY (ID_Seance ,ID_EDT )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: Cours_Membre
#------------------------------------------------------------

CREATE TABLE Cours_Membre(
        ID_Cours  Int NOT NULL ,
        ID_membre Int NOT NULL ,
        PRIMARY KEY (ID_Cours ,ID_membre )
)ENGINE=InnoDB;

ALTER TABLE Membre ADD CONSTRAINT FK_Membre_ID_Groupe FOREIGN KEY (ID_Groupe) REFERENCES Groupe(ID_Groupe) ON DELETE CASCADE;
ALTER TABLE Note ADD CONSTRAINT FK_Note_ID_membre FOREIGN KEY (ID_membre) REFERENCES Membre(ID_membre) ON DELETE CASCADE;
ALTER TABLE Note ADD CONSTRAINT FK_Note_ID_Cours FOREIGN KEY (ID_Cours) REFERENCES Cours(ID_Cours) ON DELETE CASCADE;
ALTER TABLE Seance ADD CONSTRAINT FK_Seance_ID_Cours FOREIGN KEY (ID_Cours) REFERENCES Cours(ID_Cours) ON DELETE CASCADE;
ALTER TABLE TravauxPratique ADD CONSTRAINT FK_TravauxPratique_ID_Cours FOREIGN KEY (ID_Cours) REFERENCES Cours(ID_Cours) ON DELETE CASCADE;
ALTER TABLE TravauxPratique ADD CONSTRAINT FK_TravauxPratique_ID_Groupe FOREIGN KEY (ID_Groupe) REFERENCES Groupe(ID_Groupe) ON DELETE CASCADE;
ALTER TABLE Groupe_Seance ADD CONSTRAINT FK_Groupe_Seance_ID_Seance FOREIGN KEY (ID_Seance) REFERENCES Seance(ID_Seance) ON DELETE CASCADE;
ALTER TABLE Groupe_Seance ADD CONSTRAINT FK_Groupe_Seance_ID_Groupe FOREIGN KEY (ID_Groupe) REFERENCES Groupe(ID_Groupe) ON DELETE CASCADE;
ALTER TABLE EmploieDuTemps_Seance ADD CONSTRAINT FK_EmploieDuTemps_Seance_ID_Seance FOREIGN KEY (ID_Seance) REFERENCES Seance(ID_Seance) ON DELETE CASCADE;
ALTER TABLE EmploieDuTemps_Seance ADD CONSTRAINT FK_EmploieDuTemps_Seance_ID_EDT FOREIGN KEY (ID_EDT) REFERENCES EmploieDuTemps(ID_EDT) ON DELETE CASCADE;
ALTER TABLE Cours_Membre ADD CONSTRAINT FK_Cours_Membre_ID_Cours FOREIGN KEY (ID_Cours) REFERENCES Cours(ID_Cours) ON DELETE CASCADE;
ALTER TABLE Cours_Membre ADD CONSTRAINT FK_Cours_Membre_ID_membre FOREIGN KEY (ID_membre) REFERENCES Membre(ID_membre) ON DELETE CASCADE;
