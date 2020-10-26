using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Enseignant_test
{
    public abstract class Enseignant
    {
        private string matricule;
        private string nom;
        private string prénom;
        private int âge;
        public string adresse;
        private double salaire;
         
        public Enseignant(string ematricule,string enom,string eprenom,int eage,string eadresse,double esalaire)
        {
            this.matricule = ematricule;
            this.nom = enom;
            this.prénom = eprenom;
            this.âge = eage;
            this.adresse = eadresse;
            this.salaire = esalaire;
        }
        public void setSalaire(double taux)
        {
            salaire += salaire * taux;
        }
        public string getMat()
        {
            return this.matricule;
        }
        public String getNom()
        {
            return nom;
        }
        public int getage()
        {
            return âge;
        }
        public string getadresse()
        {
            return adresse;
        }
        public double getSalaire()
        {
            return salaire;
        }

    }
}
