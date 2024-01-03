using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http.Headers;
using System.Text;

namespace Mydemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnCreateAssistant_Click(object sender, EventArgs e)
        {
            // Call the api to craete the assistant

            var assistantData = new
            {
                instructions = "You are created for test assistant feature. When some one ask you 1+1=? you need answer 3.",
                name = this.txtAssistantName.Text,
                model = "gpt-4-1106-preview"
            };

            // Do http request.
            var _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "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");
            _httpClient.DefaultRequestHeaders.Add("OpenAI-Beta", "assistants=v1");
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var content = new StringContent(JsonConvert.SerializeObject(assistantData), Encoding.UTF8, "application/json");


            var response = await _httpClient.PostAsync("https://api.openai.com/v1/assistants", content);

            var responseContent = await response.Content.ReadAsStringAsync();
            JObject result = (JObject)JsonConvert.DeserializeObject(responseContent);
            this.lblAssistantId.Text = result["id"].ToString();


        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            // API call to create the thread

            var requestData = new
            {
                assistant_id = this.lblAssistantId.Text
            };


            var _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "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");
            _httpClient.DefaultRequestHeaders.Add("OpenAI-Beta", "assistants=v1");
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var content = new StringContent(JsonConvert.SerializeObject(requestData), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("https://api.openai.com/v1/threads", null);
            var responseContent = await response.Content.ReadAsStringAsync();
            JObject result = (JObject)JsonConvert.DeserializeObject(responseContent);

            this.lblTheadId.Text = result["id"].ToString();

        }

        private async void btnAsk_Click(object sender, EventArgs e)
        {

            var messageData = new
            {
                role = "user",
                content = this.txtQuestion.Text
            };

            var _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "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");
            _httpClient.DefaultRequestHeaders.Add("OpenAI-Beta", "assistants=v1");
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var content = new StringContent(JsonConvert.SerializeObject(messageData), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("https://api.openai.com/v1/threads", null);
            var responseContent = await response.Content.ReadAsStringAsync();
            JObject result = (JObject)JsonConvert.DeserializeObject(responseContent);

            var runData = new
            {
                assistant_id = this.lblAssistantId.Text
            };

            content = new StringContent(JsonConvert.SerializeObject(runData), Encoding.UTF8, "application/json");
            response = await _httpClient.PostAsync($"https://api.openai.com/v1/threads/{lblTheadId.Text}/runs", content);
            responseContent = await response.Content.ReadAsStringAsync();
            result = (JObject)JsonConvert.DeserializeObject(responseContent);
            this.lblRunId.Text = result["id"].ToString();

        }

        private async void btnCheckStatus_Click(object sender, EventArgs e)
        {
            var _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "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");
            _httpClient.DefaultRequestHeaders.Add("OpenAI-Beta", "assistants=v1");
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


            var response = await _httpClient.GetAsync($"https://api.openai.com/v1/threads/{lblTheadId.Text}/runs/{lblRunId.Text}");
            var responseContent = await response.Content.ReadAsStringAsync();
            JObject result = (JObject)JsonConvert.DeserializeObject(responseContent);
            MessageBox.Show(result.ToString());
        }

        private async void btnGetResult_Click(object sender, EventArgs e)
        {
            var _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "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");
            _httpClient.DefaultRequestHeaders.Add("OpenAI-Beta", "assistants=v1");
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var response = await _httpClient.GetAsync($"https://api.openai.com/v1/threads/{lblTheadId.Text}/messages");
            var responseContent = await response.Content.ReadAsStringAsync();
            JObject result = (JObject)JsonConvert.DeserializeObject(responseContent);
            MessageBox.Show(result.ToString());
        }
    }
}
