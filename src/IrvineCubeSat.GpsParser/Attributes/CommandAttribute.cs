// CommandAttribute.cs
// Copyright (c) 2019-2023 Ishan Pranav. All rights reserved.
// Licensed under the MIT License.

using System;
using IrvineCubeSat.GpsParser.BodyParsers;

namespace IrvineCubeSat.GpsParser.Attributes
{
    /// <summary>
    /// Specifies that a class contains the model for a GNSS command message body.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    public sealed class CommandAttribute : Attribute
    {
        /// <summary>
        /// Gets the name of the command.
        /// </summary>
        /// <value>The command name.</value>
        public string Name { get; }

        /// <summary>
        /// Gets the log parser type.
        /// </summary>
        /// <value>A type that implements <see cref="IBodyParser"/>.</value>
        public Type ParserType { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommandAttribute"/> class.
        /// </summary>
        /// <param name="name">The command name.</param>
        public CommandAttribute(string name)
        {
            Name = name;
            ParserType = typeof(BodyParser);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommandAttribute"/> class.
        /// </summary>
        /// <param name="name">The command name.</param>
        /// <param name="parserType">A type that implements <see cref="IBodyParser"/>.</param>
        /// <exception cref="ArgumentException">The log parser type does not implement <see cref="IBodyParser"/>.</exception>
        public CommandAttribute(string name, Type parserType)
        {
            if (!typeof(IBodyParser).IsAssignableFrom(parserType))
            {
                throw new ArgumentException($"The log parser type must implement {typeof(IBodyParser).FullName}.", nameof(parserType));
            }

            Name = name;
            ParserType = parserType;
        }
    }
}
