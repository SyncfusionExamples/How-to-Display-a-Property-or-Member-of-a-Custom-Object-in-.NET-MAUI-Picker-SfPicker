using Syncfusion.Maui.Picker;
using System.Collections.ObjectModel;

namespace DisplayMemberPath;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
        ObservableCollection<CountryInfo> countryDetails = new ObservableCollection<CountryInfo>
        {
            new CountryInfo { Sport = "Baseball", Country = "USA" },
            new CountryInfo { Sport = "Pato", Country = "Argentina" },
            new CountryInfo { Sport = "Golf", Country = "Scotland" },
            new CountryInfo { Sport = "Oil wrestling", Country = "Turkey" },
            new CountryInfo { Sport = "Skiing", Country = "Norway" },
            new CountryInfo { Sport = "Cricket", Country = "England" },
            new CountryInfo { Sport = "Football", Country = "France" },
            new CountryInfo { Sport = "Badminton", Country = "Indonesia" },
        };
        PickerColumn pickerColumn = new PickerColumn()
        {
            DisplayMemberPath = "Sport",
            ItemsSource = countryDetails,
            SelectedIndex = 3,
        };
        this.picker.Columns.Add(pickerColumn);
    }
}