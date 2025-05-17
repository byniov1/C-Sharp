using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP;

class Customer
{
    private static int nextId = 0;

    //Read-only instance field initialized from the constructor
    private readonly int _id;

    public int Id { 
        get 
        { return _id; } 
    }




    public string Name { get; set; }
    public string Address{ get; set; }
    public string ContactNumber { get; set; }

    public Customer()
    {
        _id = nextId++;

        Name = "DefaultName";
        Address = "No Address";
        ContactNumber = "No ContactNumber";
        //Console.WriteLine("0 Customer");
    }

    public Customer(string name)
    {
        _id = nextId++;
     
        Name = name;
        //Console.WriteLine("First Constructor");
    }

    public Customer(string name, string address)
    {
        _id = nextId++;

        Name = name;
        Address = address;
        //Console.WriteLine("Second Constructor");
    }

    public Customer(string name, string address = "NA", string contactNumber = "NA")
    {
        _id = nextId++;

        Name = name;
        Address = address;
        ContactNumber = contactNumber;
        
        //Console.WriteLine("Third Constructor");
    }

    //Default parameters
    public void SetDetail(string name, string address, string contactNumber = "NA")
    {
        Name = name;
        Address = address;
        ContactNumber = contactNumber;
    }

    public void GetDetail()
    {
        Console.WriteLine($"Name: {Name}, Address: {Address}, ContactNumber: {ContactNumber}, Id: {_id}");
    }

    public static void DoSomeCustomerStaff()
    {
        Console.WriteLine($"I'm doing some customer staff");
    }

}


