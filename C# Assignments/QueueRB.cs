using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIS.RB
{
    class QueueRB
    {
        
        int rear, front, count, MAX_QV;                 // Declaration of top element of queue.
        int[] queue;

        public QueueRB(int QueueSize)           // Declaring a new queue every time an object is 
        {
                rear = -1;
                front = 0;
                MAX_QV = QueueSize;
                queue = new int[QueueSize];
                count = 0;
        }

        public void EnqueueRB(int value)        // Add a element in a queue.
        {
            if(count == MAX_QV)
            {
                Console.WriteLine("Queue is full. Cannot enter more elements.");
            }

            else
            {
                    rear = (rear+1) % MAX_QV;
                    queue[rear] = value;
                    count++;
            }

                
        }

        public void DequeueRB()                // Delete an element from the queue.
        {
            if(count == 0)
                {
                    Console.WriteLine("Queue is empty. Cannot delete more elements.");
                }
            else
                {
                    Console.WriteLine("Element is deleted from front and deleted element is: {0}", queue[front]);
                    front = (front+1) % MAX_QV;
                    count--;
                }
        }

        public void PrintQueue()              // Print elements from the queue.
        {
            if(count == 0)
                {
                    Console.WriteLine(" Queue is empty. Can't print any values!!");
                }
            else
                {
                    for(int i = rear; i<=front;i++)
                    {
                       Console.WriteLine(queue[i]);
                    }
                }

        }

        public static void Main(String[] args)
        {
                    char answer = 'Y';
                    QueueRB Queueobj = new QueueRB(5);
               
                    
                    while (answer == 'Y')
                    {
                        try{
                        Console.WriteLine("\n Enter the operation, you want to perform in Queue:" +
                                          "\n *******MENU*******"
                                          + "\n 1. ENQUEUE"
                                          + "\n 2. DEQUEUE"
                                          + "\n 3. PRINT QUEUE"
                                          + "\n 4. EXIT");
                        string myChoice;
                        myChoice = Console.ReadLine();
                        int choice = Convert.ToInt32(myChoice);

                        switch (choice)
                        {
                            case 1:
                                string inputVal;
                                Console.WriteLine("Enter value you want to enqueue into queue");
                                inputVal = Console.ReadLine();
                                int inputEnqueue = Convert.ToInt32(inputVal);
                                Queueobj.EnqueueRB(inputEnqueue);
                                break;
                            case 2:
                                Queueobj.DequeueRB();
                                Console.WriteLine("Value has been Dequeued!");
                                break;
                            case 3:
                                Queueobj.PrintQueue();
                                break;
                            case 4:
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
                        catch(Exception e)
                        {
                            Console.WriteLine(e.Message);
                    
                        }
                    
                    }
                        Console.Read();
            
        }


    }
}
