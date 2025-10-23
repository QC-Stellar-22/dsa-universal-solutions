using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_10
{
    public class _1
    {
        public void Find()
        {
            int[] arr = { 2, 7, 11, 15 };
            var tar = 9;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == tar)
                    {
                        Console.WriteLine($"Indices: {i}, {j}");
                    }
                }
            }
        }
    }
}
