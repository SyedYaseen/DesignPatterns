namespace DesignPatterns.StrategyPattern.Demo.CompressionAlgo;

public class PNGCompression : IImgCompress
{
    public void Compress(string fileName)
    {
        Console.WriteLine("Applying PNG compression");
    }
}