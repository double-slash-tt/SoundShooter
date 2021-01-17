using System;
using UnityEngine;

namespace SoundShooter.Music
{
    public interface IMusicGun : IDisposable
    {
        void Setup();
        (IMusicPlayback, IMusicShot) Fire(IMusicShooter shooter, IMusicAmmo ammo);
    }
}