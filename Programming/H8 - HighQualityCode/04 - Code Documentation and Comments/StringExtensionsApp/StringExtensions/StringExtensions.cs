namespace Telerik.ILS.Common
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;
    using System.Text.RegularExpressions;

    /// <summary>
    /// Class String Extensions. Only for training with little more description.
    /// <list type="bullet">
    ///     <listheader>
    ///         <term>Class String Extensions</term>
    ///         <description>Description about this class</description>
    ///     </listheader>
    ///     <item>
    ///         <description>ToMd5Hash,</description>
    ///     </item>
    ///     <item>
    ///         <description>ToBoolean,</description>
    ///     </item>
    ///     <item><description>ToShort,</description></item>
    ///     <item><description>ToInteger,</description></item>
    ///     <item><description>ToLong,</description></item>
    ///     <item><description>ToDateTime,</description></item>
    ///     <item><description>CapitalizeFirstLetter,</description></item>
    ///     <item><description>GetStringBetween,</description></item>
    ///     <item><description>ConvertCyrillicToLatinLetters,</description></item>
    ///     <item><description>ConvertLatinToCyrillicKeyboard,</description></item>
    ///     <item><description>ToValidUsername,</description></item>
    ///     <item><description>ToValidLatinFileName,</description></item>
    ///     <item><description>GetFirstCharacters,</description></item>
    ///     <item><description>GetFileExtension,</description></item>
    ///     <item><description>ToContentType,</description></item>
    ///     <item><description>ToByteArray,</description></item>
    /// </list>
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// That is a method that return from input string to a byte array
        /// and compute the hash for each symbols.
        /// </summary>
        /// <param name="input">the input value must be 'string'</param>
        /// <returns>A hexadecimal string</returns>
        public static string ToMd5Hash(this string input)
        {
            var md5Hash = MD5.Create();
            Console.WriteLine();
            // Convert the input string to a byte array and compute the hash.
            var data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new StringBuilder to collect the bytes
            // and create a string.
            var builder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                builder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return builder.ToString();
        }

        /// <summary>
        /// The method check for positive boolean value
        /// </summary>
        /// <param name="input">Expect some bool value like a string</param>
        /// <returns>Boolean value (True/False) according of input value</returns>
        public static bool ToBoolean(this string input)
        {
            var stringTrueValues = new[] { "true", "ok", "yes", "1", "да" };
            return stringTrueValues.Contains(input.ToLower());
        }

        /// <summary>
        /// Convert string number to short number
        /// </summary>
        /// <param name="input">Must be a string number</param>
        /// <returns>number from type short</returns>
        public static short ToShort(this string input)
        {
            short shortValue;
            short.TryParse(input, out shortValue);
            return shortValue;
        }

        /// <summary>
        /// Convert string number to integer number
        /// </summary>
        /// <param name="input">Must be a string number</param>
        /// <returns>number from type integer</returns>
        public static int ToInteger(this string input)
        {
            int integerValue;
            int.TryParse(input, out integerValue);
            return integerValue;
        }

        /// <summary>
        /// Convert string number to long number
        /// </summary>
        /// <param name="input">Must be a string number</param>
        /// <returns>number from type long</returns>
        public static long ToLong(this string input)
        {
            long longValue;
            long.TryParse(input, out longValue);
            return longValue;
        }

        /// <summary>
        /// Convert 'Date Time string' type to DateTime type
        /// </summary>
        /// <param name="input">Must be string in DateTime format</param>
        /// <returns>true if <paramref name="input"/> was converted successfully; otherwise,
        /// false.</returns>
        public static DateTime ToDateTime(this string input)
        {
            DateTime dateTimeValue;
            DateTime.TryParse(input, out dateTimeValue);
            return dateTimeValue;
        }

        /// <summary>
        /// This method capitalizes the first letter from a given string
        /// </summary>
        /// <param name="input">String that intended to change</param>
        /// <returns>String with a capitalize the first letter</returns>
        public static string CapitalizeFirstLetter(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            return input.Substring(0, 1).ToUpper(CultureInfo.CurrentCulture) + input.Substring(1, input.Length - 1);
        }

        /// <summary>
        /// Extract exactly part from a given string
        /// </summary>
        /// <param name="input">The string by witch the value will be extract</param>
        /// <param name="startString">Start from right string</param>
        /// <param name="endString">End to right string</param>
        /// <param name="startFrom">integer index for position to start searching</param>
        /// <returns>Desired string, if it exist</returns>
        public static string GetStringBetween(this string input, string startString, string endString, int startFrom = 0)
        {
            input = input.Substring(startFrom);
            startFrom = 0;
            if (!input.Contains(startString) || !input.Contains(endString))
            {
                return string.Empty;
            }

            var startPosition = input.IndexOf(startString, startFrom, StringComparison.Ordinal) + startString.Length;
            if (startPosition == -1)
            {
                return string.Empty;
            }

            var endPosition = input.IndexOf(endString, startPosition, StringComparison.Ordinal);
            if (endPosition == -1)
            {
                return string.Empty;
            }

            return input.Substring(startPosition, endPosition - startPosition);
        }

        /// <summary>
        /// Convert cyrillic letters to latin letters
        /// </summary>
        /// <param name="input">the letter that to be changed</param>
        /// <returns>new latin letter</returns>
        public static string ConvertCyrillicToLatinLetters(this string input)
        {
            var bulgarianLetters = new[]
                                       {
                                           "а", "б", "в", "г", "д", "е", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п",
                                           "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ь", "ю", "я"
                                       };
            var latinRepresentationsOfBulgarianLetters = new[]
                                                             {
                                                                 "a", "b", "v", "g", "d", "e", "j", "z", "i", "y", "k",
                                                                 "l", "m", "n", "o", "p", "r", "s", "t", "u", "f", "h",
                                                                 "c", "ch", "sh", "sht", "u", "i", "yu", "ya"
                                                             };
            for (var i = 0; i < bulgarianLetters.Length; i++)
            {
                input = input.Replace(bulgarianLetters[i], latinRepresentationsOfBulgarianLetters[i]);
                input = input.Replace(bulgarianLetters[i].ToUpper(), latinRepresentationsOfBulgarianLetters[i].CapitalizeFirstLetter());
            }

            return input;
        }

        /// <summary>
        /// Convert latin letters to cyrillic letters
        /// </summary>
        /// <param name="input">the letter that to be changed</param>
        /// <returns>new cyrillic letter</returns>
        public static string ConvertLatinToCyrillicKeyboard(this string input)
        {
            var latinLetters = new[]
                                   {
                                       "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p",
                                       "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"
                                   };

            var bulgarianRepresentationOfLatinKeyboard = new[]
                                                             {
                                                                 "а", "б", "ц", "д", "е", "ф", "г", "х", "и", "й", "к",
                                                                 "л", "м", "н", "о", "п", "я", "р", "с", "т", "у", "ж",
                                                                 "в", "ь", "ъ", "з"
                                                             };

            for (int i = 0; i < latinLetters.Length; i++)
            {
                input = input.Replace(latinLetters[i], bulgarianRepresentationOfLatinKeyboard[i]);
                input = input.Replace(latinLetters[i].ToUpper(), bulgarianRepresentationOfLatinKeyboard[i].ToUpper());
            }

            return input;
        }

        /// <summary>
        /// That is method with who remove incorrect symbols from 'username'
        /// </summary>
        /// <param name="input">enter desired username</param>
        /// <returns>new valid username in string type</returns>
        public static string ToValidUsername(this string input)
        {
            input = input.ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.]+", string.Empty);
        }

        /// <summary>
        /// That is method with who use for validation of file name
        /// (convert file name from cyrillic to latin)
        /// </summary>
        /// <param name="input">enter desired 'file name' for change</param>
        /// <returns>new valid username in string type</returns>
        public static string ToValidLatinFileName(this string input)
        {
            input = input.Replace(" ", "-").ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.\-]+", string.Empty);
        }

        /// <summary>
        /// That method take first characters from a given string
        /// </summary>
        /// <param name="input">Enter string that will be used</param>
        /// <param name="charsCount">Enter how much characters will be extracted</param>
        /// <returns>new string that is part of entered string</returns>
        public static string GetFirstCharacters(this string input, int charsCount)
        {
            return input.Substring(0, Math.Min(input.Length, charsCount));
        }

        /// <summary>
        /// Method give extension of fixed file
        /// </summary>
        /// <param name="fileName">need to be enter desired file in string format</param>
        /// <returns>extension of the file if it exist; otherwise give empty string</returns>
        public static string GetFileExtension(this string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
            {
                return string.Empty;
            }

            string[] fileParts = fileName.Split(new[] { "." }, StringSplitOptions.None);
            if (fileParts.Count() == 1 || string.IsNullOrEmpty(fileParts.Last()))
            {
                return string.Empty;
            }

            return fileParts.Last().Trim().ToLower();
        }

        /// <summary>
        /// Returns the content type of a file depending on its extension.
        /// </summary>
        /// <param name="fileExtension">The file extension</param>
        /// <returns>The content type associated with the given file extension</returns>
        public static string ToContentType(this string fileExtension)
        {
            var fileExtensionToContentType = new Dictionary<string, string>
                                                 {
                                                     { "jpg", "image/jpeg" },
                                                     { "jpeg", "image/jpeg" },
                                                     { "png", "image/x-png" },
                                                     {
                                                         "docx",
                                                         "application/vnd.openxmlformats-officedocument.wordprocessingml.document"
                                                     },
                                                     { "doc", "application/msword" },
                                                     { "pdf", "application/pdf" },
                                                     { "txt", "text/plain" },
                                                     { "rtf", "application/rtf" }
                                                 };
            if (fileExtensionToContentType.ContainsKey(fileExtension.Trim()))
            {
                return fileExtensionToContentType[fileExtension.Trim()];
            }

            return "application/octet-stream";
        }

        /// <summary>
        /// Converts a string into an array of bytes
        /// </summary>
        /// <param name="input">The string the method is called upon</param>
        /// <returns>An array of bytes derived from converting every character 
        /// in the given string to its byte representation</returns>
        /// <exception cref="OverflowException">The array is multidimensional and contains more than <see cref="F:System.Int32.MaxValue" /> elements.</exception>
        public static byte[] ToByteArray(this string input)
        {
            var bytesArray = new byte[input.Length * sizeof(char)];
            Buffer.BlockCopy(input.ToCharArray(), 0, bytesArray, 0, bytesArray.Length);
            return bytesArray;
        }
    }
}
