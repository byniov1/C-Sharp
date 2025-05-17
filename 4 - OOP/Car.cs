using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace OOP;

class Car
{
    // memeber variable
    // private hides the variable from other classes
    // Backing field of the Model property
    //private string _model = "";
    //public string Model { get => _model; set => _model = value; }

    //To jest to samo jak zapis wyżej,
    public string Model { get; set; }

    //private bool _isLuxury;
    //public bool IsLuxury { get => _isLuxury; set => _isLuxury = value; }
    public bool IsLuxury { get; set; }

    public static int NumberOfCars { get; set; }




    private string _brand = "";

    public string Brand { 
        get
        {
            if(IsLuxury)
            {
                return _brand + " - Luxury Edition";
            }

            return _brand;
        }



        set
        {
            if (string.IsNullOrEmpty(value))
            {
                Console.WriteLine("You eneted NOTHING");
                _brand = "DEFAULT VALUE";
                return;
            }

            _brand = value;
                
        }        
    }



    //Constructor
    public Car(string brand, string model, bool isLuxury) 
    {
        NumberOfCars++;

        Model = Model;
        Brand = brand;
        Console.WriteLine("A " + _brand + " of the model " + Model + " has been created");
        IsLuxury = isLuxury;
    }

    public void Drive()
    {
        Console.WriteLine($"I'm a {Model} and I'm driving ");
    }

}

// namespace Coding.Exercise
// {
//     public class MyClass
//     {
//         // TODO: Declare a private readonly field to store the value
//         private readonly string _x;
        
//         // TODO: Create a public read-only property to expose the field's value
//         public string X {
//             get
//             { return _x;}
//         }


//         public MyClass(string value)
//         {
//             _x = value;
//             // TODO: Initialize the readonly field with the value parameter
//         }
//     }

//     public class Exercise
//     {
//         public void PrintReadOnlyProperty()
//         {
//             // TODO: Create an instance of MyClass with the value "Read-Only Property Value"
//             MyClass myClass = new MyClass("Read-Only Property Value");
//             Console.WriteLine(myClass.X);
//             // TODO: Print the value of the read-only property to the console
//         }
//     }
// }

//class Car
//{
//    // memeber variable
//    private string _model = "";
//    private string _brand = "";

//    //Constructor
//    public Car(string brand, string model)
//    {
//        _model = model;
//        _brand = brand;
//        Console.WriteLine("A " + _brand + " of the model " + _model + " has been created");
//    }

//    public string Model()
//    {
//        return _model;
//    }
//}