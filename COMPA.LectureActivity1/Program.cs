/*
    Author: Anthony Perez
    Course Name: COMP-003A
    Facuty: Jonathan Cruz
    Purpose: basic console app
 */

//namespace level
namespace COMPA.LectureActivity1
{
    //class level
    internal class Program
    {
        //main level
        static void Main(string[] args)
        {
            //Prompt User Input
            Console.Write("Enter your name: ");
            string username = Console.ReadLine();   //gets the user input and saves it to a variable

            Console.WriteLine("Hi " + username + "My name is Anthony");
            
            Console.WriteLine("1. I am an engineering student  \n 2.\n 3. \n 4. \n 5. \n 6. \n 7. \n 8. \n 9.\n 10. ");

            

        }
    }
}