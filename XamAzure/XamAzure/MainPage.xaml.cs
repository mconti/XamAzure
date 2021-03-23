using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamAzureApi;

namespace XamAzure
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            // https://github.com/mconti/FabLabApp/blob/master/FabLabApp1/FabLabApp1/MainPage.xaml.cs

            List<Studente> studenti = new List<Studente>();
            try
            {
                HttpClient client = new HttpClient();

                //string response = await client.GetStringAsync("https://flr.azurewebsites.net/studenti");
                //string response = await client.GetStringAsync("https://192.168.0.100:45455/studenti");
                string response = await client.GetStringAsync("https://xamazureapi.conveyor.cloud/studenti");
                studenti = JsonConvert.DeserializeObject<List<Studente>>(response);
            }
            catch (Exception err)
            {
                await DisplayAlert("Ocio!!", err.Message, "Ok");
            }
            lvStudenti.ItemsSource = studenti;
        }
    }
}
