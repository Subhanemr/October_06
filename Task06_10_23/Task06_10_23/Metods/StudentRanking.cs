using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task06_10_23.Metods
{
    internal class StudentRanking
    {
        //Task 2
        // Metod 1
        public int[] reshad;
        public int[] aydin;

        public StudentRanking()
        {
            reshad = new int[3];
            aydin = new int[3];
        }

        public void InputGrades()
        {
            for (int i = 0; i < reshad.Length; i++)
            {
            Restart:
                Console.WriteLine("Reshada bal verin");
                reshad[i] = int.Parse(Console.ReadLine());
                if (reshad[i] > 100 || reshad[i] < 0)
                {
                    Console.WriteLine("Duzgun bal yazin");
                    goto Restart;
                }
            }

            for (int i = 0; i < aydin.Length; i++)
            {
            Restart:
                Console.WriteLine("Aydina bal verin");
                aydin[i] = int.Parse(Console.ReadLine());
                if (aydin[i] > 100 || aydin[i] < 0)
                {
                    Console.WriteLine("Duzgun bal yazin");
                    goto Restart;
                }
            }
        }

        public int CalculateRank()
        {
            int rank = 0;
            for (int i = 0; i < 3; i++)
            {
                if (reshad[i] > aydin[i])
                {
                    rank++;
                }
            }
            return rank;
        }
    }
}
