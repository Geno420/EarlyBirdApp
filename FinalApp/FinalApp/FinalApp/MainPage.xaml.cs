using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FinalApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void signInButton(object sender, EventArgs e) 
        {
            Navigation.PushAsync(new LoginPage());
        }

        private void LogInButton(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ButtonPage());
        }
    }
}
