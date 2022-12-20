using System;

namespace composition{
    public class Ordinateur{
        // L'ordinateur est composé d'un processeur et de deux disques durs.
        // Il y a une relation entre Ordinateur avec Processeur et DisqueDur.
        public Processeur processeur { get; set; }
        public DisqueDur DisqueDur1 { get; set; }
        public DisqueDur DisqueDur2 { get; set; }

        public Ordinateur( Processeur processeur, DisqueDur DisqueDur1, DisqueDur DisqueDur2){
            this.processeur = processeur;
            this.DisqueDur1 = DisqueDur1;
            this.DisqueDur2 = DisqueDur2;
        }

        public override string ToString(){
            return $"L'ordinateur à un processeur {processeur.Marque} avec {processeur.NombreCoeurs} coeurs. Et un disque dur qui a {DisqueDur1.Capacite} en capacite de stockage et {DisqueDur1.VitesseLecture} en vitesse de lecture, et un autre disque dur qui a {DisqueDur2.Capacite} en capacite de stockage et {DisqueDur2.VitesseLecture} en vitesse de lecture.";

        }
    }

    // Classe Processeur du même "niveau" que Ordinateur et DisqueDur
    public class Processeur{
        // Le Processeur est composé d'une Marque de sont NombreCoeurs
        public string Marque { get; set; }
        public int NombreCoeurs { get; set; }

        public Processeur(string Marque, int NombreCoeurs){
            this.Marque = Marque;
            this.NombreCoeurs = NombreCoeurs;
        }
    }

    // Classe DisqueDur du même "niveau" que Processeur et Ordinateur
    public class DisqueDur{
        // Le DisqueDur est composé d'une Capacite de sa VitesseLecture
        public int Capacite { get; set; }
        public int VitesseLecture { get; set; }

        public DisqueDur(int Capacite, int VitesseLecture){
            this.Capacite = Capacite;
            this.VitesseLecture = VitesseLecture;
        }
    }

    public class Prog{
        static void Main(string[] args){
            DisqueDur disqueDurA = new DisqueDur(20,10);
            DisqueDur disqueDurB = new DisqueDur(30,10);

            Processeur processeur = new Processeur("intel",9);

            Ordinateur ordinateur = new Ordinateur(processeur,disqueDurA,disqueDurB);

            ordinateur.ToString();
            Console.Write($"L'ordinateur à un processeur {ordinateur.processeur.Marque} avec {ordinateur.processeur.NombreCoeurs} coeurs. Et un disque dur qui a {ordinateur.DisqueDur1.Capacite} en capacite de stockage et {ordinateur.DisqueDur1.VitesseLecture} en vitesse de lecture, et un autre disque dur qui a {ordinateur.DisqueDur2.Capacite} en capacite de stockage et {ordinateur.DisqueDur2.VitesseLecture} en vitesse de lecture.");
        }
    }
}