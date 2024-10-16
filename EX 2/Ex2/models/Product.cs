public class Product : IComparable<Product>
{
    public string Name {get; private set;}
    public double Price {get; private set;}

    public Product (string name, double price)
    {
        Name = name;
        Price = price;
    }

    public int CompareTo(Product other)
    {
        if(this.Price<other.Price)
            return -1;
        if(this.Price>other.Price)
            return 1;
        return 0;
    }

    public override string ToString()
    {
        return $"Nome: {Name} Preço: {Price:C}";
    }
}