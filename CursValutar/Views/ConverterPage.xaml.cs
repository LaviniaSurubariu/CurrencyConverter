using System.Net;

namespace CursValutar.Views;

public partial class ConverterPage : ContentPage
{
	List<string> currenciesList = new List<string>();

    public ConverterPage()
	{
		InitializeComponent();
		currenciesList.Add("EUR");
		currenciesList.Add("RON");
		PickerDestination.ItemsSource = currenciesList;
		PickerSource.ItemsSource = currenciesList;
		PickerSource.SelectedIndex = 0;

    }

    private void Button_Clicked(object sender, EventArgs e) {
		
    }
}