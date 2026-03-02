using LBoL.ConfigData;
using System;
using System.Collections.Generic;
using System.Text;
using TestMod.Source.Config;
using TestMod.Source.Guns.FinalGuns.Template;

namespace TestMod.Source.Guns.FinalGuns
{
    public sealed class PurifyingStrikeDef : TestModGun
    {
        public override GunConfig MakeConfig()
        {
            GunConfig config = TestModDefaultConfig.DefaultGunConfig();

            config.Id = 90012;

            config.Name = "PurifyingStrike";

            return config;
        }
    }
}
