using App1;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelRecordApp.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TravelRecordApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HistoryPage : ContentPage
    {
        public HistoryPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            using (SQLiteConnection connection = new SQLiteConnection(App.DbLocation))
            {
                connection.CreateTable<Post>();
                var posts = connection.Table<Post>().ToList();
                PostListView.ItemsSource = posts;
            }
            

        }

        private void PostListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedpost = PostListView.SelectedItem as Post;
            if(selectedpost != null)
            {
                Navigation.PushAsync(new PostDetailPage(selectedpost));
            }
        }


    }
}