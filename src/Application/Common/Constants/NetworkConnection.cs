using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Constants
{
    public class NetworkConnection : IDisposable
    {
        private readonly string _networkName;

        public NetworkConnection(string networkName, NetworkCredential credentials)
        {
            _networkName = networkName;

            var netResource = new NetResource
            {
                RemoteName = networkName
            };

            WNetAddConnection2(
               netResource,
               credentials.Password,
               credentials.UserName,
               0);
        }
        ~NetworkConnection()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            WNetCancelConnection2(_networkName, 0, true);
        }

        [System.Runtime.InteropServices.DllImport("mpr.dll")]
        private static extern int WNetAddConnection2(NetResource netResource,
            string password, string username, int flags);

        [System.Runtime.InteropServices.DllImport("mpr.dll")]
        private static extern int WNetCancelConnection2(string name, int flags,
            bool force);
    }

    public class NetResource
    {
        public string RemoteName { get; set; }
    }
}
