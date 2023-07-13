using OpenAI.Tokenizer.Domain.Contracts;

namespace OpenAI.Tokenizer.Domain.Services
{
    public class TokenizerService : ITokenizerService
    {
        public Task<int> Count(string message, CancellationToken cancellationToken)
        {
            return Task.FromResult(0);
        }
    }
}
