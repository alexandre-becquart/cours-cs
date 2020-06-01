using System;

namespace nb_magique_console
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            const int NOMBRE_MAGIQUE_MIN = 10;
            const int NOMBRE_MAGIQUE_MAX = 100;

            Random random = new Random();

            int nombreMagique = random.Next(NOMBRE_MAGIQUE_MIN, NOMBRE_MAGIQUE_MAX);

            const int NOMBRE_DE_VIES = 4;
            int nombreDeVies = NOMBRE_DE_VIES;


            // Avec FOR

            //const int NOMBRE_DE_VIES = 5;

            //for (nombreDeVies = NOMBRE_DE_VIES; nombreDeVies > 0; nombreDeVies--)
            //{

            //    Console.Write("Devinez le nombre magique entre "+ NOMBRE_MAGIQUE_MIN + " et "+ NOMBRE_MAGIQUE_MAX + "(il vous reste " + nombreDeVies + " vies) : ");
            //    String resultat = Console.ReadLine();

            //    int nombreUtilisateur = 0;

            //    if (int.TryParse(resultat, out nombreUtilisateur))
            //    {

            //        if(nombreUtilisateur > NOMBRE_MAGIQUE_MAX || nombreUtilisateur < NOMBRE_MAGIQUE_MIN)
            //        {
            //            Console.WriteLine("ERREUR : Vous devez entrez un nombre entre " + NOMBRE_MAGIQUE_MIN + " et " + NOMBRE_MAGIQUE_MAX);
            //            nombreDeVies++;
            //        }
            //        else
            //        {
            //            //la conversion s'est bien passée
            //            if (nombreMagique > nombreUtilisateur)
            //            {
            //                Console.WriteLine("Le nombre magique est plus grand que " + nombreUtilisateur);
            //                //nombreDeVies--;
            //            }
            //            else if (nombreMagique < nombreUtilisateur)
            //            {
            //                Console.WriteLine("Le nombre magique est plus petit que " + nombreUtilisateur);
            //                //} else if (nombreMagique == nombreUtilisateur)
            //                //nombreDeVies--;

            //            }
            //            else
            //            {
            //                //égalité on a gagné
            //                Console.WriteLine("BRAVO les nombre magique est bien : " + nombreUtilisateur);
            //                break;
            //            }
            //        }


            //    }
            //    else
            //    {
            //        //Erreur de la conversion
            //        Console.WriteLine("ERREUR: Vous devez rentrer un nombre.");
            //    }
            //    Console.WriteLine("");


            //}
            //if (nombreDeVies == 0)
            //{
            //    Console.WriteLine("Désolé, vous avez perdu, le nombre magique était : " + nombreMagique);
            //}



            // AVEC UN WHILE


            //while (true)
            while (nombreDeVies > 0)
                {

                    Console.Write("Devinez le nombre magique (il vous reste " + nombreDeVies + " vies) : ");
                     String resultat = Console.ReadLine();

                    int nombreUtilisateur = 0;

                    if (int.TryParse(resultat, out nombreUtilisateur))
                    {
                    if (nombreUtilisateur > NOMBRE_MAGIQUE_MAX || nombreUtilisateur < NOMBRE_MAGIQUE_MIN)
                    {
                        Console.WriteLine("ERREUR : Vous devez entrez un nombre entre " + NOMBRE_MAGIQUE_MIN + " et " + NOMBRE_MAGIQUE_MAX);
                        //nombreDeVies++;
                    }
                    else
                    {
                        //la conversion s'est bien passée
                        if (nombreMagique > nombreUtilisateur)
                        {
                            Console.WriteLine("Le nombre magique est plus grand que " + nombreUtilisateur);
                            //nombreDeVies--;
                        }
                        else if (nombreMagique < nombreUtilisateur)
                        {
                            Console.WriteLine("Le nombre magique est plus petit que " + nombreUtilisateur);
                            //} else if (nombreMagique == nombreUtilisateur)
                            //nombreDeVies--;

                        }
                        else
                        {
                            //égalité on a gagné
                            Console.WriteLine("BRAVO les nombre magique est bien : " + nombreUtilisateur);
                            break;
                        }
                        nombreDeVies--;
                    }
                }
                else
                    {
                        //Erreur de la conversion
                        Console.WriteLine("ERREUR: Vous devez rentrer un nombre.");
                    }
                    Console.WriteLine("");


                }
            if (nombreDeVies == 0)
            {
                Console.WriteLine("Désolé, vous avez perdu, le nombre magique était: " + nombreMagique);
            }

        }
    }
}
