using Microsoft.AspNetCore.Mvc;

namespace SagasAndLegends.Web.Controllers
{
	[Produces("application/json")]
	[Route("api/Stories")]
	public class StoriesController : Controller
	{
		public string Get()
		{
			return "Tijdens de heksensabbat in de Walpurgisnacht werd een lichtende glans om de grote steen zichtbaar, maar in andere nachten gebeurde dit soms ook. Lichtgevende gestaltes of 'Witte Wieven' verzamelden zich dan om te gaan feesten. Passanten die dit verschijnsel waar namen kregen het gevoel van een loodzware last die hen benauwde. Men leek zich haast niet meer te kunnen voort bewegen. Pas wanneer men op een bepaalde afstand verwijderd was van de steen viel de druk weg. Precies om twaalf uur in de Walpurgisnacht hielden de Witte Wieven gezamenlijk een maaltijd waarbij de offersteen als eettafel werd gebruikt. Zij dronken bier uit de diepe groeven van de kei waarna een wilde dans volgde. Daarna verdwenen de Witte Wieven, op hun bezemstokken vliegend, in de lucht";
		}
	}
}