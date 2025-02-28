using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Data_Analyzer_Project
{
    public static class FileInfoExtention
    {
        public static bool IsTextFile(this FileInfo fileInfo)
        {
            if (fileInfo.Extension == " .txt")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool IsCsvFile(this FileInfo fileInfo)
        {
            if (fileInfo.Extension == " .csv")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
