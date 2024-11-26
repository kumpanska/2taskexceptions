using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            Regex regexExtForImage = new Regex("^((bmp)|(gif)|(jpe?g)|(png)|(tif)|(heic))$", RegexOptions.IgnoreCase);
            foreach (string file in files)
            {
                try 
                { 
                
                }
                catch (Exception ex)
                { 
                
                }
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
