// <copyright file="AssemblyInfo.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using System;
using System.Reflection;
using System.Runtime.InteropServices;

[assembly: ComVisible(true)]
[assembly: Guid(MyComObject.AssemblyInfo.LibraryGuid)]

namespace MyComObject
{
    internal class AssemblyInfo
    {
        internal const string LibraryGuid = "E8F39E50-BE33-4864-B54A-2E096137D080";

        internal const string IMyComObjectGuid = "C83FF168-1899-468A-BE0E-2BC4E5394AB4";
        internal const string MyComObjectGuid = "6222489B-F4C0-4BA6-9A30-90172B9BB648";

        internal const string IMyResultGuid = "454A76D0-4597-45D8-8420-671F71D50C3B";
        internal const string MyResultGuid = "C49DA0C5-727E-43F5-8359-490994D2BA23";

        internal const string IMyComEventsGuid = "E6FF9DB8-4C0D-457E-8066-C5D6C6E58692";
        internal const string OnAdditionDoneGuid = "6C5C4301-8B6F-4083-9036-B7C4D9827817";

        internal const string EnumGuid = "A28167C4-9E73-47E0-A934-43255D4AACA5";

        internal static T Attribute<T>()
            where T : Attribute
        {
            return typeof(AssemblyInfo).Assembly.GetCustomAttribute<T>();
        }
    }
}
