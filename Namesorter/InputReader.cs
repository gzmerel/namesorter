using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter {

 public class InputReader {

        public string GetFileName()

        {
            Console.WriteLine("Enter a path ");
            var fileName = Console.ReadLine();
            if (!File.Exists(fileName))
            {
                Console.WriteLine("Invalied path. Enter a path ");
            }
            return fileName;

           
        }


        
}
}