using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAssignment
{
    internal class UserInputHandler
    {
        public static Positives GetUser()
        {
            Positives userCase = new Positives();

            Console.WriteLine("Please enter you full name: ");
            userCase.Name = Console.ReadLine();

            Console.WriteLine("Now, enter you birth date please: ");
            userCase.DateOfBirth = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter the date you got the virus: ");
            userCase.DateOfGettingVirus = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("What is the date you has virus test? ");
            userCase.DateOfTest = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("What is your virus variant type? ");
            userCase.VariantType = Console.ReadLine();

            return userCase;
        }
    }
}
