using Global.VideoPlayer;
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
    public partial class Video : ContentPage
    {
        public Video()
        {
            InitializeComponent();
        }

        public Video(string VideoUrl)
        {
            if (VideoUrl == null)
                throw new Exception("The 'VideoUrl' property in the Video page is null");

            InitializeComponent();
            vidMain.Source = VideoSource.FromUri(VideoUrl);
        }
    }
}