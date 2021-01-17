using UnityEngine;

namespace SoundShooter.Music
{
    public abstract class MusicPlayback : IMusicPlayback
    {
        //=====================================
        // Property
        //=====================================
        public abstract bool IsPlaying { get; }
        public abstract float Volume { get; }
        public bool IsDisposed { get; private set; }

        //=====================================
        // Method
        //=====================================

        public void Dispose()
        {
            if (IsDisposed)
            {
                return;
            }
            IsDisposed = true;
            DoDispose();
        }
        protected virtual void DoDispose() { }
        public abstract void Play();
        public abstract void Stop();

        public virtual void OnUpdate(float dt) { }
        public abstract void SetVolume(float v);

    }
}