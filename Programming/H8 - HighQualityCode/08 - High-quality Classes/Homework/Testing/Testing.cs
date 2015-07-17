using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    class Testing
    {
        static void Main(string[] args)
        {
            var i = 132;
            Console.WriteLine(i != null);
            var sb = new StringBuilder();
            sb.Append("{");
            sb.Append(" some text ");
            sb.Append("}");
            Console.WriteLine(sb.Remove(sb.Length - 1, 1));
        }
    }
}
