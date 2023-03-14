using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConceepts
{
    public class Variables
    {
        public int mathMarks; //These variables are instance variables
        public int engMarks; //These variables are instance variables

        public static int salary; //static variable

        public const int downPayment = 1000; //constant variable

        public readonly string userName; //readonly variables
        public Variables()
        {
            this.userName = "Mahesh";
        }
        public void SampleMethod()
        {

            int tempVariable; // local Variable
            string sampleStringVariable = "Mahesh"; // local variable
            tempVariable = 10;
            Console.WriteLine(tempVariable);
            Console.WriteLine(sampleStringVariable);
        }
       
    }
}
