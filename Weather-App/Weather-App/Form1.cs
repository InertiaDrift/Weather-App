using Newtonsoft.Json.Linq;

namespace Weather_App
{
    public partial class Form1 : Form
    {
        private const string ApiKey = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void GetWeatherButton_Click(object sender, EventArgs e)
        {
            string city = CityTextBox.Text;
            string apiUrl = $"http://api.openweathermap.org/data/2.5/weather?q={city}&appid={ApiKey}";
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();

                        // Parse the JSON response
                        JObject data = JObject.Parse(json);

                        // Extract relevant information
                        double minTemperature = Convert.ToDouble(data["main"]["temp_min"]);
                        double maxTemperature = Convert.ToDouble(data["main"]["temp_max"]);
                        int humidity = Convert.ToInt32(data["main"]["humidity"]);

                        // Display the extracted information in TextBoxes or Labels
                        MinTemperatureLabel.Text = $"Minimum Temperature: {minTemperature}°C";
                        MaxTemperatureLabel.Text = $"Maximum Temperature: {maxTemperature}°C";
                        HumidityLabel.Text = $"Humidity: {humidity}%";
                    }
                    else
                    {
                        MessageBox.Show($"Error: {response.StatusCode} - {response.ReasonPhrase}", "Error");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception: {ex.Message}", "Error");
            }
        }
    }
}