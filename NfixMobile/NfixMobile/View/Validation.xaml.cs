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
    public partial class Validation : ContentPage
    {
        public Validation()
        {
            InitializeComponent();
        }

        private void btnBack_Clicked(object sender, EventArgs e)
        {
            Navigation.RemovePage(this);
        }

        private void btnValidate_Clicked(object sender, EventArgs e)
        {
            Success page = new Success();
            Navigation.PushAsync(page);
            Navigation.RemovePage(this);
        }
    }
}