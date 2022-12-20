using System;

namespace association{
    public class Client{
        
        public int id{get; set;}
        public Adresse Adresse { get; set; }

        public Client(Adresse Adresse, int id){
            this.Adresse = Adresse;
            this.id = id; 
        }
    }

    public class Adresse{
        public string Rue { get; set; }
        public string Ville { get; set; }
        public string CodePostal { get; set; }

        public Adresse(string Rue, string Ville, string CodePostal){
            this.Rue = Rue;
            this.Ville = Ville;
            this.CodePostal = CodePostal;
        }
    }

    public class Prog{
        static void Main(string[] args){
            Adresse adresse = new Adresse("29 rue Charle de Gaule","Brest","29200");
            Client Thomas = new Client(adresse,1);
            Console.Write("id client: {0}, adresse client: {1} {2} {3}", Thomas.id,Thomas.Adresse.Rue,Thomas.Adresse.Ville, Thomas.Adresse.CodePostal);
        }
    }
}