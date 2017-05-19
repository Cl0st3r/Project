using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBinDB
{
    class Relationship_Entity
    {
        private Relationship rel;
        private Entity ent;
        private char cardinality;

        internal Relationship Rel
        {
            get
            {
                return rel;
            }

            set
            {
                rel = value;
            }
        }

        internal Entity Ent
        {
            get
            {
                return ent;
            }

            set
            {
                ent = value;
            }
        }

        public char Cardinality
        {
            get
            {
                return cardinality;
            }

            set
            {
                cardinality = value;
            }
        }
    }
}
