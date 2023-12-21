using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace T13._3
{
    class Exp
    {
        /// <summary>
        /// Variables
        /// </summary>
        int a;
        int b;
        /// <summary>
        /// Properties of variables
        /// </summary>
        public int A { get => a; set => a = value; }
        public int B { get => b; set => b = value; }
        /// <summary>
        /// Constructor without parameters
        /// </summary>
        public Exp() { }
        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public Exp(int a, int b)
        {
            this.A = a; this.B = b;
        }
        public void Expression(string operation)
        {
            switch (operation)
            {
                case "/":
                    WriteLine($"\nResult: {A} / {B} = {A / B:f2}\t{B} / {A} = {B / A:f2}");
                    break;
                case "-":
                    WriteLine($"\nResult: {A} - {B} = {A - B}\t{B} - {A} = {B - A}");
                    break;
                default:
                    WriteLine("\nThis operation doesn't exist.");
                    break;
            }
        }
        public void Expression1(string operation)
        {
            /*switch (operation)
            {
                case "A++":
                   return A++;
                case "B++":
                    return B++;
                case "*=":
                    return A *= B;
                case "-":
                    return A - B;
                default:
                    return 0;

            }*/
            switch (operation)
            {
                case "++":
                    WriteLine($"\nResult: {A++} = {A}\t{B++} = {B}");
                    break;
                case "*=":
                    WriteLine($"\nResult: {A} *= {B} = {A *= B}\t{B} *= {A} = {B *= A}");
                    break;
                case "-":
                    WriteLine($"\nResult: {A} - {B} = {A - B}\t{B} - {A} = {B - A}");
                    break;

                default:
                    WriteLine("\nThis operation doesn't exist.");
                    break;
            }
        }

    }
}
