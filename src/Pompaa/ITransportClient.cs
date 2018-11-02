using System.Net;

namespace Pompa
{
    public interface ITransportClient
    {
        void Send(byte[] datagram, int bytes, IPEndPoint ipEndPoint);
    }
}
