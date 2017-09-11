using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW15
{
    [Serializable]
    public class Book
    {
        private string name;
        private int price;
        private string avtor;
        private int year;
        public string Name
        {
            get { return Name; }
            set { name = value; }
        }
        public string Avtor
        {
            get { return Avtor; }
            set { avtor = value; }
        }
        public int Year
        {
            get { return Year; }
            set { year = value; }
        }
        public int Price
        {
            get { return Price; }
            set { price = value; }
        }
    }
}
