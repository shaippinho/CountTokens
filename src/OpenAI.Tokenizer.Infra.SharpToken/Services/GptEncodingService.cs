using OpenAI.Tokenizer.Infra.SharpToken.Contracts;
using OpenAI.Tokenizer.Infra.SharpToken.ShapToken;

namespace OpenAI.Tokenizer.Infra.SharpToken.Services
{
    public class GptEncodingService : IGptEncodingService
    {
        public List<int> Encode(string input)
        {
            var encoding = GptEncoding.GetEncodingForModel("gpt-4");

           return encoding.Encode(input);
        }
    }
}
