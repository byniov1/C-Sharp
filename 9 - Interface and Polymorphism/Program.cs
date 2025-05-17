// See https://aka.ms/new-console-template for more information

/*public interface IAnimal
{
    // Explicit interface implementation - to tak można?
    //void MakeSound() 
    //{
    //    Console.WriteLine("Roar");
    //}

    void MakeSound();
    void Eat(string food);

}

public class Dog : IAnimal
{
    //void IAnimal.MakeSound();
    public void MakeSound()
    {
        Console.WriteLine("Woof");
    }

    public void Eat(string food)
    {
        Console.WriteLine($"Dog eats {food}");
    }
}*/









/*namespace InterfacesApp
{
    public class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic animal sound");
        }
    }

    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            // Part 2 of Polymorphism
            Animal mySomething = new Dog();
            mySomething.MakeSound();



            Console.ReadKey();
        }
    }
}*/













namespace InterfacesApp
{





    /*    public interface IPaymentProcessor
        {
            void ProcessPayment(decimal amount);
        }

        public class CreditCardProcessor : IPaymentProcessor
        {
            public void ProcessPayment(decimal amount)
            {
                Console.WriteLine($"Processing credit card payment of {amount:C}");
                //Implement credit card payment logic here
            }
        }

        public class PayPallProcessor : IPaymentProcessor
        {
            public void ProcessPayment(decimal amount)
            {
                Console.WriteLine($"Processing paypal payment of {amount:C}");
                //Implement paypal payment logic here
            }
        }

        public class PaymentService
        {
            private readonly IPaymentProcessor _processor;

            public PaymentService(IPaymentProcessor processor)
            {
                _processor = processor;
            }

            public void ProcessOrderPayment(decimal amount)
            {
                _processor.ProcessPayment(amount);
            }
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                IPaymentProcessor creditCardProcessor = new CreditCardProcessor();
                PaymentService paymentService = new PaymentService(creditCardProcessor);
                paymentService.ProcessOrderPayment(100.00m);

                IPaymentProcessor paypalProcessor = new PayPallProcessor();
                PaymentService pypalPaymentService = new PaymentService(paypalProcessor);
                pypalPaymentService.ProcessOrderPayment(100.00m);

                Console.ReadKey();
            }
        }*/







    /*    public interface IPayment
    {
        // TODO: Declare a method ProcessPayment
        void ProcessPayment();
    }

    public class CreditCardPayment : IPayment
    {
        // TODO: Implement the ProcessPayment method
        public void ProcessPayment()
        {
            Console.WriteLine("Processing credit card payment");
        }
    }

    public class PayPalPayment : IPayment
    {
        // TODO: Implement the ProcessPayment method
        public void ProcessPayment()
        {
            Console.WriteLine("Processing PayPal payment");
        }
    }

    public class Exercise
    {
        public void ProcessPayments()
        {
            // TODO: Create instances of CreditCardPayment and PayPalPayment, and call the ProcessPayment method on each
            IPayment creditCardPayment = new CreditCardPayment();
            IPayment payPalPayment = new PayPalPayment();
            creditCardPayment.ProcessPayment();
            payPalPayment.ProcessPayment();
        }
    }*/




    /*=====================================================================================================
    * Decupling
    * ==================================================================================================*/

    /*    public interface ILogger
    {
        void Log(string message);
    }

    public class FileLogger: ILogger
    {
        public void Log(string message)
        {
            string directoryPath = @"C:\0 - Dysk D\Nauka\c#\c# Udemy\9 Interface and Polymorphism\Logs";
            string filePath = Path.Combine(directoryPath, "log.txt");

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            File.AppendAllText(filePath, message + "\n");
        }
    }

    public class DatabaseLogger : ILogger
    {
        public void Log(string message)
        {
            // Implement the logic to log a message to a database
            Console.WriteLine($"Logging to database. {message}");
        }
    }

    public class Application
    {
        private readonly ILogger _logger;

        public Application(ILogger logger)
        {
            _logger = logger;
        }

        public void DoWork()
        {
            _logger.Log("Work started");
            // DO ALL THE WORK!
            _logger.Log("WORK DONE!");
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            ILogger fileLogger = new FileLogger();
            Application app = new Application(fileLogger);
            app.DoWork();

            ILogger databaseLogger = new DatabaseLogger();
            app = new Application(databaseLogger);
            app.DoWork();
        }
    }
*/





