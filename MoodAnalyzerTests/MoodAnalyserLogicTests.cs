using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer.Tests
{
    [TestClass]
    public class MoodAnalyserLogicTests
    {
        //Test 1
        [TestMethod]
        public void TestAnalyseMood_ShouldReturnSAD()
        {
            //Arrange
            string message = "I am in a Sad Mood";
            MoodAnalyserLogic mood = new MoodAnalyserLogic(message);
            
            //Act
            string result = mood.AnalyseMood();
            
            //Assert
            Assert.AreEqual(result, "SAD");
        }

        //Test 2
        [TestMethod]
        public void TestAnalyseMood_ShouldReturnHAPPY()
        {
            //Arrange
            string message = "I am in Any Mood";
            MoodAnalyserLogic mood = new MoodAnalyserLogic(message);
            
            //Act
            string result = mood.AnalyseMood();
            
            //Assert
            Assert.AreEqual(result, "HAPPY");      
        }
    }
}