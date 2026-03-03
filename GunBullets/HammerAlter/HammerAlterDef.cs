using LBoL.ConfigData;
using System;
using System.Collections.Generic;
using System.Text;
using TestMod.Source.Bullets.Template;
using TestMod.Source.Config;

namespace TestMod.Source.Bullets
{
    public sealed class HammerAlterDef : TestModBullet
    {
        public override BulletConfig MakeConfig()
        {
            BulletConfig config = TestModDefaultConfig.DefaultBulletConfig();

            config.Name = "HammerAlter";

            config.Widget = "Hammer";

            config.HitBody = "BoliFistHit";

            config.HitBodySfx = "NuclearbombHit";

            config.HitShield = "BoliFistHit";

            config.HitShieldSfx = "NuclearbombHit";

            config.HitBlock = "BoliFistHit";

            config.HitBlockSfx = "NuclearbombHit";

            return config;
        }
    }
}
