using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileExtensionsStarter;

namespace FileExtensionsTester
{
    class Program
    {
        static void Main(string[] args)
        {
            DefaultProgDatabase extensions = new DefaultProgDatabase();

            Console.WriteLine("empty " + extensions.getAll());

            //your tests in here
            extensions.addEntry("TXT","NOTEPAD");
            extensions.addEntry("DOC", "WORD");
            extensions.addEntry("ABC", "SOMETHINMG");

            Console.WriteLine("3 " + extensions.getAll());
            Console.WriteLine(extensions.findDefaultProgram("TXT"));

            extensions.deleteEntry("DOC");
            extensions.deleteEntry("gg");
            Console.WriteLine("2" + extensions.getAll());

            try
            {
                Console.WriteLine("expect exception");
               Console.WriteLine(extensions.findDefaultProgram("TT"));
            }
            catch(Exception ex)
            {
                Console.WriteLine("expect " + ex.Message);
            }

            Console.ReadLine();
        }
    }
}
