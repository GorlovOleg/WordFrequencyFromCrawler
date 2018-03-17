/*
Author          : Sr Programmer Analyst Oleg Gorlov
Description:	: Assigment 
Copyright       : GMedia-IT-Consulting 
email           : oleg_gorlov@yahoo.com
Date            : 03/11/2018
Release         : 1.0.0
Comment         : 

3) Write a function f(a, b) which takes two character string arguments and returns a string containing only the characters found in both strings.

 */

using System;
using System.Collections.Generic;
using System.Text;

namespace SmartSystems
{
    public class SubTwoStrings
    {
        /// <summary>
        /// a function subTwoString(a, b) which takes two character string arguments 
        /// </summary>
        /// <param name="a">char[] </param>
        /// <param name="b">char[] </param>
        /// <returns> char[] returns a string containing only the characters found in both strings</returns>
        public char[] subTwoString(char[] a, char[] b) 
        {
            string ret = "";

            for (int i = 0; i < a.Length; i++)
                for (int j = 0; j < b.Length; j++)
                {
                    if (a[i] == b[j])
                    {
                        if (ret.IndexOf(a[i]) == -1)
                            ret += a[i];
                        break;
                    }
                }

            return ret.ToCharArray();
        }

    }
}
