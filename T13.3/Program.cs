using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T13._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Enter A: ");
            //float a = float.Parse(ReadLine());
            int a = Convert.ToInt32(ReadLine());
            Write("Enter B: ");
            //float b = float.Parse(ReadLine());
            int b = Convert.ToInt32(ReadLine());
            Exp exp = new Exp(a, b);
            //Write("\nChoose which operation u want to reform: / or -.\nEnter operation: ");
            //string operation = ReadLine();
            Write("\nChoose which operation u want to reform: ++ or *= or -.\nEnter operation: ");
            string operation = ReadLine();
            //exp.Expression1(operation);
            exp.Expression1(operation);

            ReadKey();
        }
    }
}
