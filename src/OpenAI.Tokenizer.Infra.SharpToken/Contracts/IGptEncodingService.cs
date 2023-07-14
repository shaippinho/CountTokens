namespace OpenAI.Tokenizer.Infra.SharpToken.Contracts
{
    public interface IGptEncodingService
    {
        List<int> Encode(string input);
    }
}
