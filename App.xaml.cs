using Microsoft.Extensions.Configuration;
using System.Configuration;
using System.Data;
using System.Windows;

namespace GVA_Launcher_Private
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override async void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var config = new ConfigurationBuilder()
                .AddUserSecrets<App>()
                .Build();

            await Services.SupabaseService.Initialize(config["Supabase:Url"], config["Supabase:Key"]);
        }
    }

}
