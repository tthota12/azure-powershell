// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using System.Linq;

    /// <summary>
    /// Network Virtual Appliance Sku Properties.
    /// </summary>
    public partial class VirtualApplianceSkuProperties
    {
        /// <summary>
        /// Initializes a new instance of the VirtualApplianceSkuProperties class.
        /// </summary>
        public VirtualApplianceSkuProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VirtualApplianceSkuProperties class.
        /// </summary>

        /// <param name="vendor">Virtual Appliance Vendor.
        /// </param>

        /// <param name="bundledScaleUnit">Virtual Appliance Scale Unit.
        /// </param>

        /// <param name="marketPlaceVersion">Virtual Appliance Version.
        /// </param>
        public VirtualApplianceSkuProperties(string vendor = default(string), string bundledScaleUnit = default(string), string marketPlaceVersion = default(string))

        {
            this.Vendor = vendor;
            this.BundledScaleUnit = bundledScaleUnit;
            this.MarketPlaceVersion = marketPlaceVersion;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets virtual Appliance Vendor.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "vendor")]
        public string Vendor {get; set; }

        /// <summary>
        /// Gets or sets virtual Appliance Scale Unit.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "bundledScaleUnit")]
        public string BundledScaleUnit {get; set; }

        /// <summary>
        /// Gets or sets virtual Appliance Version.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "marketPlaceVersion")]
        public string MarketPlaceVersion {get; set; }
    }
}