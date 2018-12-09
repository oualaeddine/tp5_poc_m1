using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PileClassLibrary;

namespace Server
{
    class PileImpl : MarshalByRefObject, PileClassLibrary.Pile
    {
        private Stack<Etudiant> pile;
        private int taille;

        public PileImpl(int taille)
        {
            Console.WriteLine("creation de pile : " + taille);
            this.taille = taille;
            pile = new Stack<Etudiant>(taille);
        }

        public Etudiant depiler()
        {
            Console.WriteLine("depiler()");
            return pile.Peek();
        }

        public bool empiler(Etudiant e)
        {
            Console.WriteLine("empiler()");

            if (pile.Count < taille)
                pile.Push(e);
            else
                return false;

            return true;
        }

        public int lireTailleCourante()
        {
            Console.WriteLine("lireTailleCourante()");

            return pile.Count;
        }

        public int lireTailleMax()
        {
            Console.WriteLine("lireTailleMax()");

            return taille;
        }

        public void vider()
        {
            Console.WriteLine("vider()");

            pile = new Stack<Etudiant>(taille);
        }
    }
}
