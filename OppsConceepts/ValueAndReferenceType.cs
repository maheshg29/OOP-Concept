using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConceepts
{
    public class ValueAndReferenceType
    {
        //A data type is a value type if it holds a data value within its own memory space.
        //It means the variables of these data types directly contain values.
        int age;      // its store intiger vaule like 12,50...
        char code;    // its store single character like m.M...
        bool yesOrNo; // its store only true and False.
        decimal Speed;
        double salary;
        float teamperature;
        // this are all Value Type data types
        //------------------//
        //a reference type doesn't store its value directly. Instead,
        //it stores the address where the value is being stored.

        string studentName="Mahesh";
        //Arrays(even if their elements are value types)
        int[] marks = new int[5] { 99, 98, 92, 97, 95 };

        double[] balance = { 2340.0, 4523.69, 3421.0 };

        //Class
        //Delegate
    }
}
