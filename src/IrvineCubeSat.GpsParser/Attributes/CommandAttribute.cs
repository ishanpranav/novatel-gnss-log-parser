// CommandAttribute.cs
// Copyright (c) 2019-2022 Ishan Pranav. All rights reserved.
// Licensed under the MIT License.

using System;

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
        public string Command { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommandAttribute"/> class.
        /// </summary>
        /// <param name="command">The command name.</param>
        public CommandAttribute(string command)
        {
            Command = command;
        }
    }
}
