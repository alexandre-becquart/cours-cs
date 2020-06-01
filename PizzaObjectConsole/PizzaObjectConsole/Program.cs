using System;
using System.Collections.Generic;

namespace PizzaObjectConsole
{
    class MainClass
    {
        //nom, prix, afficher(

        class Pizza
        {
            public static Pizza dernierPizzaCree;

            // STATIC global à toute la classe 

            private String nom;
            private int prix;

            //constructeur
            public Pizza(string nom, int prix)
            {
                this.nom = nom;
                this.prix = prix;
                dernierPizzaCree = this;
            }
            public void Afficher()
            {
                
                    Console.WriteLine("Pizza: " + nom + " - " + prix + "€");
            }
            //public int GetPrix()
            //{
            //    return prix;
            //}

            public int Prix
            {
                get { return prix;  }
                //set
                //{
                //    //prix = value;
                //    Console.WriteLine("Vous ne pouvez pas modifier le prix d'une pizza! (valeur: " + value + ")");
                //}
            }

            public static void AfficherDernierePizza()
            {
                if (dernierPizzaCree == null)
                {
                    Console.WriteLine("Vous n'avez pas créer dernère pizza");
                }
                else
                {
                    Console.WriteLine("** DERNIERE PIZZA CREE **");
                    dernierPizzaCree.Afficher();
                }
              

            }
        }

        

        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            List<Pizza> pizzas = new List<Pizza>();
            pizzas.Add(new Pizza("quatre fromage", 11));
            pizzas.Add(new Pizza("italienne", 12));
            pizzas.Add(new Pizza("montagnarde", 15));
            pizzas.Add(new Pizza("norvégienne", 16));
            pizzas.Add(new Pizza("végétarienne", 9));

            //pizzas[0].Prix = 200;

            pizzas.Sort((Pizza x, Pizza y) =>
            {
                //première solution pour éviter modification de prix
                //return x.GetPrix().CompareTo(y.GetPrix());

                return x.Prix.CompareTo(y.Prix);

            });

            foreach (Pizza p in pizzas)
            {
                p.Afficher();

            }

            Console.WriteLine("");

            Pizza.AfficherDernierePizza();

        }
    }
}
