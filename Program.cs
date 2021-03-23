using System;
using System.Collections.Generic;

namespace recursion_practice
{
    class Program
    {
      

        static void Main(string[] args)
        {
            //exercise 1
            // Console.WriteLine("the sum of numbers from 1 to n is " + addNumbersN(100,0));

            //exercise 2
            // Console.WriteLine("the sum of number's digits  is " + addDigits(8156782,0));

            //exercise 3 to know if a number is prime or not
            //int number = 449;
            // int cont = number - 1;
            // if(primeNumber(number, cont)) Console.WriteLine("the number is prime");
            // else { Console.WriteLine("the number is not prime"); }

            //exercise 4  
            int buildsToJump = 5;

           Console.WriteLine("the ways to jump builds is "+ spiderman(buildsToJump + 1));



        }

/*
	1. Write a program in C# to calculate the sum of numbers from 1 to n using recursion. Go to the editor
	Test Data : 
	Input the last number of the range starting from 1 : 5 
	Expected Output :


    The sum of numbers from 1 to 5 : 
	15


*/

public static int addNumbersN(int n, int sum)
        {
            if (n == 0) return sum;
            sum = sum + n;
            return addNumbersN(n - 1, sum);
        }

/*
	2. Write a program in C# to find the sum of digits of a number using recursion. Go to the editor
	Test Data : 
	Input any number to find sum of digits: 25 

    Expected Output :


    The Sum of digits of 25 = 7 


*/


        public static int addDigits(int number, int sumDigits)
        {
            if (number / 10 < 10) return sumDigits + number%10 + number/10;
            sumDigits = sumDigits + number % 10;
            return addDigits(number / 10, sumDigits);

        }

        /*
         * 
         * 	3. Write a program in C to check a number is a prime number or not using recursion. Go to the editor
	    Test Data : 
	    Input any positive number : 7 
	    Expected Output :

	    The number 7 is a prime number.  

        */

        public static bool primeNumber(int number,  int cont)
        {
            if (cont == 0) return false;
            if (cont == 1 && number % 1 == 0) return true;

            int prime = number % cont;
            return prime != 0 && primeNumber(number, cont - 1);
        }


    /*
     * 	4. Spiderman is capable to jump one or two buildings


	    0				|	|	|	|
	    Spiderman		b1	b2	b3	b4

	    Spider could jump to b1, or b2. Once Spiderman has jumped to the b2, he could jump to the b3 or b4 buildings. 
	    Spiderman is always able to jump 1 or 2 buildings.
	    How many ways has Spiderman to go up n buildings.

	    (e.g.) 

	    input
	    n = 3

	    0				|	|	|
	    Spiderman		b1	b2	b3

	    output
	    way 1 (b1, b3)
	    way 2 (b1, b2, b3)
	    way 3 (b2, b3)

	    Answer: 3 ways.

            */

         public static int spiderman(int builds)
        {
            
            if (builds == 1 || builds == 2) return 1;
            return spiderman(builds-1) + spiderman (builds - 2);

        }


    }
}
