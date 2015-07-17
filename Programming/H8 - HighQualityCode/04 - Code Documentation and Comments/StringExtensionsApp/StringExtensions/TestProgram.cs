using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telerik.ILS.Common
{
    class TestProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine(111);
            var strTest = StringExtensions.ToContentType("jpg");
            Console.WriteLine(strTest);
        }
    }
}
