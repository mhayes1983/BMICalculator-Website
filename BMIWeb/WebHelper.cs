using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using static BMICalculator.Enumerations;

namespace BMIWeb
{
	public static class WebHelper
	{
		public static string GetBMIResultTypeText(BMIResultTypeEnum bmi)
		{
			switch (bmi)
			{
				case BMIResultTypeEnum.Underweight:
					return "Underweight";
				case BMIResultTypeEnum.Normal:
					return "Normal";
				case BMIResultTypeEnum.Overweight:
					return "Overweight";
				case BMIResultTypeEnum.Obese:
					return "Obese";
				default:
					return null;
			}
		}
	}
}