// AsciiMessage.cs
// Copyright (c) 2019-2022 Ishan Pranav. All rights reserved.
// Licensed under the MIT License.

namespace IrvineCubeSat.GpsParser
{
    /// <summary>
    /// Represents an ASCII GNSS message.
    /// </summary>
    public class AsciiMessage
    {
        /// <summary>
        /// Gets the message header.
        /// </summary>
        /// <value>The message header.</value>
        public AsciiMessageHeader Header { get; }

        /// <summary>
        /// Gets the message command body.
        /// </summary>
        /// <value>The message command body.</value>
        public object Command { get; }

        /// <summary>
        /// Gets the checksum included in the message footer.
        /// </summary>
        /// <value>The checksum included in the message footer.</value>
        public uint Checksum { get; }

        /// <summary>
        /// Gets the expected checksum computed by the parser.
        /// </summary>
        /// <value>The expected message checksum.</value>
        public uint ExpectedChecksum { get; }

        /// <summary>
        /// Gets the raw data of the message.
        /// </summary>
        /// <value>The raw message data.</value>
        public string Raw { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AsciiMessage"/> class.
        /// </summary>
        /// <param name="raw">The raw data.</param>
        /// <param name="header">The message header.</param>
        /// <param name="command">The message command body.</param>
        /// <param name="checksum">The checksum included in the message footer.</param>
        public AsciiMessage(string raw, AsciiMessageHeader header, object command, uint checksum)
        {
            Raw = raw;
            Header = header;
            Command = command;
            Checksum = checksum;
            ExpectedChecksum = Crc32.CalculateChecksum(raw);
        }

        public override string ToString()
        {
            return $"#{Raw}*{Checksum:x8}";
        }
    }
}
