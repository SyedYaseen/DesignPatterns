namespace DesignPatterns.StrategyPattern.Demo;

public class ImageStorage
{
    private List<Image> Images = new List<Image>();
    
    public void StoreImage(Image image, IImgCompress compressor, IFilter filter)
    {
        compressor.Compress(image.imageName);
        filter.Apply(image.imageName);
        Images.Add(image);
    }
}
