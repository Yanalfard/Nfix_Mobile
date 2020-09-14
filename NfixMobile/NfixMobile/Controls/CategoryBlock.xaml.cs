using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NfixMobile.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CategoryBlock : ContentView
    {

        public event EventHandler Clicked;
     
        public CategoryBlock()
        {
            InitializeComponent();
            this.GestureRecognizers.Add(new TapGestureRecognizer
            {
                Command = new Command(Tapped)
            });

        }
        private void Tapped()
        {
            Clicked?.Invoke(this, EventArgs.Empty);
            Vibration.Vibrate(TimeSpan.FromMilliseconds(90));
        }

    }
}