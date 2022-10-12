using System.Text;

namespace DesignPatterns.BuilderPattern;

public class Product
{
    private Dictionary<int, string> _product;
    
    public Product()
    {
        _product = new Dictionary<int, string>();
    }

    public void Add(int key, string value)
    {
        _product.Add(key, value);
    }

    public string ListProducts()
    {
        var keysArr = _product.Keys;
        var result = new StringBuilder();
        
        foreach (var key in keysArr)
        {
            result.Append($"{key} : {_product[key]}  ");
        }

        return result.ToString();
    }
}