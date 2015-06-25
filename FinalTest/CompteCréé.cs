﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalTest
{
    public struct CompteCréé : IEvenementMetier
    {
        public string _numéroDeCompte;
        private int autorisationDeCrédit;

        public CompteCréé(string _numéroDeCompte, int autorisationDeCrédit)
        {
            this._numéroDeCompte = _numéroDeCompte;
            this.autorisationDeCrédit = autorisationDeCrédit;
        }
    }
}
