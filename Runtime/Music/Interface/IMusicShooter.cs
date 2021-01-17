using System.Collections.Generic;
using UnityEngine;

namespace SoundShooter.Music
{
    public interface IMusicShooter : ISoundShooter
    {
        IReadOnlyList<IMusicPlayback> PlayList { get; }

        void Fire(IMusicAmmo ammo);
        void Pop();
        void Push(IMusicAmmo ammo);
    }
}