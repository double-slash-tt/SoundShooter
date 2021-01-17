using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SoundShooter.Music
{
    public interface IMusicPlayer : IDisposable
    {
        IReadOnlyList<IMusicPlayback> PlayList { get; }

        void OnUpdate(float dt);
        void Play(IMusicAmmo ammo);
        void Push(IMusicAmmo ammo);
        void Pop();
        void Stop();
    }
}