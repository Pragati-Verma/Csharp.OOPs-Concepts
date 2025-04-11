using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckingExecution
{
    public class FileSystemDemo
    {
        public static void Main(string[] args)
        {
            string filePath = @"D:\Practice\C#\CheckingExecution\";

            // GETTING ALL DIRECTORIES & SUBDIRECTORIES

            /*
            string[] directories = Directory.GetDirectories(filePath,"*",SearchOption.AllDirectories);
            foreach (string dir in directories)
            {
                Console.WriteLine(dir);
            }
            */

            // GETTING ALL FILES FROM CURRENT DIRECTORY

            /*
            var files = Directory.GetFiles(filePath,"*.cs", SearchOption.TopDirectoryOnly);
            foreach (var file in files)
            {
                //Console.WriteLine(file);
                var info = new FileInfo(file);
                Console.WriteLine($"{Path.GetFileName(file)}: {info.Length} bytes");
            }
            */

            // CHECKING IF DIRECTORY EXISTS & CREATING IF IT DOES NOT

            /*
            string newPath = @"D:\Practice\C#\CheckingExecution\FolderA\SubfolderAB";
            bool directoryExists = Directory.Exists(newPath);
            if(directoryExists)
            {
                Console.WriteLine($"{newPath} directory exists!");
            }
            else
            {
                Console.WriteLine($"{newPath} directory does not exist\nCreating now");
                Directory.CreateDirectory(newPath);
            }
            */

            // COPYING ALL FILES FROM SOURCE TO DESTINATION

            /*
            string destinationPath = @"D:\Practice\C#\FileSystemDemo\";
            var filesList = Directory.GetFiles(filePath);
            foreach(var file in filesList)
            {
                File.Copy(file, $"{destinationPath}{Path.GetFileName(file)}",true);
                Console.WriteLine("Copied all files!");
            }
            */

            // READING CONTENTS OF FILE USING STREAMREADER

            /*
            StreamReader streamReader = null;
            string data;
            try
            {
                streamReader = new StreamReader(@"D:\Practice\C#\CheckingExecution\Program.cs");
                data = streamReader.ReadLine();
                while(data != null)
                {
                    Console.WriteLine(data);
                    data = streamReader.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                streamReader.Close();
            }
            */

            // WRITE TO FILE USING STREAMWRITER

            /*
            StreamWriter streamWriter = null;
            try
            {
                streamWriter = new StreamWriter(@"D:\Practice\C#\CheckingExecution\FolderA\sample1.txt");
                streamWriter.Write("Hello World!");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                streamWriter.Close();
            }
            */

            /*
            string fileName = @"D:\Practice\C#\CheckingExecution\Program.cs";
            string data;
            if(File.Exists(fileName))
            {
                data = File.ReadAllText(fileName);
                Console.WriteLine(data);
            }
            */

            string fileName2 = @"D:\Practice\C#\CheckingExecution\FolderA\sample2.txt";
            string data2 = "Writing to file using File class\n";
            if(File.Exists(fileName2))
            {
                //File.WriteAllText(fileName2, data2);
                File.AppendAllText(fileName2, data2);
                Console.WriteLine($"Written to file {fileName2}");
            }
        }
    }
}
