﻿using System;
using System.Collections.Generic;
using System.Linq;


namespace spring2021_Assignment_1__Siddhi_kulkarni
{
 
        class Program
        {
            static void Main(string[] args)
            {
                //Question 1
                Console.WriteLine("Q1 : Enter the number of rows for the traingle:");
                int n = Convert.ToInt32(Console.ReadLine()); //this sets integer variable n.
                printTriangle(n);     //calling function pritTrainagle  which has been implemented below
                Console.WriteLine();

                //Question 2:
                Console.WriteLine("Q2 : Enter the number of terms in the Pell Series:");
                int n2 = Convert.ToInt32(Console.ReadLine());  //this sets integer variable n2.
                printPellSeries(n2);    //calling function printPellSeries  which has been implemented below
                Console.WriteLine();

                //Question 3:
                Console.WriteLine("Q3 : Enter the number to check if squareSums exist:");
                int n3 = Convert.ToInt32(Console.ReadLine()); //this sets integer variable n3.
                bool flag = squareSums(n3);   //calling function squareSums  which has been implemented below
                if (flag)
                {
                    Console.WriteLine("Yes, the number can be expressed as a sum of squares of 2 integers");
                }
                else
                {
                    Console.WriteLine("No, the number cannot be expressed as a sum of squares of 2 integers");
                }

                //Question 4:
                int[] arr = { 3, 1, 4, 1, 5 };
                Console.WriteLine("\n Q4: Enter the absolute difference to check");
                int k = Convert.ToInt32(Console.ReadLine());
                int n4 = diffPairs(arr, k);  //calling function diffPairs  which has been implemented below
                Console.WriteLine("There exists {0} pairs with the given difference", n4);

                //Question 5:
                List<string> emails = new List<string>();
                emails.Add("dis.email + bull@usf.com");
                emails.Add("dis.e.mail+bob.cathy@usf.com");
                emails.Add("disemail+david@us.f.com");
                int ans5 = UniqueEmails(emails);    //calling function UniqueEmails  which has been implemented below
                Console.WriteLine("Q5");
                Console.WriteLine("The number of unique emails is " + ans5);

                //Quesiton 6:
                string[,] paths = new string[,] { { "London", "New York" }, { "New York", "Tampa" },
                                        { "Delhi", "London" } };
                string destination = DestCity(paths);   //calling function DestCity  which has been implemented below
                Console.WriteLine("Q6");
                Console.WriteLine("Destination city is " + destination);

            }

