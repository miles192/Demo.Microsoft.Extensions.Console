using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Demo.Microsoft.Extensions.CLI
{
    internal class Program
    {
        private static async Task<int> Main(string[] args)
        {
            return await Task.Run(() => DefaultVerb(args));

        }

        /// <summary> Default verb. </summary>
        /// <remarks> This is a little action to use as a stub. </remarks>
        /// <param name="args"> The arguments. </param>
        /// <returns> An int. </returns>
        private static int DefaultVerb(IEnumerable<string> args)
        {
            var currentForeground = Console.ForegroundColor;
            try
            {
                Console.WriteLine(@"Default: Hello world!");
                Console.ForegroundColor = ConsoleColor.Gray;
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
