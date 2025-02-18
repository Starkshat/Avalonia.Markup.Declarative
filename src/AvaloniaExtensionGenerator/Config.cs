using System;
using System.Collections.Generic;
using System.Globalization;
using Avalonia;
using Avalonia.Animation;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Input;
using Avalonia.Layout;

namespace AvaloniaExtensionGenerator
{
    public class Config
    {
        public string[] InitialNamespaces = { 
            "Avalonia.Data",
            "Avalonia.Data.Converters",
            "System.Runtime.CompilerServices" };

        public Type[] UseFullNamespace = new[]
        {
            typeof(Avalonia.Controls.Calendar),
            typeof(ContextMenu),
            typeof(Animation),
        };

        public Type[] Exclude = new[]
        {
            typeof(ProgressBar.ProgressBarTemplateProperties)
        };

        /// <summary>
        /// Those types will be generated as Generic extension methods instead of using direct control type
        /// </summary>
        public List<Type> BaseTypes = new()
        {
            typeof(Control),
            typeof(FlyoutBase),
            typeof(Layoutable),
            typeof(Panel),
            typeof(Visual),
            typeof(TemplatedControl),
            typeof(ItemsControl),
            typeof(InputElement),
            typeof(ContentControl),
        };
    }
}