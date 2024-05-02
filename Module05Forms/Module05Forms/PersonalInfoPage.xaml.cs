using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Module05Forms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonalInfoPage : ContentPage
    {
        public PersonalInfoPage()
        {
            InitializeComponent();
        }
       
        void OnDateSelected(object sender, DataErrorsChangedEventArgs args)
        {
            DateTime birthdate = birthDatePicker.Date;
            DateTime today = DateTime.Today;
            int age = today.Year - birthdate.Year;

            ageComputation.Text = $"Age: {age}";
        }
        
        void OnSubmitClicked(object sender, EventArgs e)
        {
            DisplayAlert("Success", "You have submitted the form", "OK");
        }
    }
}