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

Il est important de bien comprendre l'association et de l'utiliser de manière appropriée afin de créer un code bien structuré et facile à maintenir.

## Composition

## Héritage
l'Héritage permet de définir une classe enfant qui hérite réutilise, étend ou modifie les comportements de sa classe parent. Cette classe est appelée la "classe dérivée"
Le C# n'autorise que l'héritage simple, c'est à dire qu'une classe ne peut hériter que d'une seule autre classe.

```C#
public class Personne
{
int Age;
char Nom;
char Prenom;
}

public class Eleve : Personne
{
    int Classement;
}
```