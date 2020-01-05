using NLog;

using Shadowsocks.Std.Encryption.Parameters;

namespace Shadowsocks.Std.Encryption.AEAD
{
    internal class AESGCMEncryptor : AEADEncryptor
    {
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();

        public AESGCMEncryptor(AEADEncryptionParameters parameters) : base(parameters)
        {
        }
    }
}