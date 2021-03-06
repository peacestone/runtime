// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Runtime.InteropServices;

internal partial class Interop
{
    internal partial class Libdl
    {
        public const int RTLD_LAZY = 0x001;

        [DllImport(Libraries.Libdl)]
        public static extern IntPtr dlopen(string fileName, int flag);
    }
}
