using System.Runtime.CompilerServices;

namespace OldStyle
{
    internal class Program
    {
        //Field (or instance variable) - sometimes even valled global variables
        //int myResult = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of days to simulate!");
            int days = int.Parse(Console.ReadLine());

            int[] temperature = new int[days];
            string[] conditions = { "Sunny", "Rainy", "Cloudy", "Snowy" };
            string[] weatherConditions = new string[days];

            Random random = new Random();

            for (int i = 0; i < days; i++)
            {
                temperature[i] = random.Next(-10, 40);
                weatherConditions[i] = conditions[random.Next(conditions.Length)];

                Console.WriteLine($"{i} - {temperature[i]} - {weatherConditions[i]}");

            }

            
            Console.WriteLine($"The max temp mas {temperature.Max()}");
            Console.WriteLine($"The min temp mas {temperature.Min()}");
            Console.WriteLine($"The min temp mas {MinTemperatur(temperature)}");
            Console.WriteLine($"The average condition is {MostCommonCodition(conditions)}");

            Console.WriteLine($"The most common codition is {CalculateAverage(temperature)}");


            //myResult = AddTwoValues(5, 6);
            //Console.WriteLine(myResult);
        }

        public static double CalculateAverage(int[] temperature)
        {
            double sum = 0;

            for (int i = 0; i < temperature.Length; i++)
            {
                sum += temperature[i];
            }


            return sum/temperature.Length;

        }

        static int MinTemperatur(int[] temperature)
        {
            int min = temperature[0];

            foreach (int temp in temperature)
            {
                if (temp < min)
                {
                    min = temp;
                }
            }

            return min;
        }

        static string MostCommonCodition(string[] conditions)
        {
            int count = 0;
            string mostCoomon = "";

            for (int i=0; i< conditions.Length; i++)
            {
                int tempCount = 0;
                for(int j=0; j< conditions.Length; j++)
                {
                    if (conditions[j] == conditions[i])
                    {
                        tempCount++;
                    }
                }
                if(tempCount > count)
                {
                    count = tempCount;
                    mostCoomon = conditions[i];
                }
            }
            Console.WriteLine();
                
            return mostCoomon;
        }
  
    }
}
