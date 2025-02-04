// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AlertsManagement.Models
{
    /// <summary> The SmartGroupCollectionGetAllOptions. </summary>
    public partial class SmartGroupCollectionGetAllOptions
    {
        /// <summary> Initializes a new instance of SmartGroupCollectionGetAllOptions. </summary>
        public SmartGroupCollectionGetAllOptions()
        {
        }

        /// <summary> Filter by target resource( which is full ARM ID) Default value is select all. </summary>
        public string TargetResource { get; set; }
        /// <summary> Filter by target resource group name. Default value is select all. </summary>
        public string TargetResourceGroup { get; set; }
        /// <summary> Filter by target resource type. Default value is select all. </summary>
        public string TargetResourceType { get; set; }
        /// <summary> Filter by monitor service which generates the alert instance. Default value is select all. </summary>
        public MonitorServiceSourceForAlert? MonitorService { get; set; }
        /// <summary> Filter by monitor condition which is either &apos;Fired&apos; or &apos;Resolved&apos;. Default value is to select all. </summary>
        public MonitorCondition? MonitorCondition { get; set; }
        /// <summary> Filter by severity.  Default value is select all. </summary>
        public ServiceAlertSeverity? Severity { get; set; }
        /// <summary> Filter by state of the smart group. Default value is to select all. </summary>
        public ServiceAlertState? SmartGroupState { get; set; }
        /// <summary> Filter by time range by below listed values. Default value is 1 day. </summary>
        public TimeRangeFilter? TimeRange { get; set; }
        /// <summary> Determines number of alerts returned per page in response. Permissible value is between 1 to 250. When the &quot;includeContent&quot;  filter is selected, maximum value allowed is 25. Default value is 25. </summary>
        public long? PageCount { get; set; }
        /// <summary> Sort the query results by input field. Default value is sort by &apos;lastModifiedDateTime&apos;. </summary>
        public SmartGroupsSortByField? SortBy { get; set; }
        /// <summary> Sort the query results order in either ascending or descending.  Default value is &apos;desc&apos; for time fields and &apos;asc&apos; for others. </summary>
        public AlertsManagementQuerySortOrder? SortOrder { get; set; }
    }
}
