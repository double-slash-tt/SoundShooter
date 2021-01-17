using System;
using UnityEngine;

namespace SoundShooter.Music
{
    public interface IMusicPlayback : IDisposable
    {
        bool IsPlaying { get; }
        bool IsDisposed { get; }
        float Volume { get; }

        void OnUpdate(float dt);
        void SetVolume(float v);
        void Play();
        void Stop();
    }
}