﻿using System;
using Mirage;

namespace MirageGodot.Messages
{
    [NetworkMessage]
    public struct RpcMessage
    {
        public uint NetId;
        public int FunctionIndex;
        public ArraySegment<byte> Payload;
    }
}