using Syncfusion.Maui.Picker;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayMemberPath
{
    public class PickerBehavior : Behavior<ContentPage>
    {
        private SfPicker picker;
        protected override void OnAttachedTo(ContentPage bindable)
        {
            base.OnAttachedTo(bindable);
            this.picker = bindable.FindByName<SfPicker>("picker");

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
        protected override void OnDetachingFrom(ContentPage bindable)
        {
            base.OnDetachingFrom(bindable);
            if (this.picker != null)
            {
                this.picker = null;
            }
        }
    }
}