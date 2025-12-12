using System;

namespace Denombrements
{
    class Program
    {
        /// <summary>
        /// Permet d'afficher une message et de renvoyer la réponse de l'utilisateur
        /// </summary>
        /// <param name="message">message à afficher</param>
        /// <returns>valeur entrée par l'utilisateur en format int</returns>
        static int Ask(string message)
        {
            Console.Write(message); // saisir le message
            return int.Parse(Console.ReadLine()); // saisir le nombre et le retourner
        }
        /// <summary>
        /// Remplace une boucle for calculant la somme de la multiplication d'une suite d'entiers, d'une valeur à une autre
        /// </summary>
        /// <param name="t">valeur maximale contenu dans la multiplication</param>
        /// <param name="n">valeur minimale contenu dans la multiplication</param>
        /// <returns>valeur de la multiplication</returns>
        static long Boucle(int t, int n)
        {
            long r = t;
            for (int k = (t - 1); k >= n+1; k--)
            {
                r *= k;
            }
            return r;
        }

        static void Main(string[] args)
        {
            string messTotal = "nombre total d'éléments à gérer = ";
            string messElem = "nombre d'éléments dans le sous ensemble = ";
            int c = 5;
            while (c != 0)
            {
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");
                Console.Write("Choix :                            ");
                try
                {
                    c = int.Parse(Console.ReadLine()); //essaye de convertir la saisie utilisateur dans le bon format
                }
                catch
                {
                    c = 5;// retourne l'utilisateur vers le message d'erreur si la saisie est incorrecte
                }

                if (c == 0) 
                { 
                    Environment.Exit(0); 
                }

                if (c == 1)
                {
                    int n = Ask(messTotal); // nombre total d'éléments à gérer
                    // calcul de r
                    long r = Boucle(n, 0);
                    Console.WriteLine(n + "! = " + r);
                }
                else if (c == 2)
                {
                    int t = Ask(messTotal);
                    int n = Ask(messElem); // total du sous ensemble
                    // calcul de r
                    long r = Boucle(t, t-n);
                    //Console.WriteLine("résultat = " + (r1 / r2));
                    Console.WriteLine("A(" + t + "/" + n + ") = " + r);
                }
                else if (c == 3)
                {
                    int t = Ask(messTotal);
                    int n = Ask(messElem);
                    // calcul de r1
                    long r1 = Boucle(t, t-n);
                    // calcul de r2
                    long r2 = Boucle(n, 0);
                    Console.WriteLine("C(" + t + "/" + n + ") = " + (r1 / r2));
                }
                else
                {
                    Console.WriteLine("Erreur de saisie, veuillez renouveler");
                }
                
            }
        }
    }
}
