

class ProductList {
    List<Product> list;

    public ProductList()
    {
        list = new List<Product>();
    }
    
    public void add(FactoryMethod factory)
    {
        list.Add(factory.newProduct());
    }
}
