using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using S11_MVVM.Views;

namespace S11_MVVM
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new OperationsPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
