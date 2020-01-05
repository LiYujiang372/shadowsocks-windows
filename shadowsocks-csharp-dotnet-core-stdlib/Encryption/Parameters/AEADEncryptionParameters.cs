namespace Shadowsocks.Std.Encryption.Parameters
{
    internal class AEADEncryptionParameters : CipherInfo
    {
        public int SaltSize { get; private set; }

        public int NonceSize { get; private set; }

        public int TagSize { get; private set; }
    }
}