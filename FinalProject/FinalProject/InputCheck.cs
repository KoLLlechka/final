using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    internal class InputCheck
    {
        public static bool IsStringToDouble(string x)
        {
            return double.TryParse(x, out var result);
        }
    }
}
