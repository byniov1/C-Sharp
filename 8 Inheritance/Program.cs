namespace _8_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
            * Animal animal = new Animal();
            Dog dog = new Dog();
            Cat cat = new Cat();
            //dog.Eat(); // Inherited method from Animal class
            //animal.MakeSound();
            dog.MakeSound(); // Method from Dog class
            cat.MakeSound();
           */


            /*
             * BaseClass baseClass = new BaseClass();
            baseClass.ShowFields();
            DerivedClass derivedClass = new DerivedClass();
            derivedClass.AccessFields();
            derivedClass.ShowFields();
            */
            //Employee joe = new Employee("Joe", 30, "Software Developer", 1234);
            //joe.DisplayEmployeeInfo();

            Manager carl = new Manager("Carl", 40, "Project Manager", 5678, 5);
            //carl.DisplayManagerInfo();

            //carl.
            Console.WriteLine(carl.ToString());
            carl.BecomeOlder(4);

            Console.ReadKey();
        }
    }
/*
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Animal is eating");
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Animal is making sound");
        }
    }

    class Dog : Animal
    {
        public override void MakeSound()
        {
            base.MakeSound(); // Calls the base class method
            Console.WriteLine("ssss");
            Console.WriteLine("Dog is barking");
        }
    }

    class Cat: Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Cat is meowing");
        }
    }

    class Collie: Dog
    {
        public void GoingNuts()
        {
            Console.WriteLine("Collie going Nuts");
        }
    }

    class BaseClass
    {
        public int publicField;
        protected int protectedField;
        private int privateField;
        public void ShowFields()
        {
            Console.WriteLine($"Public: {publicField}, Protected: {protectedField}, Private: {privateField}");
        }
    }

    class DerivedClass: BaseClass
    {
        public void AccessFields()
        {
            publicField = 1;
            protectedField = 2;
            //privateField = 3;
        }
    }


*/

    public class Person
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            Console.WriteLine("Person constructor called");
        }

        public void DisplayPersonInfo()
        {
            Console.WriteLine($"Displaying person information Name: {Name}, Age: {Age}");
        }

        /// <summary> Increases the age of the person by the specified number of years. </summary>
        /// <param name="years"></param>
        /// <returns>Returns the new Age</returns>
        public int BecomeOlder(int years)
        {
            Age = Age + years;
            return Age;
        }
    }

    public class Employee: Person
    {
        public string JobTitle{ get; private set; }
        public int EmployeeId { get; private set; }

        public Employee(string name, int age, string jobTitle, int employeeId) : base(name, age)
        {
            JobTitle = jobTitle;
            EmployeeId = employeeId;
            Console.WriteLine("Employee constructor called");
        }

        public void DisplayEmployeeInfo()
        {
            DisplayPersonInfo();
            Console.WriteLine($"Job Title: {JobTitle}, Employee ID: {EmployeeId}");
        }
    }

    public sealed class Manager: Employee
    {
        public int TeamSize { get; private set; }

        public Manager(string name, int age, string jobTitle, int employeeId, int teamSize)
            : base(name, age, jobTitle, employeeId)
        {
            TeamSize = teamSize;
        }

        public void DisplayManagerInfo()
        {
            DisplayEmployeeInfo();
            Console.WriteLine($"Team Size: {TeamSize}");
        }
    }


    public class Account
    {
        //some methods and properties
    }

    public sealed class SavingsAccount : Account
    {
        //some methods and properties
        //Tej klasy nie można będzie już  
    }
}
