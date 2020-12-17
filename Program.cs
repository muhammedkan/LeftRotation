using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @System.Environment.CurrentDirectory;
            var textWriter = new StreamReader(path+ "\\OUTPUT_PATH.txt", true);

            string[] nd = textWriter.ReadLine().Split(' ');

            int n = Convert.ToInt32(nd[0]);

            int d = Convert.ToInt32(nd[1]);

            int[] a = Array.ConvertAll(textWriter.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
            ;
            int[] result = rotLeft(a, d);

        }

        static int[] rotLeft(int[] a, int d)
        {
            int move = a.Length - (d % a.Length);//1
            int[] temp = new int[a.Length];

            for (int i = 0; i < a.Length; i++)
            {
                temp[move] = a[i];
                if (move < a.Length-1)
                {
                    move += 1;
                }
                else
                { move = 0; }
            }
            return temp;
        }
    }
}
