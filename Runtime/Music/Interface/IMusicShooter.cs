using System.Collections.Generic;
using UnityEngine;

namespace SoundShooter.Music
{
    public interface IMusicShooter : ISoundShooter
    {
        void Fire(IMusicGun gun, IMusicAmmo ammo);
        void Pop(IMusicGun gun);
        void Push(IMusicGun gun, IMusicAmmo ammo);
        void Stop(IMusicGun gun);
    }
}