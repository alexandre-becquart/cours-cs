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

            //private, protected, public
            protected string nom;
            private int prix;
            protected string[] ingredients;
            //Constructor
            public Pizza(string nom, int prix, string[] ingredients)
            {
                this.nom = nom;
                this.prix = prix;
                this.ingredients = ingredients;

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

            virtual public void Afficher()
            {
                Console.WriteLine("Pizza: " + nom + " - " + prix + "€");
                Console.WriteLine(String.Join(",", ingredients));
                Console.WriteLine(" ");
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

            public static void AfficherPizzaMoinsChereEtPlusChere()
            {
                if (pizzalLaMoinschere != null)
                {
                    Console.WriteLine("** PIZZA LA MOINS CHERE **");
                    pizzalLaMoinschere.Afficher();
                }
                if (pizzalLaPlusChere != null)
                {
                    Console.WriteLine("** PIZZA LA PLUS CHERE **");
                    pizzalLaPlusChere.Afficher();
                }

            }

            

        }

        class PizzaGratuite: Pizza
        {
            public PizzaGratuite(string nom, string[] ingredients):base(nom, 0, ingredients)
            {

            }

            override public void Afficher()
            {
                Console.WriteLine("Pizza: " + nom + " GRATUIT");
                Console.WriteLine(String.Join(",", ingredients));
                Console.WriteLine(" ");
            }
        }
        

        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //Pizza.AfficherLaDernierePizza();

            List<Pizza> pizzas = new List<Pizza>();
            pizzas.Add(new Pizza("Quatre fromages", 11, new string[] {"brie", "mozzarella", "gruyere", "emmentale"}));
            pizzas.Add(new Pizza("Norvégienne", 16, new string[] { "saumon Fumé", "tomates"}));
            pizzas.Add(new Pizza("Normande", 12, new string[] {"brie", "pommes", "oignons"}));
            pizzas.Add(new Pizza("Montagnarde", 15, new string[] { "roblochon ", "pommes de terre", "gruyere" }));
            pizzas.Add(new Pizza("Végétarienne", 9, new string[] { "tomates", "oignons", "poivrons", "olives" }));
            pizzas.Add(new PizzaGratuite("tomate", new string[] { "tomates" }));


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

            Pizza.AfficherPizzaMoinsChereEtPlusChere();

        }
    }
}
