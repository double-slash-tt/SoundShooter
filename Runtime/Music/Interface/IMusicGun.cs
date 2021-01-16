using UnityEngine;

namespace SoundShooter.Music
{
    public interface IMusicGun
    {
        void Setup();
        void Fire(IMusicAmmo ammo);
    }
}