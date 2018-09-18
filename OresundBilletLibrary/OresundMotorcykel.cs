using System;
using BilletLibrary;

namespace OresundBilletLibrary
{
    public class OresundMotorcykel : Motorcykel
    {
        // Constructor
        public OresundMotorcykel(string nummerplade, DateTime dato) : base(nummerplade, dato)
        {
            Nummerplade = nummerplade;
            Dato = dato;
        }

        public OresundMotorcykel(string nummerplade, DateTime dato, bool brobizz) : base(nummerplade, dato, brobizz)
        {
            Nummerplade = nummerplade;
            Dato = dato;
            Brobizz = brobizz;
        }

        public override decimal Pris()
        {
            return Brobizz ? 73 : 210;
        }

        public override string Køretøj()
        {
            return "Øresund MC";
        }
    }
}
