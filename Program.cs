using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker //namespace used to organize and provide a level of separation in the code(like node.js)
{
  class Program
  {
    //main() - method is envoked when program runs, main must be nested in a class
    //void - signifies tht return of this exectable method be void
    //static - emplies that the scope of this method is at the class level, not the object level, and can thus be invoked without having to first create a new class instance. 
    static void Main(string[] args)
    {
      // string greeting = "Hello";  //String
      // greeting = greeting + "World!";
      // Console.WriteLine("greeting" + greeting);

      //variant 1
      // float side =  3.14F;
      // float area = side*side;
      // Console.WriteLine("area:{0}", area);

      // double side = 3.14;
      // double area = side * side;
      // Console.WriteLine("area:{0}",area.GetType());

      /*dattype conversions*/

     string stringNum = "2";
    //  int intNum = Convert.ToInt32(stringNum);
    //  Console.WriteLine(intNum);
     Console.WriteLine(stringNum.GetType());
     Console.WriteLine("---------------");
string[] favFoods = new string[3]{ "pizza", "doughnuts", "icecream" };
string firstFood = favFoods[0];
string secondFood = favFoods[1];
string thirdFood = favFoods[2];
Console.WriteLine("I like {0}, {1}, and {2}", firstFood, secondFood, thirdFood);

List<string> employees = new List<string>() { "adam", "amy" };
employees.Add("barbara");
employees.Add("billy");
Console.WriteLine("My employees include {0}, {1}, {2}, {3}", employees[0], employees[1], employees[2], employees[3]);

for (int i = 0; i < employees.Count; i++) 
{
  Console.WriteLine(employees[i]);
}
    }
  }
}

//datatypes
/*
C# statically language

// JavaScript
var carModel = "Explorer";
var carPrice = 500;

// C#
string carModel = "Intrepid";
int carPrice = 500;

1)Strings - stores plain text
string interpolation 
Console.WriteLine($"greeting: {greeting}"); 
Console.WriteLine("greeting: {0}", greeting);


2)Numbers

integers is int data type
decimals is float data type


3)Example Math Operations
When we write a decimal with no suffix, it is by default the type double

4)Math operators
The preceding results from these math operations perform as expected, similarly to JavaScript. Strings concatenate, and the math operators abide by operation order

5)Booleans

bool
*/



//datatype conversions
/* stringNum
string stringNum = "2";
int intNum = Convert.ToInt32(stringNum);
Console.WriteLine(intNum);
Console.WriteLine(intNum.GetType());
 */


//DATA STRUCTURES
 /*
 1) dictionaries

 dictionaries in C# use a key-value pair relationship
 To use a dictionary, you must first import --using System.Collections.Generic;
 
<string, double>
<int, string>*/

//Dictionary<string, int> myScoreBoard = new Dictionary<string, int>();

/*Add() method to add data like below
myScoreBoard.Add("firstInning", 10);
myScoreBoard.Add("secondInning", 20);
myScoreBoard.Add("thirdInning", 30);
myScoreBoard.Add("fourthInning", 40);
myScoreBoard.Add("fifthInning", 50);


second way
Dictionary<string, int> myScoreBoard = new Dictionary<string, int>(){
    { "firstInning", 10 },
    { "secondInning", 20},
    { "thirdInning", 30},
    { "fourthInning", 40},
    { "fifthInning", 50}
};
 */


//ARRAYS
/*
items in arrays can be accessed by their index, which starts at 0.
However, there are a couple of notable distinctions in the way C# handles arrays, because the data type of the array’s elements must be declared—just as we did for variables. This constraint allows for only a single data type to be contained in the array.

Another distinction is that the length of the array must also be set when the array is declared. No new elements can be added or subtracted from the array.

string[] favFoods = new string[3]{ "pizza", "doughnuts", "icecream" };
string firstFood = favFoods[0];
string secondFood = favFoods[1];
string thirdFood = favFoods[2];
Console.WriteLine("I like {0}, {1}, and {2}", firstFood, secondFood, thirdFood);


*/



//LISTS
/*
Like dictionaries, lists are located in the ----using System.Collections.Generic;
List<string> employees = new List<string>() { "adam", "amy" };
employees.Add("barbara");
employees.Add("billy");
Console.WriteLine("My employees include {0}, {1}, {2}, {3}", employees[0], employees[1], employees[2], employees[3]);

*/


//LOOPs
/*
Write a for Loop

for (int i = 0; i < employees.Count; i++) 
{
  Console.WriteLine(employees[i]);
}


*/