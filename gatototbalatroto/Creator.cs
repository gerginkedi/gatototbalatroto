using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gatototbalatroto
{
    internal class Creator
    {
        public Dictionary<string, List<string>> Create()
        {


            Dictionary<string, List<string>> all = new Dictionary<string, List<string>>();

            string categoryName = "";
            string input;

            List<string> categoriesToAdd = new List<string>();

            Boolean x = true;
            while (x)
            {
                Console.Write(
                    "kategori ismi eklemek veya degistirmek icin 1 " +
                    "item eklemek icin 2 " +
                    "cikmak icin 0 " +
                    ": "
                    );

                input = Console.ReadLine();

                if (input == "1")
                {

                    Console.Write("kategori ismi giriniz ");
                    categoryName = Console.ReadLine();

                }

                else if (input == "2")
                {

                    Console.WriteLine("eklenecek item adi giriniz ");
                    categoriesToAdd.Add(Console.ReadLine());

                }
                else if (input == "0")
                {

                    x = false;

                }
            }
            all.Add(categoryName, categoriesToAdd);
            return all;
        }
    }
}
