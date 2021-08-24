using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    class Program
    {
        string intro = "**Commands:*---**Arithmetic*- add (add multiple numbers)*- sub (subtract multiple numbers)*- mult (multiply multiple numbers)*- div (divide multiple numbers)*- sqrt (find the square root of a number)*- cbrt (find the cube root of a number)*- pow (multiply a number to a power)**Pythagorean Theorem*- pytha (find a by the values of b and c)*- pythb (find b by the values of a and c)*- pythc (find c by the values of a and b)*- pytht (find if the triple is a pythagorean triple)**Statistics*- mean (find the mean of a data set)*- median (find the median of a data set)*- mode (find the mode of a data set)*- range (find the range of a data set)**Conversion*- percent (convert a decimal or fraction to a percent)*- decimal (convert a percent or fraction to a decimal)*- fraction (convert a percent or decimal to a fraction)**ConsoleCalculator*- clear (clear the console)*- commands (pulls up this list)*- exit (close the console)**---*";
        Nullable<double> answer = null;
        static void Main(string[] args)
        {
            Program p = new Program();
            MathConsole m = new MathConsole();
            p.intro = p.intro.Replace("*", Environment.NewLine);
            Console.WriteLine("Welcome to Console Calculator V1");
            Console.WriteLine("Created by Pixelated_Lagg");
            Console.WriteLine(p.intro);
            Console.Title = "ConsoleCalculator";
            Console.SetWindowPosition(0, 0);
            string input;
            for (bool loop = true; loop == true;) { input = Console.ReadLine(); p.Calculate(input); }
        }
        public void Calculate(string input)
        {
            Program p = new Program();
            MathConsole m = new MathConsole();
            answer = null;
            if (String.IsNullOrEmpty(input))
            {
                Console.WriteLine("Cmon dude, at least enter something.");
                Console.WriteLine(Environment.NewLine);
                return;
            }
            try
            {
                switch (input.ToLower())
                {
                    case string add_ when add_.Contains("add"):
                        input = input.Replace("add ", "");
                        double[] add = Array.ConvertAll(input.Split(' '), Double.Parse);
                        if (CheckNumbers(5, add) == false) { return; }
                        foreach (double d in add) { if (answer == null) { answer = d; } else { answer += d; } }
                        Console.WriteLine(answer);
                        break;
                    case string sub_ when sub_.Contains("sub"):
                        input = input.Replace("sub ", "");
                        double[] sub = Array.ConvertAll(input.Split(' '), Double.Parse);
                        if (CheckNumbers(5, sub) == false) { return; }
                        foreach (double d in sub) { if (answer == null) { answer = d; } else { answer -= d; } }
                        Console.WriteLine(answer);
                        break;
                    case string div_ when div_.Contains("div"):
                        input = input.Replace("div ", "");
                        double[] div = Array.ConvertAll(input.Split(' '), Double.Parse);
                        if (CheckNumbers(5, div) == false) { return; }
                        foreach (double d in div) { if (answer == null) { answer = d; } else { answer /= d; } }
                        Console.WriteLine(answer);
                        break;
                    case string mult_ when mult_.Contains("mult"):
                        input = input.Replace("mult ", "");
                        double[] mult = Array.ConvertAll(input.Split(' '), Double.Parse);
                        if (CheckNumbers(5, mult) == false) { return; }
                        foreach (double dd in mult) { if (answer == null) { answer = dd; } else { answer *= dd; } }
                        Console.WriteLine(answer);
                        break;
                    case string sqrt_ when sqrt_.Contains("sqrt"):
                        input = input.Replace("sqrt ", "");
                        double sqrt = Convert.ToDouble(input);
                        answer = m.Sqrt(sqrt);
                        Console.WriteLine(answer);
                        break;
                    case string cbrt_ when cbrt_.Contains("cbrt"):
                        input = input.Replace("cbrt ", "");
                        double cbrt = Convert.ToDouble(input);
                        answer = m.Cbrt(cbrt);
                        Console.WriteLine(answer);
                        break;
                    case string pow_ when pow_.Contains("pow"):
                        input = input.Replace("pow ", "");
                        double[] pow = Array.ConvertAll(input.Split(' '), Double.Parse);
                        if (CheckNumbers(2, pow) == false) { return; }
                        if (CheckNumbersDown(2, pow) == false) { return; }
                        answer = m.Pow(pow.First(), pow.Last());
                        Console.WriteLine(answer);
                        break;
                    case string pytha_ when pytha_.Contains("pytha"):
                        input = input.Replace("pytha ", "");
                        double[] pytha = Array.ConvertAll(input.Split(' '), Double.Parse);
                        if (CheckNumbers(2, pytha) == false) { return; }
                        answer = m.PythA(pytha.First(), pytha.Last());
                        Console.WriteLine(answer);
                        break;
                    case string pythb_ when pythb_.Contains("pythb"):
                        input = input.Replace("pythb ", "");
                        double[] pythb = Array.ConvertAll(input.Split(' '), Double.Parse);
                        if (CheckNumbers(2, pythb) == false) { return; }
                        answer = m.PythB(pythb.First(), pythb.Last());
                        Console.WriteLine(answer);
                        break;
                    case string pythc_ when pythc_.Contains("pythc"):
                        input = input.Replace("pythc ", "");
                        double[] pythc = Array.ConvertAll(input.Split(' '), Double.Parse);
                        if (CheckNumbers(2, pythc) == false) { return; }
                        answer = m.PythC(pythc.First(), pythc.Last());
                        Console.WriteLine(answer);
                        break;
                    case string pytht_ when pytht_.Contains("pytht"):
                        input = input.Replace("pytht ", "");
                        double[] pytht = Array.ConvertAll(input.Split(' '), Double.Parse);
                        if (CheckNumbers(3, pytht) == false) { return; }
                        if (CheckNumbersDown(3, pytht) == false) { return; }
                        Console.WriteLine(m.PythT(pytht.First(), pytht.ElementAt(1), pytht.Last()));
                        break;
                    case string mean_ when mean_.Contains("mean"):
                        input = input.Replace("mean ", "");
                        double[] mean = Array.ConvertAll(input.Split(' '), Double.Parse);
                        if (CheckNumbers(20, mean) == false) { return; }
                        if (CheckNumbersDown(2, mean) == false) { return; }
                        foreach (double d in mean) { if (answer == null) { answer = d; } else { answer += d; } }
                        answer /= mean.Length;
                        Console.WriteLine(answer);
                        break;
                    case string median_ when median_.Contains("median"):
                        input = input.Replace("median ", "");
                        double[] median = Array.ConvertAll(input.Split(' '), Double.Parse);
                        if (CheckNumbers(20, median) == false) { return; }
                        if (CheckNumbersDown(2, median) == false) { return; }
                        Array.Sort(median);
                        answer = (median.Length % 2 != 0) ? median[median.Length / 2] : ((double)median[median.Length / 2] + (double)median[(median.Length / 2) - 1]) / 2;
                        Console.WriteLine(answer);
                        break;
                    case string mode_ when mode_.Contains("mode"):
                        input = input.Replace("mode ", "");
                        double[] mode = Array.ConvertAll(input.Split(' '), Double.Parse);
                        if (CheckNumbers(20, mode) == false) { return; }
                        if (CheckNumbersDown(2, mode) == false) { return; }
                        answer = mode.GroupBy(x => x).OrderByDescending(x => x.Count()).First().Key;
                        Console.WriteLine(answer);
                        break;
                    case string range_ when range_.Contains("range"):
                        input = input.Replace("range ", "");
                        double[] range = Array.ConvertAll(input.Split(' '), Double.Parse);
                        if (CheckNumbers(20, range) == false) { return; }
                        if (CheckNumbersDown(2, range) == false) { return; }
                        answer = range.Max() - range.Min();
                        Console.WriteLine(answer);
                        break;
                    case string percent_ when percent_.Contains("percent"):
                        input = input.Replace("percent ", "");
                        if (input.Contains("0.")) { Console.WriteLine(Convert.ToDouble(input) * 100 + "%"); break; }
                        double[] percent = Array.ConvertAll(input.Split('/'), Double.Parse);
                        if (CheckNumbers(2, percent) == false) { return; }
                        if (CheckNumbersDown(2, percent) == false) { return; }
                        answer = (percent.First() / percent.Last()) * 100;
                        Console.WriteLine($"{answer}%");
                        break;
                    case string decimal_ when decimal_.Contains("decimal"):
                        input = input.Replace("decimal ", "");
                        if (input.Contains("%"))
                        {
                            input = input.Replace("%", "");
                            Console.WriteLine(Convert.ToDouble(input) / 100);
                            break;
                        }
                        double[] deci = Array.ConvertAll(input.Split('/'), Double.Parse);
                        if (CheckNumbers(2, deci) == false) { return; }
                        if (CheckNumbersDown(2, deci) == false) { return; }
                        answer = deci.First() / deci.Last();
                        Console.WriteLine(answer);
                        break;
                    case string fraction_ when fraction_.Contains("fraction"):
                        input = input.Replace("fraction ", "");
                        if (input.Contains("%"))
                        {
                            input = input.Replace("%", "");
                            Console.WriteLine(Convert.ToDouble(input) + "/100");
                            break;
                        }
                        string[] array = input.Split('.');
                        string[] array2 = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
                        if (array2.Any(s => array[0].Contains(s))) { Console.WriteLine("Decimal must be below 1!"); break; }
                        foreach (char c in input) { if (c == '0' && Convert.ToDouble(input) == Convert.ToDouble(input.Replace(c.ToString(), ""))) { input = input.Replace(c.ToString(), ""); } }
                        input = input.Replace("0.", "");
                        input = input.Replace(".", "");
                        string temp = "";
                        for (int i = 0; i < input.Length; i++) { temp = $"{temp}0"; }
                        Console.WriteLine($"{input}/1{temp}");
                        break;
                    case string color_ when color_.Contains("color"):
                        if (input.Contains("text"))
                        {
                            input = input.Replace("color text ", "");
                            switch (input)
                            {
                                case "red":
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Clear();
                                    Console.WriteLine("Text color set to red.");
                                    break;
                                case "yellow":
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.Clear();
                                    Console.WriteLine("Text color set to yellow.");
                                    break;
                                case "green":
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Clear();
                                    Console.WriteLine("Text color set to green.");
                                    break;
                                case "blue":
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.Clear();
                                    Console.WriteLine("Text color set to blue.");
                                    break;
                                case "purple":
                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                    Console.Clear();
                                    Console.WriteLine("Text color set to purple.");
                                    break;
                                case "default":
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.Clear();
                                    Console.WriteLine("Text color set to default.");
                                    break;
                                default:
                                    Console.WriteLine("Enter a valid color parameter!");
                                    break;
                            }
                        }
                        break;
                    case "commands":
                        p.intro = p.intro.Replace("*", Environment.NewLine);
                        Console.WriteLine(p.intro);
                        break;
                    case "clear":
                        Console.Clear();
                        Console.WriteLine("Console Cleared.");
                        break;
                    case "exit":
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Enter a valid command!");
                        break;
                }
            }
            catch { Console.WriteLine("Invalid command or command parameters!"); }
            input = "";
            Console.WriteLine(Environment.NewLine);
        }
        private bool CheckNumbers(int numbers, double[] array)
        {
            if (array.Length > numbers)
            {
                Console.WriteLine($"Too many numbers! Limit for this command is {numbers}.");
                Console.WriteLine(Environment.NewLine);
                return false;
            }
            return true;
        }
        private bool CheckNumbersDown(int numbers, double[] array)
        {
            if (array.Length < numbers)
            {
                Console.WriteLine($"Too little numbers! Minimum for this command is {numbers}.");
                Console.WriteLine(Environment.NewLine);
                return false;
            }
            return true;
        }
    }
}
