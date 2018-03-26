using System;
using RabbitMQ.Client;
using System.Text;

namespace Com.PlatformServices.Communication.Clients
{
    public class Messaging
    {
        ConnectionFactory factory = null;

        public Messaging()
        { 
            factory = new ConnectionFactory() { HostName = "localhost" };
        }

        public void FireEvent(string queueName, string message)
        {
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: queueName,
                                     durable: false,
                                     exclusive: false,
                                     autoDelete: false,
                                     arguments: null);

                var body = Encoding.UTF8.GetBytes(message);

                channel.BasicPublish(exchange: "",
                                     routingKey: queueName,
                                     basicProperties: null,
                                     body: body);
                Console.WriteLine(" [x] Sent {0}", message);
            }

        }
    }
}
