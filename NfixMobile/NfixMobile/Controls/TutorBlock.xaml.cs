using NfixMobile.View;
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
    public partial class TutorBlock : ContentView
    {
        public string ImageUrl
        {
            get => ImageUrl;
            set
            {
                imgMain.Source = ImageSource.FromUri(new Uri(value));
            }
        }
        public string Name
        {
            get => Name;
            set
            {
                lblName.Text = value;
            }

        }
        public string Title
        {
            get => Title;
            set
            {
                lblTitle.Text = value;
            }
        }

        public event EventHandler Clicked;
       
        public TutorBlock()
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
            Navigation.PushModalAsync(new Profile());
        }

    }
}