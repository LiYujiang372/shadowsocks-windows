using Shadowsocks.Std.Encryption.Parameters;

namespace Shadowsocks.Std.Encryption.AEAD
{
    internal abstract class AEADEncryptor : EncryptorBase<AEADEncryptionParameters>
    {
        protected AEADEncryptor(AEADEncryptionParameters parameters) : base(parameters)
        {
        }

        public override void Encrypt(byte[] inBuf, int inLength, byte[] outBuf, out int outLength)
        {
            throw new System.NotImplementedException();
        }

        public override void Decrypt(byte[] inBuf, int inLength, byte[] outBuf, out int outLength)
        {
            throw new System.NotImplementedException();
        }
    }
}