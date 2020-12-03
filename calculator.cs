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
            int action = Convert.ToInt32(Console.ReadLine());  
            Console.WriteLine("Enter 1st input");  
            int input1 = Convert.ToInt32(Console.ReadLine());  
            Console.WriteLine("Enter 2nd input");  
            int input2 = Convert.ToInt32(Console.ReadLine());  
            int result = 0;  
            switch (action) {  
                case 1: {  
                    result = Addition(input1, input2);  
                    break;  
                }  
                case 2: {  
                    result = Subtraction(input1, input2);  
                    break;  
                }  
                case 3: {  
                    result = Multiplication(input1, input2);  
                    break;  
                }  
                case 4: {  
                    result = Division(input1, input2);  
                    break;  
                }  
                default:  
                    Console.WriteLine("Wrong operation");  
                    break;  
            }  
            Console.WriteLine("The result is {0}", result);  
            Console.ReadKey();  
        }  
        
        public static int Addition(int input1, int input2) {  
            int result = input1 + input2;  
            return result;  
        }  
        
        public static int Subtraction(int input1, int input2) {  
            int result = input1 + input2;  
            return result;  
        } 
        public static int Multiplication(int input1, int input2) {  
            int result = input1 + input2;  
            return result;  
        }  
        
        public static int Division(int input1, int input2) {  
            int result = input1 + input2;  
            return result;  
        }  
    }  
}  