/*Write a program that parses an URL address and extracts from it the [protocol], [server] and [resource] elements.
For example from the URL http://www.devbg.org/forum/index.php the following information should be extracted:
		[protocol] = "http"
		[server] = "www.devbg.org"
		[resource] = "/forum/index.php"*/
using System;

namespace ParseURL
{
    class ParseURL
    {
        static void Main()
        {
            Console.WriteLine("This program will parse an URL address and extract from it the protocol, server and resource elements.");
            string url = "http://www.devbg.org/forum/index.php";
            string protocolSeparator = "://";
            string serverSeparator = "/";

            int indexProtocol = url.IndexOf(protocolSeparator);
            int indexServer = url.IndexOf(serverSeparator, indexProtocol + protocolSeparator.Length);

            string protocol = url.Substring(0, indexProtocol);
            int length = indexServer - indexProtocol - protocolSeparator.Length;
            string server = url.Substring(indexProtocol + protocolSeparator.Length, length);
            string resource = url.Substring(indexServer);

            Console.WriteLine("URL is:\n{0}\n", url);
            Console.WriteLine("[protocol] = {0}", protocol);
            Console.WriteLine("[server] = {0}", server);
            Console.WriteLine("[resource] = {0}", resource);

        }
    }
}
