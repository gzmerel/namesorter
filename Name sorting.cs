using System;
using System.IO;
namespace Namesorter
{
    using System.Linq;
    public class NameSorter
    {
        static void Main()
        {
            
            string path;
            Console.Write("Enter a path ");
            path = Console.ReadLine();

            while(!File.Exists(path))
            {
                if (path == "exit") { break; }
                Console.Write("Invalied path. Enter a path ");
                path = Console.ReadLine();
            }
            if (path == "exit") { return; }
            string[] lines = System.IO.File.ReadAllLines(@path);
            string[] sortedName = new string[lines.Length];
            int len;
            var indexofName = 0;
            string[] theLastWillbeFirst = new string[lines.Length];
            foreach (string line in lines)

            {
                var fullname = line.Split(' ');
                len = fullname.Length;
                var theLastName = fullname[len - 1];
                var FullNames = theLastName + " " + string.Join(" ", fullname, 0, len - 1);
                theLastWillbeFirst[indexofName] = FullNames;
                indexofName++;

            }
            Array.Sort(theLastWillbeFirst, StringComparer.InvariantCulture);
            var indexofSortedName = 0;

            foreach (string reverseline in theLastWillbeFirst)
            {
                var fullname = reverseline.Split(' ');
                len = fullname.Length;
                var theLastName = fullname[0];


                sortedName[indexofSortedName] = string.Join(" ", fullname, 1, len - 1) + " " + theLastName;
                indexofSortedName++;
            }

            List<string> outContest = new List<string>();

            foreach (var item in sortedName)
            {
                Console.WriteLine(item);
                outContest.Add(item.ToString());
            }

            string outFile = @"C:\Users\gizem\OneDrive\Documents\Project\NameSortingProject\sorted-names-list.txt";
            System.IO.File.WriteAllLines(outFile, outContest);

        }
    }
}