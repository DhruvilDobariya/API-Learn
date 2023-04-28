using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFileOperations.FileOperations
{
    public class FileSharedEnumLearn
    {
        // File shared enum is used to give access of file to another process if one process already have access of these file.
        public static void Main(string[] args)
        {
            Thread t1 = new Thread(Method1);
            Thread t2 = new Thread(Method2);

            t1.Start();
            t2.Start();
            //Method1();
            //Method2();
        }
        public static void Method1()
        {
            using (FileStream stream = new FileStream(@"C:\Users\dhruvil.d\Learn\dotnet\API-Learn\code\Phase 4\Basic file operations\BasicFileOperations\Text.txt", FileMode.Open, FileAccess.Write, FileShare.Write))
            {
                Console.WriteLine("File opened by method 1");
                Thread.Sleep(4000);
                Console.WriteLine("File close by method 1");
            }
        }
        public static void Method2()
        {
            using (FileStream stream = new FileStream(@"C:\Users\dhruvil.d\Learn\dotnet\API-Learn\code\Phase 4\Basic file operations\BasicFileOperations\Text.txt", FileMode.Open, FileAccess.Write, FileShare.Write))
            {
                Console.WriteLine("File opened by method 2");
                Thread.Sleep(4000);
                Console.WriteLine("File close by method 2");
            }
        }
    }
}
