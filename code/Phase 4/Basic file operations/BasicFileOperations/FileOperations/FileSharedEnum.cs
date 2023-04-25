namespace BasicFileOperations.FileOperations
{
    public class FileSharedEnum
    {
        public static void Main(string[] args)
        {
            using (FileStream fileStream = new FileStream(@"mydata", FileMode.Open, FileAccess.ReadWrite, FileShare.Read))
            {

            }
            using (FileStream fileStream = new FileStream(@"mydata", FileMode.Open, FileAccess.ReadWrite, FileShare.Write))
            {

            }
            using (FileStream fileStream = new FileStream(@"mydata", FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite))
            {

            }
            using (FileStream fileStream = new FileStream(@"mydata", FileMode.Open, FileAccess.ReadWrite, FileShare.Delete))
            {

            }
            using (FileStream fileStream = new FileStream(@"mydata", FileMode.Open, FileAccess.ReadWrite, FileShare.Inheritable))
            {

            }
            using (FileStream fileStream = new FileStream(@"mydata", FileMode.Open, FileAccess.ReadWrite, FileShare.None))
            {

            }
        }
    }
}
