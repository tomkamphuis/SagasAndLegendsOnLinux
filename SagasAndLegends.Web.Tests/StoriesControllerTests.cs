using System;
using Moq;
using SagasAndLegends.Services.StoryServices;
using SagasAndLegends.Web.Controllers;
using Xunit;

namespace SagasAndLegends.Web.Tests
{
	public class StoriesControllerTests
	{
		[Fact]
		public void Get_Should_Return_A_Story()
		{
			var mockService = new Mock<IStoryService>();
			mockService.Setup(ms => ms.GetStory()).Returns("This is my story");

			var storiesController = new StoriesController(mockService.Object);

			var result = storiesController.Get();

			Assert.NotEmpty(result);
		}
	}
}