﻿using System.IO;

namespace _02_TryCatchFinally
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var firstLine = "No first line was read";
            try
            {
                var lines = File.ReadAllLines(args[0]);
                firstLine = (lines.Length > 0) ? lines[0] : "The file was empty";
            }
            //catch (Exception ex)
            //{
            //    Console.Error.WriteLine("Could not read lines from the file: {0}", ex);
            //}
            catch (IndexOutOfRangeException)
            {
                Console.Error.WriteLine("Please specify a filename.");
            }
            catch (FileNotFoundException)
            {
                Console.Error.WriteLine("Unable to find file: {0}", args[0]);
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.Error.WriteLine("File {0} could not be accessed: {1}",
                args[0], ex.Message);
            }
            finally
            {
                Console.WriteLine(firstLine);
            }
        }
    }
}