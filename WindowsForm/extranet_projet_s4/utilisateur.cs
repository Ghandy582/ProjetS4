using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Pour utiliser mysql
using MySql.Data.MySqlClient;
//Pour utiliser le fichier de configuration
using System.Configuration;

namespace extranet_projet_s4
{
    public class Utilisateur
    {
        /*---------------------------- PROPRIETES ---------------------------*/
        int id_membre;
        int role_membre;
        string user_membre;
        string prenom_membre;
        string nom_membre;
        int premiere_co_membre;
        int id_groupe_membre;

        /*---------------------------------- METHODES -------------------------------*/
        //constructeur
        public Utilisateur(int id, int role, string user, string prenom, string nom, int premiere_co, int id_groupe)
        {
            this.id_membre = id;
            this.role_membre = role;
            this.user_membre = user;
            this.prenom_membre = prenom;
            this.nom_membre = nom;
            this.premiere_co_membre = premiere_co;
            this.id_groupe_membre = id_groupe;
        }
        //_______________________________________________________
        // Affichage des données 
        public void affiche()
        {
            MessageBox.Show("Vous êtes " + prenom_membre + " " + nom_membre + ". User: " + user_membre + " première co: " + premiere_co_membre + " id groupe: " + id_groupe_membre);
        }
        // ___________________________________
        // Les get
        public int Id_Membre   // the Name property
        {
            get
            {
                return id_membre;
            }
            set
            {
                id_membre = value;
            }
        }
        public int Role_Membre   // the Name property
        {
            get
            {
                return role_membre;
            }
            set
            {
                role_membre = value;
            }
        }
        public string User_Membre   // the Name property
        {
            get
            {
                return user_membre;
            }
            set
            {
                user_membre = value;
            }
        }
        public string Prenom_Membre   // the Name property
        {
            get
            {
                return prenom_membre;
            }
            set
            {
                prenom_membre = value;
            }
        }
        public string Nom_Membre   // the Name property
        {
            get
            {
                return nom_membre;
            }
            set
            {
                nom_membre = value;
            }
        }
        public int Premiere_co_membre   // the Name property
        {
            get
            {
                return premiere_co_membre;
            }
            set
            {
                premiere_co_membre = value;
            }
        }
        public int Id_groupe_membre   // the Name property
        {
            get
            {
                return id_groupe_membre;
            }
            set
            {
                id_groupe_membre = value;
            }
        }
    }
}
