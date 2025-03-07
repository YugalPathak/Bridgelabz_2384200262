using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RabbitMQ.Client.Events;
using RabbitMQ.Client;
using Newtonsoft.Json;
using ModelLayer.DTO;

namespace BusinessLayer.Service
{
    public class RabbitMQConsumer
    {
        private readonly EmailService _emailService;
        private readonly IConfiguration _configuration;

        public RabbitMQConsumer(EmailService emailService, IConfiguration configuration)
        {
            _emailService = emailService;
            _configuration = configuration;
        }

        public void StartListening()
        {
            var factory = new ConnectionFactory()
            {
                HostName = _configuration["RabbitMQ:Host"],
                UserName = _configuration["RabbitMQ:Username"],
                Password = _configuration["RabbitMQ:Password"]
            };

            var connection = factory.CreateConnection();
            var channel = connection.CreateModel();
            string queueName = _configuration["RabbitMQ:QueueName"];

            channel.QueueDeclare(queue: queueName, durable: false, exclusive: false, autoDelete: false, arguments: null);

            var consumer = new EventingBasicConsumer(channel);
            consumer.Received += (model, ea) =>
            {
                var body = ea.Body.ToArray();
                var message = Encoding.UTF8.GetString(body);
                var resetRequest = JsonConvert.DeserializeObject<MessageModel>(message);

                _emailService.SendResetEmail(resetRequest.Email, resetRequest.Token);
                Console.WriteLine($"Processed password reset request for: {resetRequest.Email}");
            };

            channel.BasicConsume(queue: queueName, autoAck: true, consumer: consumer);
            Console.WriteLine("RabbitMQ Consumer Started...");
        }
    }
}
