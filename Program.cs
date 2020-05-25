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

class Solution
{

    // Complete the minimumBribes function below.
    static void minimumBribes(int[] q)
    {
        Dictionary<int, Dictionary<int, int>> hist = new Dictionary<int, Dictionary<int, int>>();
        for (int i = 0; i < q.Length; i++)
        {
            hist[i] = new Dictionary<int, int>();
        }

        int cnt = 0;

        for (int j = 0; j < q.Length; j++)
        {
            for (int i = 0; i < q.Length; i++)
            {
                if (q[i] == i + 1)
                {
                    continue;
                }
                else if( q[i] > q[i+1] )
                {
                    int t = q[i];
                    q[i] = q[i+1];
                    q[i+1] = t;
                    cnt++;
                }


            }



        }

        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                int[] q = Array.ConvertAll(Console.ReadLine().Split(' '), qTemp => Convert.ToInt32(qTemp))
                ;
                minimumBribes(q);
            }
        }
    }


1 2 5 3 7 8 6 4 - 1 2 3 5 7 8 4 6 - 1 2 3 5 7 4 6 8 - 1 2 3 5 4 6 7 8 -1 2 3 4 5 6 7 8 

2 5 1 3 4 - 2 1 5 3 4 - 1 2 3 5 4 - 1 2 3 4 5
1 - 5 - 3   2-1- 