namespace DesignPatterns.BuilderPattern;

public class ConcreteBuilderA : IBuilder
{
    private Product _product = new Product();

    public ConcreteBuilderA()
    {
        Reset();
    }

    public void Reset()
    {
        _product = new Product();
    }
    
    public void AddPart1()
    {
        _product.Add(100, "Blue");
    }

    public void AddPart2()
    {
        _product.Add(200, "Red");
    }

    public void AddPart3()
    {
        _product.Add(300, "Green");
    }

    public void ListParts()
    {
        Console.WriteLine(_product.ListProducts());
    }

    public Product GetProduct()
    {
        return _product;
    }
}