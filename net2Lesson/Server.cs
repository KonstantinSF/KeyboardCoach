using System.Net;
using System.Net.Sockets;
using System.Text;

namespace net2Lesson
{
    internal class Server
    {
        static async Task Main(string[] args)
        {
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, 8888);
            using Socket tcpListener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                tcpListener.Bind(endPoint);
                tcpListener.Listen();
                Console.WriteLine("Сервер запущен. Ожидание подключений...");
                while (true)
                {
                    using var tcpClient = await tcpListener.AcceptAsync();

#if false //использование 1о байтового массива для посимвольного считывания сообщения от клиента
                var buffer = new List<byte>();
                var bytesRead = new byte[1];
                while (true)
                {
                    var count = await tcpClient.ReceiveAsync(bytesRead, SocketFlags.None);
                    if (count == 0 || bytesRead[0] == '\n')
                    {
                        break;
                    }
                    buffer.Add(bytesRead[0]);
                    var message = Encoding.UTF8.GetString(buffer.ToArray());
                    Console.WriteLine($"Получено сообщение {message}");
                } 
#endif

#if false // Сервер принимает ответ от клиента
                    byte[] responseData = new byte[512];
                    int bytes = 0;
                    var response = new StringBuilder();
                    do
                    {
                        bytes = await tcpClient.ReceiveAsync(responseData, SocketFlags.None);
                        response.Append(Encoding.UTF8.GetString(responseData, 0, bytes));
                    } while (bytes > 0);
                    Console.WriteLine(response);
                }
            }
            catch (SocketException ex)
            {
                Console.WriteLine(ex.Message);
            } 
#endif

#if false
                    1.Сервер отправляющий данные клиенту
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, 8888);
                    using Socket tcpListener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    try
                    {
                        tcpListener.Bind(endPoint);
                        tcpListener.Listen();
                        Console.WriteLine("Сервер запущен. Ожидание подключений...");
                        while (true)
                        {
                            using var tcpClient = await tcpListener.AcceptAsync();//сервер ничего не получает от клиента
                            byte[] data = Encoding.UTF8.GetBytes(DateTime.Now.ToLongTimeString());
                            await tcpClient.SendAsync(data, SocketFlags.None);
                            Console.WriteLine($"Клиенту{tcpClient.RemoteEndPoint} отправлены данные");
                        }
                    }
                    catch (SocketException ex)
                    {
                        Console.WriteLine(ex.Message);
                    } 
#endif
            }
        }
    }
}




