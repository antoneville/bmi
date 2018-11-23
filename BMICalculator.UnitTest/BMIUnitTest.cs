using BMICalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BMI.UnitTests
{
    [TestClass]
    public class BmiTest
    {
        [TestMethod]
        //Syntax Should be fine to leave method name as BMIValue as there is only one exectution path
        public void TestBMIValue_Calculates_ReturnsCalculation()
        {

            //Arrange
            BMICalculator.BMI calcTest = new BMICalculator.BMI
            {
                WeightStones = 5,
                WeightPounds = 12,
                HeightFeet = 6,
                HeightInches = 2
            };

            double expectedResult = calcTest.BMIValue;

            //Act
            double pnds = ((5 * 14) + 12);
            double inches = ((6 * 12) + 2);

            double actualResult = ((pnds * 0.453592) / Math.Pow((inches * 0.0254), 2));

            //Assert
            Assert.AreEqual(actualResult, expectedResult);
        }

        [TestMethod]
        public void TestBMICategory_Calculates_ReturnsNormal()
        {
            //Arrange
            BMICalculator.BMI calcTest = new BMICalculator.BMI
            {
                WeightStones = 8,
                WeightPounds = 12,
                HeightFeet = 5,
                HeightInches = 5
            };

            double val = calcTest.BMIValue;
            BMICategory actualResult = BMICategory.Normal;

            //Act

            BMICategory expectedResult = calcTest.BMICategory;

            //Assert
            Assert.AreEqual(actualResult, expectedResult);
        }

        [TestMethod]
        public void TestBMICategory_Calculates_ReturnsUnderWeightUpperLimit()
        {
            //Arrange
            BMICalculator.BMI calcTest = new BMICalculator.BMI
            {
                WeightStones = 4,
                WeightPounds = 6,
                HeightFeet = 4,
                HeightInches = 2
            };

            double val = calcTest.BMIValue;
            BMICategory actualResult = BMICategory.Underweight;

            //Act

            BMICategory expectedResult = calcTest.BMICategory;

            //Assert
            Assert.AreEqual(actualResult, expectedResult);
        }

        [TestMethod]
        public void TestBMICategory_Calculates_ReturnsNormalWeightUpperLimit()
        {
            //Arrange
            BMICalculator.BMI calcTest = new BMICalculator.BMI
            {
                WeightStones = 8,
                WeightPounds = 12,
                HeightFeet = 5,
                HeightInches = 5
            };

            double val = calcTest.BMIValue;
            BMICategory actualResult = BMICategory.Normal;

            //Act

            BMICategory expectedResult = calcTest.BMICategory;

            //Assert
            Assert.AreEqual(actualResult, expectedResult);
        }

        [TestMethod]
        public void TestBMICategory_Calculates_ReturnsOverWeightUpperLimit()
        {
            //Arrange
            BMICalculator.BMI calcTest = new BMICalculator.BMI
            {
                WeightStones = 11,
                WeightPounds = 12,
                HeightFeet = 5,
                HeightInches = 3
            };

            double val = calcTest.BMIValue;
            BMICategory actualResult = BMICategory.Overweight;

            //Act

            BMICategory expectedResult = calcTest.BMICategory;

            //Assert
            Assert.AreEqual(actualResult, expectedResult);
        }

        [TestMethod]
        public void TestBMICategory_Calculates_ReturnsObese()
        {
            //Arrange
            BMICalculator.BMI calcTest = new BMICalculator.BMI
            {
                WeightStones = 11,
                WeightPounds = 12,
                HeightFeet = 4,
                HeightInches = 3
            };

            double val = calcTest.BMIValue;
            BMICategory actualResult = BMICategory.Obese;

            //Act

            BMICategory expectedResult = calcTest.BMICategory;

            //Assert
            Assert.AreEqual(actualResult, expectedResult);
        }

        [TestMethod]
        public void TestBMIWeightStones_Sets_SetsWeightofStones()
        {
            //Arrange
            BMICalculator.BMI calcTest = new BMICalculator.BMI();
            int actualResult = calcTest.WeightStones = 5;
            //Act
            int expectedResult = 5;
            //Assert
            Assert.AreEqual(actualResult, expectedResult);
        }

        [TestMethod]
        public void TestBMIWeightCheck_Returns_UnderWeight()
        {
            //Arrange
            BMICalculator.BMI calcTest = new BMICalculator.BMI
            {
                WeightStones = 4,
                WeightPounds = 5,
                HeightFeet = 4,
                HeightInches = 1
            };

            String actualResult = calcTest.BMIWeightCheck;

            //Act
            String expectedResult = "Warning: You are under weight.";

            //Assert
            Assert.AreEqual(actualResult, expectedResult);

        }

        [TestMethod]
        public void TestBMIWeightCheck_Returns_HealthyWeight()
        {
            //Arrange
            BMICalculator.BMI calcTest = new BMICalculator.BMI
            {
                WeightStones = 8,
                WeightPounds = 8,
                HeightFeet = 5,
                HeightInches = 7
            };

            String actualResult = calcTest.BMIWeightCheck;

            //Act
            String expectedResult = "Success: You seem to be a healthy weight.";

            //Assert
            Assert.AreEqual(actualResult, expectedResult);
        }

        [TestMethod]
        public void TestBMIWeightCheck_Returns_Overweight()
        {
            //Arrange
            BMICalculator.BMI calcTest = new BMICalculator.BMI
            {
                WeightStones = 11,
                WeightPounds = 12,
                HeightFeet = 5,
                HeightInches = 3
            };

            String actualResult = calcTest.BMIWeightCheck;

            //Act
            String expectedResult = "Warning: You are over weight.";

            //Assert
            Assert.AreEqual(actualResult, expectedResult);

        }

        [TestMethod]
        public void TestBMIWeightCheck_Returns_Obese()
        {
            //Arrange
            BMICalculator.BMI calcTest = new BMICalculator.BMI
            {
                WeightStones = 11,
                WeightPounds = 10,
                HeightFeet = 4,
                HeightInches = 2
            };

            String actualResult = calcTest.BMIWeightCheck;

            //Act
            String expectedResult = "Critical Warning: You are severly over weight.";

            //Assert
            Assert.AreEqual(actualResult, expectedResult);

        }

    }
}
