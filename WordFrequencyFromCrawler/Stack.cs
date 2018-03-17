/*
Author          : Sr Programmer Analyst Oleg Gorlov
Description:	: Assigment 
Copyright       : GMedia-IT-Consulting 
email           : oleg_gorlov@yahoo.com
Date            : 03/11/2018
Release         : 1.0.0
Comment         : 

2) Create your own class or a set of functions that implement a stack. 

   Include the following four methods:a. Push: Adds a data element to the top of the stackb. 
   Pop: Removes a data element from the top of the stack. 
   Size: Returns the total number of elements in the stack. 
   isEmpty: Returns true if the stack is empty.Insert your answer here

   C# Program Implemented Stack with Push and Pop operations.
   Push enters an item on the stack, 
   Pop retrieves an item, moving the rest of the items in the stack up one level.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartSystems
{
    class Stack : IStack
    {
        //--- size Stack
        private int StackSize;
        //--- top Stack
        public int top;
        //--- items in Stack
        Object[] item;

        public int StackSizeSet
        {
            get { return StackSize; }
            set { StackSize = value; }
        }

        public Stack()
        {
            StackSizeSet = 10;
            item = new Object[StackSizeSet];
            top = -1;
        }

        public Stack(int capacity)
        {
            StackSizeSet = capacity;
            item = new Object[StackSizeSet];
            top = -1;
        }

        /// <summary>
        /// a function Display shows items in Stack
        /// </summary>
        public void Display()
        {
            for (int i = top; i > -1; i--)
            {

                Console.WriteLine("Item {0}: {1}", (i + 1), item[i]);
            }
        }

        /// <summary>
        /// a function Size() which takes two character string arguments 
        /// </summary>
        /// <returns> int Returns the total number of elements in the stack </returns>
        public int Size()
        {
            return top+1;
        }

        /// <summary>
        /// a function isEmpty() which takes two character string arguments 
        /// </summary>
        /// <returns> int Returns true if the stack is empty. </returns>
        public bool isEmpty()
        {
            if(top == -1) return true;

            return false;
        }

        /// <summary>
        /// a function Peek: Returns the object at the top of the Stack without removing it.
        /// </summary>
        /// <returns> int Returns the object at the top of the Stack without removing it. </returns>
        public object Peek()
        {
            if (isEmpty())
            {

                Console.WriteLine("Stack is empty!");
                return "No elements";
            }
            else
            {
                return item[top];
            }
        }

        /// <summary>
        /// a function Pop: Removes a data element from the top of the stack
        /// </summary>
        public object Pop()
        {
            if (isEmpty())
            {
                Console.WriteLine("Stack is empty!");
                return "No elements";
            }
            else
            {

                return item[top--];
            }
        }

        /// <summary>
        /// a function Push: Adds a data element to the top of the stack
        /// </summary>
        public void Push(object element)
        {
            if (top == (StackSize - 1))
            {
                Console.WriteLine("Stack is full!");
            }

            else
            {

                item[++top] = element;
                Console.WriteLine("Item pushed successfully!");
            }
        }


    }
}
