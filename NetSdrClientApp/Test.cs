using EchoServer;

namespace NetSdrClientApp
{
    public class Test
    {
       public void CreateServer()
        {
            var server = new EchoServer.EchoServer(5000); // ось тут залежність на інфраструктуру
        }
    }
}
