﻿namespace Gantry.Core.GameContent.ChatCommands.Parsers.Extensions;

/// <summary>
///     Extension methods that add new functionality to the <see cref="CommandArgumentParsers"/> class
/// </summary>
public static class ParserExtensions
{
    /// <summary>
    ///     Parses a string as a <see cref="DataStructures.AccessMode"/> value, allowing partial matches.
    /// </summary>
    public static AccessModeParser AccessMode(this CommandArgumentParsers _)
        => new("mode", false);

    /// <summary>
    ///     Parses a string as a <see cref="FileScope"/> value, allowing partial matches.
    /// </summary>
    public static FileScopeParser FileScope(this CommandArgumentParsers _)
        => new("scope", isMandatoryArg: false);

    /// <summary>
    ///     Allows the user to search for an online player, based on a partial match of their username.
    /// </summary>
    public static FuzzyPlayerParser FuzzyPlayerSearch(this CommandArgumentParsers _)
        => new("player", false);

    /// <summary>
    ///     Parses a float value that is only allowed within a specific inclusive range.
    /// </summary>
    public static FloatArgParser FloatRange(this CommandArgumentParsers _, string argName, float min, float max)
        => new(argName, min, max, isMandatoryArg: true);

    /// <summary>
    ///     Parses a string as an online player, returning an array of <see cref="PlayerUidName"/>, allowing partial matches. (Server-side only)
    /// </summary>
    public static GantryPlayersArgParser ServerPlayers(this CommandArgumentParsers _)
        => new("players", ApiEx.Server, true);

    /// <summary>
    ///     Optionally parses a string as an online player, returning an array of <see cref="PlayerUidName"/>, allowing partial matches. (Server-side only)
    /// </summary>
    public static GantryPlayersArgParser OptionalServerPlayers(this CommandArgumentParsers _)
        => new("players", ApiEx.Server, false);
}