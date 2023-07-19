using Foundation;

namespace Notes;

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
	protected override MauiApp CreateMauiApp() => DV_MauiProgram.CreateMauiApp();
}
