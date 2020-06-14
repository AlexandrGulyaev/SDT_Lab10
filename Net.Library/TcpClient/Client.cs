using System;
using System.Text;
using System.Net.Sockets;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SomeProject.Library.Client
{
    public class Client
    {
        /// <summary>
        /// TCP-Client
        /// </summary>
        public TcpClient tcpClient;

        /// <summary>
        /// Приём сообщения с сервера
        /// </summary>
        /// <returns></returns>
        public OperationResult ReceiveMessageFromServer()
        {
            try
            {
                tcpClient = new TcpClient("127.0.0.1", 8080);
                StringBuilder recievedMessage = new StringBuilder();
                byte[] data = new byte[256];
                NetworkStream stream = tcpClient.GetStream();

                do
                {
                    int bytes = stream.Read(data, 0, data.Length);
                    recievedMessage.Append(Encoding.UTF8.GetString(data, 0, bytes));
                }
                while (stream.DataAvailable);
                stream.Close();
                tcpClient.Close();

                return new OperationResult(Result.OK, recievedMessage.ToString());
            }
            catch (Exception e)
            {
                return new OperationResult(Result.Fail, e.ToString());
            }
        }

        /// <summary>
        /// Отправка сообщения на сервер
        /// </summary>
        /// <param name="message">Текст сообщения</param>
        /// <returns></returns>
        public OperationResult SendMessageToServer(string message)
        {
            try
            {
                tcpClient = new TcpClient("127.0.0.1", 8080);
                NetworkStream stream = tcpClient.GetStream();

                BinaryFormatter formatter = new BinaryFormatter();
                // Указываем, что передаем сообщение
                formatter.Serialize(stream, true);

                byte[] data = System.Text.Encoding.UTF8.GetBytes(message);
                stream.Write(data, 0, data.Length);
                stream.Close();
                tcpClient.Close();
                return new OperationResult(Result.OK, "Сообщение отправлено.");
            }
            catch (Exception e)
            {
                return new OperationResult(Result.Fail, e.Message);
            }
        }
        
        /// <summary>
        /// Отправка файла на сервер
        /// </summary>
        /// <param name="path">Путь к файлу</param>
        /// <returns></returns>
        public OperationResult SendFileToServer(string path)
        {
            try
            {
                tcpClient = new TcpClient("127.0.0.1", 8080);
                NetworkStream stream = tcpClient.GetStream();
                byte[] data = File.ReadAllBytes(path);

                BinaryFormatter formatter = new BinaryFormatter();
                // Указываем, что передаётся файл
                formatter.Serialize(stream, false);
                // Указываем расширение файла
                formatter.Serialize(stream, Path.GetExtension(path));
                // Передаем сам файл
                formatter.Serialize(stream, data);

                stream.Close();
                tcpClient.Close();
                return new OperationResult(Result.OK, "Файл " + Path.GetFileName(path) + '.' + Path.GetExtension(path) + " отправлен.");
            }
            catch (Exception e)
            {
                return new OperationResult(Result.Fail, e.Message);
            }
        }
    }
}
