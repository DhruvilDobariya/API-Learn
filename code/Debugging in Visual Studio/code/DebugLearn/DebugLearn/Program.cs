namespace DebugLearn
{
    public class Program
    {
        public static void Main(string[] args)
        {
#if DEBUG
            Console.WriteLine(Sum(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }));
            // Ans: 25
#endif
#if RELEASE
            List<int> list = new List<int>();
            Console.Write("Please enter n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Please enter no {i+1}: ");
                list.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine(Sum(list));
#endif
        }
        public static int Sum(List<int> list)
        {
            int ans = 0;
            foreach(var element in list)
            {
                if(element%2 != 0)
                {
                    ans += element;
                }
            }
            return ans;
        }
    }
}
