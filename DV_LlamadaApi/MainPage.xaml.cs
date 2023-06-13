using DV_LlamadaApi.Models;
using Newtonsoft.Json;

namespace DV_LlamadaApi;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	private void LlamarApi(object sender, EventArgs e)
	{
		string lat = latitud.Text;
		string lon = longitud.Text;

		using (var client = new HttpClient())
		{
			var url = $"https://api.openweathermap.org/data/2.5/weather?lat=" + lat + "&lon=" + lon + "&appid=4af1e82a857895326699fc8c21455c9b";

			var response = client.GetAsync(url).Result;
			if (response.IsSuccessStatusCode)
			{
				string content = response.Content.ReadAsStringAsync().Result;

				var weatherData = JsonConvert.DeserializeObject<DV_Clima>(content);
				EstadoClima.Text = weatherData.weather[0].description;
				Pais.Text = weatherData.sys.country;
				Ciudad.Text = weatherData.name;
            }
		}
    }
}

