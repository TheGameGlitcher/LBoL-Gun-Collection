using LBoL.ConfigData;
using System;
using System.Collections.Generic;
using System.Text;
using TestMod.Source.Config;
using TestMod.Source.Guns.FinalGuns.Template;

namespace TestMod.Source.Guns.FinalGuns.PrintedGun
{
    public sealed class PrintedGun4Def : TestModGun
    {
        public override GunConfig MakeConfig()
        {
            GunConfig config = TestModDefaultConfig.DefaultGunConfig();

            config.Id = 90020;

            config.Name = "PrintedGun4";

            return config;
        }
    }
}
