using MediatR;
using OpenAI.Tokenizer.Domain.Contracts;
using OpenAI.Tokenizer.Domain.Dtos;

namespace OpenAI.Tokenizer.Domain.Domain
{
    public class CountCommandHandler : IRequestHandler<CountCommand, Response>
    {
        private readonly ITokenizerService _tokenizerService;
        public CountCommandHandler(ITokenizerService tokenizerService)
        {
            _tokenizerService = tokenizerService;
        }

        public async Task<Response> Handle(CountCommand request, CancellationToken cancellationToken)
        {
            var result = await _tokenizerService.Count(request.Message, cancellationToken);

            return await Task.FromResult(new Response { Message = result.ToString() });
        }
    }
}
