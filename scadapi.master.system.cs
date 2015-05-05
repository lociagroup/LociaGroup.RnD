using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace scadapi.master
{
    class system
    {
        // Bootstrap on each platform
        
        // Configuration for the platform 
    
    }
    
    class boostrap 
    {
        //load the role of the machine
        //is it an object server?
        //what is the IO server information?
        //is it a historian?
        //is it the main system?
        //redundancy mapping and star topology
    }
    
    
    
    class deviceio
    {
        //drivers for all IO
        //list of available IO's
    }
    
    class dictionary
    {
        //rabbitmq
        
        //add tags to the dictionary
    
        //wich adds the 
    
        
        class Send
        {
            public static void Main()
            {
                var factory = new ConnectionFactory() { HostName = "localhost" };
                using (var connection = factory.CreateConnection())
                {
                    using (var channel = connection.CreateModel())
                    {
                        channel.QueueDeclare("hello", false, false, false, null);
        
                        string message = "Hello World!";
                        var body = Encoding.UTF8.GetBytes(message);
        
                        channel.BasicPublish("", "hello", null, body);
                        Console.WriteLine(" [x] Sent {0}", message);
                    }
                }
            }
        }
    
        class Receive
        {
            public static void Main()
            {
                var factory = new ConnectionFactory() { HostName = "localhost" };
                using (var connection = factory.CreateConnection())
                {
                    using (var channel = connection.CreateModel())
                    {
                        channel.QueueDeclare("hello", false, false, false, null);
        
                        var consumer = new QueueingBasicConsumer(channel);
                        channel.BasicConsume("hello", true, consumer);
        
                        Console.WriteLine(" [*] Waiting for messages." +
                                                 "To exit press CTRL+C");
                        while (true)
                        {
                            var ea = (BasicDeliverEventArgs)consumer.Queue.Dequeue();
        
                            var body = ea.Body;
                            var message = Encoding.UTF8.GetString(body);
                            Console.WriteLine(" [x] Received {0}", message);
                        }
                    }
                }
            }
        }
        
    }
    
    
    
}
