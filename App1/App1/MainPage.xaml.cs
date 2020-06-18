using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelRecordApp;
using Xamarin.Forms;

namespace App1
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btn_Login_Clicked(object sender, EventArgs e)
        {
            bool IsEmailEmpty = string.IsNullOrWhiteSpace(ent_Email.Text);
            bool IsPasswordEmpty = string.IsNullOrWhiteSpace(ent_Password.Text);

            if(IsEmailEmpty || IsPasswordEmpty)
            {

            }
            else
            {
                Navigation.PushAsync(new HomePage());
            }
        }
    }
}
