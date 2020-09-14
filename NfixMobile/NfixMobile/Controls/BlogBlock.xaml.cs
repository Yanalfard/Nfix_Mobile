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
    public partial class BlogBlock : ContentView
    {

        public string ThumbnailUrl
        {
            get => ThumbnailUrl;
            set
            {
                imgThumbnail.Source = ImageSource.FromUri(new Uri(value));
            }
        }

        public string Header
        {
            get => Header;
            set => lblHeader.Text = value;
        }

        public string Description
        {
            get => Description;
            set => lblDescription.Text = value;
        }

        public string Body { get; set; }

        public BlogBlock()
        {
            InitializeComponent();
        }

        public BlogBlock(string thumbnailUrl, string header, string description, string body)
        {
            ThumbnailUrl = thumbnailUrl;
            Header = header;
            Description = description;
            Body = body;
        }

        private void btnMore_Clicked(object sender, EventArgs e) => Navigation.PushAsync(new BlogView());
    }
}