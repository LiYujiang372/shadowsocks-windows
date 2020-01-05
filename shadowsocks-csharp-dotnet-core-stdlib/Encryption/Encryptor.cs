namespace Shadowsocks.Std.Encryption
{
    public class Encryptor
    {
        public readonly IEncryptorStrategy encryptorStrategy;

        public Encryptor(IEncryptorStrategy encryptorStrategy)
        {
            this.encryptorStrategy = encryptorStrategy;
        }

        void Decrypt(byte[] inBuf, int inLength, byte[] outBuf, out int outLength)
        {
            encryptorStrategy.Decrypt(inBuf, inLength, outBuf, out outLength);
        }

        void Encrypt(byte[] inBuf, int inLength, byte[] outBuf, out int outLength)
        {
            encryptorStrategy.Encrypt(inBuf, inLength, outBuf, out outLength);
        }
    }
}