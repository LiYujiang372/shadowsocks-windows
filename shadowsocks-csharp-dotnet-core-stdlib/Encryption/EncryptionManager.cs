using System;
using System.Collections.Generic;
using System.Linq;

namespace Shadowsocks.Std.Encryption
{
    public static class EncryptionManager
    {
        internal static readonly Dictionary<string, CipherInfo> _encryptionParameters = new Dictionary<string, CipherInfo>();

        public static Encryptor CreateEncryptor(string method)
        {
            if (_encryptionParameters.TryGetValue(method, out CipherInfo parameters))
            {
                return new Encryptor();
            }
            else throw new ArgumentException("", nameof(method));
        }

        public static List<string> GetEncryptionNames() => _encryptionParameters.Keys.ToList();

        public static void RegisterParameters(string algorithm, Type type, CipherInfo parameters)
        {
            if (!name.IsNullOrEmpty())
            {
                

                _encryptionParameters.Add(name, parameters);
            }
        }

        public static void RegisterEncryption()
        {

        }
    }
}