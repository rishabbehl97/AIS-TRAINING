using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIS.RB
{
    class Calculator
    {
        public int Add(int n, int m)
        {
            int sum = n + m;
            return sum;
        }

        public int Subtract(int m, int n)
        {
            return (m - n);
        }

        public int Multiply(int m, int n)
        {
            return (m * n);
        }

        public int Divide(int m, int n)
        {
            try
            {
                int div = (m / n);
                return div;
            }
            catch
            {
                Console.Write("Cannot Divide a number by zero!");
                return -1;
            }
        }

        public int Modulus(int m, int n)
        {
            return (m % n);
        }

           public static void Main(String []args)
           {
               Calculator c = new Calculator();
               Console.WriteLine("Enter First number");
               string num1;                         
               num1 = Console.ReadLine();
               int num_1 = Convert.ToInt32(num1);
               Console.WriteLine("Enter Second number");
               string num2;
               num2 = Console.ReadLine();
               int num_2 = Convert.ToInt32(num2);
               Console.WriteLine("\n Enter the operation:" +
                              "\n *******MENU*******"
                              +"\n 1. ADD"
                              +"\n 2. SUBTRACT"
                              +"\n 3. MULTIPLY"
                              +"\n 4. DIVIDE"
                              +"\n 5. MODULUS");
               string num3;
               num3 = Console.ReadLine();
               int choice = Convert.ToInt32(num3);
               switch (choice)
               {
                   case 1:
                       Console.WriteLine("RESULT IS :"+c.Add(num_1,num_2));
                       break;
                   case 2:
                       Console.WriteLine("RESULT IS :" +c.Subtract(num_1, num_2));
                       break;
                   case 3:
                       Console.WriteLine("RESULT IS :" +c.Multiply(num_1, num_2));
                       break;
                   case 4:
                       Console.WriteLine("RESULT IS :" +c.Divide(num_1, num_2));
                       break;
                   case 5:
                       Console.WriteLine("RESULT IS :" +c.Modulus(num_1, num_2));
                       break;
                   default:
                       Console.WriteLine("Wrong choice. Better luck next time!!");
                       break;
               }
               Console.Read();
           }
       }
    }
}
