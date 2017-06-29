using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JobsDBTool.Models.Domain
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string Summary { get; set; }
        public string Status { get; set; }
        public string Remark { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime? LastModifiedTime { get; set; }
        public DateTime? SubmittedTime { get; set; }

        [PetaPoco.Ignore]
        public int OrderByStatus {
            get {
                return (int)Enum.Parse(typeof(TaskStatus), Status);
            }
        } 
    }
}
