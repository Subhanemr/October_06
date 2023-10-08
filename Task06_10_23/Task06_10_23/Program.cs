using Task06_10_23.Metods;

namespace Task06_10_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1

            //Student student1 = new Student("Ryan", "Gosling", "AB104", 78);

            //student1.GetInfo();
            //student1.CheckGraduation();
            //student1.GetDiplomaDegree();

            //Task 2
            //Metod 1
            //StudentRanking ranking = new StudentRanking();
            //ranking.InputGrades();

            //int reshadrank = ranking.CalculateRank();

            //Console.WriteLine("Reshad rank: " + reshadrank);
            //Console.WriteLine("Aydin rank: " + (3 - reshadrank));

            //Metod 2
            //int[] reshad = new int[3];
            //int[] aydin = new int[3];
            //for (int i = 0; i < reshad.Length; i++)
            //{
            //restart:
            //    Console.WriteLine($"Reshada bal verin");
            //    reshad[i] = int.Parse(Console.ReadLine());
            //    if (reshad[i] > 100 || reshad[i] < 0)
            //    {
            //        Console.WriteLine("duzgun bal yazin");
            //        goto restart;
            //    }
            //}
            //for (int i = 0; i < aydin.Length; i++)
            //{
            //restart:
            //    Console.WriteLine("Aydina bal verin");
            //    aydin[i] = int.Parse(Console.ReadLine());
            //    if (aydin[i] > 100 || aydin[i] < 0)
            //    {
            //        Console.WriteLine("duzgun bal yazin");
            //        goto restart;
            //    }
            //}

            //int reshadrank = CalculateRank(reshad, aydin);
            //int aydinrank = CalculateRank(aydin, reshad);
            //Console.WriteLine("Resad rank " + reshadrank);
            //Console.WriteLine("Aydin rank " + aydinrank);


            //Task 3 

            //string inputText = "Bu, numune daxiletme metnidir ve biz ondan sozler toplamaq isteyirik.";
            //string[] words = CollectWords(inputText);

            //Console.WriteLine("Words in the input text:");
            //foreach (string word in words)
            //{
            //    Console.WriteLine(word);
            //}


            //Task 4

            string sampleString = "    Hello, World!    ";
            string[] delimiters = { " " };
            while (true)
            {
                Console.WriteLine();
                string[] words = sampleString.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                Console.WriteLine("Original String: \"" + sampleString + "\"");
                Console.WriteLine("Seciminizi edin:");
                Console.WriteLine("[1] CustomTrimStart:");
                Console.WriteLine("[2] CustomTrim:");
                Console.WriteLine("[3] CustomTrimEnd:");
                int choice = int.Parse(Console.ReadLine());
                if (choice > 3 && choice < 0)
                {
                    break;
                }

                switch (choice)
                {
                    case 1:
                        {
                            string[] trimmedStart = CustomTrimStart(words);
                            foreach (string word in trimmedStart)
                            {
                                Console.Write($"'{word}'");
                            }
                            break;
                        }
                    case 2:
                        {
                            foreach (string word in words)
                            {
                                Console.Write($"'{word}'");
                            }
                            break;
                        }
                    case 3:
                        {
                            string[] trimmedEnd = CustomTrimEnd(words);
                            foreach (string word in trimmedEnd)
                            {
                                Console.Write($"'{word}'");
                            }
                            break;
                        }


                }
            }

            //Task 5

            //restart:
            //Console.WriteLine("Arraylerin uzunlugunu yazin");
            //int h = int.Parse(Console.ReadLine());
            //if(h < 0)
            //{
            //    goto restart;
            //}
            //int[] array1 = new int[h];
            //int[] array2 = new int[h];
            //for (int i = 0; i < array1.Length; i++)
            //{
            //    int j = 1;
            //    Console.WriteLine($"1-ci Arraye {j}-ci Eded Daxil edin: ");
            //    array1[i] = int.Parse(Console.ReadLine());
            //    j++;
            //}

            //for (int i = 0; i < array2.Length; i++)
            //{
            //    int j = 1;
            //    Console.WriteLine($"2-ci Arraye {j}-ci Eded Daxil edin: ");
            //    array2[i] = int.Parse(Console.ReadLine());
            //    j++;
            //}

            //DisplayArray(array1, "Array 1:");
            //DisplayArray(array2, "Array 2:");

            //int[] result = AddArrays(array1, array2);

            //DisplayArray(result, " Iki arrayin cemi");

        }



        //Task 3

        //public static string[] CollectWords(string inputText)
        //{

        //    string[] delimiters = { " ", ",", ".", "!", "?", ";", ":", "-", "\n", "\r", "\t" };
        //    string[] words = inputText.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

        //    return words;
        //}


        //Task 5

        //public static int[] AddArrays(int[] array1, int[] array2)
        //{
        //    int sum = 0;
        //    int[] result = new int[array1.Length];

        //    for (int i = 0; i < array1.Length; i++)
        //    {
        //        result[i] = array1[i] + array2[i];
        //    }

        //    return result;
        //}

        //public static void DisplayArray(int[] array, string message)
        //{
        //    Console.WriteLine(message);

        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        Console.Write(array[i] + " ");
        //    }

        //    Console.WriteLine();
        //    Console.WriteLine();
        //}

        //Task 4

        static string[] CustomTrimStart(string[] input)
        {
            int i = input.Length - 1;
            input[i] = input[i] + "    ";
            return input;
        }

        static string[] CustomTrimEnd(string[] input)
        {
            input[0] = "    " + input[0];
            return input;
        }

        //Task 2
        //Metod2
        public static int CalculateRank(int[] resadrank, int[] aydinrank)
        {
            int rank = 0;
            for (int i = 0; i < 3; i++)
            {
                if (resadrank[i] > aydinrank[i])
                { rank++; }
            }
            return rank;
        }
    }

}

