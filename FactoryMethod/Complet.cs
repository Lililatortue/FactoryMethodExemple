
//mini implementation d'une classe qui peut beneficier d'un Factory methode
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
