using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValoresEspeciais {
    class Program {
        static void Main(string[] args) {
            double x = double.PositiveInfinity;
            double y = double.NegativeInfinity;
            double z = double.NaN;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            sbyte sb = sbyte.MaxValue;
            double db = double.MinValue;

            Console.WriteLine(sb);
            Console.WriteLine(db);
        }
    }
}