            /// <summary>
            ///Print a pattern with n rows given n as input
            ///n – number of rows for the pattern, integer (int)
            ///This method prints a triangle pattern.
            ///For example n = 5 will display the output as: 
            ///     *
            ///    ***
            ///   *****
            ///   *******
            ///  *********
            ///returns      : N/A
            ///return type  : void
            /// </summary>
            /// <param name="n"></param>
            private static void printTriangle(int n)
            {
                try
                /* 
                 * We suspect that this block of the statement can throw 
                 * exception so we handled it by placing these statements
                 * inside try and handle the exception in the catch block
                */
                {
                    int i = 0, j = 0, a = 1, blank, k = n;
                    blank = k - 1;
                    for (i = 1; i <= k; i++)
                    {
                        for (j = 1; j <= blank; j++)
                        {
                            Console.Write(" ");
                        }
                        for (j = 1; j < a * 2; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine("");
                        if (i < k)
                        {
                            blank--;
                            a++;
                        }
                        else
                        {
                            blank++;
                            a--;

                        }
                    }

                }
                catch (Exception)
                {
                    /*
                    * This is a generic Exception handler which means it can handle
                    * all the exceptions. This will execute if the exception is not
                    * handled by previous catch blocks.
                    */

                    Console.WriteLine("Exception Occured while computing printPattern");
                }

            }

            /// <summary>
            ///<para>
            ///In mathematics, the Pell numbers are an infinite sequence of integers.
            ///The sequence of Pell numbers starts with 0 and 1, and then each Pell number is the sum of twice of the previous Pell number and 
            ///the Pell number before that.:thus, 70 is the companion to 29, and 70 = 2 × 29 + 12 = 58 + 12. The first few terms of the sequence are :
            ///0, 1, 2, 5, 12, 29, 70, 169, 408, 985, 2378, 5741, 13860,… 
            ///Write a method that prints first n numbers of the Pell series
            /// Returns : N/A
            /// Return type: void
            ///</para>
            /// </summary>
            /// <param name="n2"></param>

            private static void printPellSeries(int n2)
            {
                try
                {
                    /* 
                     * We suspect that this block of the statement can throw 
                     * exception so we handled it by placing these statements
                     * inside try and handle the exception in the catch block
                    */
                    int i = 0;
                    int a = 0;
                    int x = 0;
                    int y = 1;
                    Console.Write(x + " ");                                                                //printing x as it is as its a first pell number.
                    Console.Write(y + " ");                                                                // printing y as it is, because its a second pell number.
                    for (i = 3; i <= n2; i++)                                                             //for loop to execute statements from n2 to 3.
                    {
                        a = 2 * y + x;                                                                   // formula for pell number.
                        Console.Write(a + " ");                                                          //printing a after checking 0,1 number in the pell series.
                        x = y;
                        y = a;
                    }
                    Console.WriteLine(" ");
                }
                catch (Exception e)
                {  /*
                *This is a generic Exception handler which means it can handle
               * all the exceptions. This will execute if the exception is not
               *handled by previous catch blocks.*/
                    Console.WriteLine("Exception Occured while computing printPellSeries" + e.Message);
                }
            }


            /// <summary>
            ///Given a non-negative integer c, decide whether there're two integers a and b such that a^2 + b^2 = c.
            ///For example:
            ///Input: C = 5 will return the output: true (1*1 + 2*2 = 5)
            ///Input: A = 3 will return the output : false
            ///Input: A = 4 will return the output: true
            ///Input: A = 1 will return the output : true
            ///Note: You cannot use inbuilt Math Class functions.
            /// </summary>
            /// <param name="n3"></param>
            /// <returns>True or False</returns>

            private static bool squareSums(int n3)
            {
                try
                {
                    /* 
                     * We suspect that this block of the statement can throw 
                     * exception so we handled it by placing these statements
                     * inside try and handle the exception in the catch block
                    */
                    for (long i = 1; i * i <= n3; i++)                                               //for loop to execute statements from 1 to n3
                    {
                        for (long j = 1; j * j <= n3; j++)                                           //for loop to execute statements from 1 to n3
                        {
                            if (i * i + j * j == n3)                                                //output should be the square of two numbers
                            {
                                return true;                                                       // checking if n3 satisfy the condition for squaresum
                            }
                        }
                    }
                    return false;
                }
                catch (Exception e)
                {
                    /*
                    * This is a generic Exception handler which means it can handle
                    * all the exceptions. This will execute if the exception is not
                    * handled by previous catch blocks.
                    */
                    Console.WriteLine("Exception Occured while computing squareSums" + e.Message);
                    throw;
                }
            }

            /// <summary>
            /// Given an array of integers and an integer n, you need to find the number of unique
            /// n-diff pairs in the array.Here a n-diff pair is defined as an integer pair (i, j),
            ///where i and j are both numbers in the array and their absolute difference is n.
            ///Example 1:
            ///Input: [3, 1, 4, 1, 5], k = 2
            ///Output: 2
            ///Explanation: There are two 2-diff pairs in the array, (1, 3) and(3, 5).
            ///Although we have two 1s in the input, we should only return the number of unique   
            ///pairs.
            ///Example 2:
            ///Input:[1, 2, 3, 4, 5], k = 1
            ///Output: 4
            ///Explanation: There are four 1-diff pairs in the array, (1, 2), (2, 3), (3, 4) and
            ///(4, 5).
            ///Example 3:
            ///Input: [1, 3, 1, 5, 4], k = 0
            ///Output: 1
            ///Explanation: There is one 0-diff pair in the array, (1, 1).
            ///Note : The pairs(i, j) and(j, i) count as same.
            /// </summary>
            /// <param name="nums"></param>
            /// <param name="k"></param>
            /// <returns>Number of pairs in the array with the given number as difference</returns>
            private static int diffPairs(int[] arr, int k)
            {
                try
                {
                    int count = 0;                                                             //this sets integer variable count with value as 0.
                    for (int i = 0; i < arr.Length; i++)                                      //for loop to execute statements from arr.Length to 0.
                    {
                        for (int j = i + 1; j < arr.Length; j++)
                            if (arr[i] - arr[j] == k ||                                                  // checking if the difference between two numbers is equal to the given integer k and 
                                arr[j] - arr[i] == k && arr[i] - arr[j] != 0 && arr[j] - arr[i] != 0)    //count it as one pair.
                                count++;
                    }

                    return count;

                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception Occured while computing diffPairs " + e.Message);
                    throw;
                }

            }

            /// <summary>
            /// An Email has two parts, local name and domain name. 
            /// Eg: rocky @usf.edu – local name : rocky, domain name : usf.edu
            /// Besides lowercase letters, these emails may contain '.'s or '+'s.
            /// If you add periods ('.') between some characters in the local name part of an email address, mail sent there will be forwarded to the same address without dots in the local name.
            /// For example, "bulls.z@usf.com" and "bullsz@leetcode.com" forward to the same email address.  (Note that this rule does not apply for domain names.)
            /// If you add a plus('+') in the local name, everything after the first plus sign will be ignored.This allows certain emails to be filtered, for example ro.cky+bulls @usf.com will be forwarded to rocky@email.com.  (Again, this rule does not apply for domain names.)
            /// It is possible to use both of these rules at the same time.
            /// Given a list of emails, we send one email to each address in the list.Return, how many different addresses actually receive mails?
            /// Eg:
            /// Input: ["dis.email+bull@usf.com","dis.e.mail+bob.cathy@usf.com","disemail+david@us.f.com"]
            /// Output: 2
            /// Explanation: "disemail@usf.com" and "disemail@us.f.com" actually receive mails
            /// </summary>
            /// <param name="emails"></param>
            /// <returns>The number of unique emails in the given list</returns>

            private static int UniqueEmails(List<string> emails)
            {
                try
                {
                    int count = 0;
                    int Listlength = emails.Count;
                    List<string> emailsNew = new List<string>();
                    for (int i = 0; i < Listlength; i++)
                    {
                        string fullemail = emails[i];
                        string local = fullemail.Split('@')[0]; // To split email id before @
                        string modifiedlocal = local.Split('+')[0]; // To get string before +

                        string domain = fullemail.Split('@')[1]; // To split email id after @
                        string[] string_array = modifiedlocal.Split(" ");
                        modifiedlocal = modifiedlocal.Replace(".", "");
                        fullemail = modifiedlocal + "@" + domain; //Merging the email id
                                                                  //Console.WriteLine("The final string: '{0}'", ListItem);
                        emailsNew.Add(fullemail); // Adding elements to new List called "emailsNew"
                    }
                    List<string> uniqueList = emailsNew.Distinct().ToList();
                    count = uniqueList.Count;
                    return count;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception occurred while computing UniqueEmails()" + e.Message);
                    throw;
                }

            }

            /// <summary>
            /// You are given the array paths, where paths[i] = [cityAi, cityBi] means there exists a direct path going from cityAi to cityBi. Return the destination city, that is, the city without any path outgoing to another city.
            /// It is guaranteed that the graph of paths forms a line without any loop, therefore, there will be exactly one destination city.
            /// Example 1:
            /// Input: paths = [["London", "New York"], ["New York","Tampa"], ["Delhi","London"]]
            /// Output: "Tampa" 
            /// Explanation: Starting at "Delhi" city you will reach "Tampa" city which is the destination city.Your trip consist of: "Delhi" -> "London" -> "New York" -> "Tampa".
            /// Input: paths = [["B","C"],["D","B"],["C","A"]]
            /// Output: "A"
            /// Explanation: All possible trips are: 
            /// "D" -> "B" -> "C" -> "A". 
            /// "B" -> "C" -> "A". 
            /// "C" -> "A". 
            /// "A". 
            /// Clearly the destination city is "A".
            /// </summary>
            /// <param name="paths"></param>
            /// <returns>The destination city string</returns>
            private static string DestCity(string[,] paths)
            {
                try
                {
                    List<string> y = new List<string>();  //Declaring an empty list with variable name as y
                    List<string> z = new List<string>(); //Declaring an empty list with variable name as z
                    string output = string.Empty;

                    int pathlength = (paths.Length) / 2;
                    for (int a = 0; a < pathlength; a++)
                    {
                        y.Add(paths[a, 0]);
                        z.Add(paths[a, 1]);
                    }
                    foreach (var x in z)
                    {
                        if (!y.Contains(x))
                            output = x;
                    }
                    return output;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception occurred while computing DestCity(paths)" + e.Message);
                    throw;
                }
            }

        }

}
