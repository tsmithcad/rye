// FeatureRelease.cs
using System;

/// <summary>
/// Represents information about a feature release.
/// </summary>
public class FeatureRelease
{
    /// <summary>
    /// Gets or sets the date of the feature release.
    /// </summary>
    public DateTime Date { get; set; }

    /// <summary>
    /// Gets or sets the name of the released feature.
    /// </summary>
    public string? FeatureName { get; set; }

    /// <summary>
    /// Gets or sets the user group affected by the feature release.
    /// </summary>
    public string? AffectedUserGroup { get; set; }

    /// <summary>
    /// Gets or sets the description of the feature release.
    /// </summary>
    public string? Description { get; set; }
}

