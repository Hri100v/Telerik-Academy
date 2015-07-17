namespace Telerik.ILS.Common
{
    using System;
    using System.Linq;

    public class TestClass
    {
        public string baseString = "some";
        string tryStringCapitalize = StringExtensions.CapitalizeFirstLetter(baseString);
        string valueHash = StringExtensions.ToMd5Hash("another");
            //Console.WriteLine(tryStringCapitalize);
        int integerNumber = StringExtensions.ToInteger("15");
        DateTime stringToDatetime = StringExtensions.ToDateTime("21.2.2014");
            
    }
}
