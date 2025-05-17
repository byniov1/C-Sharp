using System.ComponentModel;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Linq;
using System.Collections;
using System.Reflection;


// Demonstrate Add method
/* List<string> colors = new List<string>() {//Tutaj możemy sobie definiować elementy};

// Adding items to the list
colors.Add("red");
colors.Add("red");
colors.Add("red");
colors.Add("red");
colors.Add("blue");
colors.Add("green");
colors.Add("green"); 
*/

public class Product
{
    public string Name { get; set; }
    public double Price { get; set; }
}


class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public float GPA { get; set; }

    public Student(int id, string name, float gpa)
    {
        this.Id = id;
        this.Name = name;
        this.GPA = gpa;
    }
}

class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int Salary { get; set; }

    public Employee(string name, int age, int salary)
    {
        Name = name;
        Age = age;
        Salary = salary;
    }
}

// class Student
// {
//     public int Id { get; set; }
//     public string Name { get; set; }
//     public int Grade { get; set; }

//     public Student(int id, string name, int grade)
//     {
//         Id = id;
//         Name = name;
//         Grade = grade;
//     }
// }

internal class Program
{
    private static void Main(string[] args)
    {
        List<string> colors =
        [
            // Adding items to the list
            "red",
            "red",
            "red",
            "red",
            "blue",
            "green",
            "green",
        ];


        //Remove remove first occurrence return bool
        /* bool isDeletingSuccessful = colors.Remove("green");

        if(isDeletingSuccessful)
        {
            Console.WriteLine("Remove action completes successfully");
        } 
        else 
        {
            Console.WriteLine("Remove action failed");
        } */

        /* colors.Add("blue");

        int howManyRemoved = colors.RemoveAll(color => color.ToLower() == "red");
        Console.WriteLine($"RemoveAll method removes {howManyRemoved} elements");

        //Another solution
        bool isDeletingSuccessful = colors.Remove("red");
        while(isDeletingSuccessful){
            isDeletingSuccessful = colors.Remove("Red");
        }




        List<int> listOfIntegers = [1,2,3];

        foreach (var integer in listOfIntegers)
        {
            Console.WriteLine(integer);
        }  */



        /* 
        List<int> numbers = new List<int> {10,5,15,3,9};

        numbers.Sort();

        foreach (var number in numbers)
        {
            System.Console.WriteLine(number);
        }
         */

        List<int> numbers = new List<int> { 10, 5, 15, 3, 9, 25, 18 };


        /*
        List<int> found Numbers = numbers.FindAll(number => {
            return number > 10;
        }); 
        */

        /* 
        Predicate<int> isGreaterThanTen =  x => x > 10; 
        */

        /* Delegate */
        /* 
        bool isGreaterThan(int x)
        {
            return x > 10;
        }
        Predicate<int> isGreaterThanTen =  isGreaterThan;
        List<int> foundNumbers = numbers.FindAll(isGreaterThanTen);
        foreach (var number in foundNumbers)
        {
            Console.Write($"{number},");
        } */


        bool isAnyGreaterThanX = numbers.Any(x => x > 20);
        // Console.WriteLine(isAnyGreaterThanX);



        // //23.04.2025
        // // List<Product> products = new List<Product>();
        
        
        // List<Product> products = new List<Product>{
        //     new Product {Name = "Berries", Price = 2.98 },
        //     new Product {Name = "Berries", Price = 2.98 },
        //     new Product {Name = "Berries", Price = 3.98 },
        // };

        // products.Add(new Product {Name = "Apples", Price = 0.98 });

        // // foreach (var item in products)
        // // {
        // //     Console.WriteLine($"{item.Name} - {item.Price}");
        // // }

        // List<Product> cheapProducts = products.Where(product => product.Price <= 1.0).ToList();
    
        // foreach (var item in cheapProducts)
        // {
        //     Console.WriteLine($"{item.Name} - {item.Price}");
        // }
    







        /* ---------------------------
        * Legacy List - ArrayList
        ---------------------------- */
        
        
        // //undefined amount of objects
        // ArrayList myArrayList = new ArrayList();
        
        // //Defined amount of objects
        // ArrayList myArrayList2 = new ArrayList(100);


        // myArrayList.Add(25);
        // myArrayList.Add("25");
        // myArrayList.Add("Hello");
        // myArrayList.Add(2.5);
        // myArrayList.Add(14);
        // myArrayList.Add(123765443);
        // myArrayList.Add(25.4);

        // //remove first "13" from list
        // myArrayList.Remove(13);

        // //delete element from specyfic position
        // myArrayList.RemoveAt(3);


        // System.Console.WriteLine(myArrayList.Count);
        
        // double sum = 0.0;
        
        // foreach (object item in myArrayList)
        // {
        //     Console.WriteLine(item);
        //     if(item is int)
        //     {
        //         sum += Convert.ToDouble(item);
        //     }
        //     else if (item is double)
        //     {
        //         sum += (double)item;
        //     }
        //     else if (item is string) 
        //     {
        //         Console.WriteLine(item);
        //     }
        // }
        // Console.WriteLine(sum);





        /* ---------------------------
        * Legacy hasztables
        ---------------------------- */

        // Hashtable studentsTable = new Hashtable();

        // Student stud1 = new Student(1, "Maria", 33);
        // Student stud2 = new Student(2, "Adam", 43);
        // Student stud3 = new Student(3, "Wera", 53);
        // Student stud4 = new Student(4, "Wiki", 63);

        // studentsTable.Add(stud1.Id, stud1);
        // studentsTable.Add(stud2.Id, stud2);
        // studentsTable.Add(stud3.Id, stud3);
        // studentsTable.Add(stud4.Id, stud4);

        // Student storedStudent1  = (Student)studentsTable[stud1.Id];


        // foreach (DictionaryEntry student in studentsTable)
        // {
        //     Student temp = (Student)student.Value;
        //     Console.WriteLine($"Student ID: {temp.Id}, Name: {temp.Name}, GPA: {temp.GPA}");
        // }


        // //Easier method to iterate through hashtable
        // foreach (Student value in studentsTable.Values)
        // {
        //     Console.WriteLine($"Student ID: {value.Id}, Name: {value.Name}, GPA: {value.GPA}");
        // }
        

        // // Console.WriteLine($"Student ID: {storedStudent1.Id}, Name: {storedStudent1.Name}, GPA: {storedStudent1.GPA}");




        /* ---------------------------
        * Nullables in c#
        ---------------------------- */

        // // int age = null; // This will cause a compile-time error
        // int? age = null; // int? is a nullable type, it can be null or int

        // if(age.HasValue)
        // {
        //     Console.WriteLine("Age is " + age.Value);
        // }
        // else 
        // {
        //     System.Console.WriteLine("Age is not specified" + age);
        // }

        // // if(age != null)
        // // {
        // //     int sum = age.Value;
        // //     System.Console.WriteLine(sum);
        // //     Console.WriteLine("Age is " + age);
        // // }





        /* ---------------------------
        * Dictionaries
        ---------------------------- */

        // // key (unikalny) - value 
        // Dictionary<int, string?> employees = new Dictionary<int, string?>
        // {
        //     { 1, "Maria" },
        //     { 2, "Adam" },
        //     { 3, "Max" }
        // };

        // //Możemy napisać też tak
        // employees.Add(4, "Wika");
        // employees.Add(5, "Daga");
        // employees.Add(6, "Wera");

        // string? name = employees[1];
        // System.Console.WriteLine(name);

        // foreach (KeyValuePair<int, string?> employee in employees)
        // {
        //     Console.Write("Id: " + employee.Key + " Value: " + employee.Value + " | ");
        // }

        // //Update date in a dictionary
        // employees[2] = "Jane Smith";


        // //remove item
        // employees.Remove(3);

        // Console.WriteLine("\n");
        // // Iterating over a dictionary
        // foreach (KeyValuePair<int, string?> employee in employees)
        // {
        //     Console.Write("Id: " + employee.Key + " Value: " + employee.Value + " | ");
        // }

        // //How to handle uncertain situation if we don't know id given id is taken
        // if(!employees.ContainsKey(6))
        // {
        //     employees.Add(6, "Mike Jack");
        // }

        // //another method xD 
        // int counter = 0;
        // while(employees.ContainsKey(counter))
        // {
        //     counter++;
        // }
        // employees.Add(counter, "Jesuz Christ");

        // //Another way
        // bool added = employees.TryAdd(102, "Michal Brims");
        // if(!added){
        //     Console.WriteLine("Employee with the id of 102 already exist");
        // } else {
        //     Console.WriteLine("Employee added");
        // }



        /* ---------------------------
        * Dictionaries
        ---------------------------- */
        // Dictionary<int, Employee> employee = new Dictionary<int, Employee>()
        // {
        //     {1, new Employee("John Doe", 35, 10000)},
        //     {2, new Employee("Adam Doe", 25, 4000)},
        //     {3, new Employee("Wika Doe", 15, 200)},
        //     {4, new Employee("Daga Doe", 65, 100000)}
        // };

        // // foreach (var item in employee)
        // // {
        // //     Console.WriteLine($"Id:{item.Key} Named:{item.Value.Name} Age:{item.Value.Age} Salary:{item.Value.Salary}");
        // // }


        // Dictionary<int, List<int>> list = new Dictionary<int, List<int>>()
        // {
        //     {1, new List<int>{1,2,3}},
        // };

        // foreach (var item in list[1])
        // {
        //     Console.Write(item + " ");            
        // }

        
        /* ---------------------------
        * Dictionaries
        ---------------------------- */
        // var codes = new Dictionary<string, string>{
        //     ["NY"] = "New York",
        //     ["CA"] = "California",
        //     ["TX"] = "Texas",
        // };


        // // string state;
        // if(codes.TryGetValue("Na", out string state)) {
        //     Console.WriteLine(state);
        // } else {
        //     Console.WriteLine("Nothing found");
        // }

        // foreach (var item in codes)
        // {
        //     Console.WriteLine($"State code is {item.Key} and the state name is {item.Value}");
        // }


        Student s1 = new Student(1, "John", 85);
        Student s2 = new Student(2, "Alice", 90);
        Student s3 = new Student(3, "Bob", 78);


        Dictionary<string, Student> studentList = new Dictionary<string, Student>(){
            {s1.Name, s1},
            {s2.Name, s2},
            {s3.Name, s3},
        };

        // Można tutaj było napisać 
        // foreach (var item in studentList.Values)
        foreach (var item in studentList)
        {
            Console.WriteLine($"Name: {item.Key}, Id: {item.Value.Id}, Grade: {item.Value.GPA}");
        }

    }
}

