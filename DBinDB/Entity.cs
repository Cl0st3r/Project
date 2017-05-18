using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBinDB
{
    class Entity
    {
        private DateTime creationTime;
        private string name;
        private List<Attribute> attributes;

        public DateTime CreationTime
        {
            get
            {
                return creationTime;
            }

            set
            {
                creationTime = value;
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

        internal List<Attribute> Attributes
        {
            get
            {
                return attributes;
            }

            set
            {
                attributes = value;
            }
        }
    }
}
