using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConceepts
{
    public class TypeOfMethods
    {
       
    }

    public abstract class A
    {
        public abstract void Salary(); // abstract Methode
    }
    public class B : A
    {
        int salary = 10000;
        public override void Salary()
        {
            Console.WriteLine("Salary of Employee is " + salary);
        }
    }
}
