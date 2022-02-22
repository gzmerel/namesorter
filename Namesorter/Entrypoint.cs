using System;
using System.IO;
using System.Linq;

namespace NameSorter
{
  public class EntryPoint
  {
        static void Main()
        {
            var exporter = new ExportFile();
            var inputReader = new InputReader();
            var path = inputReader.GetFileName();
            var nameList = new NameParser();
            var names = nameList.GetNameList(path);
            var sorter = new SortPersonNamesAscending();
            var sortedList = sorter.Sort(names);


            foreach (var i in sortedList)
            {
                Console.WriteLine(i.FullName);
            }
            exporter.ExportData(sortedList);
        }

            

  }
}
