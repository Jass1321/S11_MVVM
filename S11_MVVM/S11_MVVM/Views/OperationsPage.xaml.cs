using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace S11_MVVM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OperationsPage : ContentPage
    {
        public OperationsPage()
        {
            InitializeComponent();
            this.BindingContext = new ViewModels.OperationsViewModel();
        }
    }
}