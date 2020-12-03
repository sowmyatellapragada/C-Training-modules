using System;  
using System.Collections.Generic;  
  
namespace Calculator {  
    class Program {  
        static void Main(string[] args) {  
            Console.WriteLine("Enter the operation");  
            Console.WriteLine("Press 1 for Addition");  
            Console.WriteLine("Press 2 for Subtraction");  
            Console.WriteLine("Press 3 for Multiplication");  
            Console.WriteLine("Press 4 for Division \n");  
            double action = Convert.ToInt32(Console.ReadLine());  
            Console.WriteLine("Enter 1st input");  
            double input_1 = Convert.ToDouble(Console.ReadLine());  
            Console.WriteLine("Enter 2nd input");  
            double input_2 = Convert.ToDouble(Console.ReadLine());  
            double result = 0;  
            switch (action) {  
                case 1: {  
                    result = Addition(input_1, input_2);  
                    break;  
                }  
                case 2: {  
                    result = Subtraction(input_1, input_2);  
                    break;  
                }  
                case 3: {  
                    result = Multiplication(input_1, input_2);  
                    break;  
                }  
                case 4: {  
                    result = Division(input_1, input_2);  
                    break;  
                }  
                default:  
                    Console.WriteLine("Wrong action!! try again");  
                    break;  
            }  
            Console.WriteLine("The result is {0}", result);  
            Console.ReadKey();  
        }  
        //Addition  
        public static double Addition(double input_1, double input_2) {  
            double result = input_1 + input_2;  
            return result;  
        }  
        //Substraction  
        public static double Subtraction(double input_1, double input_2) {  
            double result = input_1-input_2;  
            return result;  
        }  
        //Multiplication  
        public static double Multiplication(double input_1, double input_2) {  
            double result = input_1 * input_2;  
            return result;  
        }  
        //Division  
        public static double Division(double input_1, double input_2) {  
            double result = input_1 / input_2;  
            return result;  
        }  
    }  
}  
