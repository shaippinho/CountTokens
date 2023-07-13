using MediatR;
using OpenAI.Tokenizer.Domain.Dtos;

namespace OpenAI.Tokenizer.Domain.Domain
{
    public class CountCommand : Request, IRequest<Response>
    {
    }
}
