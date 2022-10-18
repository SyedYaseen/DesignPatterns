namespace DesignPatterns.AdapterPattern.DemoPractice;

public class ImagePreview
{
    private Image _image;

    public ImagePreview(Image image)
    {
        _image = image;
    }

    public void ApplyFilter(IFilter filter)
    {
        filter.Apply(_image);
    }
}