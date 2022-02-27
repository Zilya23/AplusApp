using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AplusApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AuthorizPage : ContentPage
    {
        public AuthorizPage()
        {
            InitializeComponent();
        }

        private async void btn_Registr_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pages.RegPage());
        }

        private async void btn_Entery_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pages.ProjectsPage());
        }
    }
}