using System;
using System.Collections.Generic;

namespace PizzaObjectConsole
{
    class MainClass
    {
        //nom, prix, afficher(

        class Pizza
        {
            public string nom;
            public int prix;

            public Pizza(string nom, int prix)
            {
                this.nom = nom;
                this.prix = prix;
            }

            public void Afficher()
            {
                Console.WriteLine("Pizza: " + nom + "-" + prix + "€");
            }

        }

        

        public static void Main(string[] args)
        {
            List<Pizza> pizzas = new List<Pizza>();
            //Pizza maPizza = new Pizza("Quatre Fromage", 11);
            pizzas.Add( new Pizza("quatre Fromage", 11));
            pizzas.Add( new Pizza("norvegienne", 16));
            pizzas.Add( new Pizza("normande", 12));
            pizzas.Add( new Pizza("montagnarde", 15));
            pizzas.Add( new Pizza("végétarienne", 9));
            //maPizza.Afficher();

            pizzas.Sort((Pizza x, Pizza y) =>
            {
                return x.prix.CompareTo(y.prix);
            });

            foreach (Pizza p in pizzas)
            {
                p.Afficher();
            }

        }
    }
}
