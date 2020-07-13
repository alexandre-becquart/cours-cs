using System;
using System.Collections.Generic;

namespace PizzaObjectConsole
{
    class MainClass
    {
        //nom, prix, Afficher()

        class Pizza
        {
            // static global à toute la classe
            private static Pizza dernierePizzaCree;
            private static Pizza pizzalLaMoinschere;
            private static Pizza pizzalLaPlusChere;

            private string nom;
            private int prix;

            //Constructor
            public Pizza(string nom, int prix)
            {
                this.nom = nom;
                this.prix = prix;

                dernierePizzaCree = this;

                if (pizzalLaMoinschere == null)
                {
                    pizzalLaMoinschere = this;
                }
                else
                {
                    if (prix < pizzalLaMoinschere.prix)
                    {
                        pizzalLaMoinschere = this;
                    }
                }

                if (pizzalLaPlusChere == null)
                {
                    pizzalLaPlusChere = this;
                }
                else
                {
                    if (prix > pizzalLaPlusChere.prix)
                    {
                        pizzalLaPlusChere = this;
                    }
                }

                
            }

            public void Afficher()
            {
                Console.WriteLine("Pizza: " + nom + " - " + prix + "€");
            }

            public int Prix
            {
                get { return prix; }
                //set {
                //    //prix = value;
                //    Console.WriteLine("ERREUR: Vous ne devez pas modifier le prix d'une pizza! (Valeur: "+ value + ")");
                //}
            }

            //public int GetPrix()
            //{
            //    return prix;
            //}

            public static void AfficherLaDernierePizza()
            {
                if (dernierePizzaCree == null)
                {
                    Console.WriteLine("Erreur: Vous n'avez pas créé de pizza");
                }
                else
                {
                Console.WriteLine("** DERNIERE PIZZA CREE **");
                //Console.WriteLine("Dernière pizza: " + nomDernierePizzaCree);
                //Console.WriteLine(nomDernierePizzaCree);
                dernierePizzaCree.Afficher();

                }

            }

            public static void AfficherPizzaMoinsChere()
            {
                

            }

        }


        

        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //Pizza.AfficherLaDernierePizza();

            List<Pizza> pizzas = new List<Pizza>();
            pizzas.Add(new Pizza("Quatre fromages", 11));
            pizzas.Add(new Pizza("Norvégienne", 16));
            pizzas.Add(new Pizza("Normande", 12));
            pizzas.Add(new Pizza("Montagnarde", 15));
            pizzas.Add(new Pizza("Végétarienne", 9));

            //pizzas[0].Prix = 200;

            pizzas.Sort((Pizza x, Pizza y) =>
            {
                return x.Prix.CompareTo(y.Prix);
                //return x.GetPrix().CompareTo(y.GetPrix());

                //variable en public 
                //return x.prix.CompareTo(y.prix);

                //return x.prix - y.prix;
            });

            foreach (var pizza in pizzas)
            {
                pizza.Afficher();
                
            }
            Console.WriteLine("");

            //Pizza.AfficherLaDernierePizza();

        }
    }
}
