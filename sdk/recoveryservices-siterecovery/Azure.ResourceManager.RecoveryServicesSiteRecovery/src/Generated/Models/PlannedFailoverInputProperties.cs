// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Input definition for planned failover input properties. </summary>
    public partial class PlannedFailoverInputProperties
    {
        /// <summary> Initializes a new instance of PlannedFailoverInputProperties. </summary>
        public PlannedFailoverInputProperties()
        {
        }

        /// <summary> Failover direction. </summary>
        public string FailoverDirection { get; set; }
        /// <summary>
        /// Provider specific settings.
        /// Please note <see cref="PlannedFailoverProviderSpecificFailoverInput"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="HyperVReplicaAzurePlannedFailoverProviderInput"/>, <see cref="HyperVReplicaAzureFailbackProviderInput"/> and <see cref="InMageRcmFailbackPlannedFailoverProviderInput"/>.
        /// </summary>
        public PlannedFailoverProviderSpecificFailoverInput ProviderSpecificDetails { get; set; }
    }
}
