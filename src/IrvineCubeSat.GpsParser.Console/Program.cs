// Program.cs
// Copyright (c) 2019-2022 Ishan Pranav. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace IrvineCubeSat.GpsParser.Console;

internal static class Program
{
    private static async Task Main(string[] args)
    {
        string value = args[0];

        if (File.Exists(value))
        {
            value = await File.ReadAllTextAsync(value);
        }

        List<AsciiMessage> messages = new List<AsciiMessage>();

        await foreach (AsciiMessage message in new AsciiGpsParser().ParseAsync(value))
        {
            messages.Add(message);
        }

        await System.Console.Out.WriteLineAsync(JsonSerializer.Serialize(messages, new JsonSerializerOptions()
        {
            WriteIndented = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        }));
    }
}
