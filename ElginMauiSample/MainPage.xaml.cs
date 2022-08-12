//using static Android.Media.Audiofx.DynamicsProcessing;

namespace ElginMauiSample;

public partial class MainPage : ContentPage
{
    //int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }
    async void OpenE1BridgePage(object sender, EventArgs e)
    {
        //await Navigation.PushAsync(new E1BridgePage());
    }

    async void OpenNfcePage(object sender, EventArgs e)
    {
        //await Navigation.PushAsync(new NFCEPage());
    }

    async void OpenPrinterPage(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Pages.PrinterPage("interna"));
    }

    async void OpenBarCodePage(object sender, EventArgs e)
    {
        //await Navigation.PushAsync(new BarCodesPage());
    }
    async void OpenBalancaPage(object sender, EventArgs e)
    {
        //await Navigation.PushAsync(new BalancaPage());
    }

    async void OpenTefPage(object sender, EventArgs e)
    {
        //await Navigation.PushAsync(new TefPage());
    }

    async void OpenCarteiraDigitalPage(object sender, EventArgs e)
    {
        //await Navigation.PushAsync(new CarteiraDigitalPage());
    }

    async void OpenSatPage(object sender, EventArgs e)
    {
        //await Navigation.PushAsync(new SatPage());
    }
}

