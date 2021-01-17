using System;
using UnityEngine;

namespace SoundShooter.Music
{
    public interface IMusicShot : IDisposable
    {
        bool IsCompleted { get; }

        void OnUpdate(float dt);
    }
}