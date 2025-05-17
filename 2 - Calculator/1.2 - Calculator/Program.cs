// See https://aka.ms/new-console-template for more information

using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

//Console.Write("Enter a first number: ");
//double myNumber = 0;

//try
//{
//    //myNumber = Console.ReadLine(); // nie możemy int podpiąć pod string. trzeba to sparsować
//    myNumber = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//    //Console.WriteLine($"myNumber is {myNumber}");
//}
//catch (Exception)
//{ 
//    Console.WriteLine($"I said whole number");
//}

//Console.Write("Enter something : ");
//string userInput = Console.ReadLine();
//Console.WriteLine($"You enetered {userInput}");

//Console.Write("Enter a second number: ");
//double secondNumber = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


//Console.WriteLine($"" +
//    $"Sum of firstNumber: {myNumber.ToString(CultureInfo.InvariantCulture)} " +
//    $"and secondNumber: {secondNumber.ToString(CultureInfo.InvariantCulture)} " +
//    $"is {Math.Round(myNumber + secondNumber, 2).ToString(CultureInfo.InvariantCulture)}");

// Implicit convertion
//int myInt = 13;
//double myDouble = myInt;

// Tak nie skonwertujemy, brakuje rzutowania
//double myDouble2 = 13.5;
//int myInt2 = myDouble2;

//Console.WriteLine(myInt2);

/*
 * //Explicit conversion
long myLong = 1222;
double myDouble = 13.9;
//int myInt = (int)myLong;
int myInt = (int)myDouble;

//Console.WriteLine(myInt);

//float myFloat = 123.123f;
//double myDouble = 13.213213213213;

//myFloat = (float)myDouble;

Console.WriteLine(myInt);
Console.ReadKey();
*/
/*
string numberString = "123";
int result = int.Parse(numberString);

string myBoolString = "true";

// Jedna i druga opcja działa
bool resultBool = bool.Parse(myBoolString);
//bool resultBool = Convert.ToBoolean(myBoolString);

Console.WriteLine(result);
Console.WriteLine(resultBool == true);
*/


//var myFavoriteGenre = "LitRPGs";
//var myFavoriteNumber = 2000000000000000000;

//var x = 1.0;
//var y = 1;

//var z = x + y;

//Console.WriteLine(myFavoriteNumber);

//var x = 5;
//var y = 13;

//int zz = 13;
//Console.WriteLine(zz);


//Console.WriteLine($"x is " + x);
//Console.WriteLine($"y is " + y);
//Console.WriteLine("x + y is" + x + y);
//Console.WriteLine($"x+y is {x+y + 8 * 2}");

//Console.WriteLine($"x / y is {x/y}");

//Console.WriteLine("Subrtation x - y = " + (x - y));


//Console.WriteLine("baalbalb " + (5 - 1));

//int num1 = 10;
//int num2 = 20;
//int num3 = 30;
//int average = (num1 + num2 + num3) / 3;
//Console.WriteLine("The average is: " + average);

//char myFavoriteCharacter = '☺';

//Console.WriteLine(myFavoriteCharacter);

//int num = 5;
//double price = 19.9;
//string name = "Frank";


//Interpolation
//Console.WriteLine($"the number is {5}");

////Concatenation
//Console.WriteLine("The number is " + 5);

////String formatting
//Console.WriteLine("The numebr is {0}, and the price is {1} and the name is {2}", num, price, name);



//string s1 = "This is a string with a slash / and colon ; and cooma \" and this is a string \"string\"  \n \t and backslash \\ ";
//Console.WriteLine(s1);



//bool isRainy = false;
//bool hasUmbrella = true;

//if (isRainy)
//{
//    if (hasUmbrella)
//    {
//        Console.WriteLine("i have umrella");
//    }
//    Console.WriteLine("I dont have umbrella");
//}
//Console.WriteLine("I dont need umbrela");


//if (!isRainy || hasUmbrella)
//{
//    Console.WriteLine("I'm ok");
//}

//int age = 7;

//if(age >= 18)
//{
//    Console.WriteLine("Go party in the club");
//} else if(age > 6)
//{
//    Console.WriteLine("Go party in school");
//} 
//else
//{
//    Console.WriteLine("Go party in kindergarden");
//}

//int num1 = 0;
//int num2 = 0;

//bool isEqual = num1 == num2;
//bool isNotEqual = num1 != num2;


//int age;
//char areYouWithParrents;

//Console.Write("How old are you: ");
//age = int.Parse(Console.ReadLine());

