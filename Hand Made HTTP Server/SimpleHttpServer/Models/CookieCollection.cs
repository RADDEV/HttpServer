using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;

namespace SimpleHttpServer.Models
{
    public class CookieCollection : IEnumerable<Cookie>
    {
        public CookieCollection()
        {
            this.Cookies = new Dictionary<string, Cookie>(); 

        }
        public IEnumerator<Cookie> GetEnumerator()
        {
            return this.Cookies.Values.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public Dictionary<string,Cookie> Cookies { get; private set; }

        public int Count { get { return this.Cookies.Count; } }

        public bool Contains(string cookieName)
        {
            if (Cookies.ContainsKey(cookieName))
            {
                return true;
            }
            return false;
        }

        public void Add(Cookie cookie)
        {
            Cookies.Add(cookie.Name,cookie);
        }

        public Cookie this[string cookieName]
        {
            get { return this.Cookies[cookieName]; }
            set { this.Add(value); }
        }

        public override string ToString()
        {
            return string.Join("; ", Cookies.Values);
        }
    }
}