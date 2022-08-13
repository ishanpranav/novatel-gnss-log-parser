// Program.cs
// Copyright (c) 2019-2022 Ishan Pranav. All rights reserved.
// Licensed under the MIT License.

using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace IrvineCubeSat.GpsParser.Console
{
    internal static class Program
    {
        private static async Task Main(string[] args)
        {
            string value = args[0];

            if (File.Exists(value))
            {
                value = await File.ReadAllTextAsync(value);
            }

            await System.Console.Out.WriteLineAsync(JsonSerializer.Serialize(new AsciiGpsParser().ParseAsync(value), new JsonSerializerOptions()
            {
                WriteIndented = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            }));
        }
    }
}
