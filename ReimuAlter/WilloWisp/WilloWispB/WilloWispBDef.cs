using LBoL.ConfigData;
using System;
using System.Collections.Generic;
using System.Text;
using TestMod.Source.Config;
using TestMod.Source.Guns.FinalGuns.Template;

namespace TestMod.Source.Guns.FinalGuns
{
    public sealed class WilloWispBDef : TestModGun
    {
        public override GunConfig MakeConfig()
        {
            GunConfig config = TestModDefaultConfig.DefaultGunConfig();

            config.Id = 90015;

            config.Name = "WilloWispB";

            return config;
        }
    }
}
