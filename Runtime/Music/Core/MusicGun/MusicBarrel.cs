using UnityEngine;

namespace SoundShooter.Music
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class MusicBarrel : ScriptableObject
    {
        public virtual void Setup() { }
        public abstract IMusicPlayback Fire( IMusicAmmo ammo );
    }
    public abstract class MusicBarrel<TAmmo> : MusicBarrel where TAmmo : IMusicAmmo
    {
        public sealed override IMusicPlayback Fire(IMusicAmmo ammo)
        {
            if (ammo is TAmmo a)
            {
                return DoFire( a );
            }
            return default;
        }
        protected abstract IMusicPlayback DoFire(TAmmo ammo);
    }
}