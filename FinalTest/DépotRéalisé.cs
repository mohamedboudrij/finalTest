using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalTest
{
    public struct DépotRéalisé : IEvenementMetier
    {
        private string _numéroDeCompte;
        public Montant montantDepot;
        private DateTime dateDepot;

        public DépotRéalisé(string _numéroDeCompte, Montant montantDepot, DateTime dateDepot)
        {
            // TODO: Complete member initialization
            this._numéroDeCompte = _numéroDeCompte;
            this.montantDepot = montantDepot;
            this.dateDepot = dateDepot;
        }
    }
}
