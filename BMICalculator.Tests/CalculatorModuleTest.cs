using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using static BMICalculator.Enumerations;

namespace BMICalculator.Tests
{
	[TestClass]
	public class CalculatorModuleTest
	{
		[TestMethod]
		public void TestCalculateBMIForHeightAndWeight_150lbs5ft5in()
		{
			ICalculatorModule calculator = new CalculatorModule();

			double dblBMI = calculator.CalculateBMIForHeightAndWeight(5, 5, 150);

			Assert.IsTrue(dblBMI == 25);
		}

		[TestMethod]
		public void TestCalculateBMIForHeightAndWeight_110lbs5ft6in()
		{
			ICalculatorModule calculator = new CalculatorModule();

			double dblBMI = calculator.CalculateBMIForHeightAndWeight(5, 6, 110);

			Assert.IsTrue(dblBMI == 17.8);
		}

		[TestMethod]
		public void TestCalculateBMIForHeightAndWeight_160lbs5ft8in()
		{
			ICalculatorModule calculator = new CalculatorModule();

			double dblBMI = calculator.CalculateBMIForHeightAndWeight(5, 8, 160);

			Assert.IsTrue(dblBMI == 24.3);
		}

		[TestMethod]
		public void TestGetBMIEnumerationForBMI_Underweight()
		{
			ICalculatorModule calculator = new CalculatorModule();

			BMIResultTypeEnum enmResult = calculator.GetBMIResultTypeForBMIValue(18.49);

			Assert.IsTrue(enmResult == BMIResultTypeEnum.Underweight);
		}

		[TestMethod]
		public void TestGetBMIEnumerationForBMI_Normal()
		{
			ICalculatorModule calculator = new CalculatorModule();

			BMIResultTypeEnum enmResult = calculator.GetBMIResultTypeForBMIValue(24.99);

			Assert.IsTrue(enmResult == BMIResultTypeEnum.Normal);
		}

		[TestMethod]
		public void TestGetBMIEnumerationForBMI_Overweight()
		{
			ICalculatorModule calculator = new CalculatorModule();

			BMIResultTypeEnum enmResult = calculator.GetBMIResultTypeForBMIValue(29.99);

			Assert.IsTrue(enmResult == BMIResultTypeEnum.Overweight);
		}

		[TestMethod]
		public void TestGetBMIEnumerationForBMI_Obese()
		{
			ICalculatorModule calculator = new CalculatorModule();

			BMIResultTypeEnum enmResult = calculator.GetBMIResultTypeForBMIValue(30);

			Assert.IsTrue(enmResult == BMIResultTypeEnum.Obese);
		}
	}
}
