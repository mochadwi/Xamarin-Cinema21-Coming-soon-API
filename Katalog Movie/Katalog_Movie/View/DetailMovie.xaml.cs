using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Katalog_Movie.Model;

namespace Katalog_Movie.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailMovie : ContentPage
    {
        public DetailMovie()
        {
            InitializeComponent();
            //this.BindingContext = item;
            btnBack.Clicked += async (sender, e) =>
            {
                await Navigation.PopAsync(true);
            };
        }
    }
}
