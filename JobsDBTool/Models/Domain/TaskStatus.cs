using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JobsDBTool.Models.Domain
{
    public enum TaskStatus
    {
        Draft = 0,
        Pending = 1,
        Doing=2,
	    WaitResource=3,
	    Done=4,
	    Submitted=5,
	    ReDo=6
    }
}
