using Microsoft.Extensions.Configuration;

namespace CinemaDB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .AddUserSecrets<Program>()
                .Build();

            var connStr = config.GetConnectionString("Default")!;
            using var db = new CinemaContext(connStr);
        }
    }
}
