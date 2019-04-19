// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: messages-common.proto

#pragma warning disable 
namespace Trezor.Net.Contracts.Common
{

    [global::ProtoBuf.ProtoContract()]
    public partial class Success : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"message")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Message
        {
            get { return __pbn__Message ?? ""; }
            set { __pbn__Message = value; }
        }
        public bool ShouldSerializeMessage() => __pbn__Message != null;
        public void ResetMessage() => __pbn__Message = null;
        private string __pbn__Message;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Failure : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"code")]
        [global::System.ComponentModel.DefaultValue(FailureType.FailureUnexpectedMessage)]
        public FailureType Code
        {
            get { return __pbn__Code ?? FailureType.FailureUnexpectedMessage; }
            set { __pbn__Code = value; }
        }
        public bool ShouldSerializeCode() => __pbn__Code != null;
        public void ResetCode() => __pbn__Code = null;
        private FailureType? __pbn__Code;

        [global::ProtoBuf.ProtoMember(2, Name = @"message")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Message
        {
            get { return __pbn__Message ?? ""; }
            set { __pbn__Message = value; }
        }
        public bool ShouldSerializeMessage() => __pbn__Message != null;
        public void ResetMessage() => __pbn__Message = null;
        private string __pbn__Message;

        [global::ProtoBuf.ProtoContract()]
        public enum FailureType
        {
            [global::ProtoBuf.ProtoEnum(Name = @"Failure_UnexpectedMessage")]
            FailureUnexpectedMessage = 1,
            [global::ProtoBuf.ProtoEnum(Name = @"Failure_ButtonExpected")]
            FailureButtonExpected = 2,
            [global::ProtoBuf.ProtoEnum(Name = @"Failure_DataError")]
            FailureDataError = 3,
            [global::ProtoBuf.ProtoEnum(Name = @"Failure_ActionCancelled")]
            FailureActionCancelled = 4,
            [global::ProtoBuf.ProtoEnum(Name = @"Failure_PinExpected")]
            FailurePinExpected = 5,
            [global::ProtoBuf.ProtoEnum(Name = @"Failure_PinCancelled")]
            FailurePinCancelled = 6,
            [global::ProtoBuf.ProtoEnum(Name = @"Failure_PinInvalid")]
            FailurePinInvalid = 7,
            [global::ProtoBuf.ProtoEnum(Name = @"Failure_InvalidSignature")]
            FailureInvalidSignature = 8,
            [global::ProtoBuf.ProtoEnum(Name = @"Failure_ProcessError")]
            FailureProcessError = 9,
            [global::ProtoBuf.ProtoEnum(Name = @"Failure_NotEnoughFunds")]
            FailureNotEnoughFunds = 10,
            [global::ProtoBuf.ProtoEnum(Name = @"Failure_NotInitialized")]
            FailureNotInitialized = 11,
            [global::ProtoBuf.ProtoEnum(Name = @"Failure_PinMismatch")]
            FailurePinMismatch = 12,
            [global::ProtoBuf.ProtoEnum(Name = @"Failure_FirmwareError")]
            FailureFirmwareError = 99,
        }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ButtonRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"code")]
        [global::System.ComponentModel.DefaultValue(ButtonRequestType.ButtonRequestOther)]
        public ButtonRequestType Code
        {
            get { return __pbn__Code ?? ButtonRequestType.ButtonRequestOther; }
            set { __pbn__Code = value; }
        }
        public bool ShouldSerializeCode() => __pbn__Code != null;
        public void ResetCode() => __pbn__Code = null;
        private ButtonRequestType? __pbn__Code;

        [global::ProtoBuf.ProtoMember(2, Name = @"data")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Data
        {
            get { return __pbn__Data ?? ""; }
            set { __pbn__Data = value; }
        }
        public bool ShouldSerializeData() => __pbn__Data != null;
        public void ResetData() => __pbn__Data = null;
        private string __pbn__Data;

        [global::ProtoBuf.ProtoContract()]
        public enum ButtonRequestType
        {
            [global::ProtoBuf.ProtoEnum(Name = @"ButtonRequest_Other")]
            ButtonRequestOther = 1,
            [global::ProtoBuf.ProtoEnum(Name = @"ButtonRequest_FeeOverThreshold")]
            ButtonRequestFeeOverThreshold = 2,
            [global::ProtoBuf.ProtoEnum(Name = @"ButtonRequest_ConfirmOutput")]
            ButtonRequestConfirmOutput = 3,
            [global::ProtoBuf.ProtoEnum(Name = @"ButtonRequest_ResetDevice")]
            ButtonRequestResetDevice = 4,
            [global::ProtoBuf.ProtoEnum(Name = @"ButtonRequest_ConfirmWord")]
            ButtonRequestConfirmWord = 5,
            [global::ProtoBuf.ProtoEnum(Name = @"ButtonRequest_WipeDevice")]
            ButtonRequestWipeDevice = 6,
            [global::ProtoBuf.ProtoEnum(Name = @"ButtonRequest_ProtectCall")]
            ButtonRequestProtectCall = 7,
            [global::ProtoBuf.ProtoEnum(Name = @"ButtonRequest_SignTx")]
            ButtonRequestSignTx = 8,
            [global::ProtoBuf.ProtoEnum(Name = @"ButtonRequest_FirmwareCheck")]
            ButtonRequestFirmwareCheck = 9,
            [global::ProtoBuf.ProtoEnum(Name = @"ButtonRequest_Address")]
            ButtonRequestAddress = 10,
            [global::ProtoBuf.ProtoEnum(Name = @"ButtonRequest_PublicKey")]
            ButtonRequestPublicKey = 11,
            [global::ProtoBuf.ProtoEnum(Name = @"ButtonRequest_MnemonicWordCount")]
            ButtonRequestMnemonicWordCount = 12,
            [global::ProtoBuf.ProtoEnum(Name = @"ButtonRequest_MnemonicInput")]
            ButtonRequestMnemonicInput = 13,
            [global::ProtoBuf.ProtoEnum(Name = @"ButtonRequest_PassphraseType")]
            ButtonRequestPassphraseType = 14,
            [global::ProtoBuf.ProtoEnum(Name = @"ButtonRequest_UnknownDerivationPath")]
            ButtonRequestUnknownDerivationPath = 15,
        }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ButtonAck : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class PinMatrixRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"type")]
        [global::System.ComponentModel.DefaultValue(PinMatrixRequestType.PinMatrixRequestTypeCurrent)]
        public PinMatrixRequestType Type
        {
            get { return __pbn__Type ?? PinMatrixRequestType.PinMatrixRequestTypeCurrent; }
            set { __pbn__Type = value; }
        }
        public bool ShouldSerializeType() => __pbn__Type != null;
        public void ResetType() => __pbn__Type = null;
        private PinMatrixRequestType? __pbn__Type;

        [global::ProtoBuf.ProtoContract()]
        public enum PinMatrixRequestType
        {
            [global::ProtoBuf.ProtoEnum(Name = @"PinMatrixRequestType_Current")]
            PinMatrixRequestTypeCurrent = 1,
            [global::ProtoBuf.ProtoEnum(Name = @"PinMatrixRequestType_NewFirst")]
            PinMatrixRequestTypeNewFirst = 2,
            [global::ProtoBuf.ProtoEnum(Name = @"PinMatrixRequestType_NewSecond")]
            PinMatrixRequestTypeNewSecond = 3,
        }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class PinMatrixAck : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"pin", IsRequired = true)]
        public string Pin { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class PassphraseRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"on_device")]
        public bool OnDevice
        {
            get { return __pbn__OnDevice.GetValueOrDefault(); }
            set { __pbn__OnDevice = value; }
        }
        public bool ShouldSerializeOnDevice() => __pbn__OnDevice != null;
        public void ResetOnDevice() => __pbn__OnDevice = null;
        private bool? __pbn__OnDevice;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class PassphraseAck : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"passphrase")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Passphrase
        {
            get { return __pbn__Passphrase ?? ""; }
            set { __pbn__Passphrase = value; }
        }
        public bool ShouldSerializePassphrase() => __pbn__Passphrase != null;
        public void ResetPassphrase() => __pbn__Passphrase = null;
        private string __pbn__Passphrase;

        [global::ProtoBuf.ProtoMember(2, Name = @"state")]
        public byte[] State
        {
            get { return __pbn__State; }
            set { __pbn__State = value; }
        }
        public bool ShouldSerializeState() => __pbn__State != null;
        public void ResetState() => __pbn__State = null;
        private byte[] __pbn__State;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class PassphraseStateRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"state")]
        public byte[] State
        {
            get { return __pbn__State; }
            set { __pbn__State = value; }
        }
        public bool ShouldSerializeState() => __pbn__State != null;
        public void ResetState() => __pbn__State = null;
        private byte[] __pbn__State;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class PassphraseStateAck : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class HDNodeType : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"depth", IsRequired = true)]
        public uint Depth { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"fingerprint", IsRequired = true)]
        public uint Fingerprint { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"child_num", IsRequired = true)]
        public uint ChildNum { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"chain_code", IsRequired = true)]
        public byte[] ChainCode { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"private_key")]
        public byte[] PrivateKey
        {
            get { return __pbn__PrivateKey; }
            set { __pbn__PrivateKey = value; }
        }
        public bool ShouldSerializePrivateKey() => __pbn__PrivateKey != null;
        public void ResetPrivateKey() => __pbn__PrivateKey = null;
        private byte[] __pbn__PrivateKey;

        [global::ProtoBuf.ProtoMember(6, Name = @"public_key")]
        public byte[] PublicKey
        {
            get { return __pbn__PublicKey; }
            set { __pbn__PublicKey = value; }
        }
        public bool ShouldSerializePublicKey() => __pbn__PublicKey != null;
        public void ResetPublicKey() => __pbn__PublicKey = null;
        private byte[] __pbn__PublicKey;

    }

}

#pragma warning restore