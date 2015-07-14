﻿using ProtoBuf;
using xClient.Core.Networking;

namespace xClient.Core.Packets.ClientPackets
{
    [ProtoContract]
    public class SetUserStatus : IPacket
    {
        [ProtoMember(1)]
        public string Message { get; set; }

        public SetUserStatus()
        {
        }

        public SetUserStatus(string message)
        {
            Message = message;
        }

        public void Execute(Client client)
        {
            client.Send(this);
        }
    }
}