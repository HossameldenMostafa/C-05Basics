using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class AccessModifiers
    {
        // Private -> Accessible Only Inside This Class
        private int Age;

        // Internal -> Accessible Inside The Same Project 'ConsoleApp1'
        internal string Name;

        // Public -> Accessible Anywhere
        public decimal Salary;
    }
}
