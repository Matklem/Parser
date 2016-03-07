using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoldParser;

namespace MoloParser
{
    class Program
    {
        static void Main(string[] args)
        {
            var myParser = new MyParser();
            ParserFactory.InitializeFactoryFromFile(@"C:\Users\fraus\OneDrive\Documents\GitHub\Parser\MoloParser\MoloParser\eeC.cgt");
            //var goldParser =
            //    ParserFactory.CreateParser(
            //        new StringReader(
            //            @"C:\Users\fraus\OneDrive\Documents\GitHub\Parser\MoloParser\MoloParser\TextFile1.txt"));
            //ParseMessage pm = goldParser.Parse();
            //Console.WriteLine(pm.ToString());

            myParser.Parse(@"C:\Users\fraus\OneDrive\Documents\GitHub\Parser\MoloParser\MoloParser\TextFile1.txt");
            
            Console.ReadKey();


        }
    }
}
