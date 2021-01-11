using System;

namespace SoundShooter
{
    public interface ISoundShooter : IDisposable
    {
        void OnUpdate( float dt );
    }
}