using System.Globalization;

namespace iOSReleaseLocalizationIssue;

public partial class MainPage : ContentPage
{
	System.Resources.ResourceManager resourceManager = new System.Resources.ResourceManager("iOSReleaseLocalizationIssue.Resources.MyLocalization", typeof(MainPage).Assembly);
	
	public MainPage()
	{
		InitializeComponent();
	}

	private void OnSetEngCulture(object sender, EventArgs e)
	{
		Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
        CultureStringLabel.Text = resourceManager.GetString("MyString");
	}
	private void OnSetDeCulture(object sender, EventArgs e)
	{
		Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture = new CultureInfo("de");
        CultureStringLabel.Text = resourceManager.GetString("MyString");
    }
    private void OnSetEsCulture(object sender, EventArgs e)
    {
        Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture = new CultureInfo("es");
        CultureStringLabel.Text = resourceManager.GetString("MyString");
    }
}

