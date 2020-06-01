using System;

namespace jeu_de_maths
{
    class MainClass
    {

        const int MIN = 1;
        const int MAX = 10;
        const int NB_QUESTIONS = 5;

        static Random random = new Random();

        enum OPERATEUR
        {
            ADDITION,
            MULTIPLICATION,
            SOUSTRACTION,
            DIVISON
        }


        private static OPERATEUR GetOperateur()
        {
            int operateur = random.Next(1, 4);
            if (operateur==1)
            {
                return OPERATEUR.ADDITION;
            }
            else if (operateur == 2)
            {
                return OPERATEUR.MULTIPLICATION;
            }
            //else if (operateur == 3)
            //{
            //    return OPERATEUR.SOUSTRACTION;
            //}

            return OPERATEUR.SOUSTRACTION;
        }
        

        private static bool DemanderOperation()
        {

            //int point = 0;

            int a = random.Next(MIN, MAX);
            int b = random.Next(MIN, MAX);
            OPERATEUR operateur = GetOperateur();
            int resultatOperation = 0;

            while(true)
            {
                switch (operateur)
                {
                    case OPERATEUR.ADDITION:
                        {
                            Console.Write("Combien font " + a + " + " + b + " ? :");
                            resultatOperation = a + b;
                        }
                        break;
                    case OPERATEUR.MULTIPLICATION:
                        {
                            Console.Write("Combien font " + a + " * " + b + " ? :");
                            resultatOperation = a * b;
                        }
                        break;
                    case OPERATEUR.SOUSTRACTION:
                        {
                            if (a < b)
                            {
                                int temp = a;
                                a = b;
                                b = temp;
                            }
                            Console.Write("Combien font " + a + " - " + b + " ? :");
                            resultatOperation = a - b;
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("ERREUR, ce cas n'est pas géré dans le code");
                            Environment.Exit(0);
                        }
                        break;

                }

                //if(operateur == OPERATEUR.ADDITION)
                //{
                //    //addition
                //    Console.Write("Combien font " + a + " + " + b + " ? :");
                //    resultatOperation = a + b;
                //}
                //else if (operateur == OPERATEUR.MULTIPLICATION)
                //{
                //    //multiplication
                //    Console.Write("Combien font " + a + " * " + b + " ? :");
                //    resultatOperation = a * b;
                //}
                //else if (operateur == OPERATEUR.SOUSTRACTION)
                //{
                //    //soustraction
                //    if (a < b)
                //    {
                //        int temp = a;
                //        a = b;
                //        b = temp;
                //    }
                //    Console.Write("Combien font " + a + " - " + b + " ? :");
                //    resultatOperation = a - b;
                //}


                String resultat = Console.ReadLine();

                int nombreUtilisateur = 0;

                if (int.TryParse(resultat, out nombreUtilisateur))
                {
                    if (nombreUtilisateur == resultatOperation)
                    {
                        Console.WriteLine("BRAVO : Vous avez trouvez la bonne réponse :) ! ");
                        return true;
                        //point++;

                    }
                    else
                    {
                        Console.WriteLine(nombreUtilisateur + ", ce n'est pas la bonne réponse. Réssayez !");
                        return false;
                    }

                }
                else
                {
                    Console.WriteLine("ERREUR: Vous devez renter un nombre");
                  
                }

                Console.WriteLine("");
                
            }

        }
        private static void AfficherResultat(int nbPoints )
        {

            if (nbPoints == NB_QUESTIONS)
            {
                Console.WriteLine(nbPoints + "/" + NB_QUESTIONS + " : Bravo!");
            }
            else if (nbPoints == 0)
            {
                Console.WriteLine(nbPoints + "/" + NB_QUESTIONS + " Révisez vos maths");
            }
            else if (nbPoints <= (NB_QUESTIONS / 2))
            {
                Console.WriteLine(nbPoints + "/" + NB_QUESTIONS + " Peut mieux faire");

            }
            else
            {
                Console.WriteLine(nbPoints + "/" + NB_QUESTIONS + " Pas mal!");

            }
        }


        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int nbPoints = 0;

            for (int i = 0; i < NB_QUESTIONS; i++)
            {
                Console.WriteLine("Question n°" + (i + 1) + "/" + NB_QUESTIONS);
                if (DemanderOperation())
                {
                    nbPoints++;
                }
            

                Console.WriteLine("");
            }

            AfficherResultat(nbPoints);
            

        }
    }
}
