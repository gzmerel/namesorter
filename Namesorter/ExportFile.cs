using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namesorter
{
    public class ExportFile
    {
        public static void ExportData(string[] dataToWrite)
            {
                File.WriteAllLines("sorted-names-list.txt", dataToWrite);
                Console.Write("File Written Successfully");
            }
        
    }
    
}


