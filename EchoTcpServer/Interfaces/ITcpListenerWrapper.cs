using System.Net.Sockets;

namespace EchoServer.Interfaces
{
    /// <summary>
    /// Wrapper interface for TcpListener to enable testing
    /// </summary>
    public interface ITcpListenerWrapper
    {
        void Start();
        void Stop();
        Task<TcpClient> AcceptTcpClientAsync();
    }
}