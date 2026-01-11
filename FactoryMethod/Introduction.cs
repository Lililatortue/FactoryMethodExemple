





// Overview of the Factory Method


// type : Creational Pattern
// UseCase:
//      Definir une interface pour creer un objet tous en laissant 
//      l'objet definir comment il doit etre creer. lol
//
// Diagram en Reference:
//      FactoryMethod_theorique.drawio
//      FactoryMethod_pratique.drawio
//

// la fonctionnalite
public interface FactoryMethod
{
    public Product createProduct(int taille, int couleur); //constructeur personnaliser
    public Product newProduct();                           //constructeur par default
}

//-------------- les implementation concrete --------------//
public class MakeSofa : FactoryMethod
{
    public Product createProduct(int taille, int couleur)
    {
        return new Sofa(taille, couleur);
    }

    public Product newProduct()
    {
        return new Sofa();
    }
}

public class MakeMeuble: FactoryMethod
{
    public Product createProduct(int taille, int couleur)
    {
        return new Meuble(taille, couleur);
    }

    public Product newProduct()
    {
        return new Meuble();
    }
}
// Note:
//      Beaucoup de personne en ligne presente la factory de cette maniere
//
//      public constructor(enum type) {
//          if(type.1)
//          {
//              return constructeurType1()
//          }
//          else if(type.2) 
//          {
//              return constructeurType2()
//          }
//          etc...
//      }      
//
//      Probleme:
//          L'implementation du constructeur est fortement relier avec l'implementation du Enum
//          tous les fois que tu modifis l'Enum tu dois te rappeller de modifier le constructeur
//          
//      Ceci est un anti-pattern, souvent une parfaite opportunitee d'etre remplacer par la factory methode pattern, 
//      En reprenant mon exemple, si je veux commencer a produire des chaises je peux juste creer un subclass MakeChaise et un subclasse Chaise



// le reste de l'exemple

// la fonctionnalite
public interface Product
{
    public void WhoAmI();
}


// les implementations
public class Sofa : Product
{
    private int taille  { get; set; }
    private int couleur { get; set; } // couleur est un chiffre arbitraire pour exemple


    internal Sofa() //constructeur par default
    {
        this.taille  = 100;
        this.couleur = 1;
    }
    internal Sofa(int taille, int couleur)
    {
        this.taille  = taille;
        this.couleur = couleur;
    }



    public void WhoAmI()
    {
        Console.WriteLine($"I'm a sofa [ taille: {taille}, couleur: {couleur} ]");
    }
}


public class Meuble : Product
{ 
    private int taille { get; set; }
    private int couleur { get; set; } // couleur est un chiffre arbitraire pour exemple


    internal Meuble() //constructeur par default
    {
        this.taille = 150;
        this.couleur = 1;
    }
    internal Meuble(int taille, int couleur)
    {
        this.taille = taille;
        this.couleur = couleur;
    }



    public void WhoAmI()
    {
        Console.WriteLine($"I'm a Meuble [ taille: {taille}, couleur: {couleur} ]");
    }
}

