using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PileClassLibrary;

namespace Server
{
    class UsinePileImpl : MarshalByRefObject, PileClassLibrary.UsinePile
    {
        public Pile creerUnePile(int taille)
        {
            return new PileImpl(taille);
        }
    }
}
