namespace WhatsAppClone.Views;

public partial class ChatsView : ContentView
{
	public ChatsView(ChatsViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
    }
}