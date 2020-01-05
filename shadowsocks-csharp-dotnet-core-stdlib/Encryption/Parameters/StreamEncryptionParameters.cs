namespace Shadowsocks.Std.Encryption.Parameters
{
    internal class StreamEncryptionParameters : CipherInfo
    {
        public int IvLength { get; private set; }
    }
}