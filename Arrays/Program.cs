using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Decleares and initiallizes the array
            //if multiple things betw. brackets, put a ','
            int[,,] theArray = new int[5, 10, 15];

            //displays
            Console.WriteLine("The array has {0} numbers in it", theArray.Rank); //the '.Rank' displays the number of dimensions of an array
            Console.ReadLine();


        }
    }
}
