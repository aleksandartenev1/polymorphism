using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class KekkeiGenkai
    {
        private string firstElement;
        private string secondElement;
        private string mixedDragon;

        public string FirstElement
        {
            get
            {
                return firstElement;
            }
            set
            {
                firstElement = value;
            }
        }

        public string SecondElement
        {
            get
            {
                return secondElement;
            }
            set
            {
                secondElement = value;
            }
        }

        public string MixedDragon
        {
            get
            {
                return mixedDragon;
            }
            set
            {
                mixedDragon = value;
            }
        }
    }
}
