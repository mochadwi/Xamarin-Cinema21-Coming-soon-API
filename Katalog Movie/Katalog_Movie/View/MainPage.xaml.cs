using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Katalog_Movie.ViewModel;
using Katalog_Movie.Model;
using Katalog_Movie.View;

namespace Katalog_Movie.View
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            VMMovieList vmmovie = new VMMovieList();
            listView.BindingContext = vmmovie;

            listView.ItemTapped += async (sender, e) => {
                //if (e.SelectedItem == null) return; 
                Movie movie = (Movie)e.Item;
                await Task.Yield();
                //await Navigation.PushAsync(new DetailMovie(movie));

                var detailMovie= new DetailMovie();
                detailMovie.BindingContext = movie;
                await Navigation.PushAsync(detailMovie);
                ((ListView)sender).SelectedItem = null;
            };
        }
    }
}
