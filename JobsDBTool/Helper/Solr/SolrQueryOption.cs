using System;
using System.Collections.Generic;

namespace JobsDBTool.Helper
{
    public class SolrQueryOption
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public ICollection<string> Fields { get; set; }
        public Dictionary<string, bool> SortOrder { get; set; }
    }
}
