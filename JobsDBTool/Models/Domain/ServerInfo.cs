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
        ProductWeb = 2,
        ProductAgent = 3
    }
    public class ServerInfo
    {
        public string Name { get; set; }
        public string Host { get; set; }
        public string LoginID { get; set; }
        public string LoginPWD { get; set; }
        public string CountryCode { get; set; }
        public string Env { get; set; }
        public string Index { get; set; }
        public ServerType ServerType { get; set; }
    }
}
