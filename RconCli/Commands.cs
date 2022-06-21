using System;
using System.Net.Sockets;
using CommandLine;
using Russlyman.Rcon;

public class Commands
{
    [Option('i', "ip", Required = true, HelpText = "IP Address")]
    public string IP { get; set; }

    [Option('p', "port", Required = true, HelpText = "Port")]
    public int Port { get; set; }

    [Option('x', "password", Required = true, HelpText = "RCon Password")]
    public string Password { get; set; }

    [Option('c', "command", Required = true, HelpText = "RCon Command")]
    public string Command { get; set; }

    public void SendRconCommand()
    {
        var rconClient = new RconClient();
        string reply;

        try
        {
            rconClient.Connect(IP, Port, Password);
            reply = rconClient.Send(Command);
        }
        catch (Exception exception)
        {
            string errorMessage = exception switch
            {
                FormatException => "Invalid IP or port format provided.",
                ArgumentException => "Invalid password format provided.",
                SocketException => "Server unreachable.",
                _ => exception.ToString()
            };

            Console.WriteLine(errorMessage);
            return;
        }

        Console.WriteLine(reply.Length == 0 ? "Server replied with nothing." : reply);
    }
}