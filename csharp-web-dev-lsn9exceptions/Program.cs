using System;
using System.Collections.Generic;

namespace csharp_web_dev_lsn9exceptions
{
    class Program
    {
        static double Divide(double x, double y)
        {
            if (y == 0)
            {
                throw new ArgumentOutOfRangeException("y cannot be zero");
            }
            return x / y;
        }

        static int CheckFileExtension(string fileName)
        {
            if (fileName == null || fileName == "")
            {
                throw new ArgumentNullException("fileName cannot be null");
            } else if (fileName.Substring(fileName.Length - 3,3) == ".cs")
            {
                return 1;
            } else
            {
                return 0;
            }
        }


        static void Main(string[] args)
        {
            try
            {
                Divide(100, 0);
            }
            catch (ArgumentOutOfRangeException)
            {
                Divide(100, 100);
            }
            finally
            {
                Console.WriteLine("y cannot be zero.");
            }

            // Test out your CheckFileExtension() function here!
            Dictionary<string, string> students = new Dictionary<string, string>();
            students.Add("Carl", "Program.cs");
            students.Add("Brad", "");
            students.Add("Elizabeth", "MyCode.cs");
            students.Add("Stefanie", "CoolProgram.cs");
            foreach (KeyValuePair<string, string> student in students)
            {
                try
                {
                    CheckFileExtension(student.Value);
                }
                catch
                {
                    CheckFileExtension("incorrectFile.js");
                }
                finally
                {
                    Console.WriteLine("Must submit a file.");
                }
            }

        }
    }
}
