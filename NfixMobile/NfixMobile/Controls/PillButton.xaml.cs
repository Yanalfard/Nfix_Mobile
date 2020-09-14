using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Essentials;
using Xamarin.Forms.Xaml;

namespace NfixMobile.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PillButton : ContentView
    {
        public string IconSource
        {
            get => IconSource;
            //set => img.Source = ImageSource.FromResource(value);
            set
            {
                img.Source = value;
            }
        }

        /// <summary>
        /// Hex Only
        /// </summary>
        public string PillBackground
        {
            set
            {
                mainFrame.BackgroundColor = Color.FromHex(value.ToLower());
            }
        }

        public event EventHandler Clicked;

        public PillButton()
        {
            InitializeComponent();

            img.HeightRequest = this.HeightRequest;
            img.WidthRequest = this.WidthRequest;

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