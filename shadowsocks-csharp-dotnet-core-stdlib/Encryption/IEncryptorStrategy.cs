namespace Shadowsocks.Std.Encryption
{
    public interface IEncryptorStrategy
    {
        void Decrypt(byte[] inBuf, int inLength, byte[] outBuf, out int outLength);

        void Encrypt(byte[] inBuf, int inLength, byte[] outBuf, out int outLength);
    }
}