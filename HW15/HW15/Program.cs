using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using static System.Console;

namespace HW15
{
    class Program
    {
        static void Main(string[] args)
        {
            Book bookOne = new Book
            {
                Name = "Война и Мир",
                Avtor = "Лев Николаевич Толстой",
                Year = 1867,
                Price = 3500,
            };
            Book bookTwo = new Book
            {
                Name = "Скотный двор",
                Avtor = "Джордж Оруэлл",
                Year = 1945,
                Price = 5000,
            };
            Book bookThree = new Book
            {
                Name = "Анна Каренина",
                Avtor = "Лев Николаевич Толстой",
                Year = 1873,
                Price = 4000,
            };
            BinaryFormatter format = new BinaryFormatter();
            using (FileStream stream = new FileStream(@"C:\data\book.bin", FileMode.OpenOrCreate))
            {
                format.Serialize(stream, bookOne);
                WriteLine("Serialized");
            }
            using (FileStream stream = new FileStream(@"C:\data\book.bin", FileMode.Open))
            {
                List<Book> Books = (List<Book>)format.Deserialize(stream);
                WriteLine("Deserialized")
            }
        }    
    }
} 
