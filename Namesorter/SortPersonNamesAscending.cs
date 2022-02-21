using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter
{
    public class SortPersonNamesAscending
    {

        public IEnumerable<Name> Sort(IEnumerable<Name> myList)
        {
            return myList
                .OrderBy(x => x.LastName)
                .ThenBy(x => x.FirstNames);
        }

    }
}   
               
      



