using Bunit;
using Microsoft.Extensions.DependencyInjection;
using TravelApp.Pages.In_App;
using TravelApp.TravelAppData;

namespace TestTravelApp
{
	[Collection("TravelApp")]
	public class TestDashboard
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbButtonModule),
				typeof(IgbRippleModule),
				typeof(IgbCardModule),
				typeof(IgbIconButtonModule),
				typeof(IgbListModule));
			ctx.Services.AddScoped<ITravelAppDataService>(sp => new MockTravelAppDataService());
			var componentUnderTest = ctx.RenderComponent<Dashboard>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
