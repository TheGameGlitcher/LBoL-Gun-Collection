using LBoL.ConfigData;
using System;
using System.Collections.Generic;
using System.Text;
using TestMod.Source.Config;
using TestMod.Source.Guns.Pieces.Template;

namespace TestMod.Source.Guns.Pieces.Yukari.BoundaryFracture
{
    public sealed class BoundaryFractureBPiece0Def : TestModPiece
    {
        public override PieceConfig MakeConfig()
        {
            PieceConfig config = TestModDefaultConfig.DefaultPieceConfig();

            config.Id = ConvertGunId(178009);

            config.Projectile = "EmptyCrack";

            config.LastWave = true;

            config.HitAmount = 1;

            config.RootType = 1;

            config.Scale = new float[][] { new float[] { 1f } };

            config.Color = new int[][] { new int[] { (int)BulletColor.Purple } };

            config.StartTime = 13;

            config.Group = 1;

            config.Way = new int[][] { new int[] { 1 } };

            config.Life = new int[][] { new int[] { 1 } };

            config.StartSpeed = new float[][] { new float[] { 0f } };

            return config;
        }
    }
}
