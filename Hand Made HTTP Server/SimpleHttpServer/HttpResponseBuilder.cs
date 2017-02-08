using System.IO;
using SimpleHttpServer.Enums;

namespace SimpleHttpServer.Models
{
    
    public static class HttpResponseBuilder
    {
        public static HttpResponse InternalServerError()
        {
            string content = File.ReadAllText(@"C:\Users\Slav\Desktop\Hand Made HTTP Server\Hand Made HTTP Server\SimpleHttpServer\Resources\Pages\500.html");
            return new HttpResponse()
            {
                StatusCode = ResponseStatusCode.InternalServerError,
                ContentAsUTF8 = content
            };
        }

        public static HttpResponse NotFound()
        {
            string content = File.ReadAllText(@"C:\Users\Slav\Desktop\Hand Made HTTP Server\Hand Made HTTP Server\SimpleHttpServer\Resources\Pages\404.html");
            return new HttpResponse()
            {
                StatusCode = ResponseStatusCode.NotFound,
                ContentAsUTF8 = content
            };
        }
    }
}