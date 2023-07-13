namespace OpenAI.Tokenizer.Domain.Contracts
{
    public interface ITokenizerService
    {
        public Task<int> Count(string message, CancellationToken cancellationToken);
    }
}
