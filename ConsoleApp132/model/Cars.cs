using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp132.NewFolder
{
    internal class Cars
    {
        private int _horsepower;
        public int HorsePower
        {
            get
            {
                return _horsepower;
            }
            set
            {
                if (value < 300)
                {
                    Console.WriteLine("BU MASININ AT GUCU 300DEN KICIK OLA BILMEZ");
                    return;
                }
                _horsepower = value;
            }
        }
        public readonly int Year=1999;

        protected string Name;
        public string ShowName()
        {
            return Name;
        }
    }
}
