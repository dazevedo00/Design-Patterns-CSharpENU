namespace Strategy_Pattern
{
    internal class CompressionGZIP : ICompression
    {
        public void CompressFile(string fileName)
        {
            Console.WriteLine($"Compression GZIP - OK File: {fileName}");
        }
    }
}
