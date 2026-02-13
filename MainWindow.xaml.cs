using System.Windows;
using Microsoft.Web.WebView2.Core;
using System.IO;

namespace WhatsAppLite
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Title = "WhatsApp Lite";
            this.ShowInTaskbar = true;
            Init();
        }

        async void Init()
        {
            string userData = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "WhatsAppLiteProfile");

            var env = await CoreWebView2Environment.CreateAsync(null, userData);
            await Browser.EnsureCoreWebView2Async(env);

            Browser.CoreWebView2.Settings.AreDevToolsEnabled = false;
            Browser.CoreWebView2.Settings.AreDefaultContextMenusEnabled = false;
            Browser.CoreWebView2.Settings.IsPasswordAutosaveEnabled = false;
            Browser.CoreWebView2.Settings.IsGeneralAutofillEnabled = false;

            // Memory optimization: dark scheme + prevent background throttling
            Browser.CoreWebView2.Profile.PreferredColorScheme = CoreWebView2PreferredColorScheme.Dark;
            await Browser.CoreWebView2.CallDevToolsProtocolMethodAsync(
                "Emulation.setIdleOverride",
                "{\"isUserActive\":true,\"isScreenUnlocked\":true}");


            Browser.Source = new Uri("https://web.whatsapp.com");
        }



        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void MaximizeButton_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Maximized)
                WindowState = WindowState.Normal;
            else
                WindowState = WindowState.Maximized;
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
