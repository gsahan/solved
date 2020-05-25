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

    enum direction
    {
        none,
        up,
        down,
        right,
        left
    }

    static void move(ref int r, ref int c, direction d)
    {
        switch (d)
        {
            case direction.up: r++; break;
            case direction.down: r--; break;
            case direction.right: c++; break;
            case direction.left: c--; break;
            case direction.none: break;
        }
    }

    static void multiMove(List<direction> dAr, ref int x, ref int y)
    {
        foreach (var i in dAr)
        {
            move(ref x, ref y, i);
        }
    }

    static int queensAttack(int n, int k, int r_q, int c_q, int[][] obstacles)
    {
        int cntMove = 0;
        List<List<direction>> dList = new List<List<direction>>();

        dList.Add(new List<direction>() { direction.left });
        dList.Add(new List<direction>() { direction.right });

        dList.Add(new List<direction>() { direction.up });
        dList.Add(new List<direction>() { direction.down });

        dList.Add(new List<direction>() { direction.up, direction.left });
        dList.Add(new List<direction>() { direction.up, direction.right });

        dList.Add(new List<direction>() { direction.down, direction.left });
        dList.Add(new List<direction>() { direction.down, direction.right });

        HashSet<string> obs = new HashSet<string>();

        if (k > 0)
            foreach (var i in obstacles)
            {
                obs.Add(i[0] + "_" + i[1]);
            }

        foreach (var dr in dList)
        {
            int r = r_q;
            int c = c_q;
            while (r <= n && c <= n && r > 0 && c > 0)
            {
                multiMove(dr, ref r, ref c);
                if (r <= n && c <= n && r > 0 && c > 0)
                {
                    if (k > 0 && obs.Contains(r + "_" + c))
                        break;
                    else
                        cntMove++;
                }
            }
        }

        return cntMove;

    }


    static void Main(string[] args)
    {
        var a = queensAttack(4, 0, 4, 4, null);

    }


}
