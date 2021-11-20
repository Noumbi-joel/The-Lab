using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace lelab.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private void Navigation_Compteur(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new CountPage());
        }

        private void Btn_Tabs(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new TabsPage());
        }

        private void Btn_List(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new ListPage());
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}