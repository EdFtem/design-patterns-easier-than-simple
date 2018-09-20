using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            ImportantMessagesSearcher importantMessagesSearcher = new ImportantMessagesSearcher(DateTime.Now, String.Empty, 10);
            importantMessagesSearcher.Search();
            Console.ReadLine();
        }
    }
}
