using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleHttpServer.Enums;
using SimpleHttpServer.Models;

namespace HelloHttpServer
{
    class Program
    {
        static void Main(string[] args)
        {
            var routes = new List<Route>()
            {
                new Route()
                {
                    Name = "Hello Handler",
                    UrlRegex = @"^/hello$",
                    Method = RequestMethod.GET,
                    Callable = (HttpRequest request) =>
                    {
                        return new HttpResponse()
                        {
                            Header = new Header(HeaderType.HttpResponse),
                            
                            ContentAsUTF8 = "<html>" +
                                            "<h3> Hello from HttpServer :) </h3>" +
                                            "</html",
                            StatusCode = ResponseStatusCode.Ok
                        };
                    }

                }
            };
            HttpServer server = new HttpServer(6969,routes);
            server.Listen();
        }
    }
}
