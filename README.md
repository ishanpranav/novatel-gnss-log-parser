# GNSS Log Parser
This is a cross-platform library and application for parsing NovAtel GNSS command output message logs. The project includes a standalone class library, a cross-platform command-line tool, and a Windows GUI application.

This project is a [fork of the parser designed by Ishan Pranav](https://github.com/BeckmanAvionics/gps-output-parser) for [Arnold O. Beckman High School\'s Avionics Team](https://github.com/BeckmanAvionics), part of the Irvine CubeSat STEM Program. The software is designed for compatibility with NovAtel\'s OEM6 and OEM7 products.
## Screenshots
![Screenshot of the GNSS Log Visualizer application.](docs/images/Capture.png "GNSS Log Visualizer Application")
## Command-line interface
Provide a path to a log file:
```
IrvineCubeSat.GpsParser.Console.exe "Logs\Log1.gps"
```
Or a string:
```
IrvineCubeSat.GpsParser.Console.exe "#BESTPOSA,COM1,0,90.5,FINESTEERING,1949,403742.000,02000000,b1f6,32768;SOL_COMPUTED,SINGLE,51.11636937989,-114.03825348307,1064.533,-16.9000,WGS84,1.3610,1.0236,2.4745,UNKNOWN,0.000,0.000,19,19,19,19,00,06,00,33*6e08fa22"
```
The command-line interface supports all .NET-compatible operating systems.
## API Documentation
The example below uses an ASCII parser to read messages from a string. Binary and Abbreviated ASCII messages are not supported.
```csharp
string value = @"#
BESTPOSA,COM1,0,90.5,FINESTEERING,1949,403742.000,02000000,b1f6,32768;
SOL_COMPUTED,SINGLE,51.11636937989,-114.03825348307,1064.533,-16.9000,
WGS84,1.3610,1.0236,2.4745,"""",0.000,0.000,19,19,19,19,00,06,00,33
*6e08fa22
";
AsciiGpsParser parser = new AsciiGpsParser();

await foreach (AsciiMessage message in parser.ParseAsync(value))
{
    // Process the message
}
```
### Built-in logs
Each [GNSS log](https://docs.novatel.com/OEM7/Content/Logs/Core_Logs.htm) needs a dedicated model in the parser. The following built-in logs are automatically registered.
| Command | Model Class |
| ------- | ----------- |
| [`BESTPOS`](https://docs.novatel.com/OEM7/Content/Logs/BESTPOS.htm) | `BestPositionCommand` |
| [`RXSTATUS`](https://docs.novatel.com/OEM7/Content/Logs/RXSTATUS.htm) | `ReceiverStatusCommand` |

### Custom logs
To add support for the GNSS [`TIME`](https://docs.novatel.com/OEM7/Content/Logs/TIME.htm) command, create a new class annotated with the `CommandAttribute`. The parser uses [CsvHelper](https://github.com/JoshClose/CsvHelper) to map strings to objects.
```csharp
[Command("TIME")] // Command name
public class TimeCommand
{
    [Index(0)] // Field position
    public GnssClockModelStatus Status { get; } 
}

public enum GnssClockModelStatus
{
    [Name("VALID")] // ASCII message representation
    Valid = 0, // Binary message representation

    [Name("CONVERGING")]
    Converging = 1,

    [Name("ITERATING")]
    Iterating = 2,

    [Name("INVALID")]
    Invalid = 3
}
```
Then, add the class to the parser:

```csharp
parser.TryRegister<TimeCommand>();
```
## License
This repository is licensed with the [MIT](LICENSE.txt) license.
## Attribution
This software uses third-party libraries or other resources that may be
distributed under licenses different than the software. Please see the third-party notices included [here](THIRD-PARTY-NOTICES.txt).
## References
- [NovAtel OEM7 GNSS Logs](https://docs.novatel.com/OEM7/Content/Logs/Core_Logs.htm)
- [NovAtel OEM6 Family Firmware Reference Manual](https://hexagondownloads.blob.core.windows.net/public/Novatel/assets/Documents/Manuals/om-20000129/om-20000129.pdf)
- [ASCII Messages](https://docs.novatel.com/OEM7/Content/Messages/ASCII.htm)
- [32-bit CRC](https://docs.novatel.com/OEM7/Content/Messages/32_Bit_CRC.htm)
