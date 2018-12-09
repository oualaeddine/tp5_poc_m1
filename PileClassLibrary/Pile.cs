using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PileClassLibrary
{
    public interface Pile
    {
        Boolean empiler(Etudiant e);
        Etudiant depiler();
        void vider();
        int lireTailleCourante();
        int lireTailleMax();
     }
}
