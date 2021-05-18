using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class CoreProp
    {
        private string element;
        private int level;
        public string Element
        {
            get
            {
                return element;
            }
            set
            {
                element = value;
            }
        }
        public int Level
        {
            get
            {
                return level;
            }
            set
            {
                level = value;
            }
        }

        public CoreProp(string element, int level)
        {
            Element = element;
            Level = level;
        }

    }
}