using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SayiTahmin.Views;

namespace SayiTahmin
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        Random random = new Random();
        int hedefSayi = 0;
        int kalanHak = 10;
        public MainPage()
        {
            InitializeComponent();
            hedefSayi = random.Next(0,100);
            int textSayi = random.Next(0,100);
            if (textSayi > hedefSayi)
                boxView.BackgroundColor = Color.CornflowerBlue;
            else
                boxView.BackgroundColor = Color.OrangeRed;
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            int sayi = int.Parse(txtSayi.Text);
            if (kalanHak == 0)
                await Navigation.PushAsync(new LoserPage());

            if (sayi == hedefSayi)
            {
                await Navigation.PushAsync(new WinnerPage());
            }
            if (sayi > hedefSayi)
            {
                boxView.BackgroundColor = Color.CornflowerBlue;
            }
            else
            {
                boxView.BackgroundColor = Color.OrangeRed;
            }
            kalanHak -= 1;
            lblHak.Text = kalanHak.ToString();
        }
    }
}
