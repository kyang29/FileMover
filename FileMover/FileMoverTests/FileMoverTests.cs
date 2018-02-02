using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileMover;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileMover.Tests
{
    [TestClass()]
    public class FileMoverTests
    {
        [TestMethod()]
        public void GetFilesTest()
        {
            List<string> files = FileMover.GetFiles().ToList();
            foreach(var item in files)
            {
                Console.WriteLine(item);
                FileMover.MoveToTest2(item);
            }
            Assert.AreNotEqual(files.Count, 0);
        }
    }
}