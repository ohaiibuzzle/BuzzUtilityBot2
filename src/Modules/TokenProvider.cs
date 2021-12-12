using Microsoft.Extensions.Configuration;

namespace BuzzleBot
{
    public class TokenProvider
    {
        private static string configLocation = "config.json";
        private static IConfiguration? _config;
        private static TokenProvider instance = new TokenProvider();

        private TokenProvider()
        {
            _config = new ConfigurationBuilder()
                .AddJsonFile(configLocation, optional: false, reloadOnChange: true)
                .Build();
            System.Console.WriteLine(_config.GetSection("token").Value);
        }

        public static TokenProvider Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TokenProvider();
                }
                return instance;
            }
        }

        public string GetToken(string tokenName)
        {
            Console.WriteLine($"Getting token {tokenName}");
            return _config[$"tokens:{tokenName}"];
        }
    }
}