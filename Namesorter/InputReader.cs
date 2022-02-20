using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namesorter {

 public class InputReader {

        public string GetFileName(Console console)

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