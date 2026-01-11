// description:
//      Ceci est l'introduction au concept de FactoryMethod.
//      Il est important de comprendre ces principes avant d'essayer de comprendre 
//      des utilisations avancer
void exemple()
{
    //----- instatier des factory ----//
    MakeSofa sofaFactory = new MakeSofa();
    MakeMeuble meubleFactory = new MakeMeuble();

    //----- choisir method de creation -----//
    Product sofa = sofaFactory.newProduct();
    Product sofaPerso = sofaFactory.createProduct(10, 2);

    Product meuble = meubleFactory.newProduct();
    Product meublePerso = meubleFactory.createProduct(20, 5);

    //----- utilisation de la methode WhoAmI -----//
    sofa.WhoAmI();          // Method WhoAmI de Product est overload avec celle de Sofa
    sofaPerso.WhoAmI();     // Method WhoAmI de Product est overload avec celle de Sofa

    meuble.WhoAmI();        // Method WhoAmI de Product est overload avec celle de Meuble
    meublePerso.WhoAmI();   // Method WhoAmI de Product est overload avec celle de Meuble
}



// description:
//      Referer au code dans la fiche complet.cs
void exemple_complet()
{
    MakeSofa sofaFactory = new MakeSofa();
    MakeMeuble meubleFactory = new MakeMeuble();
    ProductList list = new ProductList();


    list.add(sofaFactory);     
    list.add(meubleFactory);
}

