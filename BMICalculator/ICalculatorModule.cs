using static BMICalculator.Enumerations;

namespace BMICalculator
{
	public interface ICalculatorModule
	{
		double CalculateBMIForHeightAndWeight(double? heightFeet, double? heightInches, double? weightPounds);
		BMIResultTypeEnum GetBMIResultTypeForBMIValue(double bmi);
	}
}
