// Resources.cs
// Copyright (c) 2019-2022 Ishan Pranav. All rights reserved.
// Licensed under the MIT License.

using System.Resources;
using System.Runtime.CompilerServices;

namespace IrvineCubeSat.GpsParser.Windows;

internal static class Resources
{
    private static readonly ResourceManager s_resourceManager = new ResourceManager(typeof(Resources));

    public static string Title
    {
        get
        {
            return GetString();
        }
    }

    public static string VendorMessage
    {
        get
        {
            return GetString();
        }
    }

    public static string GetFilter()
    {
        return string.Join(separator: '|',
            getFilter(filter: "*.*"),
            getFilter(filter: "*.gps;*.log;*.txt"),
            getFilter(filter: "*.gps"),
            getFilter(filter: "*.log"),
            getFilter(filter: "*.txt"));

        static string getFilter(string filter)
        {
            return string.Format("{0} ({1})|{1}", GetString(filter), filter);
        }
    }

    public static string GetCommandMessage(int ordinal)
    {
        return string.Format(GetString(), ordinal);
    }

    public static string GetHeaderMessage(int ordinal)
    {
        return string.Format(GetString(), ordinal);
    }

    public static string GetStatusMessage(int messages)
    {
        return string.Format(GetString(), messages);
    }

    public static string GetString([CallerMemberName] string key = "")
    {
        return s_resourceManager.GetString(key) ?? key;
    }
}
