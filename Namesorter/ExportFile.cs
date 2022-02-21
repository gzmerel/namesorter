

namespace NameSorter
{
    public class ExportFile
    {
        public void ExportData(IEnumerable<Name> names)
        {
            var formattedNames = new List<string>();
            foreach (var name in names) {
                formattedNames.Add(name.FullName);
            }
            File.WriteAllLines("sorted-names-list.txt", formattedNames);
            Console.Write("File Written Successfully");
        }

    }

}


