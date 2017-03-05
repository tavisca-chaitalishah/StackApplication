using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackApplication
{
    class StackManager
    {
        int[] stack = new int[10];
        static int top = -1;
        public void StackOperationLogic()
        {

            int choice;
           
            Console.WriteLine("Stack MENU \n1. Add an element\n2. See the Top Element\n3. Remove the Top Element\n4. Display Stack Elements\n5. Exit");
            do
            {
                Console.WriteLine("Select Your Choice :");

                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter an element to add");
                        int pushItem = Convert.ToInt32(Console.ReadLine());
                        PushElement(pushItem);

                        break;
                    case 2:
                      
                        DisplayTopElement();

                        break;
                    case 3:
                       
                        popElement();
                        break;
                    case 4:
                        Console.WriteLine("Stack Elements are");
                        DisplayStack();
                        break;
                    case 5:
                        Console.WriteLine("Thankyou");
                        Environment.Exit(0);

                        break;
                    default:
                        Console.WriteLine("Wrong Input");
                        break;
                }
                

            } while (true);

           
        }
        void PushElement(int pushItem)
        {
            if (top == 9)
            {
                Console.WriteLine("Stack is Full");
            }
            else
            {
                top++;
                stack[top] = pushItem;
                Console.WriteLine("Item Pushed Successfully!");
            }
        }

        void popElement()
        {
            int popVariable;
            if (top == -1)
            {
                Console.WriteLine("Stack is Empty");
            }
            else
            {
                popVariable = stack[top];
               
                Console.WriteLine("Pop Variable is : {0}", popVariable);
                top--;
            }

        }

        void DisplayTopElement()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is Empty");
            }
            else
            {
                Console.WriteLine("Top Element is : " + stack[top]);
            }
        }

        void DisplayStack()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is Empty");
            }
            else
            {
                for (int iterator = top; iterator >= 0; iterator--)
                {
                    Console.WriteLine(stack[iterator] + "\t");
                }
            }
        }
    }
}






