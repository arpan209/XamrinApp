using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace TestApp1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new GreetPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts

            AppCenter.Start("ios=7e861a98-54b0-41ee-8ae0-06544db43235;" +
                  "uwp=6832a2b5-d0df-46f7-b3d4-25cf5497a935;" +
                  "android=20a86bcf-a2bb-4c82-bf7d-c1af82d740fa;",
                  typeof(Analytics), typeof(Crashes));
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
