namespace Strategy_Pattern
{
    internal class CompressionZIP : ICompression
    {
        public void CompressFile(string fileName)
        {
            Console.WriteLine($"Compression ZIP - OK File: {fileName}" );
        }
    }
}