    /*=====================================================================================================
     * Dependency Injection
     * ==================================================================================================*/

    //public interface IToolUser
    //{
    //    void SetHammer(Hammer hammer);
    //    void SetSaw(Saw saw);
    //}

    //public class Hammer
    //{
    //    public void Use()
    //    {
    //        Console.WriteLine("Hammering Nails!");
    //    }
    //}

    //public class  Saw
    //{
    //    public void Use()
    //    {
    //        Console.WriteLine("Sawing wood!");
    //    }
    //}

    ////No Interface Injection
    //// public class  Builder
    ////{
    ////    /*No injection
    ////    private Hammer _hammer;
    ////    private Saw _saw;

    ////    public Builder()
    ////    {
    ////        _hammer = new Hammer();
    ////        _saw = new Saw();
    ////    }

    ////    public void BuildHouse()
    ////    {
    ////        _hammer.Use();
    ////        _saw.Use();
    ////    }*/


    ////    /*Constructor Injection
    ////    private Hammer _hammer;
    ////    private Saw _saw;

    ////    public Builder(Hammer hammer, Saw saw)
    ////    {
    ////        _hammer = hammer;
    ////        _saw = saw;
    ////    }

    ////    public void BuildHouse()
    ////    {
    ////        _hammer.Use();
    ////        _saw.Use();
    ////    }
    ////    */

    ////    /*Setter Injection
    ////    public Hammer Hammer { get; set; }
    ////    public Saw Saw { get; set; }

    ////    //Setter DI
    ////    public void BuildHouse()
    ////    {
    ////        Hammer.Use();
    ////        Saw.Use();
    ////        Console.WriteLine("House Build");
    ////    }*/
    ////}

    //public class Builder: IToolUser
    //{
    //    private Hammer _hammer;
    //    private Saw _saw;


    //    public void SetHammer(Hammer hammer)
    //    {
    //        _hammer = hammer;
    //    }

    //    public void SetSaw(Saw saw)
    //    {
    //        _saw = saw;
    //    }

    //    //Setter DI
    //    public void BuildHouse()
    //    {
    //        _hammer.Use();
    //        _saw.Use();
    //        Console.WriteLine("House Build");
    //    }
    //}

    //// Dependency Injection
    //// Constructor Injection
    //// Property Injection
    //// Method Injection
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //No injection
    //        //Builder builder = new Builder();

    //        //Constructor Injection
    //        //Hammer hammer = new Hammer();
    //        //Saw saw = new Saw();
    //        //Builder builder = new Builder(hammer, saw);

    //        //Setter Injection
    //        //Hammer hammer = new Hammer();
    //        //Saw saw = new Saw();
    //        //Builder builder = new Builder();
    //        //builder.Hammer = hammer;
    //        //builder.Saw = saw;

    //        //Interface Injection
    //        Hammer hammer = new Hammer();
    //        Saw saw = new Saw();
    //        Builder builder = new Builder();
    //        builder.SetHammer(hammer);
    //        builder.SetSaw(saw);    

    //        builder.BuildHouse();
    //    }
    //}





    /*=====================================================================================================
    * Multiple inheritance throught interfaces
    * ==================================================================================================*/

    public interface  IPrintable
    {
        void Print();
    }

    public interface IScannable
    {
        void Scan();
    }

    public class MultiFunctionPrinter: IPrintable, IScannable
    {
        public void Print()
        {
            Console.WriteLine("Printing...");
        }
        public void Scan()
        {
            Console.WriteLine("Scanning...");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MultiFunctionPrinter mfp = new MultiFunctionPrinter();
            mfp.Print();
            mfp.Scan();
        }
    }



}