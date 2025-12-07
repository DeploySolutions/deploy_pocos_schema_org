using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// This type covers computer programming languages such as Scheme and Lisp, as well as other language-like computer representations. Natural languages are best represented with the [[Language]] type.
    /// </summary>
    public partial class ComputerLanguage : Intangible
    {
        public ComputerLanguage()
        {
            Type = "ComputerLanguage";
        }

    }
}
