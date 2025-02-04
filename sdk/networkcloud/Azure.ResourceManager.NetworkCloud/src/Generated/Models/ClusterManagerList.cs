// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.NetworkCloud;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> ClusterManagerList represents a list of cluster manager objects. </summary>
    internal partial class ClusterManagerList
    {
        /// <summary> Initializes a new instance of ClusterManagerList. </summary>
        internal ClusterManagerList()
        {
            Value = new ChangeTrackingList<ClusterManagerData>();
        }

        /// <summary> Initializes a new instance of ClusterManagerList. </summary>
        /// <param name="nextLink"> The link used to get the next page of operations. </param>
        /// <param name="value"> The list of cluster managers. </param>
        internal ClusterManagerList(string nextLink, IReadOnlyList<ClusterManagerData> value)
        {
            NextLink = nextLink;
            Value = value;
        }

        /// <summary> The link used to get the next page of operations. </summary>
        public string NextLink { get; }
        /// <summary> The list of cluster managers. </summary>
        public IReadOnlyList<ClusterManagerData> Value { get; }
    }
}
