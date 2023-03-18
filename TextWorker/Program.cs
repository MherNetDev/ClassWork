using System;
using System.ComponentModel;
using System.IO;

namespace TextFileWorker_Json
{
    internal class Program
    {
        static void Main(string[] args)
        {//C:\Users\student.BASIC
            string file = @"C:\Users\student.BASIC\Desktop\somefile.txt";
            bool fileExist = File.Exists(file);
            Program program = new Program();
            if (fileExist)
            {
                Console.WriteLine("File exist.continuing task.Opening file:");
                program.deletefileOr(file);
                program.openFile(file);
            }

            else
            {
                Console.WriteLine("File doesn't exist.creating file:");
                program.createFile(file);
            }

        }
        public void deletefileOr(string file)
        {

            Console.WriteLine("Do you want to delete file?\ntype y for yes:   type n for no:");
            File.Delete(file);

        }

        public void createFile(string file)
        {
            File.Create(file);
            if (File.Exists(file))
            {
                Console.WriteLine("iff");
                openFile(file);

            }
        }
        public void openFile(string file)
        {

            string[] fileContains = File.ReadAllLines(file);
            foreach (string line in fileContains)
                Console.WriteLine(line);

        }


    }
}