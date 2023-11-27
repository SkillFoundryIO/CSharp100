using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeMinis.BLL
{
    public class LoopExercises
    {
        /* Given a string and a non-negative int n, return a larger string 
         * that is n copies of the original string. */
        public static string StringTimes(string str, int n)
        {
            throw new NotImplementedException();
        }

        /* Given a string and a non-negative int n, we'll say that the front of 
         * the string is the first 3 chars, or whatever is there if the string is less 
         * than length 3. Return n copies of the front; 
        */
        public static string FrontTimes(string str, int n)
        {
            throw new NotImplementedException();
        }

        /* Count the number of "xx" in the given string. We'll say that overlapping is 
         * allowed, so "xxx" contains 2 "xx". 
        */
        public static int CountXX(string str)
        {
            throw new NotImplementedException();
        }

        /* Given a string, return true if the first instance of "x" in the string is 
         * immediately followed by another "x". 
        */
        public static bool DoubleX(string str)
        {
            throw new NotImplementedException();
        }

        /* Given a string, return a new string made of every other char starting with 
         * the first, so "Hello" yields "Hlo". 
        */
        public static string EveryOther(string str)
        {
            throw new NotImplementedException();
        }

        /* Given a non-empty string like "Code" return a string like "CCoCodCode".  
         * (first char, first two, first 3, etc) 
        */
        public static string StringSplosion(string str)
        {
            throw new NotImplementedException();
        }

        /* Given a string, return the count of the number of times that a substring 
         * length 2 appears in the string and also as the last 2 chars of the string, 
         * so "hixxxhi" yields 1 (we won't count the end substring). 
        */
        public static int CountLast2(string str)
        {
            throw new NotImplementedException();
        }

        /* Given an array of ints, return the number of 9's in the array. */
        public static int Count9(int[] numbers)
        {
            throw new NotImplementedException();
        }

        /* Given an array of ints, return true if one of the first 4 elements in the 
         * array is a 9. The array length may be less than 4. 
        */
        public static bool ArrayFront9(int[] numbers)
        {
            throw new NotImplementedException();
        }

        /* Given an array of ints, return true if .. 1, 2, 3, .. appears in the 
         * array somewhere. 
        */
        public static bool Array123(int[] numbers)
        {
            throw new NotImplementedException();
        }

        /* Given 2 strings, a and b, return the number of the positions where they 
         * contain the same length 2 substring. So "xxcaazz" and "xxbaaz" yields 3, 
         * since the "xx", "aa", and "az" substrings appear in the same place in 
         * both strings. 
        */
        public static int SubStringMatch(string a, string b)
        {
            throw new NotImplementedException();
        }

        /* Given a string, return a version where all the "x" have been removed.
         * Except an "x" at the very start or end should not be removed. 
        */
        public static string StringX(string str)
        {
            throw new NotImplementedException();
        }

        /* Given a string, return a string made of the chars at indexes 0,1, 4,5, 
         * 8,9 ... so "kittens" yields "kien". 
        */
        public static string AltPairs(string str)
        {
            throw new NotImplementedException();
        }

        /* Suppose the string "yak" is unlucky. Given a string, return a version where 
         * all the "yak" are removed, but the "a" can be any char. The "yak" strings 
         * will not overlap. 
        */
        public static string DoNotYak(string str)
        {
            throw new NotImplementedException();
        }

        /* Given an array of ints, return the number of times that two 6's are next to 
         * each other in the array. Also count instances where the second "6" is 
         * actually a 7.
        */
        public static int Array667(int[] numbers)
        {
            throw new NotImplementedException();
        }

        /* Given an array of ints, we'll say that a triple is a value appearing 3 times 
         * in a row in the array. Return true if the array does not contain any triples. 
        */
        public static bool NoTriples(int[] numbers)
        {
            throw new NotImplementedException();
        }

        /* Given an array of ints, return true if it contains a 2, 7, 1 pattern --
         * a value, followed by the value plus 5, followed by the value minus 1. 
         */
        public static bool Pattern51(int[] numbers)
        {
            throw new NotImplementedException();
        }
    }
}
