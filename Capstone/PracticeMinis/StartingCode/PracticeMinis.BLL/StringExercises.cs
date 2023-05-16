using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeMinis.BLL
{
    public class StringExercises
    {
        /* Given a string name, e.g. "Bob", return a greeting of the form "Hello Bob!". */
        public static string SayHi(string name)
        {
            throw new NotImplementedException();
        }

        /* Given two strings, a and b, return the result of putting them together in the order 
         * abba, e.g. "Hi" and "Bye" returns "HiByeByeHi". 
         */
        public static string Abba(string a, string b)
        {
            throw new NotImplementedException();
        }

        /* The web is built with HTML strings like "<i>Yay</i>" which draws Yay as italic text. 
         * In this example, the "i" tag makes <i> and </i> which surround the word "Yay". Given tag and 
         * word strings, create the HTML string with tags around the word, e.g. "<i>Yay</i>". 
         */
        public static string MakeTags(string tag, string content)
        {
            throw new NotImplementedException();
        }

        /* Given an "out" string length 4, such as "<<>>", and a word, return a new string where 
         * the word is in the middle of the out string, e.g. "<<word>>".
         * Hint: Substrings are your friend here 
         */
        public static string InsertWord(string container, string word)
        {
            throw new NotImplementedException();
        }

        /* Given a string, return a new string made of 3 copies of the last 2 chars of the original 
         * string. The string length will be at least 2. 
         */
        public static string MultipleEndings(string str)
        {
            throw new NotImplementedException();
        }

        /* Given a string of even length, return the first half. So the string "WooHoo" yields "Woo". */
        public static string FirstHalf(string str)
        {
            throw new NotImplementedException();
        }

        /* Given a string, return a version without the first and last char, so "Hello" yields "ell". 
         * The string length will be at least 2. 
         */
        public static string TrimOne(string str)
        {
            throw new NotImplementedException();
        }

        /* Given 2 strings, a and b, return a string of the form short+long+short, with the shorter string 
         * on the outside and the longer string on the inside. The strings will not be the same length, but 
         * they may be empty (length 0). 
         */
        public static string LongInMiddle(string a, string b)
        {
            throw new NotImplementedException();
        }

        /* Given a string, return a "rotated left 2" version where the first 2 chars are moved to the end. 
         * The string length will be at least 2. 
        */
        public static string Rotateleft2(string str)
        {
            throw new NotImplementedException();
        }

        /* Given a string, return a "rotated right 2" version where the last 2 chars are moved to the start. 
         * The string length will be at least 2. 
        */
        public static string RotateRight2(string str)
        {
            throw new NotImplementedException();
        }

        /* Given a string of even length, return a string made of the middle two chars, so the string "string" 
         * yields "ri". The string length will be at least 2. */
        public static string MiddleTwo(string str)
        {
            throw new NotImplementedException();
        }

        /* Given a string, return true if it ends in "ly". */
        public static bool EndsWithLy(string str)
        {
            throw new NotImplementedException();
        }

        /* Given a string and an int n, return a string made of the first and last n chars from the string. 
         * The string length will be at least n. 
        */
        public static string FrontAndBack(string str, int n)
        {
            throw new NotImplementedException();
        }

        /* Given a string and an index, return a string length 2 starting at the given index. If the index is 
         * too big or too small to define a string length 2, use the first 2 chars. The string length will be at least 2. 
        */
        public static string TakeTwoFromPosition(string str, int n)
        {
            throw new NotImplementedException();
        }

        /* Given a string, return true if "bad" appears starting at index 0 or 1 in the string, such as with "badxxx" or 
         * "xbadxx" but not "xxbadxx". The string may be any length, including 0. 
        */
        public static bool HasBad(string str)
        {
            throw new NotImplementedException();
        }
    }
}
