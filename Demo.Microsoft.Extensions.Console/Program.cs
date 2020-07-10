using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace Demo.Microsoft.Extensions.CLI
{
    internal class Program
    {
        private static async Task<int> Main()
        {
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("configuration.json")
                .Build();

            return await Task.Run(() => DefaultVerb(configuration));
        }

        /// <summary> Default verb. </summary>
        /// <remarks> This is a little action to use as a stub. </remarks>
        /// <param name="configuration"></param>
        /// <returns> An int. </returns>
        private static int DefaultVerb(IConfiguration configuration)
        {
            var currentForeground = Console.ForegroundColor;
            try
            {
                Console.WriteLine(configuration["Demo:Banner"]);
                Console.ForegroundColor = ConsoleColor.Gray;

                // this is how to process a json array of literals from the config file
                var args = configuration.GetSection("Demo:Arguments")
                    .GetChildren()
                    .Select(arg => arg.Value)
                    .ToArray();

                Console.WriteLine($"Verb: Default called with {string.Join(",", args)}...");
                return 0;
            }
            finally
            {
                Console.ForegroundColor = currentForeground;
            }
        }
    }
}
