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

        //Test 3
        [TestMethod]
        public void TestCustomException_ShouldReturn_CustomNullMsgException_When_given_null()
        {
            try
            {
                //Arrange
                string message = null;
                MoodAnalyserLogic mood = new MoodAnalyserLogic(message);

                //Act
                mood.AnalyseMood();

            }
            catch (MoodAnalyserException m)
            {

                Assert.AreEqual("Message should not be null", m.Message);
            }
            
        }

        //Test 4
        [TestMethod]
        public void TestCustomException_ShouldReturn_CustomEmptyMsgException_When_given_empty()
        {
            try
            {
                //Arrange
                string message = "";
                MoodAnalyserLogic mood = new MoodAnalyserLogic(message);

                //Act
                mood.AnalyseMood();

            }
            catch (MoodAnalyserException m)
            {

                Assert.AreEqual("Message should not be empty", m.Message);
            }

        }

        //Test 5
        [TestMethod]
        public void Given_MoodAnalyser_ClassName_Should_Return_MoodAnalyser_Object()
        {
            //Arrange
            string className = "MoodAnalyzer.MoodAnalyserLogic";
            string constructorName = "MoodAnalyserLogic";
            MoodAnalyserLogic expected = new MoodAnalyserLogic();
            //Act
            object resultObj = MoodAnalyserFactory.CreateMoodAnalyserObject(className, constructorName);
            expected.Equals(resultObj);
        }

        //Test 6
        [TestMethod]
        public void ImproperClassName_ShouldThrowMoodAnalysisException()
        {
            try
            {
                //Arrange
                string className = "WrongNamespace.MoodAnalyser";
                string constructorName = "MoodAnalyser";
                //Act
                object resultObj = MoodAnalyserFactory.CreateMoodAnalyserObject(className, constructorName);
            }
            catch (MoodAnalyserException e)
            {
                //Assert
                Assert.AreEqual("class not found", e.Message);
            }
        }

        //Test 7
        [TestMethod]
        public void ImproperConstructorName_ShouldThrowMoodAnalysisException()
        {
            try
            {
                //Arrange
                string className = "MoodAnalyzerProblem.MoodAnalyser";
                string constructorName = "WrongConstructorName";
                //Act
                object resultObj = MoodAnalyserFactory.CreateMoodAnalyserObject(className, constructorName);
            }
            catch (MoodAnalyserException e)
            {
                //Assert
                Assert.AreEqual("constructor not found", e.Message);
            }
        }
    }
}