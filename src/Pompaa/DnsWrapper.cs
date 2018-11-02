using System.Net;

namespace Pompa
{
    public class DnsWrapper : DnsBase
    {

        public override IPAddress[] GetHostAddresses(string hostNameOrAddress)
        {
            return Dns.GetHostAddresses(hostNameOrAddress);
        }
    }
}