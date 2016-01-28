using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMiniMethods_RecursiveEven {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(RecursiveEven(10));
        }

        static int RecursiveEven(int n) {
            if (n == 0) {
                return 0;
            }
            return RecursiveEven(n - 1) + 2;
        }

    }
}
