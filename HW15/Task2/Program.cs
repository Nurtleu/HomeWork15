using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.IO;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryFormatter format = new BinaryFormatter();
            using (FileStream stream = new FileStream(@"C:\data\book.bin", FileMode.Open))
            {
                List<Book> someBooks = (List<Book>)format.Deserialize(stream);
            }
        }
    }
}
