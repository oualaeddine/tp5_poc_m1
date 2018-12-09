using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PileClassLibrary
{
    [Serializable]

    public class Etudiant
    {
        int id { get; set; }
        string nom { get; set; }
        string prenom { get; set; }

   public     Etudiant(int id, string nom, string prenom)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
        }
    }
}
