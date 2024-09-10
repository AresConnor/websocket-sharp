using System;
using WebSocketSharp.Net;

namespace WebSocketSharp.Server
{
    public class WebSocketRequestEventArgs : EventArgs
    {
        public HttpListenerContext Context { get; private set; }

        internal WebSocketRequestEventArgs(HttpListenerContext context)
        {
            Context = context;
        }
    }
}