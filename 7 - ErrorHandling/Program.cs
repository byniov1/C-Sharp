using System.Diagnostics;


/*
int result = 0;
try
{
    Console.WriteLine("Plase enter a number");
    // int num1 = 0;
    int num1 = int.Parse(Console.ReadLine());
    int num2 = 2;
    result = num2 / num1;
}
catch (System.Exception ex) 
{
    // System.Console.WriteLine(ex.ToString());
    // Console.WriteLine("Attempted to divide by 0");
    Console.WriteLine("Error: " + ex.Message);
    Debug.WriteLine(ex.ToString());
}
finally
{
    Console.WriteLine("This always executes");
}

Console.WriteLine("Result : " + result);*/


/*int GetUserAge(string input)
{
    int age;
    if (!int.TryParse(input, out age))
    {
        throw new Exception("You didn't enter a valid age");
    }
    if(age < 0 || age > 120)
    {
        throw new Exception("Your age must be between 0 and 120");
    }
    return age;
}

Console.WriteLine("Enter your age");
GetUserAge(Console.ReadLine());*/



static void LevelOne()
{
    LevelTwo();
}

static void LevelTwo()
{
    Console.WriteLine("Level two before throw!");
    throw new FormatException("Something went wrong!");
    Console.WriteLine("Level two After throw!");
}

Console.WriteLine("App running before the try block");
try
{
    LevelOne();
}
catch (Exception ex)
{
    Console.WriteLine("Exception caught in Main: " + ex.Message);
}
Console.WriteLine("App is still running!");