using Bunit;
using Microsoft.Extensions.DependencyInjection;
using TravelApp.Pages.In_App;
using TravelApp.TravelAppData;

namespace TestTravelApp
{
	[Collection("TravelApp")]
	public class TestArticles
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbCardModule),
				typeof(IgbButtonModule),
				typeof(IgbRippleModule),
				typeof(IgbIconButtonModule));
			ctx.Services.AddScoped<ITravelAppDataService>(sp => new MockTravelAppDataService());
			var componentUnderTest = ctx.RenderComponent<Articles>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
