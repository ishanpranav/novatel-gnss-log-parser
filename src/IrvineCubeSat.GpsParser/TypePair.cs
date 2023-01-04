// TypePair.cs
// Copyright (c) 2019-2023 Ishan Pranav. All rights reserved.
// Licensed under the MIT License.

using System;

namespace IrvineCubeSat.GpsParser
{
    internal readonly struct TypePair
    {
        public Type CommandType { get; }
        public Type ParserType { get; }

        public TypePair(Type commandType, Type parserType)
        {
            CommandType = commandType;
            ParserType = parserType;
        }
    }
}
