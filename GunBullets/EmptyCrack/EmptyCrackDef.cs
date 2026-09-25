using LBoL.ConfigData;
using System;
using System.Collections.Generic;
using System.Text;
using TestMod.Source.Bullets.Template;
using TestMod.Source.Config;

namespace TestMod.Source.Bullets
{
    public sealed class EmptyCrackDef : TestModBullet
    {
        public override BulletConfig MakeConfig()
        {
            BulletConfig config = TestModDefaultConfig.DefaultBulletConfig();

            config.Name = "EmptyCrack";

            config.Widget = "Empty";

            config.LaunchSfx = "";

            config.HitBody = "BoliFistHit";

            config.HitBodySfx = "";

            config.HitShield = "BoliFistHit";

            config.HitShieldSfx = "";

            config.HitBlock = "BoliFistHit";

            config.HitBlockSfx = "";

            return config;
        }
    }
}
