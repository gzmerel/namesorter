using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter
{
    public class NameParser
    {
        public List<Name> GetNameList(string path)
        {
            string[] lines = System.IO.File.ReadAllLines(path);
            List<Name> myName = new List<Name>();
            foreach (string line in lines)
            {
                var lastSpace = line.LastIndexOf(" ");
                var start = 0;
                var fullname = line.Split(" ");

                myName.Add(new Name
                {
                    FirstNames = line.Substring(start, lastSpace - start),
                    LastName = fullname.Last()
                });
                ;
            }
            return myName;
        }
            
    }
}
