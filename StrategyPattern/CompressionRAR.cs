namespace Strategy_Pattern
{
    internal class CompressionRAR : ICompression
    {
        public void CompressFile(string fileName)
        {
            Console.WriteLine($"Compression RAR - OK File: {fileName}");
        }
    }
}
