using System.Threading.Tasks;

namespace BuzzleBot
{
    class Program
    {
        public static Task Main(string[] args)
            => Startup.RunAsync(args);
    }
}