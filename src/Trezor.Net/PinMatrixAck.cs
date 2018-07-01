﻿using ProtoBuf;

namespace Trezor
{
    [ProtoContract]
    public class PinMatrixAck
    {
        [ProtoMember(1, Name = @"pin", IsRequired = true)]
        public string Pin { get; set; }

    }
}