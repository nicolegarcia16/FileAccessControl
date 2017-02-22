using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileAccessControl;

namespace FileAccessControlTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestValidateFileName()
        {
            string filename = "C:\\Users\\nicol\\Documents\\Graduate Classes\\SSE 554\\Project 1\\Project1.docx";
            Form1 frm = new Form1();
            bool isValid = frm.validateFilename(filename);
            Assert.IsTrue(isValid);
        }
    }
}
