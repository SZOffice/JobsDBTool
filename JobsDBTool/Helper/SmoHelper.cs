using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JobsDBTool.Helper
{
    public class SmoHelper
    {
        public static Server GetServer(string connectionString)
        {
            try
            {
                ServerConnection connection = new ServerConnection();
                connection.ConnectionString = connectionString;

                Server server = new Server(connection);
                return server;
            }
            catch (Exception exception)
            {
                throw new Exception("Failed to create Server: " + exception.Message);
            }
        }

    }
}
