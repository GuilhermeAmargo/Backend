class StockManager
{
    public LinkedList<Product> Products;

    public StockManager(LinkedList<Product> products)
    {
        this.Products = products;
    }

    public void AddProduct (string name, double price)
    {
        Product product = new Product(name, price);
        Products.AddLast(product);
    }

    public bool RemoveProduct (string name)
    {
        Products.Remove();
    }

    public override string ToString()
    {
        return$"{Products}";
    }
}
