using System;
using BilletLibrary;

namespace OresundBilletLibrary
{
    public class OresundMotorcykel : Motorcykel
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="nummerplade">Nummerplade på max 7 tegn</param>
        /// <param name="dato">Dato køretøjet kørte over broen</param>
        public OresundMotorcykel(string nummerplade, DateTime dato) : base(nummerplade, dato)
        {
            Nummerplade = nummerplade;
            Dato = dato;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="nummerplade">Nummerplade på max 7 tegn</param>
        /// <param name="dato">Dato køretøjet kørte over broen</param>
        /// <param name="brobizz">Om Brobizz blev brugt til betaling</param>
        public OresundMotorcykel(string nummerplade, DateTime dato, bool brobizz) : base(nummerplade, dato, brobizz)
        {
            Nummerplade = nummerplade;
            Dato = dato;
            Brobizz = brobizz;
        }

        /// <summary>
        /// Get price for vehicle
        /// </summary>
        /// <returns></returns>
        public override decimal Pris()
        {
            return Brobizz ? 73 : 210;
        }

        /// <summary>
        /// Navnet på køretøjstypen.
        /// Default er "Øresund MC".
        /// </summary>
        /// <returns></returns>
        public override string Køretøj()
        {
            return "Øresund MC";
        }
    }
}
