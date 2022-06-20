#nullable enable

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnitTests;

internal static class ProjectSourcePath
{
    private const  string  myRelativePath = nameof(ProjectSourcePath)
        + ".cs";

    private static string? lazyValue;
    public  static string  Value => lazyValue ??= calculatePath();

    private static string calculatePath()
    {
        string pathName = GetSourceFilePathName();

        Debug.Assert(
            pathName.EndsWith(myRelativePath, StringComparison.Ordinal)
        );

        return pathName
            .Substring(0, pathName.Length - myRelativePath.Length );
    }

    public static string GetSourceFilePathName(
        [CallerFilePath] string? callerFilePath = null
    ) => callerFilePath ?? "";
}

