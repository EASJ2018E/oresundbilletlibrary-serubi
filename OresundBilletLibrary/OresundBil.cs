using System;
using BilletLibrary;

namespace OresundBilletLibrary
{
    public class OresundBil : Bil
    {
        // Constructor
        public OresundBil(string nummerplade, DateTime dato) : base(nummerplade, dato)
        {
            Nummerplade = nummerplade;
            Dato = dato;
        }

        public OresundBil(string nummerplade, DateTime dato, bool brobizz) : base(nummerplade, dato, brobizz)
        {
            Nummerplade = nummerplade;
            Dato = dato;
            Brobizz = brobizz;
        }

        public override decimal Pris()
        {
            return Brobizz ? 161 : 410;
        }

        public override string Køretøj()
        {
            return "Øresund Bil";
        }
    }
}
