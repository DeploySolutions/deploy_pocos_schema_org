using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// An agent bookmarks/flags/labels/tags/marks an object.
    /// </summary>
    public partial class BookmarkAction : OrganizeAction
    {
        public BookmarkAction()
        {
            Type = "BookmarkAction";
        }

    }
}
