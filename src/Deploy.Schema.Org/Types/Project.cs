using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// An enterprise (potentially individual but typically collaborative), planned to achieve a particular aim.
    /// Use properties from [[Organization]], [[subOrganization]]/[[parentOrganization]] to indicate project sub-structures. 
    ///    
    /// </summary>
    public partial class Project : Organization
    {
        public Project()
        {
            Type = "Project";
        }

    }
}
