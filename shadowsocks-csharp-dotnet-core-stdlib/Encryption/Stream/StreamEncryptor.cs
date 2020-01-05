using System;

using Shadowsocks.Std.Encryption.Parameters;

namespace Shadowsocks.Std.Encryption.Stream
{
    internal abstract class StreamEncryptor : EncryptorBase<StreamEncryptionParameters>
    {
        protected byte[] _encryptIV;
        protected byte[] _decryptIV;

        protected StreamEncryptor(StreamEncryptionParameters parameters) : base(parameters)
        {
            _encryptIV = new byte[parameters.IvLength];

            _random.NextBytes(_encryptIV);
        }

        public override void Decrypt(byte[] inBuf, int inLength, byte[] outBuf, out int outLength)
        {
            _decryptIV = new byte[Parameters.IvLength];
            Array.Copy(inBuf, _decryptIV, Parameters.IvLength);

            outLength = (inLength - Parameters.IvLength);
        }

        public override void Encrypt(byte[] inBuf, int inLength, byte[] outBuf, out int outLength)
        {
            throw new System.NotImplementedException();
        }
    }
}