using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2taskexception
{
    class Files
    {
        public static void ReadFiles()
        {
            Console.Write("Enter directory: ");
            string dir = Console.ReadLine();
            string[] files = Directory.GetFiles(dir);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
