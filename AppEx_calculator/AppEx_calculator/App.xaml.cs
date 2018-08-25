using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace AppEx_calculator
{
    public partial class App : Application
    {
        public App()
        {

            // Initialize Live Reload.



            InitializeComponent();

            //MainPage  = new pLogin();
            MainPage = new NavigationPage( new pLogin());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
