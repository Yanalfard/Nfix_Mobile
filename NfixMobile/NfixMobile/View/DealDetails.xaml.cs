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
    public partial class DealDetails : ContentPage
    {
        public DealDetails()
        {
            InitializeComponent();
        }

        private void btnBack_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.RemovePage(this);
            }
            catch
            {
                Navigation.PopModalAsync();
            }
        }
    }
}