namespace Telerik.ILS.Common
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            string baseString = "some";
            string tryStringCapitalize = StringExtensions.CapitalizeFirstLetter(baseString);
            Console.WriteLine(tryStringCapitalize);
        }
    }
}
