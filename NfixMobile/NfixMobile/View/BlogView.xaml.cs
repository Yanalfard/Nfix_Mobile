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
    public partial class BlogView : ContentPage
    {
        public string ThumbnailUrl
        {
            get => ThumbnailUrl;
            set
            {
                imgMain.Source = ImageSource.FromUri(new Uri(value));
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

        public string Body
        {
            get => Body;
            set => lblBody.Text = value;
        }


        public BlogView()
        {
            InitializeComponent();
        }

        public BlogView(string thumbnailUrl, string header, string description, string body)
        {
            ThumbnailUrl = thumbnailUrl;
            Header = header;
            Description = description;
            Body = body;
        }
    }
}