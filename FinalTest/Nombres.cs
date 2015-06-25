using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace FinalTest
{
    public class Nombres
    {
        private IEnumerable<KeyValuePair<string, int>> keyValuePairs;
        public IEnumerable<int> NombresPairs
        {
            get
            {
                var query = keyValuePairs.Where(x => (x.Value % 2 == 0)).Select(x=> x.Value);
                return query;
            }
            set { NombresPairs = value; }
        }

        public String TexteNombresImpairs
        {
            get
            {
                var query = keyValuePairs
                    .Where(x => (x.Value%2 != 0))
                    .OrderByDescending(x => x.Value)
                    .Select(x => x.Key)
                    .Aggregate((workingSentence, next) => next + ", " + workingSentence);
                return query;
            }
            set { TexteNombresImpairs = value; }
        }

        public String PremierNombreDontLeTexteContientPlusDe5Caractères
        {
            get
            {
                var query = keyValuePairs
                    .Where(x => (x.Key.Length > 5))
                    .Select(x => x.Key)
                    .First();
                return query;
            }
            set { TexteNombresImpairs = value; }
        }

        public IEnumerable<int> QuatreNombresSupérieursSuivant3
        {
            get
            {
                var query = keyValuePairs
                    .Where(x => (x.Value > 3))
                    .OrderBy(x => x.Value)
                    .Skip(0)
                    .Take(4)
                    .Select(x => x.Value);
                return query;
            }
            set { QuatreNombresSupérieursSuivant3 = value; }
        }

        public Nombres(IEnumerable<KeyValuePair<string, int>> keyValuePairs)
        {
            this.keyValuePairs = keyValuePairs;
        }



    }
}
