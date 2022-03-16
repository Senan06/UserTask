using System;
using UserTask.Models;
namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User me = new User("", "sdjasdjasdnA2", 0);
            Console.WriteLine(me.UserName);
            Console.WriteLine(me.Password);
            Console.WriteLine(me.Age);
        }
    }
    
}