using Microsoft.AspNetCore.Mvc;
using SagasAndLegends.Services.StoryServices;

namespace SagasAndLegends.Web.Controllers
{
	[Produces("application/json")]
	[Route("api/Stories")]
	public class StoriesController : Controller
	{
		private readonly IStoryService _storyService;

		public StoriesController(IStoryService storyService)
		{
			_storyService = storyService;
		}

		public string Get()
		{
			return _storyService.GetStory();
		}
	}
}