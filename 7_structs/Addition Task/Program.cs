using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addition_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            NoteBook note = new NoteBook("laccetti", "shevrolet", 1000);
            note.ShowNoteBook();

            Console.ReadKey();
        }
    }

    struct NoteBook
    {
        private string type;
        private string manufacturer;
        private double price;

        public NoteBook(string type, string manufacturer, double price)
        {
            this.type = type;
            this.manufacturer = manufacturer;
            this.price = price;
        }

        public void ShowNoteBook()
        {
            Console.WriteLine($"Type: {type}");
            Console.WriteLine($"Manufacturer: {manufacturer}");
            Console.WriteLine($"Price: {price}");
        }
    }
}
