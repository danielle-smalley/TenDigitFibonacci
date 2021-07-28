using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace TenDigitFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            //The Fibonacci sequence is defined by the recurrence relation:

            //Fn = Fn−1 + Fn−2, where F1 = 1, F2 = 1, F3 = 2, .... and F12 = 144.F12 is the first term to contain three digits.

            //What is the index of the first term in the Fibonacci sequence to contain 10 digits ?


            //So here are the first 12 terms:
            /* F1 = 1
             * F2 = 1
             * F3 = 2
             * F4 = 3
             * F5 = 5
             * F6 = 8
             * F7 = 13
             * F8 = 21
             * F9 = 34
             * F10 = 55
             * F11 = 89
             * F12 = 144
             * 
             * Note for myself: A 10 digit number would look like: 1,000,000,000 (billion)
             * 
             */

            int n1 = 0; //first number
            int n2 = 1; //second number
            int sum = 0; //starting point for sum

            ArrayList fiboTenIndex = new ArrayList(); //create an array list to hold the values so I can count them in while loop to find index

            while (sum < 1000000000) //first instance of 10 digits
            {
                sum = n1 + n2; //sum (resulting next number) is first number + second number in fibo sequence

                n1 = n2; //this is resetting number 1 to be number 2 to start over in taking 1st number + second number to get = third number in fibo sequence
                n2 = sum; //Again, resetting but setting number 2 to be the next number 3
                fiboTenIndex.Add(sum); //So the while loop loops through the "next"/3rd fibo number until we reach 10 digits for the number/result. This line of code is counting the index each time, so we can see which index exactly is the 10 digit long number
            }

            Console.WriteLine((fiboTenIndex.Count + 1) + " is the index where we encounter the first 10 digit number in the Fibonacci sequence. The result itself is " + sum);


            //int length = 1000;
            //int n1 = 1;
            //int n2 = 1;
            //int n3 = 0;

            //for (int i = 1; i < length; i++)
            //{
            //    n3 = n1 + n2;
            //    i += n3;
            //}

            //n1 = n2;
            //n2 = n3;

            //Console.WriteLine(n3);



            //int n1 = 1;
            //int n2 = 2;
            //int n3 = 0;
            //int count = 2;

            //while (count < 1001)
            //{
            //    n3 = n1 + n2;
            //    count += n3;
            //}
            //n1 = n2;
            //n2 = n3;

            //Console.WriteLine(count);

            //int i = 0;
            //int count = 2;
            //int fib = new int[3];

            //int count = 3;
            //IDictionary Fib = new Dictionary();
            //Fib.Add(0, 0);
            //Fib.Add(1, 1);
            //Fib.Add(2, 1);
            //while (true)
            //{

            //}



        }//end main
    }//end class
}//end namespace
