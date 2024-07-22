using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace WeatherApp
{
	public partial class Form1 : Form
	{
		private WeatherService _weatherService;
		private DatabaseService _databaseService;

		public Form1()
		{
			InitializeComponent();
			_weatherService = new WeatherService();
			_databaseService = new DatabaseService();
		}

		private async void buttonSearch_Click(object sender, EventArgs e)
		{
			string cityName = textBoxCityName.Text;

			try
			{
				JObject weatherData = await _weatherService.FetchWeatherAsync(cityName);

				if (weatherData != null)
				{
					string result = $"{cityName}: {weatherData["main"]["temp"]}°C, {weatherData["weather"][0]["description"]}";
					labelResult.Text = result;
					labelError.Text = string.Empty;

					// Save to database
					_databaseService.InsertHistory(cityName);
				}
				else
				{
					labelResult.Text = string.Empty;
					labelError.Text = "City not found or no internet connection.";
				}
			}
			catch (Exception ex)
			{
				labelResult.Text = string.Empty;
				labelError.Text = $"Error: {ex.Message}";
			}
		}
	}
}
