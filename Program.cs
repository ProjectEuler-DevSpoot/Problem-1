/*
 * Project Euler; Problem 1.
 * 
 * If we list all the natural numbers below $10$ that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
 * Find the sum of all the multiples of 3 or 5 below 1000.
 * 
 * KEYWORD: or
 * 
 * @author Nathaniel A. Rivera
 * @modified 7/28/24 2119 PDT.
 */

int sumOf1000 = 0;

for(int i = 0; i < 1000; i++)
{

    if (i % 3 == 0 || i % 5 == 0) 
        { sumOf1000 = sumOf1000 + i;}

}


Console.WriteLine("The Sum Of All Multiples of 3 and 5 for under 1000 is...");
Console.WriteLine(sumOf1000);