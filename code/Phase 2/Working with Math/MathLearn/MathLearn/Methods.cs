namespace MathLearn
{
    public class Methods
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Math.Min(10, 12));
            Console.WriteLine(Math.Max(10, 12));

            Console.WriteLine(Math.Pow(10, 2));
            Console.WriteLine(Math.Sqrt(100));

            Console.WriteLine(Math.Floor(20.5));
            Console.WriteLine(Math.Ceiling(20.5));
            Console.WriteLine(Math.Round(20.50));
            Console.WriteLine(Math.Round(20.51));

            Console.WriteLine(Math.Log2(10)); // return log base 2, arg1: number
            Console.WriteLine(Math.Log10(10)); // return log base 10, arg1: number
            Console.WriteLine(Math.Log(100,10)); // return log base n, arg1: number, arg2: base

            // 90 degree means 1.57079 radian
            Console.WriteLine(Math.Sin(1.57079)); // angle in radian
            Console.WriteLine(Math.Cos(1.57079)); // angle in radian
            Console.WriteLine(Math.SinCos(1.57079)); // angle in radian

        }
    }
}
