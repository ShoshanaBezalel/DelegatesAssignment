using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAssignment
{
    internal class SortPositives
    {
        delegate int PositivesComprasionDelegate(Positives x, Positives y);

        private static void Sort()
        {
            Console.WriteLine("Choose a sorting option:");
            Console.WriteLine("1. Sort by Name");
            Console.WriteLine("2. Sort by Date of Birth");
            Console.WriteLine("3. Sort by Date of Getting Virus");

            if(int.TryParse(Console.ReadLine(), out int userChoice))
            {
                PositivesComprasionDelegate comprasionDelegate = null;

                switch(userChoice)
                {
                    case 1:
                        comprasionDelegate = (x, y) => x.Name.CompareTo(y.Name);
                        break;
                    case 2:
                        comprasionDelegate = (x, y) => x.DateOfBirth.CompareTo(y.DateOfBirth);
                        break;
                    case 3:
                        comprasionDelegate = (x, y) => x.DateOfGettingVirus.CompareTo(y.DateOfGettingVirus);
                        break;

                    default:
                        Console.WriteLine("Inavalid choice!!");
                        break;
                }
            }
        }

    }
}
