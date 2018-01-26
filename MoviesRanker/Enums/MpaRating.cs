using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MoviesRanker.Enums
{
    public enum MPARating
    {
        G,
        [Description("PG-13")]
        PG13,
        [Description("PG")]
        PG,
        [Description("R")]
        R,
        [Description("NC-17")]
        NC17
    }
}