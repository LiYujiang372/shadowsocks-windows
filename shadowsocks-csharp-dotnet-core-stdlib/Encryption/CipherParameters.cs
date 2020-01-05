namespace Shadowsocks.Std.Encryption
{
    public abstract class CipherInfo
    {
        public string Algorithm { get; private set; }

        public int KeySize { get; private set; }

        public int Type { get; private set; }
    }
}