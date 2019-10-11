using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JobsDBTool.Models.Domain
{
    public enum ServerType
    {
        Null = -1,
        PreviewWeb = 0,
        PreviewAgent = 1,
        PreviewNginx = 2,
        ProductWeb = 3,
        ProductAgent = 4,
        ProductNginx = 5
    }
    public class ServerInfo
    {
        public string Name { get; set; }
        public string Host { get; set; }
        public string LoginID { get; set; }
        public string LoginPWD { get; set; }
        public string CountryCode { get; set; }
        public ServerType ServerType { get; set; }
    }
}
