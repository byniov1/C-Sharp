using System.Runtime.InteropServices;

namespace _11___Events
{
    /* 1
     *  internal class Program
        {
            //1 Declaration
            public delegate void Notify(string message);


            static void Main(string[] args)
            {
                //Delegate define a method signature
                // and any method assigned to a delegate must match this signature


                // 2 Instatiation
                Notify notifyDelegate = ShowMessage;
                Notify notifyDelegate2 = new Notify(notifyDelegate);


                //3 Invocation:
                notifyDelegate("Hello from notifyDelegate");
            }

            static void ShowMessage(string message)
            {
                Console.WriteLine(message);
            }
        }*/

    /* 2   
internal class Program
    {
        public delegate void LogHandler(string message);

        public class Logger
        {
            public void LogToConsole(string message)
            {
                Console.WriteLine($"Console log:" + message);
            }

            public void LogToFile(string message)
            {
                Console.WriteLine($"File log:" + message);
            }
        }

        static void Main(string[] args)
        {
            Logger logger = new Logger();
            LogHandler logHandler = logger.LogToConsole;
            logHandler("Logging to console");

            logHandler = logger.LogToFile;
            logHandler("Logging to file");
        }
    }*/

    /*Generics*/
    internal class Program
    {

        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5, };
            string[] stringArray = { "One", "Two", "Three", "Four" };
            PrintArray(intArray);
            PrintArray(stringArray);
            Console.ReadKey();

        }

        public static void PrintIntArray(int[] array)
        {
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }
        }

        public static void PrintStringArray(string[] array)
        {
            foreach (string item in array)
            {
                Console.WriteLine(item);
            }
        }

        public static void PrintArray<T>(T[] array)
        {
            foreach (T item in array)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

    }

}
