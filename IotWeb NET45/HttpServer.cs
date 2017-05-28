using IotWeb_CarbyneFork.Common.Http;

namespace IotWeb_CarbyneFork.Server
{
	public class HttpServer : BaseHttpServer
	{
		public HttpServer(int port)
			: base(new SocketServer(port))
		{
			// No configuration required
		}
	}
}
