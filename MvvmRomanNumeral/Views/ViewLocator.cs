// Copyright (c) The Avalonia Project. All rights reserved.
// Licensed under the MIT license. See licence.md file in the project root for full license information.

using System;
using Avalonia.Controls;
using Avalonia.Controls.Templates;
using ReactiveUI;

namespace MvvmRomanNumeral.Views
{
    public class ViewLocator : IDataTemplate
    {
        public Control Build(object data)
        {
            if (data is null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            string name = data.GetType().FullName!.Replace("ViewModel", "View");
            Type type = Type.GetType(name);

            return type is null ? new TextBlock { Text = "Not Found: " + name } : (Control)Activator.CreateInstance(type)!;
        }

        public bool Match(object data)
        {
            return data is null ? throw new ArgumentNullException(nameof(data)) : data is ReactiveObject;
        }
    }
}