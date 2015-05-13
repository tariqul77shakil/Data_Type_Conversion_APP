using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 10;
            double secondNumber = firstNumber; //Implicit Conversion (Double bigger than Int).

            double anofirstNumber = 10.33;
            int anosecondfNumber = (int)anofirstNumber;  //Explicit Conversion.
            

            char aChar = 'A';
            int value = aChar;  //Implicit Conversion

            int value2 = 97;
            char anoChar = (char)value2;  //Explicit Conversion

            double dnum = 65.345;
            char cvalue = (char)dnum;   //Explicit Conversion

            String a = "Shakil";
            int cs = Convert.ToInt32(a);


            Console.WriteLine("  "+cvalue);
            Console.ReadKey();

        }
    }
}
