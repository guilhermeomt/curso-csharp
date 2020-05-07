using System;
using System.Collections.Generic;
using System.IO;

namespace programa11
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                IEnumerable<string> files = Directory.EnumerateFiles(@"C:\Users\guili\Documents\Workspace\vscode\csharp\programa10","*.*",SearchOption.AllDirectories);
                foreach(string file in files)
                    System.Console.WriteLine(Path.GetFileName(file));                 
            }
            catch (IOException e)
            {
                System.Console.WriteLine("An error ocurred: " + e.Message);
            }
        }
    }
}
