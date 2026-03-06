using LBoL.ConfigData;
using System;
using System.Collections.Generic;
using System.Text;
using TestMod.Source.Bullets.Template;
using TestMod.Source.Config;

namespace TestMod.Source.Bullets
{
    public sealed class HammerSfxAlterDef : TestModBullet
    {
        public override BulletConfig MakeConfig()
        {
            BulletConfig config = TestModDefaultConfig.DefaultBulletConfig();

            config.Name = "HammerSfxAlter";

            config.Widget = "Hammer";

            config.HitBody = "HitNuclearbomb";

            config.HitBodySfx = "NuclearbombHit";

            config.HitShield = "HitNuclearbomb";

            config.HitShieldSfx = "NuclearbombHit";

            config.HitBlock = "HitNuclearbomb";

            config.HitBlockSfx = "NuclearbombHit";

            return config;
        }
    }
}
