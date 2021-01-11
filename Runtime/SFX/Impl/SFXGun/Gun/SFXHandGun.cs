using UnityEngine;

namespace SoundShooter.SFX.Impl
{
    /// <summary>
    /// 単発で撃つタイプ
    /// </summary>
    [CreateAssetMenu(menuName = nameof(SoundShooter) + "/" + nameof(SFX) + "/" + nameof(SFXGun) + "/" + nameof(SFXGun) + "/" + nameof(SFXHandGun))]
    public sealed class SFXHandGun : SFXGun
    {
        //==================================
        // Method
        //==================================
        protected override void DoFire(ISFXShooter shooter, ISFXAmmo ammo)
        {
            var playback = Shot(ammo);
            shooter.Shot(playback);
        }
    }
}