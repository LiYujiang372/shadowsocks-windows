using System;
using System.Collections.Generic;
using System.Linq;
using Shadowsocks.Std.Encryption;
using Shadowsocks.Std.Sys;
using Shadowsocks.Std.Util;

namespace Shadowsocks.Std.Model
{
    public class ShadowsocksContext
    {
        public string[] runArgs { get; private set; }

        public IApplication application { get; private set; }

        public IAutoStartup autoStartup { get; private set; }

        public IDelegatesInit delegatesInit { get; private set; }

        static ShadowsocksContext()
        {
            var i18n = new List<IGetI18N>(AppDomain.CurrentDomain.GetAssemblies().SelectMany(a => a.GetTypes().Where(t => t.GetInterfaces().Contains(typeof(IGetI18N)))).Cast<IGetI18N>())
            {
                new StdI18N(),
                new ExternalI18N()
            };

            I18N.Init(i18n);
        }
    }
}