namespace OOPS
{
    public class Polymorphism
    {
        public static void Main(string[] args)
        {

        }
    }
    public class CalculatorOG
    {
        public virtual double Sum(double a, double b)
        {
            return a + b;
        }
        // Static Overloading
        public double Sum(double a, double b, double c)
        {
            return a + b + c;
        }
    }
    public class Calculator : CalculatorOG
    {
        // Dynamic Overriding
        public override double Sum(double a, double b)
        {
            return a + b + 5;
        }
        // Dynamic Overloading
        public int Sum(int a, int b, int c)
        {
            return a + b + c;
        }
    }
}
