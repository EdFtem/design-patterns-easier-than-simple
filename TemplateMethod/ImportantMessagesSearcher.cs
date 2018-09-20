using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    public class ImportantMessagesSearcher : MessageSearcher
    {
        public ImportantMessagesSearcher(DateTime dateSent, string personName, int importanceLevel) : base(dateSent, personName, importanceLevel)
        {
        }

        protected override void CreateImportanceLevelCriteria()
        {
            Console.WriteLine("Added ImportanceLevel logic!");
        }
    }
}
