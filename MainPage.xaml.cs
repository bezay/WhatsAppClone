namespace WhatsAppClone
{
    public partial class MainPage : ContentPage
    {

        public MainPage(ChatsViewModel chvm)
        {
            InitializeComponent();

            PageContent.Content = new ChatsView(chvm);
        }

       
    }
}
