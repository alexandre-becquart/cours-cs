using System;

namespace HelloWorld
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("quel est votre nom ?");
            String nom  = Console.ReadLine();

            Console.WriteLine("Quel est votre age ?");
            String age = Console.ReadLine();

            int ageNum = 0;

            if (int.TryParse(age, out ageNum) == true)
            {
                ageNum++;
                Console.WriteLine("Vous vous appelez " + nom + ", vous avez " + age + " ans. l'an prochain vous aurez " + ageNum + " ans.");

            }
            else
            {
                Console.WriteLine("Votre age doit être un nombre ! ");
            };

            

            //Console.WriteLine("Bonjour vous vous appelez " +nom);


        }
    }
}
