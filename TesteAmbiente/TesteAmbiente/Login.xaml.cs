using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TesteAmbiente
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
            btnEntrar.Clicked += BtnEntrar_Clicked;
        }

        protected override void OnDisappearing()
        {
            btnEntrar.Clicked -= BtnEntrar_Clicked;
        }

        private void BtnEntrar_Clicked(object sender, EventArgs e)
        {
            var masterDetail = new MasterDetailPage
            {
                Title = "Teste de Ambiente",
                Master = new Master(),
                Detail = new NavigationPage(new Detail())
            };

            App.Current.MainPage = masterDetail;
        }
    }
}