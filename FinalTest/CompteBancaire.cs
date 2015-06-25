using System.Collections.Generic;

namespace FinalTest
{
    public class CompteBancaire
    {
        private readonly CompteCréé _compteCréé;
        private readonly DépotRéalisé _depoDépotRéalisé;

        public CompteBancaire(CompteCréé compteCréé)
        {
            _compteCréé = compteCréé;
        }

        public CompteBancaire(CompteCréé compteCréé,DépotRéalisé depoDépotRéalisé)
        {
            _compteCréé = compteCréé;
            _depoDépotRéalisé = depoDépotRéalisé;
        }

        public static IEnumerable<IEvenementMetier> Ouvrir(string _numéroDeCompte, int autorisationDeCrédit)
        {
            yield return new CompteCréé(_numéroDeCompte, autorisationDeCrédit);
        }

        public IEnumerable<IEvenementMetier>  FaireUnDepot(Montant montantDepot, System.DateTime dateDepot)
        {
            yield return new DépotRéalisé(this._compteCréé._numéroDeCompte, montantDepot, dateDepot);
        }

        public IEnumerable<IEvenementMetier> FaireUnRetrait(Montant montantRetrait, System.DateTime dateRetrait)
        {
            yield return new RetraitRéalisé(this._compteCréé._numéroDeCompte,montantRetrait, dateRetrait);
        }
    }
}