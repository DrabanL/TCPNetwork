﻿using System.Net.Sockets;

namespace RabanSoft.SocketNetwork.Example.Server {
    /// <summary>
    /// Extends <see cref="SocketClient"/> and implements chat member properties.
    /// </summary>
    internal class ChatMember : SocketClient {
        public string Name;

        /// <summary>
        /// Initialize the object with existing connected Socket.
        /// </summary>
        public ChatMember(Socket socket) : base(socket) { }
    }
}
