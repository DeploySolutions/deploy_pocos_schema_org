using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A CDCPMDRecord is a data structure representing a record in a CDC tabular data format
    /// used for hospital data reporting. See [documentation](/docs/cdc-covid.html) for details, and the linked CDC materials for authoritative
    /// definitions used as the source here.
    /// </summary>
    public partial class CDCPMDRecord : StructuredValue
    {
        public CDCPMDRecord()
        {
            Type = "CDCPMDRecord";
        }

    /// <summary>
    /// A CDCPMDRecord is a data structure representing a record in a CDC tabular data format
    /// used for hospital data reporting. See [documentation](/docs/cdc-covid.html) for details, and the linked CDC materials for authoritative
    /// definitions used as the source here.
    /// </summary>
        [JsonPropertyName("cvdCollectionDate")]
        public virtual object? CvdCollectionDate { get; set; }

    /// <summary>
    /// A CDCPMDRecord is a data structure representing a record in a CDC tabular data format
    /// used for hospital data reporting. See [documentation](/docs/cdc-covid.html) for details, and the linked CDC materials for authoritative
    /// definitions used as the source here.
    /// </summary>
        [JsonPropertyName("cvdFacilityCounty")]
        public virtual string? CvdFacilityCounty { get; set; }

    /// <summary>
    /// A CDCPMDRecord is a data structure representing a record in a CDC tabular data format
    /// used for hospital data reporting. See [documentation](/docs/cdc-covid.html) for details, and the linked CDC materials for authoritative
    /// definitions used as the source here.
    /// </summary>
        [JsonPropertyName("cvdFacilityId")]
        public virtual string? CvdFacilityId { get; set; }

    /// <summary>
    /// A CDCPMDRecord is a data structure representing a record in a CDC tabular data format
    /// used for hospital data reporting. See [documentation](/docs/cdc-covid.html) for details, and the linked CDC materials for authoritative
    /// definitions used as the source here.
    /// </summary>
        [JsonPropertyName("cvdNumBeds")]
        public virtual double? CvdNumBeds { get; set; }

    /// <summary>
    /// A CDCPMDRecord is a data structure representing a record in a CDC tabular data format
    /// used for hospital data reporting. See [documentation](/docs/cdc-covid.html) for details, and the linked CDC materials for authoritative
    /// definitions used as the source here.
    /// </summary>
        [JsonPropertyName("cvdNumBedsOcc")]
        public virtual double? CvdNumBedsOcc { get; set; }

    /// <summary>
    /// A CDCPMDRecord is a data structure representing a record in a CDC tabular data format
    /// used for hospital data reporting. See [documentation](/docs/cdc-covid.html) for details, and the linked CDC materials for authoritative
    /// definitions used as the source here.
    /// </summary>
        [JsonPropertyName("cvdNumC19Died")]
        public virtual double? CvdNumC19Died { get; set; }

    /// <summary>
    /// A CDCPMDRecord is a data structure representing a record in a CDC tabular data format
    /// used for hospital data reporting. See [documentation](/docs/cdc-covid.html) for details, and the linked CDC materials for authoritative
    /// definitions used as the source here.
    /// </summary>
        [JsonPropertyName("cvdNumC19HOPats")]
        public virtual double? CvdNumC19HOPats { get; set; }

    /// <summary>
    /// A CDCPMDRecord is a data structure representing a record in a CDC tabular data format
    /// used for hospital data reporting. See [documentation](/docs/cdc-covid.html) for details, and the linked CDC materials for authoritative
    /// definitions used as the source here.
    /// </summary>
        [JsonPropertyName("cvdNumC19HospPats")]
        public virtual double? CvdNumC19HospPats { get; set; }

    /// <summary>
    /// A CDCPMDRecord is a data structure representing a record in a CDC tabular data format
    /// used for hospital data reporting. See [documentation](/docs/cdc-covid.html) for details, and the linked CDC materials for authoritative
    /// definitions used as the source here.
    /// </summary>
        [JsonPropertyName("cvdNumC19MechVentPats")]
        public virtual double? CvdNumC19MechVentPats { get; set; }

    /// <summary>
    /// A CDCPMDRecord is a data structure representing a record in a CDC tabular data format
    /// used for hospital data reporting. See [documentation](/docs/cdc-covid.html) for details, and the linked CDC materials for authoritative
    /// definitions used as the source here.
    /// </summary>
        [JsonPropertyName("cvdNumC19OFMechVentPats")]
        public virtual double? CvdNumC19OFMechVentPats { get; set; }

    /// <summary>
    /// A CDCPMDRecord is a data structure representing a record in a CDC tabular data format
    /// used for hospital data reporting. See [documentation](/docs/cdc-covid.html) for details, and the linked CDC materials for authoritative
    /// definitions used as the source here.
    /// </summary>
        [JsonPropertyName("cvdNumC19OverflowPats")]
        public virtual double? CvdNumC19OverflowPats { get; set; }

    /// <summary>
    /// A CDCPMDRecord is a data structure representing a record in a CDC tabular data format
    /// used for hospital data reporting. See [documentation](/docs/cdc-covid.html) for details, and the linked CDC materials for authoritative
    /// definitions used as the source here.
    /// </summary>
        [JsonPropertyName("cvdNumICUBeds")]
        public virtual double? CvdNumICUBeds { get; set; }

    /// <summary>
    /// A CDCPMDRecord is a data structure representing a record in a CDC tabular data format
    /// used for hospital data reporting. See [documentation](/docs/cdc-covid.html) for details, and the linked CDC materials for authoritative
    /// definitions used as the source here.
    /// </summary>
        [JsonPropertyName("cvdNumICUBedsOcc")]
        public virtual double? CvdNumICUBedsOcc { get; set; }

    /// <summary>
    /// A CDCPMDRecord is a data structure representing a record in a CDC tabular data format
    /// used for hospital data reporting. See [documentation](/docs/cdc-covid.html) for details, and the linked CDC materials for authoritative
    /// definitions used as the source here.
    /// </summary>
        [JsonPropertyName("cvdNumTotBeds")]
        public virtual double? CvdNumTotBeds { get; set; }

    /// <summary>
    /// A CDCPMDRecord is a data structure representing a record in a CDC tabular data format
    /// used for hospital data reporting. See [documentation](/docs/cdc-covid.html) for details, and the linked CDC materials for authoritative
    /// definitions used as the source here.
    /// </summary>
        [JsonPropertyName("cvdNumVent")]
        public virtual double? CvdNumVent { get; set; }

    /// <summary>
    /// A CDCPMDRecord is a data structure representing a record in a CDC tabular data format
    /// used for hospital data reporting. See [documentation](/docs/cdc-covid.html) for details, and the linked CDC materials for authoritative
    /// definitions used as the source here.
    /// </summary>
        [JsonPropertyName("cvdNumVentUse")]
        public virtual double? CvdNumVentUse { get; set; }

    /// <summary>
    /// A CDCPMDRecord is a data structure representing a record in a CDC tabular data format
    /// used for hospital data reporting. See [documentation](/docs/cdc-covid.html) for details, and the linked CDC materials for authoritative
    /// definitions used as the source here.
    /// </summary>
        [JsonPropertyName("datePosted")]
        public virtual object? DatePosted { get; set; }

    }
}
