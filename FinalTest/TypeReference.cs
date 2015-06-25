using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalTest
{
    public class TypeReference
    {
        private int p;

        public TypeReference(int p)
        {
            // TODO: Complete member initialization
            this.p = p;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj.GetType() != this.GetType()) return false;

            TypeReference other = (TypeReference)obj;
            return other.p == this.p;
        }
    }
}
