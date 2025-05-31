using OpenAI;
using OpenAI.Chat;
using System.ClientModel;
using System.Text.Json;
using System.Threading.Tasks;
using OpenAI.Models;

namespace proyecto_2
{
    internal class OpenAIServiceWrapper
    {
        static async Task Main(string[] args)
        { 
            string apiKey = Environment.GetEnvironmentVariable("OPENAI_API_KEY");
            if (string.IsNullOrEmpty(apiKey))
            {
                MessageBox.Show("Error: configura OPENAI_API_KEY antes de ejecutar");
                return;
            }

            ChatClient client = new ChatClient(
                model: "gpt-3.5-turbo",
                apiKey: apiKey
                );

        }
    }
}
