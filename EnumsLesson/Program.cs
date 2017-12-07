using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsLesson
{
    class Program
    {
        static void Main(string[] args)
        {
              //конвертация в другой тип
             /*  var probablyDocumentType = (DocumentTupes)Enum.Parse(typeof(DocumentTupes), "Паспорт"); 
               DocumentTupes type = DocumentTupes.Паспорт; */
            User user = new User();
            user.DeletedDate = null;
            Console.WriteLine(user.DeletedDate);
            Console.ReadLine();
        }
    }
}
