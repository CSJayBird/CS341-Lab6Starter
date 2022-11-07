namespace Lab6Starter;

/**
 * 
 * Name: Maximilian Patterson and Jonathan Renier-Wigg
 * Date: 11/1/2022
 * Description: Working with github and implementing ResetGame()
 * Bugs: N/A
 * Reflection: N/A
 * 
 */


public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		return builder.Build();
	}
}

