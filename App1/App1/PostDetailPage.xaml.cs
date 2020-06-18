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
    public partial class PostDetailPage : ContentPage
    {
        Post _post;
        public PostDetailPage(Post post)
        {
            InitializeComponent();
            _post = post;
            ent_Exper.Text = _post.Experience;
        }

        private void btn_Update_Clicked(object sender, EventArgs e)
        {
            _post.Experience = ent_Exper.Text;
            using (SQLiteConnection connection = new SQLiteConnection(App.DbLocation))
            {
                connection.CreateTable<Post>();
                int rows = connection.Update(_post);
                if (rows > 0)
                {
                    DisplayAlert("Success", "Saved Successfully", "Ok");
                }
                else
                {
                    DisplayAlert("Failed", "Saved Failed", "Ok");
                }
            }
        }

        private void btn_Delete_Clicked(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(App.DbLocation))
            {
                connection.CreateTable<Post>();
                int rows = connection.Delete(_post);
                if (rows > 0)
                {
                    DisplayAlert("Success", "Saved Successfully", "Ok");
                }
                else
                {
                    DisplayAlert("Failed", "Saved Failed", "Ok");
                }
            }
        }
    }
}