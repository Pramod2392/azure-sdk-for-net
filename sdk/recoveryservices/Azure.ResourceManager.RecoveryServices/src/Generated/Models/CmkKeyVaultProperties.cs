// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.RecoveryServices.Models
{
    /// <summary> The properties of the Key Vault which hosts CMK. </summary>
    internal partial class CmkKeyVaultProperties
    {
        /// <summary> Initializes a new instance of CmkKeyVaultProperties. </summary>
        public CmkKeyVaultProperties()
        {
        }

        /// <summary> Initializes a new instance of CmkKeyVaultProperties. </summary>
        /// <param name="keyUri"> The key uri of the Customer Managed Key. </param>
        internal CmkKeyVaultProperties(Uri keyUri)
        {
            KeyUri = keyUri;
        }

        /// <summary> The key uri of the Customer Managed Key. </summary>
        public Uri KeyUri { get; set; }
    }
}
