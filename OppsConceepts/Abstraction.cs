using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConceepts
{
    abstract class Abstraction
    {
        public abstract void Salary(); // abstract Methode
        public void NonAbstractMethode() // Non Abstract Methode
        {
            Console.WriteLine("This is Non Abstract Methode");
        }
    }

    class DetailsInfo : Abstraction
    {
        int salary = 10000;
        public override void Salary()
        {
            Console.WriteLine("Salary of Employee is "+ salary);
        }
    }
}
