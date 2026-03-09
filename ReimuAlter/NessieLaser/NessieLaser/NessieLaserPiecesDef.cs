using LBoL.ConfigData;
using System;
using System.Collections.Generic;
using System.Text;
using TestMod.Source.Config;
using TestMod.Source.Guns.FinalGuns.Template;
using TestMod.Source.Guns.Pieces.Template;

namespace TestMod.Source.Guns.Pieces
{
    public sealed class NessieLaserPieceDef : TestModPiece
    {
        public override PieceConfig MakeConfig()
        {
            PieceConfig config = TestModDefaultConfig.DefaultPieceConfig();

            config.Id = ConvertGunId(90028);

            config.Projectile = "MonoRainbowLaserMain";

            config.Type = true;

            config.ShootType = 1;

            config.ParentPiece = 0;

            config.LastWave = true;

            config.HitAmount = 1;

            config.Scale = new float[][] { new float[] { 2f } };

            config.Color = new int[][] { new int[] { (int)BulletColor.SkyBlue } };

            config.RootType = 2;

            config.X = new float[][] { new float[] { -1f } };

            config.Y = new float[][] { new float[] { 6f } };

            config.RadiusA = new float[][] { new float[] { -80f } };

            config.Aim = 1;

            config.StartTime = 0;

            config.Life = new int[][] { new int[] { 85 } };

            config.EvStart = new int[][][] { new int[][] { new int[] { 10 } } };

            config.EvDuration = new int[][][] { new int[][] { new int[] { 85 } } };

            config.EvNumber = new float[][][] { new float[][] { new float[] { 66f } } };

            config.EvType = new int[][] { new int[] { (int)BulletEventType.Angle } };

            return config;
        }
    }
}
