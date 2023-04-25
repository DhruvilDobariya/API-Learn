namespace BasicFileOperations.FileOperations
{
    public class FileModeEnum
    {
        public static void Main(string[] args)
        {
            // All permission that's not mean like FileAccess.Write, it mean os permission like, readonly.
            using (FileStream fileStream = new FileStream(@"mydata", FileMode.Open))
            {
                // It opens existing file if it doesn't exist then it will throw an exception which is FileNotFoundException
            }
            using (FileStream fileStream = new FileStream(@"mydata", FileMode.OpenOrCreate))
            {
                // It opens existing file if it doesn't exist then it will create new file.
            }
            using (FileStream fileStream = new FileStream(@"mydata", FileMode.Create))
            {
                // It will create new file, if file is already exist then it will overwrite it.
                // This required write permission.
            }
            using (FileStream fileStream = new FileStream(@"mydata", FileMode.CreateNew))
            {
                // It will create new file.
                // This required write permission
                // If file already exist then it will throw IOException
            }
            using (FileStream fileStream = new FileStream(@"mydata", FileMode.Truncate))
            {
                /// It will open the file and truncate it, so the size of file become zero byte.
                // This required write permission.
            }
            using (FileStream fileStream = new FileStream(@"mydata", FileMode.Append))
            {
                // It will append the text in existing file and if file not exist then it will create and then append the text.
                // It will required write permission.
            }
        }
    }
}
