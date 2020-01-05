using Org.BouncyCastle.Security;

namespace Shadowsocks.Std.Encryption
{
    internal abstract class EncryptorBase<P> : IEncryptorStrategy where P : CipherInfo
    {
        protected readonly SecureRandom _random;

        protected P Parameters { get; private set; }

        protected EncryptorBase(P parameters)
        {
            Parameters = parameters;

            _random = new SecureRandom();
        }

        public abstract void Decrypt(byte[] inBuf, int inLength, byte[] outBuf, out int outLength);

        public abstract void Encrypt(byte[] inBuf, int inLength, byte[] outBuf, out int outLength);
    }
}