//if(age < 18)
//{
//    Console.Write("Are you with parrents Y - N : ");
//    areYouWithParrents = char.Parse(Console.ReadLine());

//    if(areYouWithParrents == 'Y')
//    {
//        Console.WriteLine('X');
//        return;
//    }
//    Console.WriteLine("You cannot");
//}

//Console.WriteLine('X');

//int month = 1;
//string monthName;

//switch (month)
//{
//    case 1:
//        monthName = "J";
//        break;
//    case 2:
//        monthName = "M";
//        break;
//    default:
//        monthName = "U";
//        break;
//}


/*string question = "Co jest stolica Niemiec";
string anwser = "Berlin";

int points;

Console.WriteLine(question);
string userAnwser = Console.ReadLine();

if (userAnwser.Trim().ToLower() == anwser.ToLower())
{
    Console.WriteLine("Correct");
}*/


/*Console.Write("Give me a number: ");
string inputString = Console.ReadLine();
//int num1 = int.Parse(inputString);

int num1 = 0;
bool isNumber = int.TryParse(inputString, out num1);


num1++;
Console.WriteLine($"User eneterd number +1 {num1}");
*/

/*Random random = new Random();
int randomNum = random.Next(0, 11);
Console.WriteLine(randomNum);*/


/*for(int i = 0; i<10; i++)
{
    for (int j = 0; j < 10; j++)
    {
        Console.Write('#');
    }
    Console.WriteLine();
}*/

//Szalenie trudne zadanie
/*string myString = "Hi \r\nHI";

for (int i = 10; i >= 0; i--)
{
    Console.WriteLine(i);
    Thread.Sleep(1000);
}
*/
/*string rocket = "     |\r\n     |\r\n    / \\\r\n   / _ \\\r\n  |.o '.|\r\n  |'._.'|\r\n  |     |\r\n ,'|  | |`.\r\n/  |  | |  \\\r\n|,-'--|--'-.|";

for (int i = 10; i >= 0; i--)
{
    Console.Clear();
    Console.WriteLine(rocket);
    rocket = "\r\n" + rocket;
    Thread.Sleep(100);
}
Console.WriteLine("The rocket has landed");
*/
//Console.ReadKey();

/*int counter = 0;
while(counter < 10)
{
    Console.WriteLine(counter);
    counter++;
}*/

bool isGood = true;


/*while (isGood)
{
    Console.WriteLine("Life is good");
    isGood = false;
}
*/

/*do
{
    Console.WriteLine("Life is good");
    isGood = false;
}
while (isGood);*/

//for (int i = 0; i<10; i++)
//{
//    Console.WriteLine(i);
//    if (i == 3)
//        break;
//}

/*int[] myIntArray = new int[5];
int[] myIntArray2 = [1, 2, 3, 4, 5, 6];
string[] week = ["Mon", "Tue", "Wed"];

myIntArray[0] = 1;
Console.WriteLine(myIntArray.Length);
Console.WriteLine(myIntArray2.Length);


for (int i = 0; i<week.Length; i++)
{
    Console.WriteLine(week[i]);
}

Console.WriteLine();

foreach (var item in week)
{
    Console.WriteLine(item);
}*/

/*int[,] array2DDeclaration = new int[3, 3];

int[,] array2DIniziled = { { 1, 2 }, { 3, 4 } };

Console.WriteLine(array2DIniziled[1,0]);
array2DIniziled[0, 0] = 5;
Console.WriteLine(array2DIniziled[0, 0]);

string[,] ticTacToeFielf = {
    { "O", "X", "X"},
    { "O", "O", "X"},
    { "X", "X", "O"}
};

string[,,] simple3DArray =
{
    {
        {"000", "001"},
        {"010", "011"},
    },
    { 
        {"100", "101"},
        {"110", "111"}   
    },
};

Console.WriteLine();*/

/*int[] myArray = new int[5] { 1, 2, 3, 4, 5 };
            
            foreach (int item in myArray)
            {
    Console.WriteLine(item);
            }*/

/*int[,] myArray = new int[3,3]{ { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

for (int i = 0; i < 3; i++)
{
    int sum = 0;
    for (int j = 0; j < 3; j++)
    {
        sum += myArray[i, j];
    }
    Console.WriteLine(sum);
}
*/
/*
void calculate(int x, int y)
{
    Console.WriteLine($"{x+y}");
}

calculate(5,6);*/

/*void MyFirstMethod()
{
    Console.WriteLine("My Wery first method was called");
}
MyFirstMethod();*/