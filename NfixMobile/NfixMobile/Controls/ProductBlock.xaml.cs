using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NfixMobile.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductBlock : ContentView
    {
        public ProductBlock()
        {
            InitializeComponent();
        }

        private void btnBuy_Clicked(object sender, EventArgs e)
        {

        }
    }
}