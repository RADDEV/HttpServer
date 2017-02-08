using System;
using System.Text;
using SimpleHttpServer.Enums;

namespace SimpleHttpServer.Models
{
    public class HttpResponse
    {
        public HttpResponse()
        {
            this.Header = new Header(HeaderType.HttpResponse);
        }
        public ResponseStatusCode StatusCode { get; set; }

        public string StatusMessage
        {
            get
            {
                return Enum.GetName(typeof(ResponseStatusCode), this.StatusCode);
            }
        }

        public Header Header { get; set; }

        public Byte[] Content { get; set; }

        public string ContentAsUTF8
        {
            set
            {
                this.Content = Encoding.UTF8.GetBytes(value);
            }
        }
        
        public override string ToString()
        {
            return $"HTTP/1.0 {this.StatusCode} {this.StatusMessage} {Environment.NewLine} {this.Header}";
        }
    }
}