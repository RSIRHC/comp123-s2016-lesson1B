using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static comp123_s2016_lesson1B.Program; 



namespace Lesson1TestProject
{
    [TestClass]
    public class Lesson1UnitTest
    {
        [TestMethod]
        public void OutputStringToConsoleTestMethod()
        {
            //Arrange
            string outputString = "Enter UserName: ";
            bool hasNewLine = false;
            string actualResult;
            string expectedResult = "Enter UserName: ";

            //Act
            actualResult = OutputStringToConsole(outputString, hasNewLine);

            //Assert
            Assert.AreEqual(expectedResult, actualResult); 
        }
    }
}
