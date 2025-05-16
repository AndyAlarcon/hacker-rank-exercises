using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    public static string caesarCipher(string s, int k)
    {
        string result = string.Empty;

        foreach(var letter in s)
        {
            var increment = letter + k;

            if(letter >= 65 && letter <= 90)
            {
                if(increment > 90)
                {
                    increment -= 90-letter;

                    while(increment > 90)
                    {
                        increment -= 25;
                        if(increment < 90)
                        {
                            result += Convert.ToString((char)(increment - 1));
                        }
                    }
                }
                else
                {
                    result += Convert.ToString((char)(letter + k));
                }
            }
            else if(letter >= 97 && letter <= 122)
            {
                if(increment > 122)
                {
                    increment = increment - (122-letter);
                    while(increment > 122)
                    {
                        increment -= 25;
                        if(increment < 122)
                        {
                            result += Convert.ToString((char)(increment - 1));
                        }
                    }
                }
                else
                {
                    result += Convert.ToString((char)(letter + k));
                }
            }
            else
            {
                result += Convert.ToString((char)letter);
            }
        }
        return result;
    }

}

class Program
{
    public static void Main(string[] args)
    {

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        string s = Console.ReadLine();

        int k = Convert.ToInt32(Console.ReadLine().Trim());

        string result = Result.caesarCipher(s, k);

        Console.WriteLine(result);

    }
}
