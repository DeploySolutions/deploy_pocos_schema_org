using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// An [[EmployerReview]] is a review of an [[Organization]] regarding its role as an employer, written by a current or former employee of that organization.
    /// </summary>
    public partial class EmployerReview : Review
    {
        public EmployerReview()
        {
            Type = "EmployerReview";
        }

    }
}
