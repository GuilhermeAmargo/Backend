public class nameComparer : IComparer<Product>
{
    public int Compare(Product a1, Product a2)
    {
        return a1.Name.CompareTo(a2.Name);
    }
}