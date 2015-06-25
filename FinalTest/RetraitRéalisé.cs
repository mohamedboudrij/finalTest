using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalTest
{
    public struct RetraitRéalisé : IEvenementMetier
    {
        private string _numéroDeCompte;
        private Montant montantRetrait;
        private DateTime dateRetrait;

        public RetraitRéalisé(string _numéroDeCompte, Montant montantRetrait, DateTime dateRetrait)
        {
            // TODO: Complete member initialization
            this._numéroDeCompte = _numéroDeCompte;
            this.montantRetrait = montantRetrait;
            this.dateRetrait = dateRetrait;
        }
    }
}
