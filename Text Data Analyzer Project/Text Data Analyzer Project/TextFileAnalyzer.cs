using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Data_Analyzer_Project
{
    public class TextFileAnalyzer : FileAnalyzer ,IFileAnalysis
    {
        public void AnalyzeFile(FileInfo fileinfo)
        {
            string filestring = File.ReadAllText(fileinfo.FullName);

            AnalysisResult result = new AnalysisResult();

           var words = filestring.Split(new char[] { ' ', '\n', '\r' });
            result.WordCount = words.Length;
            result.CharachterCount = filestring.Length;
            var Lines = filestring.Split(new char[] { '\n'});
            result.LineCount = Lines.Length;


            SetResults(result);
        }
    }
}
