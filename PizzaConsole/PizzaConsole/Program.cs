using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaConsole
{
    class MainClass
    {
        private static void AfficherListe( List<String> liste)
        {
            foreach (String p in liste)
            {
                Console.WriteLine(p);
            }

        }
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Etape 1

            //List<int> liste = new List<int>();

            //while (true)
            //{
            //    Console.Write("Prix de l'article en euros, ou rien pour terminer la saisie: ");
            //    String prix = Console.ReadLine();
            //    int prixNum = 0;
            //    if (int.TryParse(prix, out prixNum))
            //    {
            //        liste.Add(prixNum);
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}

            //// Tableaux (Array)

            ////const int NB_ELEMENTS = 4;
            ////int[] tableau = new int[NB_ELEMENTS] {1, 3, 5, 10 };


            //int somme = 0;
            //foreach (var a in liste)
            //{
            //    somme += a;
            //}

            //Console.WriteLine("La somme total est de " + somme + " euros pour " + liste.Count + " articles");

            //Console.WriteLine("");

            //int i = 0;

            //foreach (int a in liste)
            //{
            //    if (i == liste.Count-1)
            //    {
            //        Console.Write(a);
            //    }
            //    else
            //    {
            //        Console.Write(a + ", ");

            //    }
            //    i++;
            //}

            //Etape 2

            //String[] nomPizzas = { "quatre fromages", "tartiflette", "margherita", "indienne", "mexicaine", "chèvre et miel" };

            //convertir le tableau en liste

            //List<String> ListePizzas = new List<string>(nomPizzas);

            //  avec Linq

            //List<String> ListePizzas = nomPizzas.ToList();

            //ListePizzas.Add("végétarienne");


            //ListePizzas.Sort();
            //ListePizzas.Reverse();

            //ListePizzas.RemoveAt(0);


            //for (int i = ListePizzas.Count()-1; i >= 0;  i--)
            //{
            //    String pizza = ListePizzas[i];
            //    int longeur = pizza.Length;
            //    if (pizza[longeur -1] == 'e')
            //    {
            //        ListePizzas.Remove(pizza);
            //    }

            //}


            //Affiche la liste des pizza
            //foreach (String pizza in ListePizzas)
            //{


            //        Console.WriteLine(pizza);

            //}

            //Exercice

            const int NB_PIZZA_INIT = 10;

            List<String> pizzas = new List<String>();

            for (int i = 0; i < NB_PIZZA_INIT; i++)
            {
                pizzas.Add("pizza " + (i + 1));
            }

            while (true)
            {
                Console.Write("Rentrez votre pizza (ou rien pour terminer): ");
                String pizza = Console.ReadLine();

                if (pizza.Length == 0)
                {
                    break;
                }
                else
                {
                    pizzas.Add(pizza);
                }



            }

            AfficherListe(pizzas);


        }
    }
}
