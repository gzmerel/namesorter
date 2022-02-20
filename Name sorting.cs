using System;
using System.IO;
using System.Linq;

namespace Namesorter
{
  public class NameSorter
  {
        static void Main()
        {
            
            var inputReader = new InputReader();
            var path = InputReader.GetFileName(Console);
            var nameList = new NameList();
            var names = nameList.GetNameList(path);
            var sortedList = new SortingNamesList();
            var sortedList = NameSorter.SortingNamesList(SortedList);


            foreach (var i in SortedList)
            {
                Console.WriteLine(i);
            }
            ExportFile.ExportData(SortedList);
        }

            

  }
}
