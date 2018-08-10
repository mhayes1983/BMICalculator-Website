<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BMIWeb._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="page-header">
        <h2>Body mass index (BMI)</h2>
        <p class="lead">A measure of body fat in adults</p>
        <p><a href="https://www.cdc.gov/healthyweight/assessing/bmi/adult_bmi/index.html" class="btn btn-primary" target="_blank">Learn more &raquo;</a></p>
    </div>

	<div class="row">
		<div class="col-md-12">
			<h4>Calculate your Body mass index (BMI)</h4>
		</div>		
	</div>
	<asp:UpdatePanel ID="uplBMICalculate" runat="server">
		<ContentTemplate>
			<div class="row">
				<div class="col-md-5">
					<div class="row">
						<div class="col-md-12">
							<div class="form-group">
								<label for="txtWeight">Weight</label>
								<input type="text" class="form-control" id="txtWeightPounds" runat="server" placeholder="pounds"> lb
							</div>
						</div>
					</div>
					<div class="row">
						<div class="col-md-12">
							<div class="form-group">
								<label for="txtHeightFeet">Height</label>
								<input type="text" class="form-control" id="txtHeightFeet" runat="server" placeholder="feet"> ft
								<input type="text" class="form-control" id="txtHeightInches" runat="server" placeholder="inches"> in
							</div>
						</div>
					</div>
				</div>
				<div class="col-md-7">
					<div class="row">
						<div class="col-md-12">
							<h3><label id="lblBMIResultValue" runat="server">--.-</label></h3>
							<h4><label id="lblBMIResultType" runat="server">-</label> BMI</h4>
						</div>				
					</div>
				</div>
			</div>
			<div class="row">
				<div class="col-md-2">
					<asp:Button ID="btnCalculateBMI" class="btn btn-primary" runat="server" Text="Calculate" OnClick="btnCalculateBMI_Click" />
					<asp:Button ID="btnClearBMI" class="btn btn-default" runat="server" Text="Clear" OnClick="btnClearBMI_Click" /> 
				</div>
			</div>
			<asp:PlaceHolder ID="phErrorMessage" Visible="false" runat="server">
			<div class="row">
				<div class="col-md-12">
					<div class="alert alert-danger">
					  <strong>An error has occured!</strong> <label id="lblError" runat="server" />
					</div>
				</div>
			</div>
			</asp:PlaceHolder>
			</ContentTemplate>
	</asp:UpdatePanel>
</asp:Content>
