// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.IO;

namespace Wpf.Extensions.Hosting
{
    internal static class HostingPathResolver
    {
        public static string ResolvePath(string contentRootPath)
        {
            var canonicalPath = ResolvePath(contentRootPath, AppContext.BaseDirectory);
            return canonicalPath;
        }

        public static string ResolvePath(string contentRootPath, string basePath)
        {
            if (string.IsNullOrEmpty(contentRootPath))
            {
                return Path.GetFullPath(basePath);
            }
            if (Path.IsPathRooted(contentRootPath))
            {
                return Path.GetFullPath(contentRootPath);
            }
            return Path.GetFullPath(Path.Combine(Path.GetFullPath(basePath), contentRootPath));
        }
    }
}
