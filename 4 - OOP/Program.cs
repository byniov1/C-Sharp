namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*            
             //Console.WriteLine("Hello, World!");

            //Car audi = new Car("A3", "Audi", false);
            //Car bmw = new Car("BMW", "E36", false);
            //Console.WriteLine(audi.Brand);

            ////string y = audi._model;
            //string audiModel = audi.Model;
            //string audiBrand = audi.Brand;

            //audi.Brand = "AUDI";
            //Console.WriteLine(audi.Brand);

            //audi.Brand = "";
            //Console.WriteLine(audi.Brand);
            */

            /*
            //Customer earl = new Customer("Earl");
            //Customer frank = new Customer("Frank", "TheTank");
            Customer adam = new Customer("Adam", "Noiwak", "bfjdaksfh");
            Customer NN = new Customer();

            //Console.WriteLine(earl.Name);
            //Console.WriteLine(frank.Name);
            Console.WriteLine(adam.Name);
            Console.WriteLine(NN.Name);
            */



/*

            Car myAudi = new Car("Audi ", "A3", false);
            Car myAudi2 = new Car("Audi ", "A3", false);
            Car myAudi3 = new Car("Audi ", "A3", false);
            myAudi.Drive();

            Customer myCustomer = new Customer();
            myCustomer.SetDetail("Frank", "MainStreet2", "555123345");

            Console.WriteLine(AddNum(firstNum:5, secondNum:6));




            Customer customer = new Customer(); 
            customer.SetDetail("Frank", "MainStreet2", "555123345");
            Customer.DoSomeCustomerStaff();

            //MyMethod();
            Program program = new Program();
            program.MyMethod();

            int x = DoubleValue(10);
            Console.WriteLine(x);


            Console.WriteLine(Car.NumberOfCars);
            */


            // Customer customer1 = new Customer();
            // Customer customer2 = new Customer();
            // Customer customer3 = new Customer();
            // Customer customer4 = new Customer();
            // Customer customer5 = new Customer();
            // Customer customer6 = new Customer();

            // customer1.GetDetail();
            // customer5.GetDetail();
            // Console.WriteLine(customer6.Id);

            // Console.ReadKey();


            Question[] questions = new Question[]
            {
                new Question(
                    "What is the capital of France?", 
                    new string[] {"Paris", "London", "Berlin"},
                    0
                ),
                new Question(
                    "What is 2 + 2?", 
                    new string[] {"1", "5", "4"},
                    2
                ),
                new Question(
                    "What is the capital of Germany", 
                    new string[] {"Paris", "London", "Berlin"},
                    2
                ),
            };

            Quiz quiz = new Quiz(questions);
            quiz.StartQuiz();
            Console.ReadLine();
        }

        // static int AddNum(int firstNum, int secondNum)
        // {
        //     return firstNum + secondNum;
        // }

        // public void MyMethod()
        // {
        //     Console.WriteLine("My Method");
        // }

        // public static int DoubleValue(int number = 10)
        // {
        //     return number * 2;
        // }
    }
}
