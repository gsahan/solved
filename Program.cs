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
using System.Numerics;

class Solution
{


    /**
Ensure that rxc >=L

*/

    static string encryption(string s)
    {
        StringBuilder sb = new StringBuilder();

        int len = s.Length;

        double sq = Math.Sqrt(len);
        int row = (int)Math.Floor(sq);
        int column = (int)Math.Ceiling(sq);

        while( len > row*column )
        {
            if(row+1 <= column)
            {
                row++;
            }
            else
            {
                column++;
            }
        }


        for (int c = 0; c < column; c++)
        {
            for (int r = 0; r < row; r++)
            {
                int i = r * column + c;
                if (i < len)
                    sb.Append(s[i]);
                else
                    break;

            }
            sb.Append(' ');

        }
        return sb.ToString();
    }

    static void Main(string[] args)
    {
        string a = "chillout";
        var ret = encryption(a);
        Console.WriteLine(ret);

    }


}
