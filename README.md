# Tuto relation (Relation ship)

## Association

**L'association est une relation entre deux classes en C# qui indique que l'une des classes utilise l'autre de manière occasionnelle.** Cette relation est généralement implémentée en créant une instance de la classe utilisée dans l'autre classe, comme un champ membre.

Voici un exemple d'association en C# :

```C#
// Classe Client du même "niveau" que Adresse.
public class Client
{
    // Le client a une adresse
    public Adresse Adresse { get; set; }
}

// Classe Adresse du même "niveau" que Client.
public class Adresse
{
    public string Rue { get; set; }
    public string Ville { get; set; }
    public string CodePostal { get; set; }
}
```

Dans cet exemple, la classe Client a une association avec la classe Adresse, car elle a un champ membre de type Adresse. Cependant, l'association est faible, car la classe Client n'a pas besoin de la classe Adresse pour exister. Si la classe Adresse était supprimée, la classe Client pourrait être modifiée pour utiliser une autre classe ou une simple chaîne de caractères pour stocker l'adresse.


## Héritage

**L'héritage est une relation entre deux classes en C# qui permet à une classe (appelée "classe fille") d'hériter de tous les membres (champs, propriétés, méthodes, etc.) d'une autre classe (appelée "classe mère").** La classe fille peut également redéfinir ou étendre les membres hérités.
Le C# n'autorise que l'héritage simple. C'est à dire qu'une classe ne peut hériter que d'une seule autre classe.

Voici un exemple d'héritage en C# :

```C#
// Classe principal du programme
public class Animal
{
    // L'Animal est composé d'un Nom de sont Age.
    public string Nom { get; set; }
    protected int Age { get; set; }

    // Définition d'une méthode de classe DanseFortnite que le chat et c'est enfants peuvent utiliser.
    public void DanseFortnite()
    {
        Console.WriteLine("L'animal effectue une danse Fortnite");
    }
}

// Classe Chat qui hérite de classe Animal. C'est donc une classe fille de la classe Animal.
public class Chat : Animal
{
    // Le Chat qui hérite de Animal est composé d'un Nom et de sont Age ET de sa CouleurPelage.
    public string CouleurPelage { get; set; }

    // Définition d'une méthode de classe Miauler que le chat et c'est enfant peuvent utiliser.
    // Le parents Animal ne peu pas utiliser la méthode Miauler().
    public void Miauler()
    {
        Console.WriteLine("jul jul jul");
    }
}
```

Dans cet exemple, la classe Chat hérite de la classe Animal et peut donc utiliser tous les membres de cette classe, comme le nom et l'âge, ainsi que la méthode DanseFortnite().


## Agregation et composition

Une agrégation modélise la relation "se compose de" entre deux classes. Si un objet A est composé d'un objet B, alors B peut vivre sans A.
La composition est une relation entre deux classes en C# qui indique que l'une des classes est constituée de l'autre de manière essentielle.** Cette relation est généralement implémentée en créant une instance de la classe composée dans l'autre classe, comme un champ membre.

```C#
public class Employe
  {
      // Agrégation
      private Projet ProjetCourant;
      // Composition - On crée une instance de salaire
      // à l'intérieur de notre objet Employe
      private Salaire salaire = new Salaire();
 
      // Le projet sur lequel travaille de salarié
      // est passé en paramètre du constructeur
      public Employe(Projet projet, int salaire)
      {
          this.salaire.Annuel = salaire;
          this.ProjetCourant = projet;
      }
  }
 
  public class Salaire
  {
      public int Annuel { get; set; }
  }
 
  public class Projet
  {
      public string Nom { get; set; }
  }
```

Voici un exemple de composition en C# :

```C#
// Classe Ordinateur du même "niveau" que Processeur et DisqueDur.
public class Ordinateur
{
    // L'ordinateur est composé d'un processeur et de deux disques durs.
    // Il y a une relation entre Ordinateur avec Processeur et DisqueDur.
    public Processeur processeur { get; set; }
    public DisqueDur DisqueDur1 { get; set; }
    public DisqueDur DisqueDur2 { get; set; }

    // Il est aussi possible de créer une méthode AfficherDetailsProcesseur() pour apeller Processeur.AfficherDetails().
    public void AfficherDetailsProcesseur()
    {
        Processeur.AfficherDetails();
    }
}

// Classe Processeur du même "niveau" que Ordinateur et DisqueDur.
public class Processeur
{
    // Le Processeur est composé d'une Marque de sont NombreCoeurs.
    public string Marque { get; set; }
    public int NombreCoeurs { get; set; }

    // Méthode Processeur dans AfficherDetails().
    public void AfficherDetails()
    {
        Console.WriteLine($"Marque: {Marque}");
        Console.WriteLine($"Nombre de coeurs: {NombreCoeurs}");
    }
}

// Classe DisqueDur du même "niveau" que Processeur et Ordinateur.
public class DisqueDur
{
    // Le DisqueDur est composé d'une Capacite de sa VitesseLecture.
    public int Capacite { get; set; }
    public int VitesseLecture { get; set; }
}
```
Dans cet exemple, la classe Ordinateur est composée de la classe Processeur et de la classe DisqueDur, car elle a des champs membres de ces types. La composition est forte, car la classe Ordinateur ne peut exister sans ces classes. Si l'une des classes composées était supprimée, la classe Ordinateur ne pourrait plus être utilisée.

En général, la composition est utilisée pour créer des objets plus complexes à partir de classes plus simples, tandis que l'héritage est utilisé pour partager du code commun entre classes.

=======

## Agregation

Une agrégation modélise la relation "se compose de" entre deux classes. Si un objet A est composé d'un objet B, alors B peut vivre sans A.

```C#
public class Employe
{
    private Projet Emploi;
    public Employe(Projet emploi)
    {
        this.Emploi = emploi;
    }
}

public class Emploi 
{
    public string taf {get; set;}
}
```

## Héritage

**L'héritage est une relation entre deux classes en C# qui permet à une classe (appelée "classe fille") d'hériter de tous les membres (champs, propriétés, méthodes, etc.) d'une autre classe (appelée "classe mère").** La classe fille peut également redéfinir ou étendre les membres hérités.
Le C# n'autorise que l'héritage simple. C'est à dire qu'une classe ne peut hériter que d'une seule autre classe.

Voici un exemple d'héritage en C# :

```C#
// Classe principal du programme.
public class Animal
{
    // L'Animal est composé d'un Nom de sont Age.
    public string Nom { get; set; }
    protected int Age { get; set; }

    // Définition d'une méthode de classe DanseFortnite que le chat et c'est enfants peuvent utiliser.
    public void DanseFortnite()
    {
        Console.WriteLine("L'animal effectue une danse Fortnite");
    }
}

// Classe Chat qui hérite de classe Animal. C'est donc une classe fille de la classe Animal.
public class Chat : Animal
{
    // Le Chat qui hérite de Animal est composé d'un Nom et de sont Age ET de sa CouleurPelage.
    public string CouleurPelage { get; set; }

    // Définition d'une méthode de classe Miauler que le chat et c'est enfant peuvent utiliser.
    // Le parents Animal ne peu pas utiliser la méthode Miauler().
    public void Miauler()
    {
        Console.WriteLine("jul jul jul");
    }
}
```

Dans cet exemple, la classe Chat hérite de la classe Animal et peut donc utiliser tous les membres de cette classe, comme le nom et l'âge, ainsi que la méthode DanseFortnite().
