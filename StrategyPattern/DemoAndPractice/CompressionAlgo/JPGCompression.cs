namespace DesignPatterns.StrategyPattern.Demo.CompressionAlgo;

public class JPGCompression : IImgCompress
{
    public void Compress(string fileName)
    {
        Console.WriteLine("JPEG Compression applied");
    }
}