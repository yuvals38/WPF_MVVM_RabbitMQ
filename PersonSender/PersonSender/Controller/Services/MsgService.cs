using Newtonsoft.Json;
using PersonSender.Models;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonSender.Controller.Services
{
    public class MsgService
    {
        ConnectionFactory factory;
        public MsgService()
        {
            factory = new ConnectionFactory() { HostName = "localhost" };
           
        }

        public void SendMsg(Person person)
        {
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: "person",
                                     durable: false,
                                     exclusive: false,
                                     autoDelete: false,
                                     arguments: null);

                string message = SerializePerson(person);
                var body = Encoding.UTF8.GetBytes(message);

                channel.BasicPublish(exchange: "",
                                     routingKey: "person",
                                     basicProperties: null,
                                     body: body);
                Console.WriteLine(" Sent " + message);
            }

            Console.WriteLine(" Press [enter] to exit.");
            Console.ReadLine();
        }
        private string SerializePerson(Person person)
        {
            string jsonText = JsonConvert.SerializeObject(person);
            return jsonText;
        }

    }


}
