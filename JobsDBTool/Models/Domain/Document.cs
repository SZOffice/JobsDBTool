using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JobsDBTool.Models.Domain
{
    public class Document
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ParentId { get; set; }        
        public string Content { get; set; }
        public int SortOrder { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
