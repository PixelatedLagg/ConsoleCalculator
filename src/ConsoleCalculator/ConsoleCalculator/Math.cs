using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    class MathConsole
    {
        public double Sqrt(double num) => Math.Sqrt(num);
        public double Cbrt(double num) => Math.Pow(num, 1.0 / 3.0);
        public double Pow(double num1, double num2) => Math.Pow(num1, num2);
        public double PythA(double b, double c) => Math.Sqrt((c * c) - (b * b));
        public double PythB(double a, double c) => Math.Sqrt((c * c) - (a * a));
        public double PythC(double a, double b) => Math.Sqrt((b * b) + (a * a));
        public bool PythT(double a, double b, double c) { if (c == Math.Sqrt((b * b) + (a * a))) { return true; } else { return false; } }
    }
}
