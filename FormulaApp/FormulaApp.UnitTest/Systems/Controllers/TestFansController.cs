using FluentAssertions;
using FormulaApp.Api;
using Microsoft.AspNetCore.Mvc;

namespace FormulaApp.UnitTest.Systems.Controllers;
public class TestFansController
{
	[Fact]
	public async Task Get_OnSuccess_ReturnStatusCode200()
	{
		//Arrange
		var fansController = new FansController();
		//Act
		var result = (OkObjectResult)await fansController.Get();

		//Assert
		result.StatusCode.Should().Be(200);
	}
}