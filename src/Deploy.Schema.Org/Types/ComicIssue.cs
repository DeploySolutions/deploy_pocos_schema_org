using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Individual comic issues are serially published as
    ///     	part of a larger series. For the sake of consistency, even one-shot issues
    ///     	belong to a series comprised of a single issue. All comic issues can be
    ///     	uniquely identified by: the combination of the name and volume number of the
    ///     	series to which the issue belongs; the issue number; and the variant
    ///     	description of the issue (if any).
    /// </summary>
    public partial class ComicIssue : PublicationIssue
    {
        public ComicIssue()
        {
            Type = "ComicIssue";
        }

    /// <summary>
    /// Individual comic issues are serially published as
    ///     	part of a larger series. For the sake of consistency, even one-shot issues
    ///     	belong to a series comprised of a single issue. All comic issues can be
    ///     	uniquely identified by: the combination of the name and volume number of the
    ///     	series to which the issue belongs; the issue number; and the variant
    ///     	description of the issue (if any).
    /// </summary>
        [JsonPropertyName("artist")]
        public virtual Person? Artist { get; set; }

    /// <summary>
    /// Individual comic issues are serially published as
    ///     	part of a larger series. For the sake of consistency, even one-shot issues
    ///     	belong to a series comprised of a single issue. All comic issues can be
    ///     	uniquely identified by: the combination of the name and volume number of the
    ///     	series to which the issue belongs; the issue number; and the variant
    ///     	description of the issue (if any).
    /// </summary>
        [JsonPropertyName("colorist")]
        public virtual Person? Colorist { get; set; }

    /// <summary>
    /// Individual comic issues are serially published as
    ///     	part of a larger series. For the sake of consistency, even one-shot issues
    ///     	belong to a series comprised of a single issue. All comic issues can be
    ///     	uniquely identified by: the combination of the name and volume number of the
    ///     	series to which the issue belongs; the issue number; and the variant
    ///     	description of the issue (if any).
    /// </summary>
        [JsonPropertyName("inker")]
        public virtual Person? Inker { get; set; }

    /// <summary>
    /// Individual comic issues are serially published as
    ///     	part of a larger series. For the sake of consistency, even one-shot issues
    ///     	belong to a series comprised of a single issue. All comic issues can be
    ///     	uniquely identified by: the combination of the name and volume number of the
    ///     	series to which the issue belongs; the issue number; and the variant
    ///     	description of the issue (if any).
    /// </summary>
        [JsonPropertyName("letterer")]
        public virtual Person? Letterer { get; set; }

    /// <summary>
    /// Individual comic issues are serially published as
    ///     	part of a larger series. For the sake of consistency, even one-shot issues
    ///     	belong to a series comprised of a single issue. All comic issues can be
    ///     	uniquely identified by: the combination of the name and volume number of the
    ///     	series to which the issue belongs; the issue number; and the variant
    ///     	description of the issue (if any).
    /// </summary>
        [JsonPropertyName("penciler")]
        public virtual Person? Penciler { get; set; }

    /// <summary>
    /// Individual comic issues are serially published as
    ///     	part of a larger series. For the sake of consistency, even one-shot issues
    ///     	belong to a series comprised of a single issue. All comic issues can be
    ///     	uniquely identified by: the combination of the name and volume number of the
    ///     	series to which the issue belongs; the issue number; and the variant
    ///     	description of the issue (if any).
    /// </summary>
        [JsonPropertyName("variantCover")]
        public virtual string? VariantCover { get; set; }

    }
}
