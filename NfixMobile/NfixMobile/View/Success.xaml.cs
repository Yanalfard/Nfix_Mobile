using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NfixMobile.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Success : ContentPage
    {
        public Success()
        {
            InitializeComponent();
        }

        private void btnLater_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainTabbedPage());
            Navigation.RemovePage(this);
        }

        private void Button_Clicked(object sender, EventArgs e) => Navigation.PushAsync(new DealDetails());
    }
}