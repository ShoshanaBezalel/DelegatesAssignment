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

        public void Sort(List<Positives> positiveCases)
        {
            Console.WriteLine("Choose a sorting option:");
            Console.WriteLine("1. Sort by Name");
            Console.WriteLine("2. Sort by Date of Birth");
            Console.WriteLine("3. Sort by Date of Getting Virus");

            if(int.TryParse(Console.ReadLine(), out int userChoice))
            {
                PositivesComprasionDelegate comparisonDelegate = null;

                switch(userChoice)
                {
                    case 1:
                        comparisonDelegate = (x, y) => x.Name.CompareTo(y.Name);
                        break;
                    case 2:
                        comparisonDelegate = (x, y) => x.DateOfBirth.CompareTo(y.DateOfBirth);
                        break;
                    case 3:
                        comparisonDelegate = (x, y) => x.DateOfGettingVirus.CompareTo(y.DateOfGettingVirus);
                        break;

                    default:
                        Console.WriteLine("Inavalid choice!!");
                        break;
                }
                if(comparisonDelegate != null)
                {
                    positiveCases.Sort((x, y) => comparisonDelegate(x, y));
                }
            }
            else Console.WriteLine("Invalid input!");
        }

    }
}
