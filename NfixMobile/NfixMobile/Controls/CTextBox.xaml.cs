using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NfixMobile.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CTextBox : ContentView
    {
        public string Text
        {
            get
            {
                return TxtMain.Text;
            }
            set
            {
                TxtMain.Text = value;
            }
        }

        public string Placeholder
        {
            get
            {
                return TxtMain.Placeholder;
            }
            set
            {
                TxtMain.Placeholder = value;
            }
        }

        public string IsPassword
        {
            set
            {
                TxtMain.IsPassword = (value.ToLower() == "true") ? true : false;
            }
        }

        public string Keyboard
        {
            set
            {
                switch (value.ToLower())
                {
                    case "text":
                        TxtMain.Keyboard = Xamarin.Forms.Keyboard.Text;
                        break;
                    case "tel":
                        TxtMain.Keyboard = Xamarin.Forms.Keyboard.Telephone;
                        break;
                    case "chat":
                        TxtMain.Keyboard = Xamarin.Forms.Keyboard.Chat;
                        break;

                    default:
                        break;
                }
            }
        }

        public CTextBox()
        {
            InitializeComponent();
        }

        private void TxtMain_Focused(object sender, FocusEventArgs e)
        {
            boxStripe.BackgroundColor = (Color)Application.Current.Resources["Primary"];
        }

        private void TxtMain_Unfocused(object sender, FocusEventArgs e)
        {
            boxStripe.BackgroundColor = Color.FromHex("#303030");
        }
    }
}