﻿// ReSharper disable CheckNamespace

#pragma warning disable CA1069 // Enum values should not be duplicated
#pragma warning disable IDE0130 // Namespace does not match folder structure
namespace JetBrains.Annotations;
#pragma warning restore IDE0130 // Namespace does not match folder structure

/// <summary>
///     Specifies what is considered to be used implicitly when marked
///     with <see cref="MeansImplicitUseAttribute"/> or <see cref="UsedImplicitlyAttribute"/>.
/// </summary>
[Flags]
[UsedImplicitly(WithMembers)]
public enum ImplicitUseTargetFlags
{
    /// <summary>
    ///     By default, the type marked with the attribute are considered used.
    /// </summary>
    Default = Itself,

    /// <summary>
    ///     The type marked with the attribute are considered used.
    /// </summary>
    Itself = 1,

    /// <summary>
    ///     Members of the type marked with the attribute are considered used.
    /// </summary>
    Members = 2,

    /// <summary>
    ///     Inherited entities are considered used.
    /// </summary>
    WithInheritors = 4,

    /// <summary>
    ///     Entity marked with the attribute and all its members considered used.
    /// </summary>
    WithMembers = Itself | Members,

    /// <summary>
    ///     Entity marked with the attribute and all its members considered used.
    /// </summary>
    All = Itself | Members | WithInheritors
}