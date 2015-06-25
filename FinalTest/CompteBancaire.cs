using System.Collections.Generic;

namespace FinalTest
{
    public class CompteBancaire
    {
        private string _numéroDeCompte;
        private int autorisationDeCrédit;

        private IEnumerable<IEvenementMetier> evenement;
        public static IEnumerable<IEvenementMetier> Ouvrir(string _numéroDeCompte, int autorisationDeCrédit)
        {
            yield return new CompteCréé(_numéroDeCompte, autorisationDeCrédit);
        }
    }
}