﻿using System;

namespace Regex
{
    internal class Program
    {
        static void Main()
        {
            string str = "Some string";
            RegEx regEx = new RegEx("S.me string");
            bool isMatch = regEx.IsMatch(str);
            Console.WriteLine(isMatch);

            regEx.SetPattern("[ab]");
            isMatch = regEx.IsMatch(str);
            Console.WriteLine(isMatch);

            regEx.SetPattern("[^abc]");
            isMatch = regEx.IsMatch(str);
            Console.WriteLine(isMatch);

            regEx.SetPattern("S?me string");
            isMatch = regEx.IsMatch(str);
            Console.WriteLine(isMatch);
        }
    }
}
