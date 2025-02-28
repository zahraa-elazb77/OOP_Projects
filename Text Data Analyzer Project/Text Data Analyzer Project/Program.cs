using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Data_Analyzer_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to file analyzer");
            Console.WriteLine("please entre folder path to analyze");

            string InputFolder = Console.ReadLine();

            DirectoryInfo directoryinfo = new DirectoryInfo(InputFolder);
            if (directoryinfo.Exists == false)
            {
                Console.WriteLine("Folder does not exist");
                return;
            }

            var filenames = directoryinfo.GetFiles();

            IFileAnalysis fileanalysis = null;

            foreach (var file in filenames)
            {
                if(file.IsTextFile())
                {
                    fileanalysis = new TextFileAnalyzer();

                    fileanalysis.AnalyzeFile(file);

                    var results = ((FileAnalyzer)fileanalysis).GetResults();
                    Console.WriteLine($"file name : {file.Name}");
                    Console.WriteLine($"Word count : {results.WordCount}");
                    Console.WriteLine($"Character count : {results.CharachterCount}");
                    Console.WriteLine($"Line count : {results.LineCount}");

                }
                else if (file.IsCsvFile())
                {
                    fileanalysis = new CSVFileAnalyzer();

                    fileanalysis.AnalyzeFile(file);

                    var results = ((FileAnalyzer)fileanalysis).GetResults();
                    Console.WriteLine($"file name : {file.Name}");
                    Console.WriteLine($"Field count : {results.FieldCount}");
                     
                }
                Console.ReadKey();
               
            }
        }
    }
}
