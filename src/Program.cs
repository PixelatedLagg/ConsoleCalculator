using System;

class Program
{
    public static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Loop();
            return;
        }
        double result = 0;
        switch (args[0].ToLower())
        {
            case "add":
                for (int i = 1; i < args.Length; i++)
                {
                    result += Convert.ToDouble(args[i]);
                }
                Console.WriteLine(result);
                return;
            case "sub":
                for (int i = 1; i < args.Length; i++)
                {
                    result += Convert.ToDouble(args[i]);
                }
                Console.WriteLine(result);
                return;
            case "mult":
                for (int i = 1; i < args.Length; i++)
                {
                    result *= Convert.ToDouble(args[i]);
                }
                Console.WriteLine(result);
                return;
            case "div":
                for (int i = 1; i < args.Length; i++)
                {
                    result /= Convert.ToDouble(args[i]);
                }
                Console.WriteLine(result);
                return;
            case "sqrt":
                if (args.Length != 2)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid parameters.");
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                Console.WriteLine(Math.Sqrt(Convert.ToDouble(args[1])));
                return;
            case "cbrt":
                if (args.Length != 2)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid parameters.");
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                Console.WriteLine(Math.Cbrt(Convert.ToDouble(args[1])));
                return;
            case "pow":
                if (args.Length != 3)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid parameters.");
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                Console.WriteLine(Math.Pow(Convert.ToDouble(args[1]), Convert.ToDouble(args[2])));
                return;
            case "pytha":
                if (args.Length != 3)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid parameters.");
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                Console.WriteLine(PythA(Convert.ToDouble(args[1]), Convert.ToDouble(args[2])));
                return;
            case "pythb":
                if (args.Length != 3)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid parameters.");
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                Console.WriteLine(PythB(Convert.ToDouble(args[1]), Convert.ToDouble(args[2])));
                return;
            case "pythc":
                if (args.Length != 3)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid parameters.");
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                Console.WriteLine(PythC(Convert.ToDouble(args[1]), Convert.ToDouble(args[2])));
                return;
            case "pytht":
                if (args.Length != 4)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid parameters.");
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                if (PythT(Convert.ToDouble(args[1]), Convert.ToDouble(args[2]), Convert.ToDouble(args[3])))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
                return;
            case "mean":
                for (int i = 1; i < args.Length; i++)
                {
                    result += Convert.ToDouble(args[i]);
                }
                Console.WriteLine(result / args.Length - 1);
                return;
                    /*case string median_ when median_.Contains("median"):
                        input = input.Replace("median ", "");
                        double[] median = Array.ConvertAll(input.Split(' '), Double.Parse);
                        if (CheckNumbers(20, median) == false)
                        {
                            return;
                        }
                        if (CheckNumbersDown(2, median) == false)
                        {
                            return;
                        }
                        Array.Sort(median);
                        answer = (median.Length % 2 != 0) ? median[median.Length / 2] : ((double)median[median.Length / 2] + (double)median[(median.Length / 2) - 1]) / 2;
                        Console.WriteLine(answer);
                        break;
                    case string mode_ when mode_.Contains("mode"):
                        input = input.Replace("mode ", "");
                        double[] mode = Array.ConvertAll(input.Split(' '), Double.Parse);
                        if (CheckNumbers(20, mode) == false)
                        {
                            return;
                        }
                        if (CheckNumbersDown(2, mode) == false) 
                        {
                            return;
                        }
                        answer = mode.GroupBy(x => x).OrderByDescending(x => x.Count()).First().Key;
                        Console.WriteLine(answer);
                        break;
                    case string range_ when range_.Contains("range"):
                        input = input.Replace("range ", "");
                        double[] range = Array.ConvertAll(input.Split(' '), Double.Parse);
                        if (CheckNumbers(20, range) == false)
                        {
                            return;
                        }
                        if (CheckNumbersDown(2, range) == false)
                        {
                            return;
                        }
                        answer = range.Max() - range.Min();
                        Console.WriteLine(answer);
                        break;
                    case string percent_ when percent_.Contains("percent"):
                        input = input.Replace("percent ", "");
                        if (input.Contains("0."))
                        {
                            Console.WriteLine(Convert.ToDouble(input) * 100 + "%");
                            break;
                        }
                        double[] percent = Array.ConvertAll(input.Split('/'), Double.Parse);
                        if (CheckNumbers(2, percent) == false)
                        {
                            return;
                        }
                        if (CheckNumbersDown(2, percent) == false) 
                        {
                            return;
                        }
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
                        if (CheckNumbers(2, deci) == false)
                        {
                            return;
                        }
                        if (CheckNumbersDown(2, deci) == false)
                        {
                            return;
                        }
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
                        if (array2.Any(s => array[0].Contains(s)))
                        {
                            Console.WriteLine("Decimal must be below 1!");
                            break;
                        }
                        foreach (char c in input)
                        {
                            if (c == '0' && Convert.ToDouble(input) == Convert.ToDouble(input.Replace(c.ToString(), "")))
                            {
                                input = input.Replace(c.ToString(), "");
                            }
                        }
                        input = input.Replace("0.", "");
                        input = input.Replace(".", "");
                        string temp = "";
                        for (int i = 0; i < input.Length; i++) { temp = $"{temp}0"; }
                        Console.WriteLine($"{input}/1{temp}");
                        break;*/
        }
    }
    static double PythA(double b, double c) => Math.Sqrt((c * c) - (b * b));
    static double PythB(double a, double c) => Math.Sqrt((c * c) - (a * a));
    static double PythC(double a, double b) => Math.Sqrt((b * b) + (a * a));
    static bool PythT(double a, double b, double c) 
    { 
        if (c == Math.Sqrt((b * b) + (a * a))) 
        { 
            return true; 
        } 
        else 
        { 
            return false; 
        } 
    }
    static void Loop()
    {

    }
}