using OpenAI.Tokenizer.Domain.Contracts;
using OpenAI.Tokenizer.Domain.Domain;
using OpenAI.Tokenizer.Domain.Services;
using OpenAI.Tokenizer.Infra.SharpToken.Contracts;
using OpenAI.Tokenizer.Infra.SharpToken.Services;
using System.Reflection;

namespace OpenAI.Tokenizer.API
{
    public static class Bootstrapper
    {
        public static void AddInjection(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<ITokenizerService, TokenizerService>();
            services.AddScoped<IGptEncodingService, GptEncodingService>();

            //services.AddSingleton(configuration.GetSection(KeyVaultSettings.SessionName).Get<KeyVaultSettings>());
        }

        public static void AddMediator(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(CountCommand).GetTypeInfo().Assembly));
        }
    }
}
