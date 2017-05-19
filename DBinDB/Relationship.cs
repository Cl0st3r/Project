using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBinDB
{
    class Relationship
    {
        private bool isIdentifying;
        private string name;
        public Attribute foreignKey;
        public bool IsIdentifying
        {
            get
            {
                return isIdentifying;
            }

            set
            {
                isIdentifying = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
    }
}
