using System;

class Program
{
    static void Main(string[] args)
    {
//ex1
/*
string name = " Dima" ;
int age = 24; 
double favoriteNumber = 3; 
Console.WriteLine($"hello , my name is {name}.  I am {age} years old,and my favorite number is {favoriteNumber}  "); 
*/

//--------------------------------------------------------------------
       /* 
        //ex 2
        int[] numbers = new int[5];
        Console.WriteLine("Enter 5 numbers:");
        for (int i = 0; i < 5; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Array elements:");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
*/
        //--------------------
/*
        //ex 3 
        
          Console.WriteLine("Enter a number:");
        int num = int.Parse(Console.ReadLine());
        if (IsEven(num))
        {
            Console.WriteLine($"{num} is even.");
        }
        else
        {
            Console.WriteLine($"{num} is odd."); }
    }
            
              static bool IsEven(int number)
    {
        return number % 2 == 0;
    } 
    */
/*
//-------------------------------------------------------------------------------------------------
        //ex 4 
        
Console.WriteLine( "inter Your age ");
 int age = int.Parse(Console.ReadLine());



if ( age <= 12 )
{
Console.WriteLine( "You are a child");

}

if ( age >= 13 &&  age <= 17 )
{
    
Console.WriteLine( "You are a teenager");
}

if ( age >= 18  )
{
    
Console.WriteLine( "You are a adult");
} 
*/
//--------------------------------------------------------------------------------
//ex 5
/*
         Console.WriteLine("Enter a number between 1 and 12:");
        int monthNumber = int.Parse(Console.ReadLine());
        string monthName;
        switch (monthNumber)
        {
            case 1: monthName = "January"; break;
            case 2: monthName = "February"; break;
            case 3: monthName = "March"; break;
            case 4: monthName = "April"; break;
            case 5: monthName = "May"; break;
            case 6: monthName = "June"; break;
            case 7: monthName = "July"; break;
            case 8: monthName = "August"; break;
            case 9: monthName = "September"; break;
            case 10: monthName = "October"; break;
            case 11: monthName = "November"; break;
            case 12: monthName = "December"; break;
            default: monthName = "Invalid month number"; break;
        }
        Console.WriteLine($"Month: {monthName}");

        } 
//-----------------------------------------------------------------------------------------------
        //ex 6

/*
        public class Book
{
    
    public string Title { get; set; }
    public string Author { get; set; }
    public double Price { get; set; }

    public Book(string title, string author, double price)
    {
        Title = title;
        Author = author;
        Price = price;
    }

    public void PrintDetails()
    {
        Console.WriteLine($"Title: {Title}, Author: {Author}, Price: {Price}");
        //in main 
      Book[] books = new Book[3];
         Book [0] newbook = ("booktitle" , "dima " , 11.2);
          Book [1] newbook = ("booktitle" , "dima " , 11.2);
           Book [2] newbook = ("booktitle" , "dima " , 11.2);
          foreach (Book book in books)
        {
            book.PrintDetails();

        }
        */
    }

    
 }


    