using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileMover
{
    public class FileMover
    {
        public static string[] GetFiles()
        {
            string[] files = Directory.GetFiles($"{Environment.GetEnvironmentVariable("USERPROFILE")}/Documents/Test/","*.txt");
            return files;
        }

        public static void MoveToTest2(string filepath)
        {
            int lastIndex = filepath.LastIndexOf("/");
            string fileName = filepath.Substring(lastIndex + 1);
            Directory.Move(filepath, $"{Environment.GetEnvironmentVariable("USERPROFILE")}/Documents/Test2/{fileName}");
        }

        public static void Move(string sourceFilePath, string destinationFilePath)
        {
            int lastIndex = sourceFilePath.LastIndexOf("/");
            if(lastIndex == sourceFilePath.Length - 1)
            {
                throw new ArgumentException("There is not a valid item to move.");
            }
            if (!destinationFilePath.Last().Equals("/"))
            {
                destinationFilePath = destinationFilePath + "/";
            }
            string fileName = sourceFilePath.Substring(lastIndex + 1);
            Directory.Move(sourceFilePath, destinationFilePath+ fileName);
        }
    }
}
