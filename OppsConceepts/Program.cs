using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConceepts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To OOP Concept");
            ObjectAndClass objectAndClass=new ObjectAndClass();
            objectAndClass.SampleMethode();

            Car car = new Car();
            string brandName = "BMW";
            car.Brand(brandName);
            car.MethodInVehical();
            car.MethodeInCar();

            Polymorphism polymorphism = new Polymorphism();
            Console.WriteLine("Enter 2 Digit for Addition");
            int digitOne = Convert.ToInt32(Console.ReadLine());
            int digitTwo = Convert.ToInt32(Console.ReadLine());
            int resultOne = polymorphism.Add(digitOne, digitTwo);

            Console.WriteLine("Enter 3rd Digit for addition");
            int digitThree=Convert.ToInt32(Console.ReadLine());
            int resultTwo = polymorphism.Add(digitTwo, digitOne, digitThree);

            Polymorphism circle = new Circle();
            Console.WriteLine("Area :" + circle.Area());

            Polymorphism square = new Square();
            Console.WriteLine("Area :" + square.Area());

            Encapsulation encapsulation = new Encapsulation();
            Console.WriteLine("Enter Employee Name");
            encapsulation.name = Console.ReadLine();
            encapsulation.SetSalary(8000);
            Console.WriteLine("Salary of" + encapsulation.name + " is " + encapsulation.GetSalary());

            DetailsInfo detailsInfo = new DetailsInfo();
            detailsInfo.NonAbstractMethode();
            detailsInfo.Salary();
            Console.ReadLine();
        }
    }
}
