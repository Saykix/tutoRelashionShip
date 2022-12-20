# Tuto relation (Relation ship)

## Association

L'association est une relation entre deux classes en C# qui indique que l'une des classes utilise l'autre de manière occasionnelle. Cette relation est généralement implémentée en créant une instance de la classe utilisée dans l'autre classe, comme un champ membre.

Voici un exemple d'association en C# :

```C#
public class Client
{
    // Le client a une adresse
    public Adresse Adresse { get; set; }
}

public class Adresse
{
    public string Rue { get; set; }
    public string Ville { get; set; }
    public string CodePostal { get; set; }
}
```

Dans cet exemple, la classe Client a une association avec la classe Adresse, car elle a un champ membre de type Adresse. Cependant, l'association est faible, car la classe Client n'a pas besoin de la classe Adresse pour exister. Si la classe Adresse était supprimée, la classe Client pourrait être modifiée pour utiliser une autre classe ou une simple chaîne de caractères pour stocker l'adresse.

## Composition

La composition est une relation entre deux classes en C# qui indique que l'une des classes est constituée de l'autre de manière essentielle. Cette relation est généralement implémentée en créant une instance de la classe composée dans l'autre classe, comme un champ membre.

Voici un exemple de composition en C# :

```C#
public class Ordinateur
{
    // L'ordinateur est composé d'un processeur et de deux disques durs
    public Processeur Processeur { get; set; }
    public DisqueDur DisqueDur1 { get; set; }
    public DisqueDur DisqueDur2 { get; set; }
}

public class Processeur
{
    public string Marque { get; set; }
    public int NombreCoeurs { get; set; }
}

public class DisqueDur
{
    public int Capacite { get; set; }
    public int VitesseLecture { get; set; }
}
```
Dans cet exemple, la classe Ordinateur est composée de la classe Processeur et de la classe DisqueDur, car elle a des champs membres de ces types. La composition est forte, car la classe Ordinateur ne peut exister sans ces classes. Si l'une des classes composées était supprimée, la classe Ordinateur ne pourrait plus être utilisée.

En général, la composition est utilisée pour créer des objets plus complexes à partir de classes plus simples, tandis que l'héritage est utilisé pour partager du code commun entre classes.


## Héritage

L'héritage est une relation entre deux classes en C# qui permet à une classe (appelée "classe fille") de hériter de tous les membres (champs, propriétés, méthodes, etc.) d'une autre classe (appelée "classe mère"). La classe fille peut également redéfinir ou étendre les membres hérités.

Voici un exemple d'héritage en C# :

```C#
// Classe principal
public class Animal
{
    public string Nom { get; set; }
    public int Age { get; set; }

    public void Bouger()
    {
        Console.WriteLine("L'animal bouge.");
    }
}

// Classe Chat qui hérite de classe Animal
public class Chat : Animal
{
    public string CouleurPelage { get; set; }

    public void Miauler()
    {
        Console.WriteLine("jul jul jul");
    }
}
```

Dans cet exemple, la classe Chat hérite de la classe Animal et peut donc utiliser tous les membres de cette classe, comme le nom et l'âge, ainsi que la méthode Bouger().