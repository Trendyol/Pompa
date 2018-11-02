using System.Net;
namespace Pompa
{
    public interface ITransport
    {
        string Scheme { get; }
        void Send(IPEndPoint target, string message);
    }
}
