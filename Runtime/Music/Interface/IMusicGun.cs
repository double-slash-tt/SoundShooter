using UnityEngine;

namespace SoundShooter.Music
{
    public interface IMusicGun
    {
        void Setup();
        (IMusicPlayback, IMusicShot) Fire(IMusicShooter shooter, IMusicAmmo ammo);
    }
}