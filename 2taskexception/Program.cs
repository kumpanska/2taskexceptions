using System;
using System.Collections.Generic;
using System.Drawing;
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
                    if (regexExtForImage.IsMatch(Path.GetExtension(file).TrimStart('.')))
                    {
                        using (Bitmap bmp = new Bitmap(file))
                        {
                            bmp.RotateFlip(RotateFlipType.RotateNoneFlipY);
                            string newName = Path.Combine(Path.GetDirectoryName(file), Path.GetFileNameWithoutExtension(file) + "-mirrored.gif");
                            bmp.Save(newName);
                            Console.WriteLine($"Mirrored file {newName}");
                        }
                    }
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
