namespace gatototbalatroto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            bool isActive = true;
            Creator creator = new Creator();
            while (isActive)
            {

                Dictionary<string, List<string>> all = new Dictionary<string, List<string>>();

                Console.WriteLine("ne yapmak istiyorsun?");
                Console.WriteLine("kategori olusturmak icin 1");
                Console.WriteLine("kategorileri gormek icin 2");
                Console.WriteLine("bitirmek icin 0 ");

                input = Console.ReadLine();

                if (input == "1")
                {
                    //List<string> categoryNameFromCreator = creator.Create().Keys.ToList();
                    //string categoryName = categoryNameFromCreator[0];

                    Dictionary<string, List<string>> dictionaryComesFromCreator = new Dictionary<string, List<string>>(creator.Create());

                    Console.WriteLine("olusturulan kategori: ");



                    string categoryName = dictionaryComesFromCreator.Keys.First();//kategori adi
                    Console.Write("eklenen kategori adi: ");
                    Console.WriteLine(categoryName.ToUpper());

                    List<string> categoryItems = dictionaryComesFromCreator[categoryName];//kategori itemleri

                    Console.WriteLine("eklenen kategori itemleri: ");
                    Console.WriteLine("********************");
                    foreach (string item in categoryItems)
                    {
                        Console.WriteLine(item.ToLower());
                    }
                }

                else if (input == "2")
                {
                    List<string> categoriesList = all.Keys.ToList();
                    foreach (string item in categoriesList)
                    {
                        Console.WriteLine(item);
                    }
                }
            }
        }
    }
}
