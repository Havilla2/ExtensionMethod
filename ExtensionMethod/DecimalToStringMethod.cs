using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    public static class DecimalToStringMethod
    {
        public static string DecimalToString(this DecimalToSring decimalToSring, decimal num)
        {
            return num.ToString("C", CultureInfo.CurrentCulture);
        }
    }
}
