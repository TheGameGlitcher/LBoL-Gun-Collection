using LBoL.ConfigData;
using System;
using System.Collections.Generic;
using System.Text;
using TestMod.Source.Config;
using TestMod.Source.Guns.FinalGuns.Template;

namespace TestMod.Source.Guns.FinalGuns
{
    public sealed class DreamfiniteBDef : TestModGun
    {
        public override GunConfig MakeConfig()
        {
            GunConfig config = TestModDefaultConfig.DefaultGunConfig();

            config.Id = 90025;

            config.Name = "DreamfiniteB";

            config.ForceHitTime = 0.8f;

            return config;
        }
    }
}
