using System;
using System.Collections;
using System.Text.RegularExpressions;

namespace StackImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Icollection Stack Implementation
            //Stack num = new Stack();
            //Stack ops = new Stack();
            //string expression = "5+10+15+20";
            //calculate(num, ops, expression);
            //Console.WriteLine(num.Pop());
            //Console.Read();


            //Stack class Implementation
            CStack alist = new CStack();
                string ch;
                string word = "sees";
                bool isPalindrome = true;
                for (int x = 0; x < word.Length; x++)
                    alist.Push(word.Substring(x, 1));
                int pos = 0;
                while (alist.Count > 0)
                {
                    ch = alist.Pop().ToString();
                    if (ch != word.Substring(pos, 1))
                    {
                        isPalindrome = false;
                        break;
                    }
                    pos++;
                }
                if (isPalindrome)
                    Console.WriteLine(word + " is a palindrome.");
                else
                    Console.WriteLine(word + " is not a palindrome.");
                Console.Read();
            }

            //IsNumeric is'nt built into c3 so we must define it
            static bool IsNumeric(string input)
            {
                bool flag = true;
                string pattern = (@"^\d+$");
                Regex validate = new Regex(pattern);
                if (!validate.IsMatch(input))
                {
                    flag = false;
                }
                return flag;
            }

            static void calculate(Stack N, Stack O, string exp)
            {
                string ch, token = "";
                for (int p = 0; p < exp.Length; p++)
                {
                    ch = exp.Substring(p, 1);
                    if (IsNumeric(ch))
                        token += ch;
                }


            }
        
    }
}
