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

    public class Article
    {
        public string Nom { get; set; }
        public string Prix { get; set; }
        public string Description { get; set; }
    }

    public partial class ListPage : ContentPage
    {
        List<Article> articles;
        public ListPage()
        {
            InitializeComponent();
            articles = new List<Article>();

            articles.Add(new Article { Nom = "Lait", Prix = "5£" , Description = "lorem ipsum"});
            articles.Add(new Article { Nom = "Pains", Prix = "4£" , Description = "lorem or dele"});
            articles.Add(new Article { Nom = "Beignets", Prix = "7£", Description = "lorem ipsir dolor" });
            articles.Add(new Article { Nom = "Ovaltine", Prix = "1£" , Description = "denkansen algo fade"});

            maListePage.ItemsSource = articles;
            maListePage.ItemSelected += (sender, e) =>
            {
                if(maListePage.SelectedItem != null)
                {
                    Article item = maListePage.SelectedItem as Article;
                    DisplayAlert(item.Nom, item.Description, "OK");
                    maListePage.SelectedItem = null;
                }
            };
        }
    }
}