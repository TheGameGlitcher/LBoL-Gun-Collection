public static BulletConfig DefaultBulletConfig()
{
    return new BulletConfig(
        Name: "Empty",
        Widget: "",
        Launch: "FireCommon",
        LaunchSfx: "CommonLaunchLight",
        HitBody: "HitBodySmall",
        HitBodySfx: "CommonHitBody",
        HitShield: "HitShield",
        HitShieldSfx: "BulletHitShield",
        HitBlock: "HitBlock",
        HitBlockSfx: "BulletHitShield",
        Graze: "",
        GrazeSfx: "CommonGraze"
        );
}