using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Data_Analyzer_Project
{
    internal class CSVFileAnalyzer : FileAnalyzer, IFileAnalysis
    {
        public void AnalyzeFile(FileInfo fileinfo)
        {
            string[] filestring = File.ReadAllLines(fileinfo.FullName);

           var rowElements = filestring[0].Split(',');

            AnalysisResult result = new AnalysisResult();

            result.FieldCount = rowElements.Length;

            SetResults(result);

        }
    }
}
