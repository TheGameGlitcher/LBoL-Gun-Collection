using LBoL.ConfigData;
using System;
using System.Collections.Generic;
using System.Text;
using TestMod.Source.Config;
using TestMod.Source.Guns.Pieces.Template;

namespace TestMod.Source.Guns.Pieces
{
    public sealed class MercilessRodFriendBOriginPieceDef : TestModPiece
    {
        public override PieceConfig MakeConfig()
        {
            PieceConfig config = TestModDefaultConfig.DefaultPieceConfig();

            config.Id = ConvertGunId(90027);

            config.Projectile = "DanmaRice";

            config.Type = false;

            config.ShootType = 1;

            config.LastWave = false;

            config.RootType = 1;

            config.Radius = new float[][] { new float[] { 15 } };

            config.RadiusA = new float[][] { new float[] { 180f } };

            config.Aim = 0;

            config.StartTime = 0;

            config.Group = 1;

            config.Way = new int[][] { new int[] { 1 } };

            config.GAngle = new float[][] { new float[] { 0f, 360f } };

            config.Range = new float[][] { new float[] { 360f } };

            config.Life = new int[][] { new int[] { 30 } };

            config.StartSpeed = new float[][] { new float[] { 0.1f } };

            return config;
        }
    }

    public sealed class MercilessRodFriendBPiece0Def : TestModPiece
    {
        public override PieceConfig MakeConfig()
        {
            PieceConfig config = TestModDefaultConfig.DefaultPieceConfig();

            config.Id = ConvertGunId(90027, 1);

            config.Projectile = "Hammer";

            config.Type = false;

            config.ShootType = 2;

            config.ParentPiece = 0;

            config.LastWave = true;

            config.ZeroHitNotDie = true;

            config.Color = new int[][] { new int[] { (int)BulletColor.Red } };

            config.Aim = 4;

            config.StartTime = 2;

            config.GInterval = 0;

            config.Group = 1;

            config.Way = new int[][] { new int[] { 1 } };

            config.StartSpeed = new float[][] { new float[] { 45f }, new float[] { 9f } };

            config.LaunchSfx = "CommonLaunchLight";

            config.HitBodySfx = "NuclearbombHit";

            return config;
        }
    }

    public sealed class MercilessRodFriendBVFXPieceDef : TestModPiece
    {
        public override PieceConfig MakeConfig()
        {
            PieceConfig config = TestModDefaultConfig.DefaultPieceConfig();

            config.Id = ConvertGunId(90027, 2);

            config.Projectile = "LineTimeStop";

            config.Type = true;

            config.ShootType = 2;

            config.ParentPiece = 0;

            config.LastWave = false;

            config.HitAmount = 0;

            config.Scale = new float[][] { new float[] { 0.77f } };

            config.Aim = 4;

            config.StartTime = 2;

            config.GInterval = 0;

            config.Group = 1;

            config.Way = new int[][] { new int[] { 1 } };

            config.Life = new int[][] { new int[] { 40 } };

            return config;
        }
    }
}
