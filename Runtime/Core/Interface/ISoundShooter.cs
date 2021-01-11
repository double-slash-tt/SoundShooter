using System;
using UnityEditor;
using UnityEngine;

namespace SoundShooter
{
    public interface ISoundShooter : IDisposable
    {
        void OnUpdate( float dt );
    }
}