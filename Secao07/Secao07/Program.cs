using System;
using System.Globalization;

namespace Secao07
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan ts = TimeSpan.FromMilliseconds(0.5);
            Console.WriteLine(ts);

            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1.ToLongDateString().ToString(CultureInfo.InvariantCulture) + ", " +  d1.Kind);
        }
    }
}
