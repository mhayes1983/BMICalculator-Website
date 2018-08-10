using System;

namespace BMICalculator
{
	public class CalculatorModule : ICalculatorModule
	{
		public CalculatorModule()
		{}

		public double CalculateBMIForHeightAndWeight(double? heightFeet, double? heightInches, double? weightPounds)
		{
			if (!heightFeet.HasValue || heightFeet.Value <= 0)
			{
				throw new Exception(String.Format("Invalid Height Feet {0}", heightFeet.Value));
			}
			if (!heightInches.HasValue || heightInches.Value > 11 || heightInches.Value < 0)
			{
				throw new Exception(String.Format("Invalid Height Inches {0}", heightInches.Value));
			}
			if (!weightPounds.HasValue || weightPounds.Value <= 0)
			{
				throw new Exception(String.Format("Invalid Weight Pounds {0}", weightPounds.Value));
			}

			try
			{
				//Formula: weight(lb) / [height(in)]2 x 703
				//Calculate BMI by dividing weight in pounds(lbs) by height in inches(in) squared and multiplying by a conversion factor of 703.
				double dblTotalHeightInches = ((heightFeet.Value * 12) + heightInches.Value);

				return (Math.Round((weightPounds.Value / Math.Pow(dblTotalHeightInches, 2)) * 703, 1));
			}
			catch (Exception ex)
			{

				throw new Exception(String.Format("Unable to calculate BMI for Height Feet {0}, Height Inches {1}, Weight Pounds {2}", heightFeet, heightInches, weightPounds), ex);
			}			
		}

		public Enumerations.BMIResultTypeEnum GetBMIResultTypeForBMIValue(double bmi)
		{
			try
			{
				//Below 18.5 - Underweight
				if (bmi < 18.5)
				{
					return Enumerations.BMIResultTypeEnum.Underweight;
				}
				//18.5 – 24.9 Normal or Healthy Weight
				if (bmi >= 18.5 && bmi < 25)
				{
					return Enumerations.BMIResultTypeEnum.Normal;
				}
				//25.0 – 29.9 Overweight
				if (bmi >= 25 && bmi < 30)
				{
					return Enumerations.BMIResultTypeEnum.Overweight;
				}
				//30.0 and Above  Obese
				return Enumerations.BMIResultTypeEnum.Obese;
			}
			catch (Exception ex)
			{

				throw new Exception(String.Format("Unable to determine BMI result type for BMI value {0}", bmi), ex);
			}			
		}
	}
}
