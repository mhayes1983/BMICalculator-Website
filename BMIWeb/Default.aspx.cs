using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using BMICalculator;
using static BMICalculator.Enumerations;

namespace BMIWeb
{
	public partial class _Default : Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		private double? HeightFeet
		{
			get
			{
				string strValue = txtHeightFeet.Value;
				double dblValue;
				if(!string.IsNullOrEmpty(strValue) && double.TryParse(strValue, out dblValue))
				{
					return dblValue;
				}
				return null;
			}
		}

		private double? HeightInches
		{
			get
			{
				string strValue = txtHeightInches.Value;
				double dblValue;
				if (!string.IsNullOrEmpty(strValue) && double.TryParse(strValue, out dblValue))
				{
					return dblValue;
				}
				return null;
			}
		}

		private double? WeightPounds
		{
			get
			{
				string strValue = txtWeightPounds.Value;
				double dblValue;
				if (!string.IsNullOrEmpty(strValue) && double.TryParse(strValue, out dblValue))
				{
					return dblValue;
				}
				return null;
			}
		}

		protected void btnCalculateBMI_Click(object sender, EventArgs e)
		{
			try
			{
				ClearErrorMessage();

				ICalculatorModule calculatorModule = new CalculatorModule();

				//Calculate BMI value result
				double dblBMIValueResult = calculatorModule.CalculateBMIForHeightAndWeight(HeightFeet, HeightInches, WeightPounds);
				lblBMIResultValue.InnerText = dblBMIValueResult.ToString();

				BMIResultTypeEnum enmBMIResultType = calculatorModule.GetBMIResultTypeForBMIValue(dblBMIValueResult);
				lblBMIResultType.InnerText = WebHelper.GetBMIResultTypeText(enmBMIResultType);
			}
			catch (Exception ex)
			{
				//TODO: Create Exception class and types and display correct error message based on type of exception
				//For now just display the whole exception string
				DisplayErrorMessage(ex.ToString());
			}
		}

		protected void btnClearBMI_Click(object sender, EventArgs e)
		{
			try
			{
				ClearErrorMessage();
				txtHeightFeet.Value = null;
				txtHeightInches.Value = null;
				txtWeightPounds.Value = null;
				lblBMIResultType.InnerText = "-";
				lblBMIResultValue.InnerText = "--.-";
			}
			catch (Exception ex)
			{
				//TODO: Create Exception class and types and display correct error message based on type of exception
				//For now just display the whole exception string
				DisplayErrorMessage(ex.ToString());
			}
		}

		private void ClearErrorMessage()
		{
			lblError.InnerText = null;
			phErrorMessage.Visible = false;
		}

		private void DisplayErrorMessage(string errorMessage)
		{
			phErrorMessage.Visible = true;
			lblError.InnerText = errorMessage;			
		}
	}
}