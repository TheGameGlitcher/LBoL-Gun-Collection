using LBoL.ConfigData;
using System;
using System.Collections.Generic;
using System.Text;
using TestMod.Source.Config;
using TestMod.Source.Guns.Pieces.Template;

namespace TestMod.Source.Guns.Pieces.PrintedGunPieces
{
    public sealed class PrintedGun0PieceDef : TestModPiece
    {
        public override PieceConfig MakeConfig()
        {
            PieceConfig config = TestModDefaultConfig.DefaultPieceConfig();

            config.Id = ConvertGunId(90016);

            config.Projectile = "DanmaBigBullet";

            config.Type = false;

            config.ShootType = 1;

            config.LastWave = true;

            config.ZeroHitNotDie = false;

            config.Scale = new float[][] { new float[] { 1.6f } };

            config.Color = new int[][] { new int[] { (int)BulletColor.Grayscale } };

            config.Way = new int[][] { new int[] { 1 } };

            config.Aim = 0;

            config.StartTime = 0;

            config.Group = 1;

            config.StartSpeed = new float[][] { new float[] { 40f } };

            config.Life = new int[][] { new int[] { 30 } };

            config.LaunchSfx = "SumirekoGunShoot";

            config.HitBodySfx = "CommonHitBody";

            return config;
        }
    }
}
