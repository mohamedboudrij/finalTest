using System.Collections.Generic;

namespace FinalTest
{
    public class CompteBancaire
    {
        private readonly CompteCréé _compteCréé;

        public CompteBancaire(CompteCréé compteCréé)
        {
            _compteCréé = compteCréé;
        }

        public static IEnumerable<IEvenementMetier> Ouvrir(string _numéroDeCompte, int autorisationDeCrédit)
        {
            yield return new CompteCréé(_numéroDeCompte, autorisationDeCrédit);
        }

        public IEnumerable<IEvenementMetier>  FaireUnDepot(Montant montantDepot, System.DateTime dateDepot)
        {
            yield return new DépotRéalisé(this._compteCréé._numéroDeCompte, montantDepot, dateDepot);
        }
    }
}