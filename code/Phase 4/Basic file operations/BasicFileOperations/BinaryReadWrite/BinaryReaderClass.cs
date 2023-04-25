﻿namespace BasicFileOperations.BinaryReadWrite
{
    public class BinaryReaderClass
    {
        public static void Main(string[] args)
        {
            BinaryReader binaryReader;
            try
            {
                binaryReader = new BinaryReader(new FileStream("mydata", FileMode.Open, FileAccess.Read));
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n Cannot open file.");
                return;
            }

            try
            {
                Console.WriteLine($"Integer data: {binaryReader.ReadInt32()}");
                Console.WriteLine($"Double data: {binaryReader.ReadDouble()}");
                Console.WriteLine($"Boolean data: {binaryReader.ReadBoolean()}");
                Console.WriteLine($"String data: {binaryReader.ReadString()}");
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n Cannot read from file.");
                return;
            }
            binaryReader.Close();
        }
    }
}