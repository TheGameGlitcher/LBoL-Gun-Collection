using LBoL.ConfigData;
using System;
using System.Collections.Generic;
using System.Text;
using TestMod.Source.Config;
using TestMod.Source.Guns.FinalGuns.Template;

namespace TestMod.Source.Guns.FinalGuns.PrintedGun
{
    public sealed class PrintedGun6Def : TestModGun
    {
        public override GunConfig MakeConfig()
        {
            GunConfig config = TestModDefaultConfig.DefaultGunConfig();

            config.Id = 90022;

            config.Name = "PrintedGun6";

            return config;
        }
    }
}
