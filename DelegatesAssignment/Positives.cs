using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAssignment
{
    internal class Positives
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateOfGettingVirus { get; set; }
        public DateTime DateOfTest { get; set; }
        public int Age => DateTime.Now.Year - DateOfBirth.Year;
        public string VariantType { get; set; }

    }
}
