using Android.Widget;
using Microsoft.Extensions.DependencyInjection;

namespace WhatsAppClone
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            Microsoft.Maui.Handlers.SearchBarHandler.Mapper.AppendToMapping(nameof(SearchBar), (handler, view) =>
            {

#if ANDROID
                var linearLayout = handler.PlatformView.GetChildAt(2) as LinearLayout;
                linearLayout = linearLayout?.GetChildAt(0) as LinearLayout;
                linearLayout = linearLayout?.GetChildAt(1) as LinearLayout;
                if (linearLayout != null) { 
                    linearLayout.Background = null;
                    linearLayout.SetBackgroundColor(Android.Graphics.Color.Transparent);
                }

#endif
            });
        }
        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}