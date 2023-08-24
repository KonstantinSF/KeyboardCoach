using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;

namespace ClientNet3
{
    internal class Client
    {
        static async Task Main(string[] args)
        {
            using Socket tcpClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			try
			{
                await tcpClient.ConnectAsync("127.0.0.1", 8888);
                Console.WriteLine("Введите сообщение: ");
                var message = Console.ReadLine();
                byte [] requestData = Encoding.UTF8.GetBytes(message);
                await tcpClient.SendAsync(requestData,SocketFlags.None);
                Console.WriteLine("Сообщение отправлено");
#if false 
                //Клиент отправляет сообщение

                await tcpClient.ConnectAsync("127.0.0.1", 8888);//адрес СЕРВЕРА, клиент всегда подключается, а не ждет подключения!!!
                Console.WriteLine("Введите сообщение: ");
                var message = Console.ReadLine();
                byte[] requestData = Encoding.UTF8.GetBytes(message);
                await tcpClient.SendAsync(requestData, SocketFlags.None);
                Console.WriteLine("Сообщение отправлено");  
#endif

#if false
                byte[] data = new byte[512];
                int bytes = await tcpClient.ReceiveAsync(data, SocketFlags.None);
                string time = Encoding.UTF8.GetString(data, 0, bytes);
                Console.WriteLine($"Текущее время: {time}");
#endif
            }
			catch (SocketException ex)
			{
                Console.WriteLine (ex.Message);
			}
        }
    }
}