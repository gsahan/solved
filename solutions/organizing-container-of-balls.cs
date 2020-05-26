using System.Collections.Generic;
using System.Numerics;

class OrganizinBalls
{

    static string organizingContainers(int[][] container)
    {
        List<BigInteger> cont = new List<BigInteger>();
        List<BigInteger> typeCont = new List<BigInteger>();
        int cntContainer = container.Length;

        for (int i = 0; i < cntContainer; i++)
        {

            cont.Add(0);
            typeCont.Add(0);

            if (cntContainer != container[i].Length)
                break;

            for (int j = 0; j < cntContainer; j++)
            {
                cont[i] += container[i][j];
                typeCont[i] += container[j][i];
            }
        }

        if (cont.Count > 0)
            cont.Sort();
        if (typeCont.Count > 0)
            typeCont.Sort();

        if (isEqual(cont, typeCont))
            return "Possible";
        else
            return "Impossible";

    }

    public static bool isEqual(List<BigInteger> ths, List<BigInteger> other)
    {
        bool ret = false;

        if (ths.Count != other.Count)
            ret = false;
        else
        {
            for (int i = 0; i < ths.Count; i++)
            {
                if (ths[i] != other[i])
                {
                    ret = false;
                    break;
                }
                else
                {
                    ret = true;
                }
            }
        }

        return ret;

    }

    static void testIt(string[] args)
    {
        int[][] c = new int[8][];

        c[0] = new int[] { 850352964, 977596446, 949048147, 948864413, 583894071, 690057713, 997747480, 989967717 };
        c[1] = new int[] { 989808562, 768213277, 465807106, 806209383, 997601076, 726063750, 886274860, 999745463 };
        c[2] = new int[] { 999716184, 614327240, 646233100, 701848586, 996640233, 637114525, 979053522, 973751653 };
        c[3] = new int[] { 729579413, 623758391, 789451199, 998061161, 915515002, 887943421, 667982910, 663066401 };
        c[4] = new int[] { 625660022, 983861176, 747822232, 924237583, 765182731, 879961473, 915988053, 973592376 };
        c[5] = new int[] { 978486425, 911982749, 995853966, 373364101, 706580937, 995621049, 869416897, 906988203 };
        c[6] = new int[] { 996021364, 982486194, 880450667, 971761433, 779568692, 990258135, 985311146, 547004947 };
        c[7] = new int[] { 963237644, 954080173, 997900896, 551011238, 803702301, 931274261, 685754083, 585606717 };


        var a = organizingContainers(c);

    }


}