﻿using MessageServiceNamespace;

namespace ChatClient
{
    public class Program
    {
        static void Main(string[] args)
        {
            MessageServiceClient messageServiceClient = new MessageServiceClient("http://localhost:5077", new HttpClient());
            var clientId = messageServiceClient.ConnectAsync("Test").Result;


            MessageClient messageClient = new MessageClient(clientId);


            while (true)
            {
                messageClient.SendMessageAsync(1002, "Hello, GeekBrains!");
                Console.ReadKey();
            }
        }
    }
}