using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBinDB
{
    class Attribute
    {
        private string name;
        private bool isPrimary;
        private bool isForeign;
        private string type;
        private string defaultValue;
        private List<Constraints> constraints;
        private Relationship foreignKey;

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

        public bool IsPrimary
        {
            get
            {
                return isPrimary;
            }

            set
            {
                isPrimary = value;
            }
        }

        public bool IsForeign
        {
            get
            {
                return isForeign;
            }

            set
            {
                isForeign = value;
            }
        }

        public string Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }

        public string DefaultValue
        {
            get
            {
                return defaultValue;
            }

            set
            {
                defaultValue = value;
            }
        }
    }
}
