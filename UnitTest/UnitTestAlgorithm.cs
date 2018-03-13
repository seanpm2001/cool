﻿using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Cool.Parsing;
using Cool.AST;

namespace UnitTest
{
    [TestClass]
    public class UnitTestAlgorithm
    {
        [TestMethod]
        public void TopologicalSortSuccess()
        {
            UnitTestParsing testParsing = new UnitTestParsing();
            string directorySuccess = "../../../Examples/Algorithm/success/";
            DirectoryInfo directory = new DirectoryInfo(directorySuccess);
            FileInfo[] files = directory.GetFiles();

            foreach (var file in files)
            {
                testParsing.ParsingFile(file.FullName);
                var astBuilder = new ASTBuilder();
                ASTNode root = astBuilder.Visit(testParsing.tree);
                ProgramNode rootProgram = root as ProgramNode;

            }

        }

        [TestMethod]
        public void TopologicalSortFail()
        {

        }
    }
}
