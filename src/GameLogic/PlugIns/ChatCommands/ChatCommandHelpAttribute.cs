﻿// <copyright file="ChatCommandHelpAttribute.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.GameLogic.PlugIns.ChatCommands
{
    using System;
    using MUnique.OpenMU.DataModel.Entities;

    /// <summary>
    /// An attribute which decorates an <see cref="IChatCommandPlugIn"/> with help information.
    /// This information is then used in the <see cref="HelpCommand"/>.
    /// </summary>
    /// <seealso cref="System.Attribute" />
    [AttributeUsage(AttributeTargets.Class)]
    public class ChatCommandHelpAttribute : Attribute
    {
        private readonly Type argumentsType;

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCommandHelpAttribute" /> class.
        /// </summary>
        /// <param name="command">The command.</param>
        /// <param name="argumentsType">Type of the arguments.</param>
        /// <param name="minimumCharacterStatus">The minimum character status.</param>
        public ChatCommandHelpAttribute(string command, Type argumentsType = null, CharacterStatus minimumCharacterStatus = CharacterStatus.Normal)
        {
            this.Command = command;
            this.argumentsType = argumentsType;
            this.MinimumCharacterStatus = minimumCharacterStatus;
        }

        /// <summary>
        /// Gets the command.
        /// </summary>
        public string Command { get; }

        /// <summary>
        /// Gets the minimum character status.
        /// </summary>
        public CharacterStatus MinimumCharacterStatus { get; }

        /// <summary>
        /// Gets the usage text for the chat command.
        /// </summary>
        public string Usage => this.argumentsType == null ? this.Command : CommandExtensions.CreateUsage(this.argumentsType, this.Command);
    }
}