using System;

namespace heritage{
    public class Animal{
        // L'Animal est composé d'un Nom de sont Age.
        public string Nom { get; set; }
        protected int Age { get; set; }

        public Animal(string Nom, int Age){
            this.Nom = Nom;
            this.Age = Age;
        }

        // Définition d'une méthode de classe DanseFortnite que le chat et c'est enfants peuvent utiliser.
        public void DanseFortnite(){
            Console.WriteLine("L'animal effectue une danse Fortnite");
        }
        public virtual void Crie(){}
    }

    // Classe Chat qui hérite de classe Animal. C'est donc une classe fille de la classe Animal.
    public class Chat : Animal{
        // Le Chat qui hérite de Animal est composé d'un Nom et de sont Age ET de sa CouleurPelage.
        public string CouleurPelage { get; set; }

        public Chat(string Nom, int Age, string CouleurPelage):base(Nom, Age){
            this.CouleurPelage = CouleurPelage;
        }

        // Définition d'une méthode de classe Miauler que le chat et c'est enfant peuvent utiliser.
        // Le parents Animal ne peu pas utiliser la méthode Miauler().
        public override void Crie()
        {
            Console.WriteLine("jul jul jul");
        }
    }

    public class Prog{
        static void Main(string[] args){
            Animal animal = new Animal("Dragon", 1000);
            Animal chat = new Chat("chat", 1, "vert");

            animal.DanseFortnite();
            chat.Crie();
            chat.DanseFortnite();
        }
    }
}