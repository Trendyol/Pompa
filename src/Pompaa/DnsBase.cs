using System.Net;

namespace Pompa
{
    public abstract class DnsBase {
        public abstract IPAddress[] GetHostAddresses(string hostNameOrAddress);

    }
}
