using OpenAI.Tokenizer.Domain.Contracts;
using OpenAI.Tokenizer.Infra.SharpToken.Contracts;

namespace OpenAI.Tokenizer.Domain.Services
{
    public class TokenizerService : ITokenizerService
    {
        readonly IGptEncodingService _gptEncodingService;


        public TokenizerService(IGptEncodingService gptEncodingService)
        {
            _gptEncodingService = gptEncodingService;
        }

        public Task<int> Count(string message, CancellationToken cancellationToken)
        {
            var result = _gptEncodingService.Encode(message);
            return Task.FromResult(result.Count);
        }
    }
}
