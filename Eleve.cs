using System;
using System.Collections.Generic;
using System.Text;

namespace Evaluation
{
    class Eleve
    {
        public string nom { get; private set; }
        public string prenom { get; private set; }
        
        public List<Note> notes = new List<Note>();
        public Eleve(string Prenom, string Nom)
        {
            nom = Nom;
            prenom = Prenom;
        }
        public void ajouterNote(Note note)
        {
            if (notes.Count < 201)
                notes.Add(note);
            else
                Console.Write("vous ne pouvez pas ajouter de nouvelles notes pour cette élève.");
        }

        public double Moyenne(int i) // méthode pour calculer la moyenne d'un eleve dans une matiere
        {
            double val;
            double moy = 0;
            int c = 1;
            for (int j = 0; j < notes.Count; j++)
            {
                if (notes[j].matiere == i)
                {
                    val = Math.Round(notes[j].note, 2);
                    moy += val;
                    c++;
                }
            }
            return Math.Round(moy / c, 2);
        }
        public double Moyenne() // methode pour calculer la moyenne generale d'un eleve
        {
            int c = 1;
            int temp=notes[0].matiere;
            double moy = 0;
            for (int j = 1; j < notes.Count; j++) //boucle pour compter le nombre de matières différentes
            {
                if (notes[j].matiere != temp)
                {
                    c++;
                    temp = notes[j].matiere;
                }
            }
            for (int j = 0 ; j < c; j++)
            {
                moy+=Moyenne(j);                
            }
            return Math.Round(moy/c,2);
            
        }
    }
}    

