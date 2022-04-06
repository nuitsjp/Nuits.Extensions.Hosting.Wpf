﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Windows;

namespace Wpf.Extensions.Hosting;

/// <summary>
/// Argument for the WPF application startup event.
/// </summary>
/// <typeparam name="TApplication"></typeparam>
/// <typeparam name="TWindow"></typeparam>
public class ApplicationStartupEventArgs<TApplication, TWindow> : EventArgs
    where TApplication : Application
    where TWindow : Window
{
    public ApplicationStartupEventArgs(TApplication application, TWindow window)
    {
        Application = application;
        Window = window;
    }

    public TApplication Application { get; }
    public TWindow Window { get; }
}