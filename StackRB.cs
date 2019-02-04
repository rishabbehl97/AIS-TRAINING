using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIS.RB
{
    class StackRB
    {
        static readonly int MAX_SV = 1000;      // Consider any random varible , to be infinity
        int top;                                // Declaration of top element of stack.
        int[] stack = new int[MAX_SV];

        public bool IsEmpty()                   // It will return if stack is empty or not [Boolean function return 0(if empty) or 1]
        {
            return (top < 0);
        }

        public StackRB()                        // Constructor [Every time obj is created it'll initialize top to -1.
        {
            top = -1;
        }

        public bool PushInStack(int inputVal)       // Function to insert elements in the stack.
        {
            if (top >= MAX_SV)
            {
                Console.WriteLine("Stack has overflowed. Kindly adjust.");
                return false;
            }
            else
            {
                stack[++top] = inputVal;
                return true;
            }
        }

        public int PopFromStack()                   // Function to remove one element from the stack
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow. Please fill something first in the stack.");
                return 0;
            }
            else
            {
                int valueDeleted = stack[top--];
                return valueDeleted;
            }
        }

        public void PeekInStack()                   // Function to check the stack values.
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow. Please fill something in the stack.");
                return;
            }
            else
            {
                Console.WriteLine(" Element at the top: {0}", stack[top]);
            }
        }

        public void PrintStack()                  // Function to print the values of stack.
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow. Kindly fill something in the stack.");
                return;
            }
            else
            {
                Console.WriteLine("Elements of the stack are as:");
                for (int i = top; i >= 0; i--)
                {
                    Console.WriteLine(stack[i]);
                }
            }
        }
        
                public static void Main(String[] args)
                {
                    char answer = 'Y';
                    StackRB Stackobj = new StackRB();
                    while (answer == 'Y')
                    {
                        Console.WriteLine("\n Enter the operation, you want to perform in stack:" +
                                          "\n *******MENU*******"
                                          + "\n 1. PUSH"
                                          + "\n 2. POP"
                                          + "\n 3. PEEK"
                                          + "\n 4. DISPLAY"
                                          + "\n 5. EXIT");
                        string myChoice;
                        myChoice = Console.ReadLine();
                        int choice = Convert.ToInt32(myChoice);

                        switch (choice)
                        {
                            case 1:
                                string inputVal;
                                Console.WriteLine("Enter value you want to push into stack");
                                inputVal = Console.ReadLine();
                                int inputPush = Convert.ToInt32(inputVal);
                                Stackobj.PushInStack(inputPush);
                                break;
                            case 2:
                                Console.WriteLine("Value has been popped out! And value is : {0}" + Stackobj.PopFromStack());
                                break;
                            case 3:
                                Stackobj.PopFromStack();
                                break;
                            case 4:
                                Stackobj.PrintStack();
                                break;
                            case 5:
                                return;
                            default:
                                Console.WriteLine("Wrong choice. Try it again!!");
                                break;
                        }

                        Console.WriteLine(" Do you want to continue. If yes press Y and if no press N");
                        String ans = Console.ReadLine();
                        char ans_1 = Convert.ToChar(ans);

                        if(ans_1 == 'Y')
                        {
                            continue;
                        }
                        else
                        {
                            answer = 'N';
                        }
                    }
                        Console.Read();

                }
            }
            
    }
}
