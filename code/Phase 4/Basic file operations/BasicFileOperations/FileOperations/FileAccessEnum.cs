namespace BasicFileOperations.FileOperations
{
    public class FileAccessEnum
    {
        public static void Main(string[] args)
        {
            using (FileStream fileStream = new FileStream(@"mydata", FileMode.Open, FileAccess.Read))
            {
                Console.WriteLine(fileStream.CanRead); // true
                Console.WriteLine(fileStream.CanWrite); // false
            }
            using (FileStream fileStream = new FileStream(@"mydata", FileMode.Open, FileAccess.Write))
            {
                Console.WriteLine(fileStream.CanRead); // false
                Console.WriteLine(fileStream.CanWrite); // true
            }
            using (FileStream fileStream = new FileStream(@"mydata", FileMode.Open, FileAccess.ReadWrite))
            {
                Console.WriteLine(fileStream.CanRead); // true
                Console.WriteLine(fileStream.CanWrite); // true
            }
        }
    }
}
