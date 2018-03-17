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
    Pop: Removes a data element from the top of the stackc. 
    Size: Returns the total number of elements in the stackd. 
    isEmpty: Returns true if the stack is empty.Insert your answer here
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace SmartSystems
{

    /// <summary>
    /// interface IStack
    /// </summary>
    interface IStack
    {
        Boolean isEmpty();
        void Push(Object element);
        Object Pop();
        Object Peek();
        int Size();
        void Display();
    }
}
