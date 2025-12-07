using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Represents additional information about a relationship or property. For example a Role can be used to say that a 'member' role linking some SportsTeam to a player occurred during a particular time period. Or that a Person's 'actor' role in a Movie was for some particular characterName. Such properties can be attached to a Role entity, which is then associated with the main entities using ordinary properties like 'member' or 'actor'.\n\nSee also [blog post](https://blog.schema.org/2014/06/16/introducing-role/).
    /// </summary>
    public partial class Role : Intangible
    {
        public Role()
        {
            Type = "Role";
        }

    /// <summary>
    /// Represents additional information about a relationship or property. For example a Role can be used to say that a 'member' role linking some SportsTeam to a player occurred during a particular time period. Or that a Person's 'actor' role in a Movie was for some particular characterName. Such properties can be attached to a Role entity, which is then associated with the main entities using ordinary properties like 'member' or 'actor'.\n\nSee also [blog post](https://blog.schema.org/2014/06/16/introducing-role/).
    /// </summary>
        [JsonPropertyName("endDate")]
        public virtual object? EndDate { get; set; }

    /// <summary>
    /// Represents additional information about a relationship or property. For example a Role can be used to say that a 'member' role linking some SportsTeam to a player occurred during a particular time period. Or that a Person's 'actor' role in a Movie was for some particular characterName. Such properties can be attached to a Role entity, which is then associated with the main entities using ordinary properties like 'member' or 'actor'.\n\nSee also [blog post](https://blog.schema.org/2014/06/16/introducing-role/).
    /// </summary>
        [JsonPropertyName("namedPosition")]
        public virtual object? NamedPosition { get; set; }

    /// <summary>
    /// Represents additional information about a relationship or property. For example a Role can be used to say that a 'member' role linking some SportsTeam to a player occurred during a particular time period. Or that a Person's 'actor' role in a Movie was for some particular characterName. Such properties can be attached to a Role entity, which is then associated with the main entities using ordinary properties like 'member' or 'actor'.\n\nSee also [blog post](https://blog.schema.org/2014/06/16/introducing-role/).
    /// </summary>
        [JsonPropertyName("roleName")]
        public virtual object? RoleName { get; set; }

    /// <summary>
    /// Represents additional information about a relationship or property. For example a Role can be used to say that a 'member' role linking some SportsTeam to a player occurred during a particular time period. Or that a Person's 'actor' role in a Movie was for some particular characterName. Such properties can be attached to a Role entity, which is then associated with the main entities using ordinary properties like 'member' or 'actor'.\n\nSee also [blog post](https://blog.schema.org/2014/06/16/introducing-role/).
    /// </summary>
        [JsonPropertyName("startDate")]
        public virtual object? StartDate { get; set; }

    }
}
