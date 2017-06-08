using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonkeyHubApp.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MonkeyHubApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Teste : ContentPage
    {
        readonly AzureService azureService = new AzureService();
        public Teste()
        {
            InitializeComponent();

            LoginButton.Clicked += async (sender, args) =>
            {
                var user = await azureService.LoginAsync();
                InfoLabel.Text = (user != null) ? $"Bem vindo: {user.UserId}" : "Falaha no Login, tente novamente!";
            };
        }
    }
}
