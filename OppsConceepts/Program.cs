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
            Console.ReadLine();
        }
    }
}
