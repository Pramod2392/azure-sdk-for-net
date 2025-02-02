// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    internal static partial class ContainerRegistryPasswordNameExtensions
    {
        public static string ToSerialString(this ContainerRegistryPasswordName value) => value switch
        {
            ContainerRegistryPasswordName.Password => "password",
            ContainerRegistryPasswordName.Password2 => "password2",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ContainerRegistryPasswordName value.")
        };

        public static ContainerRegistryPasswordName ToContainerRegistryPasswordName(this string value)
        {
            if (string.Equals(value, "password", StringComparison.InvariantCultureIgnoreCase)) return ContainerRegistryPasswordName.Password;
            if (string.Equals(value, "password2", StringComparison.InvariantCultureIgnoreCase)) return ContainerRegistryPasswordName.Password2;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ContainerRegistryPasswordName value.");
        }
    }
}
