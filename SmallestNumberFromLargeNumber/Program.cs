using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmallestNumberFromLargeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int x = int.Parse(Console.ReadLine());
            int q = x;
            List<int> digitarray = new List<int>();

            while (q != 0)
            {

                digitarray.Add(q % 10);
                q = q / 10;

            }


            int min = 0;
            for (int z = digitarray.Count - 1; z > 0; z--)
            {
                List<int> temparray = new List<int>();
                foreach (int listitem in digitarray)
                {
                    temparray.Add(listitem);
                }
                int value = 0;
                if (digitarray[z] > digitarray[z - 1])
                {
                    temparray.RemoveAt(z - 1);
                    foreach (int abc in temparray)
                    {
                        Console.WriteLine(abc.ToString());
                    }
                    value = temparray[temparray.Count - 1];
                    for (int index = temparray.Count - 2; index >= 0; index--)
                    {
                        value = value * 10 + (temparray[index]);
                    }

                }
                else if (digitarray[z] < digitarray[z - 1])
                {
                    temparray.RemoveAt(z);
                    foreach (int abc in temparray)
                    {
                        Console.WriteLine(abc.ToString());
                    }
                    value = temparray[temparray.Count - 1];
                    for (int index = temparray.Count - 2; index >= 0; index--)
                    {
                        value = value * 10 + (temparray[index]);
                    }
                }

                Console.WriteLine(value.ToString());

                if (z == digitarray.Count - 1)
                {
                    min = value;
                }
                else
                {
                    if (value < min)
                        min = value;
                }


            }
            Console.WriteLine("Min: " + min.ToString());

            Console.ReadLine();

        }
    }
}
