using System;
using SimpleHttpServer.Enums;

namespace SimpleHttpServer.Models
{
    public class HttpRequest
    {
        public RequestMethod Method { get; set; }
        public string Url { get; set; }
        public Header Header { get; set; }
        public string Content { get; set; }

        public override string ToString()
        {
            return $"{this.Method} {this.Url} HTTP/1.0 {Environment.NewLine} {this.Header} {Environment.NewLine} {this.Content}";
        }
    }
}