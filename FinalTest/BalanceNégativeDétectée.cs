using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FinalTest;

namespace FinalTest
{
    public struct BalanceNégativeDétectée : IEvenementMetier
    {
        private string _numéroDeCompte;
        private Montant montant;
        private DateTime dateRetrait;

        public BalanceNégativeDétectée(string _numéroDeCompte, Montant montant, DateTime dateRetrait)
        {
            this._numéroDeCompte = _numéroDeCompte;
            this.montant = montant;
            this.dateRetrait = dateRetrait;
        }
    }
}
