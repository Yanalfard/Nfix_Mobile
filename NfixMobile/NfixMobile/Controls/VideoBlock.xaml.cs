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
    public partial class VideoBlock : ContentView
    {
        public string ThumbnailUrl
        {
            get => ThumbnailUrl;
            set
            {
                imgThumbnail.Source = ImageSource.FromUri(new Uri(value));
            }

        }

        public string VideoUrl { get; set; }

        public int ViewCount
        {
            get => ViewCount;
            set
            {
                lblViewCount.Text = value.ToString();
            }
        }

        public int Title
        {
            get => Title;
            set
            {
                lblTitle.Text = value.ToString();
            }
        }


        public event EventHandler Clicked;

        public VideoBlock()
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
            if (VideoUrl == null)
                throw new Exception("The 'VideoUrl' property in the VideoBlock is null");

            Navigation.PushModalAsync(new NfixMobile.View.Video(VideoUrl));
        }
    }
}