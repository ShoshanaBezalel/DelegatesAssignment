using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAssignment
{
    internal class PositivesManager
    {
        private List<Positives> positiveCases = new List<Positives>();

        public void AddPositives(Positives userCase)
        {
            positiveCases.Add(userCase);
        }

        public void DisplayPositives()
        {
            Console.WriteLine("Positives Details:");

            foreach (var positiveCase in positiveCases)
            {
                Console.WriteLine($"Name: {positiveCase.Name} | Age: {positiveCase.Age} | Get the virus on: {positiveCase.DateOfGettingVirus} | Get virus test on: {positiveCase.DateOfTest} | Variant type: {positiveCase.VariantType}");
            }
        }
    }
}
