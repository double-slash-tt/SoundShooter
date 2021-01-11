using UnityEngine;

namespace SoundShooter
{
    public abstract class SoundShooterProvider : ScriptableObject
    {
        public abstract void Provide();
    }
}