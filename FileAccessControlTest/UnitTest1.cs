using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileAccessControl;
using System.Security.AccessControl;

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

        [TestMethod]
        public void TestGetAccessControlString()
        {
            string filename = "C:\\Users\\nicol\\Documents\\Graduate Classes\\SSE 554\\Project 1\\Project1.docx";
            ACLView frm = new ACLView(filename);
            FileSystemAccessRule rule = new FileSystemAccessRule("ident", FileSystemRights.FullControl, AccessControlType.Allow);
            string accessControlString = frm.getAccessControlString(rule);
            Assert.IsTrue(accessControlString != null && accessControlString.Length > 0);
        }

        [TestMethod]
        public void TestGetSystemRightsString()
        {
            string filename = "C:\\Users\\nicol\\Documents\\Graduate Classes\\SSE 554\\Project 1\\Project1.docx";
            ACLView frm = new ACLView(filename);
            FileSystemAccessRule rule = new FileSystemAccessRule("ident", FileSystemRights.FullControl, AccessControlType.Allow);
            string systemRightsString = frm.getSystemRightsString(rule);
            Assert.IsTrue(systemRightsString != null && systemRightsString.Length > 0);
        }

        [TestMethod]
        public void TestGetIdentityReferenceString()
        {
            string filename = "C:\\Users\\nicol\\Documents\\Graduate Classes\\SSE 554\\Project 1\\Project1.docx";
            ACLView frm = new ACLView(filename);
            FileSystemAccessRule rule = new FileSystemAccessRule("ident", FileSystemRights.FullControl, AccessControlType.Allow);
            string identityReferenceString = frm.getIdentityReferenceString(rule);
            Assert.IsTrue(identityReferenceString != null && identityReferenceString.Length > 0);
        }

        [TestMethod]
        public void TestGetInheritedRulesString()
        {
            string filename = "C:\\Users\\nicol\\Documents\\Graduate Classes\\SSE 554\\Project 1\\Project1.docx";
            ACLView frm = new ACLView(filename);
            FileSystemAccessRule rule = new FileSystemAccessRule("ident", FileSystemRights.FullControl, AccessControlType.Allow);
            string inheritedRulesString = frm.getInheritedRulesString(rule);
            Assert.IsTrue(inheritedRulesString != null && inheritedRulesString.Length > 0);
        }

        [TestMethod]
        public void TestGetAuthorizationRules()
        {
            string filename = "C:\\Users\\nicol\\Documents\\Graduate Classes\\SSE 554\\Project 1\\Project1.docx";
            ACLView frm = new ACLView(filename);
            AuthorizationRuleCollection rules = frm.getAuthorizationRules(filename);
            Assert.IsTrue(rules.Count > 0);
        }


    }
}
