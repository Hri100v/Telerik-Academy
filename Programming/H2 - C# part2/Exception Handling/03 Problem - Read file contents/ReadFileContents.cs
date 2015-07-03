/*Problem 3. Read file contents

Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console.
Find in MSDN how to use System.IO.File.ReadAllText(…).
Be sure to catch all possible exceptions and print user-friendly error messages.
 */

using System;
using System.Linq;
using System.IO;
using System.Security;

namespace ProblemReadFileContents
{
    class ReadFileContents
    {
        static void Main(string[] args)
        {
            string path = "C:\\WINDOWS\\win.ini";
            //string path = Console.ReadLine();
            string testPath = "C:\\WINDOWS*\\ERasa";

            ReadFile(testPath);

        }

        static void ReadFile(string filePath)
        {
            try
            {
                Console.WriteLine(File.ReadAllText(filePath));
            }
            // 1
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("That directory is not found.");
            }
            // 2
            catch (FileNotFoundException exception)
            {
                Console.Error.WriteLine(exception.Message);
            }
            // 3
            catch (ArgumentNullException exception)
            {
                Console.Error.WriteLine(exception.Message);
            }
            // 4
            catch (ArgumentException)
            {
                Console.WriteLine("{0} - this file path have zero elements, contains only white space, or contains one or more invalid characters.", filePath);
            }
            // 5
            catch (PathTooLongException exception)
            {
                Console.Error.WriteLine(exception.Message);
            }
            // 6
            catch (UnauthorizedAccessException exception)
            {
                Console.Error.WriteLine(exception.Message);
            }
            // 7
            catch (SecurityException exception)
            {
                Console.Error.WriteLine(exception.Message);
            }
            //8
            catch (IOException exception)
            {
                Console.Error.WriteLine(exception.Message);
            }
            // 9
            catch (NotSupportedException exception)
            {
                Console.Error.WriteLine(exception.Message);
            }


        }
    }
}
