using System;
using System.Collections.Generic;
using SolrNet.Attributes;

namespace JobsDBTool.Helper
{
    public enum OperateType { 
        Xml=0,
        Javabin=1
    }
    public class ISolr
    {
        public long id { get; set; }
    }

    public class Example : ISolr
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string[] Tag { get; set; }
    }

    public class Example2 : ISolr
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public DateTime CreatedTime { get; set; }
    }


    public class ExampleSolrNet
    {
        [SolrUniqueKey("id")]
        public long Id { get; set; }
                
        [SolrField("name")]
        public string Name { get; set; }

        [SolrField("description")]
        public string Description { get; set; }

        [SolrField("tag")]
        public ICollection<string> Tag { get; set; }
    }
}
