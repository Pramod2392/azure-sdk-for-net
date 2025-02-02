// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServices.Models
{
    /// <summary> Base class for request and response capabilities information for Microsoft.RecoveryServices. </summary>
    public partial class ResourceCapabilitiesBase
    {
        /// <summary> Initializes a new instance of ResourceCapabilitiesBase. </summary>
        /// <param name="resourceCapabilitiesBaseType"> Describes the Resource type: Microsoft.RecoveryServices/Vaults. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceCapabilitiesBaseType"/> is null. </exception>
        public ResourceCapabilitiesBase(string resourceCapabilitiesBaseType)
        {
            Argument.AssertNotNull(resourceCapabilitiesBaseType, nameof(resourceCapabilitiesBaseType));

            ResourceCapabilitiesBaseType = resourceCapabilitiesBaseType;
        }

        /// <summary> Describes the Resource type: Microsoft.RecoveryServices/Vaults. </summary>
        public string ResourceCapabilitiesBaseType { get; set; }
    }
}
