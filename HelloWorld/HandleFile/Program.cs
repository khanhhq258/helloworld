using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HandleFile
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadTextFromFile("D:/ReadFile.txt");
            WriteTextIntoFile("D:/WriteFile.txt", "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            Console.ReadKey();
        }

        public static void ReadTextFromFile(string filePath) {
            if (File.Exists(filePath))
            {
                using (StreamReader sr = new StreamReader(filePath)) {
                    string line;
                    while ((line = sr.ReadLine()) != null) {
                        Console.WriteLine(line);
                    }
                }
            }
            else {
                Console.Write("File does not exist");
            }
        }

        public static void WriteTextIntoFile(string filePath,string text) {
            try {
                using (StreamWriter sw = new StreamWriter(filePath)) {
                    sw.WriteLine(text);
                }
            }
            catch (Exception ex) {
                Console.Write(ex.Message);
            }
        }
    }
}
