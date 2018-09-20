using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    public class MessageSearcher
    {
        private DateTime DateSent;
        private string PersonName;
        private int ImportanceLevel;

        public MessageSearcher(DateTime dateSent, string personName, int importanceLevel)
        {
            DateSent = dateSent;
            PersonName = personName;
            ImportanceLevel = importanceLevel;
        }

        protected virtual void CreateDateCriteris()
        {
            Console.WriteLine("Added DateCriteris");
        }

        protected virtual void CreateSentPersonCriteria()
        {
            Console.WriteLine("Added PersonCriteria");
        }

        protected virtual void CreateImportanceLevelCriteria()
        {
            Console.WriteLine("Added ImportanceLevelCriteria");
        }

        public string Search()
        {
            CreateDateCriteris();
            CreateSentPersonCriteria();
            CreateImportanceLevelCriteria();

            return "Some list of messages...";
        }
    }
}
