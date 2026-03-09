using LBoL.ConfigData;
using System;
using System.Collections.Generic;
using System.Text;
using TestMod.Source.Config;
using TestMod.Source.Guns.Pieces.Template;

namespace TestMod.Source.Guns.Pieces
{
    public sealed class NessieLaserPieceBDef : TestModPiece
    {
        public override PieceConfig MakeConfig()
        {
            PieceConfig config = TestModDefaultConfig.DefaultPieceConfig();

            config.Id = ConvertGunId(90029);

            config.Projectile = "MonoRainbowLaserMain";

            config.Type = true;

            config.ShootType = 1;

            config.ParentPiece = 0;

            config.LastWave = true;

            config.HitAmount = 0;

            config.Scale = new float[][] { new float[] { 9f } };

            config.Color = new int[][] { new int[] { (int)BulletColor.SkyBlue } };

            config.RootType = 2;

            config.X = new float[][] { new float[] { -1f } };

            config.Y = new float[][] { new float[] { 11.5f } };

            config.RadiusA = new float[][] { new float[] { -68f } };

            config.Aim = 1;

            config.StartTime = 0;

            config.Life = new int[][] { new int[] { 90 } };

            return config;
        }
    }
}
