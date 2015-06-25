﻿using System;
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

        public Nombres(IEnumerable<KeyValuePair<string, int>> keyValuePairs)
        {
            this.keyValuePairs = keyValuePairs;
        }



    }
}