using System;
using System.Collections.Generic;
using System.Text;

namespace Evaluation
{
    class Classe
    {
        public string nomClasse { get; set; }
        public List<Eleve> eleves = new List<Eleve>();
        public List<string> matieres = new List<string>();
        
        public Classe (string nomclasse)
        {
            nomClasse = nomclasse;
        }

        public void ajouterEleve(string prenom, string nom)
        {
            if (eleves.Count < 31)
            {
                Eleve i = new Eleve(prenom, nom);
                eleves.Add(i);
            }
            else
                Console.Write("Vous ne pouvez pas ajouter d'élève car cette classe est pleine.");
        }
        public void ajouterMatiere(string cmatiere)
        {
            if (matieres.Count < 11)
                matieres.Add(cmatiere);
            else
                Console.Write("vous ne pouvez pas ajouter de matière.");
        }
        public double Moyenne(int i) // methode pour calculer la moyenne générale dans une matière
        {
            int c = 1;
            string temp1 = eleves[0].prenom;
            string temp2 = eleves[0].nom;
            double moy = 0;
            for (int j = 1; j < eleves.Count; j++) //boucle pour compter le nombre d'élèves différents
            {
                if (eleves[j].prenom != temp1 && eleves[j].nom != temp2)
                {
                    c++;
                    temp1 = eleves[j].prenom;
                    temp2 = eleves[j].nom;
                }
            }
            for (int j = 0; j < c; j++)
            {
                Eleve prog = eleves[j];
                moy += prog.Moyenne(i);
            }
            return Math.Round(moy / c, 2);
        }
        public double Moyenne() //methode pour calculer la moyenne générale
        {
            int c=1;
            string temp = matieres[0];
            double moy=0;
            for (int j = 1; j < matieres.Count; j++) //boucle pour compter le nombre de matière diffèrentes
            {
                if (matieres[j]!=temp)
                {
                    c++;
                    temp = matieres[j];
                }   
            }
            for (int j = 0; j < c; j++)
            {
                moy += Moyenne(j);
            }
            return Math.Round(moy / c, 2);
        }
    }
}
