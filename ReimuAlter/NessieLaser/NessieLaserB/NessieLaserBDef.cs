using LBoL.ConfigData;
using System;
using System.Collections.Generic;
using System.Text;
using TestMod.Source.Config;
using TestMod.Source.Guns.FinalGuns.Template;

namespace TestMod.Source.Guns.FinalGuns
{
    public sealed class NessieLaserBDef : TestModGun
    {
        public override GunConfig MakeConfig()
        {
            GunConfig config = TestModDefaultConfig.DefaultGunConfig();

            config.Id = 90029;

            config.Name = "NessieLaserB";

            config.ForceHitTime = 1.6667f;

            config.ForceHitAnimation = true;

            return config;
        }
    }
}
