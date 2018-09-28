// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: messages-monero.proto

#pragma warning disable CS1591, CS0612, CS3021, IDE1006
namespace Trezor.Net.Contracts.Monero
{

    [ProtoBuf.ProtoContract()]
    public class MoneroTransactionSourceEntry : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"outputs")]
        public System.Collections.Generic.List<MoneroOutputEntry> Outputs { get; } = new System.Collections.Generic.List<MoneroOutputEntry>();

        [ProtoBuf.ProtoMember(2, Name = @"real_output")]
        public ulong RealOutput
        {
            get { return __pbn__RealOutput.GetValueOrDefault(); }
            set { __pbn__RealOutput = value; }
        }
        public bool ShouldSerializeRealOutput() => __pbn__RealOutput != null;
        public void ResetRealOutput() => __pbn__RealOutput = null;
        private ulong? __pbn__RealOutput;

        [ProtoBuf.ProtoMember(3, Name = @"real_out_tx_key")]
        public byte[] RealOutTxKey { get; set; }
        public bool ShouldSerializeRealOutTxKey() => RealOutTxKey != null;
        public void ResetRealOutTxKey() => RealOutTxKey = null;

        [ProtoBuf.ProtoMember(4, Name = @"real_out_additional_tx_keys")]
        public System.Collections.Generic.List<byte[]> RealOutAdditionalTxKeys { get; } = new System.Collections.Generic.List<byte[]>();

        [ProtoBuf.ProtoMember(5, Name = @"real_output_in_tx_index")]
        public ulong RealOutputInTxIndex
        {
            get { return __pbn__RealOutputInTxIndex.GetValueOrDefault(); }
            set { __pbn__RealOutputInTxIndex = value; }
        }
        public bool ShouldSerializeRealOutputInTxIndex() => __pbn__RealOutputInTxIndex != null;
        public void ResetRealOutputInTxIndex() => __pbn__RealOutputInTxIndex = null;
        private ulong? __pbn__RealOutputInTxIndex;

        [ProtoBuf.ProtoMember(6, Name = @"amount")]
        public ulong Amount
        {
            get { return __pbn__Amount.GetValueOrDefault(); }
            set { __pbn__Amount = value; }
        }
        public bool ShouldSerializeAmount() => __pbn__Amount != null;
        public void ResetAmount() => __pbn__Amount = null;
        private ulong? __pbn__Amount;

        [ProtoBuf.ProtoMember(7, Name = @"rct")]
        public bool Rct
        {
            get { return __pbn__Rct.GetValueOrDefault(); }
            set { __pbn__Rct = value; }
        }
        public bool ShouldSerializeRct() => __pbn__Rct != null;
        public void ResetRct() => __pbn__Rct = null;
        private bool? __pbn__Rct;

        [ProtoBuf.ProtoMember(8, Name = @"mask")]
        public byte[] Mask { get; set; }
        public bool ShouldSerializeMask() => Mask != null;
        public void ResetMask() => Mask = null;

        [ProtoBuf.ProtoMember(9, Name = @"multisig_kLRki")]
        public MoneroMultisigKLRki multisigkLRki { get; set; }

        [ProtoBuf.ProtoContract()]
        public class MoneroOutputEntry : ProtoBuf.IExtensible
        {
            private ProtoBuf.IExtension __pbn__extensionData;
            ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [ProtoBuf.ProtoMember(1, Name = @"idx")]
            public ulong Idx
            {
                get { return __pbn__Idx.GetValueOrDefault(); }
                set { __pbn__Idx = value; }
            }
            public bool ShouldSerializeIdx() => __pbn__Idx != null;
            public void ResetIdx() => __pbn__Idx = null;
            private ulong? __pbn__Idx;

            [ProtoBuf.ProtoMember(2, Name = @"key")]
            public MoneroRctKey Key { get; set; }

            [ProtoBuf.ProtoContract()]
            public class MoneroRctKey : ProtoBuf.IExtensible
            {
                private ProtoBuf.IExtension __pbn__extensionData;
                ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                    => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

                [ProtoBuf.ProtoMember(1, Name = @"dest")]
                public byte[] Dest { get; set; }
                public bool ShouldSerializeDest() => Dest != null;
                public void ResetDest() => Dest = null;

                [ProtoBuf.ProtoMember(2, Name = @"mask")]
                public byte[] Mask { get; set; }
                public bool ShouldSerializeMask() => Mask != null;
                public void ResetMask() => Mask = null;
            }

        }

        [ProtoBuf.ProtoContract()]
        public class MoneroMultisigKLRki : ProtoBuf.IExtensible
        {
            private ProtoBuf.IExtension __pbn__extensionData;
            ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [ProtoBuf.ProtoMember(1)]
            public byte[] K { get; set; }
            public bool ShouldSerializeK() => K != null;
            public void ResetK() => K = null;

            [ProtoBuf.ProtoMember(2)]
            public byte[] L { get; set; }
            public bool ShouldSerializeL() => L != null;
            public void ResetL() => L = null;

            [ProtoBuf.ProtoMember(3)]
            public byte[] R { get; set; }
            public bool ShouldSerializeR() => R != null;
            public void ResetR() => R = null;

            [ProtoBuf.ProtoMember(4, Name = @"ki")]
            public byte[] Ki { get; set; }
            public bool ShouldSerializeKi() => Ki != null;
            public void ResetKi() => Ki = null;
        }

    }
}

#pragma warning restore CS1591, CS0612, CS3021, IDE1006
