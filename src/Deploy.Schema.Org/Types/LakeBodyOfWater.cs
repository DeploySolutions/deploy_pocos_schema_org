using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A lake (for example, Lake Pontrachain).
    /// </summary>
    public partial class LakeBodyOfWater : BodyOfWater
    {
        public LakeBodyOfWater()
        {
            Type = "LakeBodyOfWater";
        }

    }
}
