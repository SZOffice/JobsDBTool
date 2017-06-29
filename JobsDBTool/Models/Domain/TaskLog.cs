using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JobsDBTool.Models.Domain
{
    public class TaskLog
    {
        public int TaskId { get; set; }
        public string Remark { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}
