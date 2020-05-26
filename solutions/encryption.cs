using System.Text;
using System;

class Encryption
{

    string encryption(string s)
    {
        StringBuilder sb = new StringBuilder();

        int len = s.Length;

        double sq = Math.Sqrt(len);
        int row = (int)Math.Floor(sq);
        int column = (int)Math.Ceiling(sq);

        while (len > row * column)
        {
            if (row + 1 <= column)
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


}
