/*
 The MIT License (MIT)

 Copyright (c) 2019 NovAtel Inc.

 Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without r
estriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom
 the Software is furnished to do so, subject to the following conditions:

 The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

 THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE
 AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, A
 RISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

using System.Text;

namespace IrvineCubeSat.GpsParser
{
    /// <summary>
    /// Provides methods for calculating the 32-bit cyclical redundancy check (CRC-32) checksum.
    /// </summary>
    /// <remarks>The implementation of this class is based on <see href="https://github.com/novatel/checksum/blob/master/C/crcAscii/crcAscii.c">this</see> sample code from NovAtel licensed under the MIT License.</remarks>
    /// <seealso href="https://github.com/novatel/checksum/blob/master/C/crcAscii/crcAscii.c">32-bit CRC</seealso>
    public static class Crc32
    {
        /// <summary>
        /// Calculates the CRC-32 checksum for an ASCII string.
        /// </summary>
        /// <param name="buffer">The string value.</param>
        /// <returns>The checksum.</returns>
        public static uint CalculateChecksum(string value)
        {
            byte[] buffer = Encoding.ASCII.GetBytes(value);

            return CalculateChecksum(buffer, index: 0, buffer.Length);
        }

        /// <summary>
        /// Calculates the CRC-32 checksum for a sequence of bytes.
        /// </summary>
        /// <param name="buffer">The byte array containing the sequence of bytes included in the checksum.</param>
        /// <param name="index">The index of the first byte to include.</param>
        /// <param name="count">The number of bytes to include.</param>
        /// <returns>The checksum.</returns>
        public static uint CalculateChecksum(byte[] buffer, int index, int count)
        {
            uint result = 0;

            for (int i = index; i < count; i++)
            {
                uint crc = (result ^ buffer[i]) & 0xff;

                for (int j = 0; j < 8; j++)
                {
                    if ((crc & 1) > 0)
                    {
                        crc = (crc >> 1) ^ 0xedb88320;
                    }
                    else
                    {
                        crc >>= 1;
                    }
                }

                result = ((result >> 8) & 0x00ffffff) ^ crc;
            }

            return result;
        }
    }
}
