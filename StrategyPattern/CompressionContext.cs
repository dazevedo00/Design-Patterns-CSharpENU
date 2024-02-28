namespace Strategy_Pattern
{
    public class CompressionContext
    {

        private ICompression _icompression;

        public CompressionContext(ICompression icompression)
        {
            _icompression = icompression;
        }

        public void SetStrategy(ICompression icompression)
        {
            _icompression = icompression;
        }

        public void CreateCompressedFile(string fileName)
        {
            _icompression.CompressFile(fileName);
        }
    }
}
