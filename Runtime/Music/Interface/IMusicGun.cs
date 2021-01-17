using System;
using UnityEngine;

namespace SoundShooter.Music
{
    public interface IMusicGun : IDisposable
    {
        void Setup();
        IMusicPlayback Fire(IMusicAmmo ammo);
        IMusicShot Shot(IMusicPlayer player, IMusicPlayback playback);
    }
}